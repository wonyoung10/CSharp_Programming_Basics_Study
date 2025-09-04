namespace 기본_컨트롤
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("버튼을 클릭하였습니다.");
            string strOrder = "";
            lblOrder.Text = "";
            if (ckbsoon.Checked)
            {
                strOrder += ckbsoon.Text + "\n";
            }
            if (ckbPasta.Checked)
            {
                strOrder += ckbPasta.Text + "\n";
            }
            if (ckbSteak.Checked)
            {
                strOrder += ckbSteak.Text + "\n";
            }
            if (ckbTang.Checked)
            {
                strOrder += ckbTang.Text + "\n";
            }
            lblOrder.Text = strOrder + "메뉴를 요청하였습니다.";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (radioAgree.Checked)
            {
                MessageBox.Show("개인정보 동의 하셨습니다.");
            }
            else MessageBox.Show("개인정보 동의하지 않으셨습니다.");
        }

        private void BtnReceipt_Click_Click(object sender, EventArgs e)
        {
            string strText = textBox1.Text + "\n라고 요구 사항이 접수되었습니다.";
            MessageBox.Show(strText);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string strText = cbPay.Text + "(으)로 " + lbArea.Text + " 결제방법을" + "\n선택하셨습니다.";
            MessageBox.Show(strText);
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbArea.Items.Clear();
            if (cbPay.SelectedIndex == 0)
            {
                lbArea.Items.Add("일시불");
                lbArea.Items.Add("3개월 할부");
                lbArea.Items.Add("6개월 할부");
                lbArea.Items.Add("12개월 할부");
            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbArea.Items.Add("하루은행");
                lbArea.Items.Add("시뇽은행");
                lbArea.Items.Add("정호은행");
                lbArea.Items.Add("돈돈은행");

            }
            else if (cbPay.SelectedIndex == 2)
            {
                lbArea.Items.Add("N포인트");
                lbArea.Items.Add("주유포인트");
                lbArea.Items.Add("레이저포인트");
                lbArea.Items.Add("정호포인트");
            }
        }
    }
}
