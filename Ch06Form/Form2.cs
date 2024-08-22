using System;
using System.Windows.Forms;

namespace Ch06Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbInput.Text.Length == 0)
            {
                MessageBox.Show("내용을 입력해 주세요.");
                return;
            }

            string text = tbInput.Text;
            lstList.Items.Add(text);
            lstListCount.Items.Add(0);

            tbInput.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstList.SelectedItem != null)
            {
                lstList.Items.Remove(lstList.SelectedItem);
                lstList.SelectedIndex = -1;
            }

            if (lstListCount.SelectedItems != null)
            {
                lstListCount.Items.Remove(lstListCount.SelectedItem);
                lstListCount.SelectedIndex = -1;
            }
        }

        private void lstList_Click(object sender, EventArgs e)
        {
            lstListCount.SelectedIndex = lstList.SelectedIndex;
        }

        private void lstListCount_Click(object sender, EventArgs e)
        {
            lstList.SelectedIndex = lstListCount.SelectedIndex;
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int count = (int)nudCount.Value;

            int voteMax = lstList.Items.Count;

            Random random = new Random();


            for (int i = 0; i < count; i++)
            {
                int winnerIndex = random.Next(0, voteMax);

                string name = lstList.Items[winnerIndex].ToString();
                string msg = string.Format("{0}번째 투표: {1}를 투표함", i + 1, name);
                Console.WriteLine(msg);

                int curCount = Convert.ToInt32(lstListCount.Items[winnerIndex]);
                curCount++;
                lstListCount.Items[winnerIndex] = curCount;

            }



        }

    }
}
