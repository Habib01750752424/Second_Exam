using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_4
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void saveCustomerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MobileUI accountUi=new MobileUI();
            this.Hide();
            accountUi.Show();
        }

        private void transectionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchByPriceUI transectionUi=new SearchByPriceUI();
            this.Hide();
            transectionUi.Show();
        }

        private void searchLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchByImeiUI searchUi=new SearchByImeiUI();
            this.Hide();
            searchUi.Show();
        }
    }
}
