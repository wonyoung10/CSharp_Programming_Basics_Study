namespace number_db
{
    partial class Form2
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
            button1 = new Button();
            tb_phone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tb_name = new TextBox();
            label3 = new Label();
            tb_idx = new TextBox();
            label4 = new Label();
            tb_desc = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 20F);
            button1.Location = new Point(578, 89);
            button1.Name = "button1";
            button1.Size = new Size(150, 74);
            button1.TabIndex = 0;
            button1.Text = "등록하기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tb_phone
            // 
            tb_phone.Font = new Font("맑은 고딕", 15F);
            tb_phone.Location = new Point(12, 129);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(200, 34);
            tb_phone.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F);
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(183, 37);
            label1.TabIndex = 2;
            label1.Text = "USER_PHONE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 20F);
            label2.Location = new Point(228, 89);
            label2.Name = "label2";
            label2.Size = new Size(170, 37);
            label2.TabIndex = 4;
            label2.Text = "USER_NAME";
            // 
            // tb_name
            // 
            tb_name.Font = new Font("맑은 고딕", 15F);
            tb_name.Location = new Point(228, 129);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(200, 34);
            tb_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 20F);
            label3.Location = new Point(228, 218);
            label3.Name = "label3";
            label3.Size = new Size(134, 37);
            label3.TabIndex = 6;
            label3.Text = "USER_IDX";
            // 
            // tb_idx
            // 
            tb_idx.Font = new Font("맑은 고딕", 15F);
            tb_idx.Location = new Point(228, 258);
            tb_idx.Name = "tb_idx";
            tb_idx.Size = new Size(200, 34);
            tb_idx.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 20F);
            label4.Location = new Point(12, 218);
            label4.Name = "label4";
            label4.Size = new Size(157, 37);
            label4.TabIndex = 8;
            label4.Text = "USER_DESC";
            // 
            // tb_desc
            // 
            tb_desc.Font = new Font("맑은 고딕", 15F);
            tb_desc.Location = new Point(12, 258);
            tb_desc.Name = "tb_desc";
            tb_desc.Size = new Size(200, 34);
            tb_desc.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(tb_desc);
            Controls.Add(label3);
            Controls.Add(tb_idx);
            Controls.Add(label2);
            Controls.Add(tb_name);
            Controls.Add(label1);
            Controls.Add(tb_phone);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tb_phone;
        private Label label1;
        private Label label2;
        private TextBox tb_name;
        private Label label3;
        private TextBox tb_idx;
        private Label label4;
        private TextBox tb_desc;
    }
}