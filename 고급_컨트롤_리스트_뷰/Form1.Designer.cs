namespace 고급_컨트롤_리스트_뷰
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbPhone = new TextBox();
            tbOrg = new TextBox();
            tbName = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            listView1 = new ListView();
            chName = new ColumnHeader();
            chPhone = new ColumnHeader();
            chOrg = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 80);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "이름 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 125);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "휴대폰 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 174);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "소속 :";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(158, 122);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(435, 23);
            tbPhone.TabIndex = 3;
            // 
            // tbOrg
            // 
            tbOrg.Location = new Point(158, 171);
            tbOrg.Name = "tbOrg";
            tbOrg.Size = new Size(435, 23);
            tbOrg.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(158, 77);
            tbName.Name = "tbName";
            tbName.Size = new Size(435, 23);
            tbName.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(615, 72);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(152, 55);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "입력";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(615, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 55);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { chName, chPhone, chOrg });
            listView1.Location = new Point(2, 205);
            listView1.Name = "listView1";
            listView1.Size = new Size(796, 284);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // chName
            // 
            chName.Text = "이름";
            chName.Width = 200;
            // 
            // chPhone
            // 
            chPhone.Text = "휴대폰";
            chPhone.Width = 150;
            // 
            // chOrg
            // 
            chOrg.Text = "소속";
            chOrg.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(listView1);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(tbName);
            Controls.Add(tbOrg);
            Controls.Add(tbPhone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbPhone;
        private TextBox tbOrg;
        private TextBox tbName;
        private Button btnInsert;
        private Button btnDelete;
        private ListView listView1;
        private ColumnHeader chName;
        private ColumnHeader chPhone;
        private ColumnHeader chOrg;
    }
}
