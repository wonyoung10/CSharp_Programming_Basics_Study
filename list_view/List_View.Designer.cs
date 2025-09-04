namespace list_view
{
    partial class list_view
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbDir = new ListView();
            lbFiles = new ListView();
            btnDirList = new Button();
            btnFileList = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // lbDir
            // 
            lbDir.Alignment = ListViewAlignment.SnapToGrid;
            lbDir.AutoArrange = false;
            lbDir.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lbDir.LabelWrap = false;
            lbDir.Location = new Point(28, 28);
            lbDir.Name = "lbDir";
            lbDir.Size = new Size(481, 244);
            lbDir.TabIndex = 0;
            lbDir.UseCompatibleStateImageBehavior = false;
            lbDir.View = View.Details;
            lbDir.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // lbFiles
            // 
            lbFiles.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            lbFiles.Location = new Point(28, 305);
            lbFiles.Name = "lbFiles";
            lbFiles.Size = new Size(481, 244);
            lbFiles.TabIndex = 1;
            lbFiles.UseCompatibleStateImageBehavior = false;
            lbFiles.View = View.Details;
            // 
            // btnDirList
            // 
            btnDirList.Font = new Font("맑은 고딕", 15F);
            btnDirList.Location = new Point(530, 28);
            btnDirList.Name = "btnDirList";
            btnDirList.Size = new Size(269, 56);
            btnDirList.TabIndex = 2;
            btnDirList.Text = "디렉토리 목록";
            btnDirList.UseVisualStyleBackColor = true;
            btnDirList.Click += btnDirList_Click;
            // 
            // btnFileList
            // 
            btnFileList.Font = new Font("맑은 고딕", 15F);
            btnFileList.Location = new Point(530, 305);
            btnFileList.Name = "btnFileList";
            btnFileList.Size = new Size(269, 56);
            btnFileList.TabIndex = 3;
            btnFileList.Text = "파일 목록";
            btnFileList.UseVisualStyleBackColor = true;
            btnFileList.Click += btnFileList_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "디렉토리";
            columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "파일";
            columnHeader2.Width = 500;
            // 
            // list_view
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 599);
            Controls.Add(btnFileList);
            Controls.Add(btnDirList);
            Controls.Add(lbFiles);
            Controls.Add(lbDir);
            Name = "list_view";
            Text = "list_view";
            Load += list_view_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lbDir;
        private ListView lbFiles;
        private Button btnDirList;
        private Button btnFileList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}
