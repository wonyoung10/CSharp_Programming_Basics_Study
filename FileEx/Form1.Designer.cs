namespace FileEx
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
            btnFileCopy = new Button();
            btnFileInfo = new Button();
            lbFileInfo = new ListBox();
            SuspendLayout();
            // 
            // btnFileCopy
            // 
            btnFileCopy.Location = new Point(33, 50);
            btnFileCopy.Name = "btnFileCopy";
            btnFileCopy.Size = new Size(328, 66);
            btnFileCopy.TabIndex = 0;
            btnFileCopy.Text = "파일 복사";
            btnFileCopy.UseVisualStyleBackColor = true;
            btnFileCopy.Click += btnFileCopy_Click;
            // 
            // btnFileInfo
            // 
            btnFileInfo.Location = new Point(440, 50);
            btnFileInfo.Name = "btnFileInfo";
            btnFileInfo.Size = new Size(333, 66);
            btnFileInfo.TabIndex = 1;
            btnFileInfo.Text = "파일 정보";
            btnFileInfo.UseVisualStyleBackColor = true;
            btnFileInfo.Click += btnFileInfo_Click;
            // 
            // lbFileInfo
            // 
            lbFileInfo.FormattingEnabled = true;
            lbFileInfo.ItemHeight = 15;
            lbFileInfo.Location = new Point(33, 155);
            lbFileInfo.Name = "lbFileInfo";
            lbFileInfo.Size = new Size(740, 259);
            lbFileInfo.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbFileInfo);
            Controls.Add(btnFileInfo);
            Controls.Add(btnFileCopy);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFileCopy;
        private Button btnFileInfo;
        private ListBox lbFileInfo;
    }
}
