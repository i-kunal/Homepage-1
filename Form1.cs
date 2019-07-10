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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdministrator_Click(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator();
            administrator.Show();
            

        }

        private void BtnLibrarian_Click(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian();
            librarian.Show();
        }

        private void CmbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LblSignin_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
