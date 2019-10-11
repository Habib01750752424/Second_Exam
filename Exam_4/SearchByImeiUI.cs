using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam_4.BLL;
using Exam_4.Models;
namespace Exam_4
{
    public partial class SearchByImeiUI : Form
    {
        private MobileManager _mobileManager=new MobileManager();
        public SearchByImeiUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(imeiTextBox.Text))
            {
                MessageBox.Show("Please Enter IMEI");
                return;
            }
            if (imeiTextBox.TextLength!=15)
            {
                MessageBox.Show("IMEI must be 15 chat");
                return;
            }

            Mobile mobile =_mobileManager.GetByImei(imeiTextBox.Text);
            if  (mobile != null)
            {
                modelNameLabel.Text = mobile.ModelName;
                imeiLable.Text = mobile.IMEI;
                priceLabel.Text = mobile.Price.ToString();
            }
            else
            {
                MessageBox.Show("No data found");
                return;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
