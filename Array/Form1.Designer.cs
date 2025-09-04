namespace Array
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
            this.tbInput1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.tbInput2 = new System.Windows.Forms.TextBox();
            this.tbInput3 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput1
            // 
            this.tbInput1.Font = new System.Drawing.Font("굴림", 16F);
            this.tbInput1.Location = new System.Drawing.Point(71, 79);
            this.tbInput1.Name = "tbInput1";
            this.tbInput1.Size = new System.Drawing.Size(148, 32);
            this.tbInput1.TabIndex = 0;
            this.tbInput1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(113, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "array[0]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(343, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "array[1]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(572, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "array[2]";
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Bold);
            this.btnResult.Location = new System.Drawing.Point(71, 155);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(600, 62);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "적용";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // tbInput2
            // 
            this.tbInput2.Font = new System.Drawing.Font("굴림", 16F);
            this.tbInput2.Location = new System.Drawing.Point(290, 79);
            this.tbInput2.Name = "tbInput2";
            this.tbInput2.Size = new System.Drawing.Size(148, 32);
            this.tbInput2.TabIndex = 6;
            this.tbInput2.Text = "0";
            // 
            // tbInput3
            // 
            this.tbInput3.Font = new System.Drawing.Font("굴림", 16F);
            this.tbInput3.Location = new System.Drawing.Point(523, 79);
            this.tbInput3.Name = "tbInput3";
            this.tbInput3.Size = new System.Drawing.Size(148, 32);
            this.tbInput3.TabIndex = 7;
            this.tbInput3.Text = "0";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(67, 233);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(125, 20);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "배열 출력 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbInput3);
            this.Controls.Add(this.tbInput2);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox tbInput2;
        private System.Windows.Forms.TextBox tbInput3;
        private System.Windows.Forms.Label lblResult;
    }
}

