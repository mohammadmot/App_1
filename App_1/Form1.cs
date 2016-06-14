using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Allow the user to edit item text.
            listViewUserInfo.LabelEdit = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int nRecordId = listViewUserInfo.Items.Count + 1;

            // Create three items and three sets of sub-items for each item.
            ListViewItem item = new ListViewItem(nRecordId.ToString(), 0);
            item.Checked = true;
            item.SubItems.Add("username");
            item.SubItems.Add("password");
            item.SubItems.Add("comment");

            listViewUserInfo.Items.Add(item);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
