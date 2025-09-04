using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
namespace 계산기
{
    public partial class Frm_계산기 : Form
    {


        private List<string> NumList = new List<string>();

        string pattern = @"([\÷×\-+])"; // 구분자를 추출하는 정규식

        private string num = ""; // 수 저장후 리스트 옮기는 작업

        private bool chk_결과 = true; // 부호를 입력 했을때 계산 안되게 막기 용


        private bool Fisrt_Number_chk = false;
        private bool Sign = false;
        private string Sign_Num = "";
        private bool Same = false;



        public Frm_계산기()
        {
            InitializeComponent();

            this.ClassInit();

        }

        private void calculate(bool chk)
        {
            /*
             chk = true 면 
                output에 결과 출력 x = >  = 눌렀을 때 
            chk = false 면
                output 에는 결과 출력 및 label_결과에 식 보존

             */
            //============ label에서 list 로 저장 하기
            string NumStr = label_결과.Text;
            string[] parts = Regex.Split(NumStr, pattern);
            NumList.AddRange(parts);

            foreach (var item in NumList)
            {
                Debug.WriteLine(item);
            }

            List<string> calculateList = new List<string>();

            for (int i = 0; i < NumList.Count; i++)
            {
                string token = NumList[i];
                // 곱셈 나누셈 처리
                if (token == "×" || token == "÷")
                {
                   
                    double left = double.Parse(calculateList[0]);
                    double right = double.Parse(NumList[++i]);
                    calculateList[0] = (token == "×" ? left * right : left / right).ToString();
                }
                else
                {
                    calculateList.Add(token);
                }
            }

            // 덧셈과 뺄셈 처리
            double result = double.Parse(calculateList[0]);
            for (int i = 1; i < calculateList.Count; i += 2)
            {
                string si = calculateList[i];
                double value = double.Parse(calculateList[i + 1]);

                if (si == "+")
                    result += value;
                else if (si == "-")
                    result -= value;
            }

            Debug.WriteLine(result);
            if (!chk) output.Text = result.ToString();
            if (chk)
            {
                label_결과.Text = result.ToString();
                output.Text = "";
            }
                NumList.Clear();
        }
        private void ClassInit()
        {
            this.label_결과.Text = "0";
            this.output.Text = "";

        }

        private void Frm_계산기_Resize(object sender, EventArgs e)
        {



        }

        // ======================================= 숫자 ========================================================
        private void Button_0_Click(object sender, EventArgs e)
        {
            if (this.label_결과.Text == "0")
            {

                this.label_결과.Text = "";
            }
            else if (Sign)
            {
                this.label_결과.Text = "";
                Sign = false;
            }
            this.label_결과.Text = this.label_결과.Text + "0";
            chk_결과 = true;
            calculate(false);
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            if (this.label_결과.Text == "0") this.label_결과.Text = "";
            else if (Sign)
            {
                this.label_결과.Text = "";
                Sign = false;
            }
            this.label_결과.Text = this.label_결과.Text + "1";
            chk_결과 = true;
            calculate(false);
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            if (this.label_결과.Text == "0") this.label_결과.Text = "";
            else if (Sign)
            {
                this.label_결과.Text = "";
                Sign = false;
            }
            this.label_결과.Text = this.label_결과.Text + "2";
            chk_결과 = true;
            calculate(false);
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            if (this.label_결과.Text == "0")
            {

                this.label_결과.Text = "";
            }
            else if (Sign)
            {
                this.label_결과.Text = "";
                Sign = false;
            }
            this.label_결과.Text = this.label_결과.Text + "3";
            chk_결과 = true;
            calculate(false);
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            if (this.label_결과.Text == "0") this.label_결과.Text = "";
            else if (Sign)
            {
                this.label_결과.Text = "";
                Sign = false;
            }
            this.label_결과.Text = this.label_결과.Text + "4";
            chk_결과 = true;
            calculate(false);
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            if (this.label_결과.Text == "0") this.label_결과.Text = "";
            else if (Sign)
            {
                this.label_결과.Text = "";
                Sign = false;
            }
            this.label_결과.Text = this.label_결과.Text + "5";
            chk_결과 = true;
            calculate(false);
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            if (this.label_결과.Text == "0") this.label_결과.Text = "";
            else if (Sign)
            {
                this.label_결과.Text = "";
                Sign = false;
            }
            this.label_결과.Text = this.label_결과.Text + "6";
            chk_결과 = true;
            calculate(false);
        }

        private void Button_7_Click(object sender, EventArgs e)
        {

            if (this.label_결과.Text == "0") this.label_결과.Text = "";
            else if (Sign)
            {
                this.label_결과.Text = "";
                Sign = false;
            }
            this.label_결과.Text = this.label_결과.Text + "7";
            chk_결과 = true;
            calculate(false);
        }
        private void Button_8_Click(object sender, EventArgs e)
        {
            if (this.label_결과.Text == "0") this.label_결과.Text = "";
            else if (Sign)
            {
                this.label_결과.Text = "";
                Sign = false;
            }
            this.label_결과.Text = this.label_결과.Text + "8";
            chk_결과 = true;
            calculate(false);
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            if (this.label_결과.Text == "0") this.label_결과.Text = "";
            else if (Sign)
            {
                this.label_결과.Text = "";
                Sign = false;
            }
            this.label_결과.Text = this.label_결과.Text + "9";
            chk_결과 = true;
            calculate(false);
        }

        private void Button_결과_Click(object sender, EventArgs e) // = 버튼
        {
            if (!chk_결과) return;
            if (!Same)
            {
                Same = true;
            }
            calculate(true);


        }


        private void Button_reset_Click(object sender, EventArgs e)
        {
            NumList.Clear();

            this.label_결과.Text = "0";
            Fisrt_Number_chk = false;
            Sign = false;
            Sign_Num = "";
            this.output.Text = "";
            Same = false;
        }
        // ============================================ 연산자 ===========================================================
        private void Button_puls_Click(object sender, EventArgs e)
        {

            label_결과.Text = label_결과.Text + "+";
            output.Text = "";
            chk_결과 = false;
        }

        private void Button_minus_Click(object sender, EventArgs e)
        {

            label_결과.Text = label_결과.Text + "-";
            output.Text = "";
            chk_결과 = false;
        }

        private void Button_multiply_Click(object sender, EventArgs e)
        {

            label_결과.Text = label_결과.Text + "×";
            output.Text = "";
            chk_결과 = false;
        }

        private void Button_Division_Click(object sender, EventArgs e)
        {

            label_결과.Text = label_결과.Text + "÷";
            output.Text = "";
            chk_결과 = false;
        }

        private void Button_Backspace_Click(object sender, EventArgs e)
        {
            if (this.label_결과.Text.Length == 1)
            {
                this.label_결과.Text = "0";
                this.num = "0";
            }
            else if (this.label_결과.Text != "0")
            {
                this.label_결과.Text = this.label_결과.Text.Substring(0, this.label_결과.Text.Length - 1);
                output.Text = "";
            }

        }
    }
}
