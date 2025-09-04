namespace number_db
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
            listView1 = new ListView();
            insertButton = new Button();
            refresh = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 96);
            listView1.Name = "listView1";
            listView1.Size = new Size(808, 299);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // insertButton
            // 
            insertButton.Location = new Point(737, 41);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(83, 23);
            insertButton.TabIndex = 1;
            insertButton.Text = "insertButton";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click_1;
            // 
            // refresh
            // 
            refresh.Location = new Point(745, 12);
            refresh.Name = "refresh";
            refresh.Size = new Size(75, 23);
            refresh.TabIndex = 2;
            refresh.Text = "refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // button1
            // 
            button1.Location = new Point(638, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 458);
            Controls.Add(button1);
            Controls.Add(refresh);
            Controls.Add(insertButton);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button insertButton;
        private Button refresh;
        private Button button1;
    }
}
