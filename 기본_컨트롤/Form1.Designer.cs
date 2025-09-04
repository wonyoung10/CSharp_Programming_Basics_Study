namespace 기본_컨트롤
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
            btnEvent = new Button();
            label1 = new Label();
            ckbsoon = new CheckBox();
            ckbPasta = new CheckBox();
            ckbSteak = new CheckBox();
            ckbTang = new CheckBox();
            lblOrder = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioDisagree = new RadioButton();
            radioAgree = new RadioButton();
            btnEnter = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            BtnReceipt_Click = new Button();
            label4 = new Label();
            label5 = new Label();
            cbPay = new ComboBox();
            lbArea = new ListBox();
            btnPay = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEvent
            // 
            btnEvent.Location = new Point(68, 174);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(321, 71);
            btnEvent.TabIndex = 0;
            btnEvent.Text = "주문";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += btnEvent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 16F, FontStyle.Bold);
            label1.Location = new Point(68, 54);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 1;
            label1.Text = "주문하세요";
            // 
            // ckbsoon
            // 
            ckbsoon.AutoSize = true;
            ckbsoon.Location = new Point(68, 121);
            ckbsoon.Name = "ckbsoon";
            ckbsoon.Size = new Size(62, 19);
            ckbsoon.TabIndex = 2;
            ckbsoon.Text = "순대국";
            ckbsoon.UseVisualStyleBackColor = true;
            // 
            // ckbPasta
            // 
            ckbPasta.AutoSize = true;
            ckbPasta.Location = new Point(210, 121);
            ckbPasta.Name = "ckbPasta";
            ckbPasta.Size = new Size(62, 19);
            ckbPasta.TabIndex = 3;
            ckbPasta.Text = "파스타";
            ckbPasta.UseVisualStyleBackColor = true;
            // 
            // ckbSteak
            // 
            ckbSteak.AutoSize = true;
            ckbSteak.Location = new Point(331, 121);
            ckbSteak.Name = "ckbSteak";
            ckbSteak.Size = new Size(74, 19);
            ckbSteak.TabIndex = 4;
            ckbSteak.Text = "스테이크";
            ckbSteak.UseVisualStyleBackColor = true;
            // 
            // ckbTang
            // 
            ckbTang.AutoSize = true;
            ckbTang.Location = new Point(470, 121);
            ckbTang.Name = "ckbTang";
            ckbTang.Size = new Size(62, 19);
            ckbTang.TabIndex = 5;
            ckbTang.Text = "탕수육";
            ckbTang.UseVisualStyleBackColor = true;
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Location = new Point(571, 125);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(55, 15);
            lblOrder.TabIndex = 6;
            lblOrder.Text = "주문결과";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 16F, FontStyle.Bold);
            label2.Location = new Point(68, 268);
            label2.Name = "label2";
            label2.Size = new Size(455, 30);
            label2.TabIndex = 7;
            label2.Text = "이벤트에 응모하려면 개인정보 동의해주세요";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioDisagree);
            groupBox1.Controls.Add(radioAgree);
            groupBox1.Location = new Point(68, 312);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 72);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "개인정보동의";
            // 
            // radioDisagree
            // 
            radioDisagree.AutoSize = true;
            radioDisagree.Location = new Point(293, 31);
            radioDisagree.Name = "radioDisagree";
            radioDisagree.Size = new Size(73, 19);
            radioDisagree.TabIndex = 10;
            radioDisagree.TabStop = true;
            radioDisagree.Text = "동의안함";
            radioDisagree.UseVisualStyleBackColor = true;
            // 
            // radioAgree
            // 
            radioAgree.AutoSize = true;
            radioAgree.Location = new Point(26, 31);
            radioAgree.Name = "radioAgree";
            radioAgree.Size = new Size(49, 19);
            radioAgree.TabIndex = 9;
            radioAgree.TabStop = true;
            radioAgree.Text = "동의";
            radioAgree.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(500, 316);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(126, 72);
            btnEnter.TabIndex = 11;
            btnEnter.Text = "응모";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 16F, FontStyle.Bold);
            label3.Location = new Point(68, 403);
            label3.Name = "label3";
            label3.Size = new Size(183, 30);
            label3.TabIndex = 12;
            label3.Text = "주문 시 요구사항";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 20F);
            textBox1.Location = new Point(68, 436);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(406, 43);
            textBox1.TabIndex = 13;
            // 
            // BtnReceipt_Click
            // 
            BtnReceipt_Click.Location = new Point(500, 436);
            BtnReceipt_Click.Name = "BtnReceipt_Click";
            BtnReceipt_Click.Size = new Size(126, 43);
            BtnReceipt_Click.TabIndex = 14;
            BtnReceipt_Click.Text = "접수";
            BtnReceipt_Click.UseVisualStyleBackColor = true;
            BtnReceipt_Click.Click += BtnReceipt_Click_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 16F, FontStyle.Bold);
            label4.Location = new Point(68, 511);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 15;
            label4.Text = "결제방법";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 16F, FontStyle.Bold);
            label5.Location = new Point(291, 511);
            label5.Name = "label5";
            label5.Size = new Size(101, 30);
            label5.TabIndex = 16;
            label5.Text = "결제정보";
            // 
            // cbPay
            // 
            cbPay.FormattingEnabled = true;
            cbPay.Items.AddRange(new object[] { "신용카드", "무통장입금", "포인트" });
            cbPay.Location = new Point(68, 544);
            cbPay.Name = "cbPay";
            cbPay.Size = new Size(121, 23);
            cbPay.TabIndex = 17;
            cbPay.Text = "신용카드";
            cbPay.SelectedIndexChanged += cbPay_SelectedIndexChanged;
            // 
            // lbArea
            // 
            lbArea.FormattingEnabled = true;
            lbArea.ItemHeight = 15;
            lbArea.Items.AddRange(new object[] { "일시불", "3개월 할부", "6개월 할부", "12개월 할부" });
            lbArea.Location = new Point(291, 544);
            lbArea.Name = "lbArea";
            lbArea.Size = new Size(120, 94);
            lbArea.TabIndex = 18;
            // 
            // btnPay
            // 
            btnPay.Font = new Font("맑은 고딕", 15F, FontStyle.Bold);
            btnPay.Location = new Point(500, 533);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(126, 105);
            btnPay.TabIndex = 19;
            btnPay.Text = "결제";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 653);
            Controls.Add(btnPay);
            Controls.Add(lbArea);
            Controls.Add(cbPay);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(BtnReceipt_Click);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(btnEnter);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(lblOrder);
            Controls.Add(ckbTang);
            Controls.Add(ckbSteak);
            Controls.Add(ckbPasta);
            Controls.Add(ckbsoon);
            Controls.Add(label1);
            Controls.Add(btnEvent);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEvent;
        private Label label1;
        private CheckBox ckbsoon;
        private CheckBox ckbPasta;
        private CheckBox ckbSteak;
        private CheckBox ckbTang;
        private Label lblOrder;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioDisagree;
        private RadioButton radioAgree;
        private Button btnEnter;
        private Label label3;
        private TextBox textBox1;
        private Button BtnReceipt_Click;
        private Label label4;
        private Label label5;
        private ComboBox cbPay;
        private ListBox lbArea;
        private Button btnPay;
    }
}
