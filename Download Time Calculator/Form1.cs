using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_Time_Calculator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double resultNum, downloadRateNum, storageNum;

            double.TryParse(storageTxtBox.Text, out storageNum);
            double.TryParse(downRateTxtBox.Text, out downloadRateNum);

            resultNum = storageNum / downloadRateNum;

            resultBox.Text = resultNum.ToString("c").Remove(0, 1);

            if (storageCmbBox.SelectedIndex == 1 )
            {
                double.TryParse(storageTxtBox.Text + 100, out storageNum);
            }
        }

        private void storageCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (storageCmbBox.Text == "GB")
            {

            }    
        }
    }
}
