using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace SchoolHouse
{

    public partial class frmTeacher : Form
    {
        TeacherService teacherServices = new TeacherService();
        List<Teacher> listOfTeachers = new List<Teacher>();

        int teacherIndexer = 0;
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void writeStudentJson_Click(object sender, EventArgs e)
        {
            var userJson = teacherServices.ToJson(); ;
            var path = @"C:\List\Teacher1.json";
            System.IO.File.WriteAllText(path, userJson);
        }


        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void readJSON_Click(object sender, EventArgs e)
        {
            TeacherRead();
        }

        private void TeacherRead()
        {
            listOfTeachers.Clear();
            listOfTeachers = teacherServices.getTeacherlist();
            //upDateTextBoxes();
            teacherIndexer = 0;
        }

        private void updateTextBoxes()
        {
            tbFirstName.Text = listOfTeachers[teacherIndexer].firstName;
            tbLastName.Text = listOfTeachers[teacherIndexer].lastName;
        }


        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            if (teacherIndexer < listOfTeachers.Count - 1) { teacherIndexer++; }
            updateTextBoxes();


        }

        private void pbPrevious_Click(object sender, EventArgs e)
        {
            if (teacherIndexer > 0) { teacherIndexer--; }
            updateTextBoxes();
        }
        
        private void pbFirstName_Click(object sender, EventArgs e)
        {
            teacherIndexer = 0;
            updateTextBoxes();
        }

        private void pbLastStudent_Click(object sender, EventArgs e)
        {
            teacherIndexer = listOfTeachers.Count - 1;
            updateTextBoxes();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            string fname= tbFirstName.Text;
            string lname = tbLastName.Text;
            string flName = fname + " " + lname;
            listOfTeachers.Add(new Teacher() { firstName = fname, lastName = lname, fullName = flName });
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
        }
    }
}
