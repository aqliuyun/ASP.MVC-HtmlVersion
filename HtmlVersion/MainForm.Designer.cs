namespace HtmlVersion
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_transformcss = new System.Windows.Forms.Button();
            this.btn_transformjs = new System.Windows.Forms.Button();
            this.lst_filters = new System.Windows.Forms.ListView();
            this.versionFilesList = new System.Windows.Forms.CheckedListBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_ProjectName = new System.Windows.Forms.Label();
            this.btn_addfilter = new System.Windows.Forms.Button();
            this.btn_removefilter = new System.Windows.Forms.Button();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_selected = new System.Windows.Forms.Label();
            this.cb_checkall = new System.Windows.Forms.CheckBox();
            this.bottom = new System.Windows.Forms.Panel();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.center = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bottom.SuspendLayout();
            this.top.SuspendLayout();
            this.center.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_transformcss
            // 
            this.btn_transformcss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_transformcss.Location = new System.Drawing.Point(379, 3);
            this.btn_transformcss.Name = "btn_transformcss";
            this.btn_transformcss.Size = new System.Drawing.Size(101, 35);
            this.btn_transformcss.TabIndex = 0;
            this.btn_transformcss.Text = "transform css files";
            this.btn_transformcss.UseVisualStyleBackColor = true;
            this.btn_transformcss.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_transformjs
            // 
            this.btn_transformjs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_transformjs.Location = new System.Drawing.Point(500, 3);
            this.btn_transformjs.Name = "btn_transformjs";
            this.btn_transformjs.Size = new System.Drawing.Size(97, 35);
            this.btn_transformjs.TabIndex = 1;
            this.btn_transformjs.Text = "tranform js files";
            this.btn_transformjs.UseVisualStyleBackColor = true;
            this.btn_transformjs.Click += new System.EventHandler(this.button2_Click);
            // 
            // lst_filters
            // 
            this.lst_filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_filters.Location = new System.Drawing.Point(0, 0);
            this.lst_filters.MultiSelect = false;
            this.lst_filters.Name = "lst_filters";
            this.lst_filters.Size = new System.Drawing.Size(199, 340);
            this.lst_filters.TabIndex = 2;
            this.lst_filters.UseCompatibleStateImageBehavior = false;
            this.lst_filters.View = System.Windows.Forms.View.List;
            // 
            // versionFilesList
            // 
            this.versionFilesList.CheckOnClick = true;
            this.versionFilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionFilesList.FormattingEnabled = true;
            this.versionFilesList.Location = new System.Drawing.Point(0, 0);
            this.versionFilesList.Name = "versionFilesList";
            this.versionFilesList.Size = new System.Drawing.Size(397, 312);
            this.versionFilesList.TabIndex = 3;
            this.versionFilesList.SelectedIndexChanged += new System.EventHandler(this.versionFilesList_SelectedIndexChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(473, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(115, 28);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "refresh project";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.AutoSize = true;
            this.lbl_ProjectName.Location = new System.Drawing.Point(12, 12);
            this.lbl_ProjectName.Name = "lbl_ProjectName";
            this.lbl_ProjectName.Size = new System.Drawing.Size(108, 13);
            this.lbl_ProjectName.TabIndex = 5;
            this.lbl_ProjectName.Text = "None Actived Project";
            // 
            // btn_addfilter
            // 
            this.btn_addfilter.Location = new System.Drawing.Point(12, 6);
            this.btn_addfilter.Name = "btn_addfilter";
            this.btn_addfilter.Size = new System.Drawing.Size(75, 23);
            this.btn_addfilter.TabIndex = 6;
            this.btn_addfilter.Text = "add filter";
            this.btn_addfilter.UseVisualStyleBackColor = true;
            this.btn_addfilter.Click += new System.EventHandler(this.btn_addfilter_Click);
            // 
            // btn_removefilter
            // 
            this.btn_removefilter.Location = new System.Drawing.Point(93, 6);
            this.btn_removefilter.Name = "btn_removefilter";
            this.btn_removefilter.Size = new System.Drawing.Size(75, 23);
            this.btn_removefilter.TabIndex = 7;
            this.btn_removefilter.Text = "remove filter";
            this.btn_removefilter.UseVisualStyleBackColor = true;
            this.btn_removefilter.Click += new System.EventHandler(this.btn_removefilter_Click);
            // 
            // tb_filter
            // 
            this.tb_filter.Location = new System.Drawing.Point(12, 38);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(175, 20);
            this.tb_filter.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lst_filters);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(600, 340);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.versionFilesList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 312);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_selected);
            this.panel1.Controls.Add(this.cb_checkall);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 28);
            this.panel1.TabIndex = 4;
            // 
            // lbl_selected
            // 
            this.lbl_selected.AutoSize = true;
            this.lbl_selected.Location = new System.Drawing.Point(104, 7);
            this.lbl_selected.Name = "lbl_selected";
            this.lbl_selected.Size = new System.Drawing.Size(56, 13);
            this.lbl_selected.TabIndex = 10;
            this.lbl_selected.Text = "0 selected";
            // 
            // cb_checkall
            // 
            this.cb_checkall.AutoSize = true;
            this.cb_checkall.Location = new System.Drawing.Point(3, 6);
            this.cb_checkall.Name = "cb_checkall";
            this.cb_checkall.Size = new System.Drawing.Size(69, 17);
            this.cb_checkall.TabIndex = 9;
            this.cb_checkall.Text = "check all";
            this.cb_checkall.UseVisualStyleBackColor = true;
            this.cb_checkall.CheckedChanged += new System.EventHandler(this.cb_checkall_CheckedChanged);
            // 
            // bottom
            // 
            this.bottom.Controls.Add(this.btn_export);
            this.bottom.Controls.Add(this.btn_import);
            this.bottom.Controls.Add(this.btn_transformcss);
            this.bottom.Controls.Add(this.btn_transformjs);
            this.bottom.Controls.Add(this.btn_addfilter);
            this.bottom.Controls.Add(this.btn_removefilter);
            this.bottom.Controls.Add(this.tb_filter);
            this.bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom.Location = new System.Drawing.Point(0, 386);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(600, 64);
            this.bottom.TabIndex = 4;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(203, 33);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 10;
            this.btn_export.Text = "export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(203, 3);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 24);
            this.btn_import.TabIndex = 9;
            this.btn_import.Text = "import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // top
            // 
            this.top.Controls.Add(this.btn_refresh);
            this.top.Controls.Add(this.lbl_ProjectName);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(600, 46);
            this.top.TabIndex = 0;
            // 
            // center
            // 
            this.center.Controls.Add(this.splitContainer1);
            this.center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center.Location = new System.Drawing.Point(0, 46);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(600, 340);
            this.center.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.center);
            this.Controls.Add(this.top);
            this.Controls.Add(this.bottom);
            this.Name = "MainForm";
            this.Text = "manage html resources with version";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bottom.ResumeLayout(false);
            this.bottom.PerformLayout();
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.center.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_transformcss;
        private System.Windows.Forms.Button btn_transformjs;
        private System.Windows.Forms.ListView lst_filters;
        private System.Windows.Forms.CheckedListBox versionFilesList;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_ProjectName;
        private System.Windows.Forms.Button btn_addfilter;
        private System.Windows.Forms.Button btn_removefilter;
        private System.Windows.Forms.TextBox tb_filter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel bottom;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Panel center;
        private System.Windows.Forms.Label lbl_selected;
        private System.Windows.Forms.CheckBox cb_checkall;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_import;
    }
}