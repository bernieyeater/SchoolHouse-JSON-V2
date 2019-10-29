using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolHouse
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void pbStudentEditor_Click(object sender, EventArgs e)
        {
            new frmStudentEdit().Show();
        }

        private void pbClassesTaughtEditor_Click(object sender, EventArgs e)
        {
            new frmClassesTaughtEditor().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmTeacher().Show();
        }
    }
}
