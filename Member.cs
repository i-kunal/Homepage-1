using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homepage
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SearchABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void RequestABookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAccount editAccount = new EditAccount();
            editAccount.Show();
            String s="hi";
        }
    }
}
