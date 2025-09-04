namespace directoryinfo_실습
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
            btnDirInfo = new Button();
            lbDirInfo = new ListBox();
            SuspendLayout();
            // 
            // btnDirInfo
            // 
            btnDirInfo.Location = new Point(335, 395);
            btnDirInfo.Name = "btnDirInfo";
            btnDirInfo.Size = new Size(112, 23);
            btnDirInfo.TabIndex = 0;
            btnDirInfo.Text = "디렉터리 정보";
            btnDirInfo.UseVisualStyleBackColor = true;
            btnDirInfo.Click += btnDirInfo_Click;
            // 
            // lbDirInfo
            // 
            lbDirInfo.FormattingEnabled = true;
            lbDirInfo.ItemHeight = 15;
            lbDirInfo.Location = new Point(12, 15);
            lbDirInfo.Name = "lbDirInfo";
            lbDirInfo.Size = new Size(776, 349);
            lbDirInfo.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbDirInfo);
            Controls.Add(btnDirInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDirInfo;
        private ListBox lbDirInfo;
    }
}
