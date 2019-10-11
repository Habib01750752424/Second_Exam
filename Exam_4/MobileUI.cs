using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam_4.BLL;
using Exam_4.Models;

namespace Exam_4
{
    public partial class MobileUI : Form
    {
        private MobileManager _mobileManager=new MobileManager();
        public MobileUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Mobile mobile=new Mobile(); 
            if (String.IsNullOrEmpty(modelNameTextBox.Text))
            {
                MessageBox.Show("Enter Model name");
                return;
            }

            if (String.IsNullOrEmpty(imeiTextBox.Text))
            {
                MessageBox.Show("Enter IMEI");
                return;
            }
            if (imeiTextBox.TextLength!=15)
            {
                MessageBox.Show("IMEI Must be 15 char");
                return;
            }

            mobile.ModelName = modelNameTextBox.Text;
            mobile.IMEI = imeiTextBox.Text;
            if (_mobileManager.IsImeiExist(mobile))
            {
                MessageBox.Show("This IMEI exist");
                return;
            }
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Enter price");
                return;
            }
            if (!Regex.IsMatch(priceTextBox.Text,@"\d"))
            {
                MessageBox.Show("Price Must be number");
                return;
            }

            mobile.Price =Convert.ToDouble(priceTextBox.Text);
            if (_mobileManager.Add(mobile))
            {
                MessageBox.Show("Mobile added");
                return;
            }
            else
            {
                MessageBox.Show("Cannot Added");
                return;
            }
        }
    }
}
