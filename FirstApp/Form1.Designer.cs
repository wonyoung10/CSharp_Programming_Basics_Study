namespace FirstApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInt = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInt
            // 
            this.btnInt.Font = new System.Drawing.Font("굴림", 15F);
            this.btnInt.Location = new System.Drawing.Point(43, 53);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(174, 60);
            this.btnInt.TabIndex = 0;
            this.btnInt.Text = "정수형출력";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbResult.Location = new System.Drawing.Point(418, 189);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(68, 27);
            this.lbResult.TabIndex = 1;
            this.lbResult.Text = "결과";
            this.lbResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Font = new System.Drawing.Font("굴림", 15F);
            this.btnDouble.Location = new System.Drawing.Point(43, 168);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(174, 60);
            this.btnDouble.TabIndex = 2;
            this.btnDouble.Text = "실수형 출력";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnString
            // 
            this.btnString.Font = new System.Drawing.Font("굴림", 15F);
            this.btnString.Location = new System.Drawing.Point(43, 275);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(174, 60);
            this.btnString.TabIndex = 3;
            this.btnString.Text = "문자형 출력";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 416);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnString;
    }
}

