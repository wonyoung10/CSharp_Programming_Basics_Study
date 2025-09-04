namespace number_list
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
            ctrButton_Insert = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // ctrButton_Insert
            // 
            ctrButton_Insert.Location = new Point(12, 12);
            ctrButton_Insert.Name = "ctrButton_Insert";
            ctrButton_Insert.Size = new Size(75, 23);
            ctrButton_Insert.TabIndex = 0;
            ctrButton_Insert.Text = "button1";
            ctrButton_Insert.UseVisualStyleBackColor = true;
            ctrButton_Insert.Click += ctrButton_Insert_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 102);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 336);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(ctrButton_Insert);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ctrButton_Insert;
        private ListView listView1;
    }
}
