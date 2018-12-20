using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.SqlServer.Server;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TextManager.Interop;

namespace HtmlVersion
{
    public partial class MainForm : Form
    {
        private AsyncPackage package;
        private Project currentProject;
        private DTE dte;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(AsyncPackage package)
        {
            this.package = package;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var projectpath = Path.GetDirectoryName(this.currentProject.FullName);
            foreach (var item in versionFilesList.Items)
            {
                var file = item.ToString();
                var time = File.GetLastWriteTime(file);
                var filepath = file.Substring(projectpath.Length, file.Length - projectpath.Length);
                if (Path.GetExtension(file).ToLowerInvariant() != ".css") { continue; }
                try
                {
                    dte.ExecuteCommand(@"Edit.ReplaceinFiles", "\"^\"~(" + filepath.Replace("\\","/") + ")(\\?v=[\\d]*)?^\"\" \"^\"~" + filepath.Replace("\\", "/") + "?v=" + time.ToString("yyyyMMddHHmm") + "^\"\" /lookin:\"Current Project\" /regex /ext:*.cshtml /all");
                }
                catch { }
            }
            MessageBox.Show("finish!");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshProjectInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var projectpath = Path.GetDirectoryName(this.currentProject.FullName);
            foreach (var item in versionFilesList.Items)
            {                
                var file = item.ToString();
                var time = File.GetLastWriteTime(file);
                var filepath = file.Substring(projectpath.Length, file.Length - projectpath.Length);
                if (Path.GetExtension(file).ToLowerInvariant() != ".js") { continue; }
                try
                {
                    dte.ExecuteCommand(@"Edit.ReplaceinFiles", "\"^\"~(" + filepath.Replace("\\", "/") + ")(\\?v=[\\d]*)?^\"\" \"^\"~" + filepath.Replace("\\", "/") + "?v=" + time.ToString("yyyyMMddHHmm") + "^\"\" /lookin:\"Current Project\" /regex /ext:*.cshtml /all");
                }
                catch { }
            }
            MessageBox.Show("finish!");
        }

        private void RefreshProjectInfo()
        {
            this.package.GetServiceAsync(typeof(EnvDTE.DTE)).ContinueWith((obj) =>
            {
                this.dte = (obj.Result as EnvDTE.DTE).DTE;
                Array activeSolutionProjects = dte.ActiveSolutionProjects as Array;
                var projectpath = string.Empty;
                if (activeSolutionProjects != null && activeSolutionProjects.Length > 0)
                {
                    this.currentProject = activeSolutionProjects.GetValue(0) as Project;
                    this.Invoke(new MethodInvoker(() =>
                    {
                        this.lbl_ProjectName.Text = this.currentProject.Name;
                        this.lst_filters.Items.Clear();
                    }));
                    LoadStorage();
                    LoadToVersionList();
                }
            });
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.RefreshProjectInfo();
        }

        private void btn_addfilter_Click(object sender, EventArgs e)
        {
            this.lst_filters.Items.Add(this.tb_filter.Text);
            if (this.currentProject == null) return;
            var projectpath = Path.GetDirectoryName(this.currentProject.FullName);
            SyncStorage();
            LoadToVersionList();
        }

        private void LoadStorage()
        {
            try
            {
                using (IsolatedStorageFile storeForAssembly = IsolatedStorageFile.GetUserStoreForAssembly())
                {
                    using (IsolatedStorageFileStream storageFileStream = new IsolatedStorageFileStream(this.currentProject.Name + ".filters", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite, storeForAssembly))
                    {
                        this.lst_filters.Items.Clear();
                        var list = (List<string>)(new BinaryFormatter().Deserialize(storageFileStream));
                        this.Invoke(new MethodInvoker(() =>
                        {
                            foreach (var item in list)
                            {
                                this.lst_filters.Items.Add(item);
                            }
                        }));
                    }
                }
            }
            catch { }
        }

        private void SyncStorage()
        {
            try
            {
                using (IsolatedStorageFile storeForAssembly = IsolatedStorageFile.GetUserStoreForAssembly())
                {
                    using (IsolatedStorageFileStream storageFileStream = new IsolatedStorageFileStream(this.currentProject.Name + ".filters", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite, storeForAssembly))
                    {
                        var list = new List<string>();
                        foreach (ListViewItem item in this.lst_filters.Items)
                        {
                            list.Add(item.Text);
                        }
                        new BinaryFormatter().Serialize(storageFileStream, list);
                    }
                }
            }
            catch { }
        }

        private void LoadToVersionList()
        {
            var projectpath = Path.GetDirectoryName(this.currentProject.FullName);
            var cssfiles = Directory.EnumerateFiles(projectpath, "*.css", SearchOption.AllDirectories);
            var jsfiles = Directory.EnumerateFiles(projectpath, "*.js", SearchOption.AllDirectories);
            this.Invoke(new MethodInvoker(() =>
            {
                foreach (ListViewItem item in lst_filters.Items)
                {
                    cssfiles = cssfiles.Where(x => !x.Contains(item.Text));
                    jsfiles = jsfiles.Where(x => !x.Contains(item.Text));
                }
                this.versionFilesList.Items.Clear();
                foreach (var item in cssfiles)
                {
                    this.versionFilesList.Items.Add(item, true);
                }
                foreach (var item in jsfiles)
                {                    
                    this.versionFilesList.Items.Add(item, true);
                }
                this.lbl_selected.Text = this.versionFilesList.CheckedItems.Count.ToString() + " checked";
                this.cb_checkall.Checked = true;
            }));
        }

        private void btn_removefilter_Click(object sender, EventArgs e)
        {
            if (this.lst_filters.SelectedItems.Count > 0)
            {
                this.lst_filters.Items.Remove(this.lst_filters.SelectedItems[0]);
            }
            SyncStorage();
        }

        private void versionFilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbl_selected.Text = this.versionFilesList.CheckedItems.Count.ToString() + " checked";
            if(this.versionFilesList.CheckedItems.Count != this.versionFilesList.Items.Count)
            {
                this.cb_checkall.Checked = false;
            }
            else
            {
                this.cb_checkall.Checked = true;
            }
        }

        private void cb_checkall_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_checkall.Checked)
            {
                for (var i = 0; i < this.versionFilesList.Items.Count; i++)
                {
                    this.versionFilesList.SetItemChecked(i, true);
                }
                this.cb_checkall.Text = "unchecked all";
                this.lbl_selected.Text = this.versionFilesList.CheckedItems.Count.ToString() + " checked";
            }
            else
            {
                for (var i = 0; i < this.versionFilesList.Items.Count; i++)
                {
                    this.versionFilesList.SetItemChecked(i, false);
                }
                this.cb_checkall.Text = "checked all";
                this.lbl_selected.Text = "0 checked";
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog();
            file.Filter = "(configfile)|*.mhvsetting";
            if (file.ShowDialog() == DialogResult.OK)
            {
                var stream = file.OpenFile();
                var list = (List<string>)(new BinaryFormatter().Deserialize(stream));
                this.Invoke(new MethodInvoker(() =>
                {
                    this.lst_filters.Items.Clear();
                    foreach (var item in list)
                    {
                        this.lst_filters.Items.Add(item);
                    }
                }));
                SyncStorage();
                RefreshProjectInfo();
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            var file = new SaveFileDialog();
            file.FileName = this.currentProject?.Name??"my" + ".mhvsetting";
            file.Filter = "(configfile)|*.mhvsetting";
            if (file.ShowDialog() == DialogResult.OK)
            {
                var stream = file.OpenFile();
                var list = new List<string>();
                foreach (ListViewItem item in this.lst_filters.Items)
                {
                    list.Add(item.Text);
                }
                new BinaryFormatter().Serialize(stream, list);
            }
        }
    }
}
