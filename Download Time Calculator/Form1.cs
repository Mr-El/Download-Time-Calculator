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

            int selectedIndex = storageCmbBox.SelectedIndex;
            Object selectedItem = storageCmbBox.SelectedItem;

            // MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
               // "Index: " + selectedIndex.ToString());

            switch (storageCmbBox.SelectedItem.ToString().Trim())
            {
                case "KB":
                    storageNum = storageNum * 1000;
                    break;
                case "MB":
                    storageNum = storageNum * Math.Pow(1000, 2);
                    break;
                case "GB":
                    storageNum = storageNum * Math.Pow(1000, 3);
                    break;
                case "TB":
                    storageNum = storageNum * Math.Pow(1000, 4);
                    break;
                default:
                    break;
            }

            switch (downRateCmboBox.SelectedItem.ToString().Trim())
            {
                case "KB/s":
                    downloadRateNum = downloadRateNum * 1000;
                    break;
                case "MB/s":
                    downloadRateNum = downloadRateNum * Math.Pow(1000, 2);
                    break;
                case "GB/s":
                    downloadRateNum = downloadRateNum * Math.Pow(1000, 3);
                    break;
                case "TB/s":
                    downloadRateNum = downloadRateNum * Math.Pow(1000, 4);
                    break;
                default:
                    break;
            }

            resultNum = storageNum / downloadRateNum;

            Double hoursEnd = Math.Floor(resultNum / 3600);
            Double minutesEnd = Math.Floor((resultNum / 60) % 60);
            Double secondsEnd = Math.Floor(resultNum % 60);
            

            resultBox.Text = resultNum.ToString(hoursEnd + ":" + minutesEnd + ":" + secondsEnd);
        }

        private void storageCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (storageCmbBox.Text == "GB")
            {

            }    
        }
    }
}
