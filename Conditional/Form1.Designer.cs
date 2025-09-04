namespace Conditional
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKuk = new System.Windows.Forms.TextBox();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.tbEng = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(238, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "영어 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(436, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "수학 :";
            // 
            // tbKuk
            // 
            this.tbKuk.Font = new System.Drawing.Font("굴림", 15F);
            this.tbKuk.Location = new System.Drawing.Point(90, 53);
            this.tbKuk.Name = "tbKuk";
            this.tbKuk.Size = new System.Drawing.Size(122, 30);
            this.tbKuk.TabIndex = 3;
            // 
            // tbMath
            // 
            this.tbMath.Font = new System.Drawing.Font("굴림", 15F);
            this.tbMath.Location = new System.Drawing.Point(499, 53);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(122, 30);
            this.tbMath.TabIndex = 4;
            // 
            // tbEng
            // 
            this.tbEng.Font = new System.Drawing.Font("굴림", 15F);
            this.tbEng.Location = new System.Drawing.Point(301, 53);
            this.tbEng.Name = "tbEng";
            this.tbEng.Size = new System.Drawing.Size(122, 30);
            this.tbEng.TabIndex = 5;
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("굴림", 15F);
            this.btnResult.Location = new System.Drawing.Point(31, 131);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(590, 44);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "결과";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(364, 246);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(99, 40);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "학점";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
            this.lblAvg.Location = new System.Drawing.Point(161, 246);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(140, 40);
            this.lblAvg.TabIndex = 8;
            this.lblAvg.Text = "평균값";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 362);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.tbEng);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.tbKuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKuk;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.TextBox tbEng;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAvg;
    }
}

