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
    public partial class SearchByPriceUI : Form
    {
        private MobileManager _mobileManager=new MobileManager();
        public SearchByPriceUI()
        {
            InitializeComponent();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fromPriceTextBox.Text))
            {
                MessageBox.Show("Enter 1st price");
                return;
            }
            if (String.IsNullOrEmpty(toPriceTextBox.Text))
            {
                MessageBox.Show("Enter 2nd price");
                return;
            }

            List<Mobile> mobiles = _mobileManager.GetByPriceRange(fromPriceTextBox.Text, toPriceTextBox.Text);
            if (mobiles != null)
            {
                mobileDataGridView.DataSource = mobiles;
                SL();
                // return;
            }
            else
            {
                MessageBox.Show("No data found");
                return;
            }
        }

        private void SearchByPriceUI_Load(object sender, EventArgs e)
        {
            
        }

        public void SL()
        {
            int i = 1;
            foreach (DataGridViewRow rows in mobileDataGridView.Rows)
            {
                rows.Cells[0].Value = i;
                i++;
            }
        }
    }
}
