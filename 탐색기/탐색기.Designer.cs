namespace 탐색기
{
    partial class 탐색기
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(탐색기));
            treeView1 = new TreeView();
            imagelist = new ImageList(components);
            listView = new ListView();
            chname = new ColumnHeader();
            chAttr = new ColumnHeader();
            chSize = new ColumnHeader();
            chTime = new ColumnHeader();
            openFileDialog = new OpenFileDialog();
            ToolStripOpen = new MenuStrip();
            파일ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ToolStripOpen.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imagelist;
            treeView1.Location = new Point(0, 43);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(282, 470);
            treeView1.TabIndex = 0;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            // 
            // imagelist
            // 
            imagelist.ColorDepth = ColorDepth.Depth32Bit;
            imagelist.ImageStream = (ImageListStreamer)resources.GetObject("imagelist.ImageStream");
            imagelist.TransparentColor = Color.Transparent;
            imagelist.Images.SetKeyName(0, "1.jpg");
            imagelist.Images.SetKeyName(1, "2.jpg");
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { chname, chAttr, chSize, chTime });
            listView.Location = new Point(288, 43);
            listView.Name = "listView";
            listView.Size = new Size(719, 459);
            listView.SmallImageList = imagelist;
            listView.TabIndex = 1;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.Click += listView_Click;
            // 
            // chname
            // 
            chname.Text = "이름";
            chname.Width = 150;
            // 
            // chAttr
            // 
            chAttr.Text = "속성";
            chAttr.Width = 200;
            // 
            // chSize
            // 
            chSize.Text = "크기";
            chSize.Width = 100;
            // 
            // chTime
            // 
            chTime.Text = "생성 시간";
            chTime.Width = 300;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // ToolStripOpen
            // 
            ToolStripOpen.Items.AddRange(new ToolStripItem[] { 파일ToolStripMenuItem });
            ToolStripOpen.Location = new Point(0, 0);
            ToolStripOpen.Name = "ToolStripOpen";
            ToolStripOpen.Size = new Size(1019, 24);
            ToolStripOpen.TabIndex = 2;
            ToolStripOpen.Text = "열기";
            ToolStripOpen.Click += ToolStripOpen_Click;
            // 
            // 파일ToolStripMenuItem
            // 
            파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            파일ToolStripMenuItem.Size = new Size(43, 20);
            파일ToolStripMenuItem.Text = "파일";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // 탐색기
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 514);
            Controls.Add(label1);
            Controls.Add(listView);
            Controls.Add(treeView1);
            Controls.Add(ToolStripOpen);
            MainMenuStrip = ToolStripOpen;
            Name = "탐색기";
            Text = "Form1";
            ToolStripOpen.ResumeLayout(false);
            ToolStripOpen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ListView listView;
        private ColumnHeader chname;
        private ColumnHeader chAttr;
        private ColumnHeader chSize;
        private ColumnHeader chTime;
        private OpenFileDialog openFileDialog;
        private MenuStrip ToolStripOpen;
        private ToolStripMenuItem 파일ToolStripMenuItem;
        public ImageList imagelist;
        private Label label1;
    }
}
