namespace FileExplore
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listView = new ListView();
            chname = new ColumnHeader();
            chAttr = new ColumnHeader();
            chSize = new ColumnHeader();
            chTime = new ColumnHeader();
            ToolStripOpen = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            imageList = new ImageList(components);
            ToolStripOpen.SuspendLayout();
            SuspendLayout();
            // 
            // listView
            // 
            listView.CheckBoxes = true;
            listView.Columns.AddRange(new ColumnHeader[] { chname, chAttr, chSize, chTime });
            listView.HideSelection = true;
            listView.LabelEdit = true;
            listView.Location = new Point(1, 27);
            listView.Name = "listView";
            listView.Size = new Size(799, 357);
            listView.StateImageList = imageList;
            listView.TabIndex = 0;
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
            chAttr.Width = 100;
            // 
            // chSize
            // 
            chSize.DisplayIndex = 3;
            chSize.Text = "크기";
            chSize.Width = 100;
            // 
            // chTime
            // 
            chTime.DisplayIndex = 2;
            chTime.Text = "생성 시간";
            chTime.Width = 300;
            // 
            // ToolStripOpen
            // 
            ToolStripOpen.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            ToolStripOpen.Location = new Point(0, 0);
            ToolStripOpen.Name = "ToolStripOpen";
            ToolStripOpen.Size = new Size(800, 24);
            ToolStripOpen.TabIndex = 1;
            ToolStripOpen.Text = "열기";
            ToolStripOpen.Click += ToolStripOpen_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(43, 20);
            toolStripMenuItem1.Text = "열기";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "1.jpg");
            imageList.Images.SetKeyName(1, "2.jpg");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView);
            Controls.Add(ToolStripOpen);
            MainMenuStrip = ToolStripOpen;
            Name = "Form1";
            Text = "Form1";
            ToolStripOpen.ResumeLayout(false);
            ToolStripOpen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView;
        private MenuStrip ToolStripOpen;
        private OpenFileDialog openFileDialog;
        private ImageList imageList;
        private ColumnHeader chname;
        private ColumnHeader chAttr;
        private ColumnHeader chSize;
        private ColumnHeader chTime;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
