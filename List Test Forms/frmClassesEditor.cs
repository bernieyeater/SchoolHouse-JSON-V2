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
    public partial class frmClassesTaughtEditor : Form
    {
        ClassesService classesTaughtService = new ClassesService();
        TeacherService teacherServices = new TeacherService();
        List<Teacher> listOfTeachers = new List<Teacher>();

        List<SchoolHouse.ClassesTaught> listOfClasses = new List<SchoolHouse.ClassesTaught>();
        int classIndexer = 0;

        public frmClassesTaughtEditor()
        {
            InitializeComponent();

            String[] sDepartment = { "", "Business", "English", "History", "Math", "Music", "Science", "Pys Ed" };
            cbClassDepartment.DataSource = sDepartment;
            ClassesRead();
            listOfTeachers.Clear();
            listOfTeachers = teacherServices.getTeacherlist();
            cbTeacherFullName.Items.Clear();
            foreach (var person in listOfTeachers) cbTeacherFullName.Items.Add(person.fullName);
        }
        
        private void pbUpdate_Click(object sender, EventArgs e)
        {
            classWrite();
        }

        private void writeStudentJson_Click(object sender, EventArgs e)
        {
            classWrite();

        }

        private void classWrite()
        {
            var userJsonC = classesTaughtService.ToJson();
            var path = @"C:\List\Classes1.json";
            System.IO.File.WriteAllText(path, userJsonC);
        }

        private void pbAddClass_Click(object sender, EventArgs e)
        {
            string cDept = cbClassDepartment.Text;
            string cID = tbClassTaughtID.Text;
            string cTeach = cbTeacherFullName.Text;
            string cDescript = tbClassTaughtDescription.Text;
            classesTaughtService.AddClassTaught(cDept, cID, cDescript, cTeach );
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Garbage methods C# creates
        private void cbClassDepartment_SelectedIndexChanged(object sender, EventArgs e) { }
        private void tbClassTaughtID_TextChanged(object sender, EventArgs e) {}
        private void lbMainTitle_Click(object sender, EventArgs e) { }
        private void readClassJSON_Click(object sender, EventArgs e)
        {
            ClassesRead();
        }

        private void ClassesRead()
        {
            listOfClasses.Clear();
            listOfClasses = classesTaughtService.getClasslist();
            classIndexer = 0;
            UpdateClassTextbox();
        }
        private void UpdateClassTextbox()
        {
            cbClassDepartment.Text = listOfClasses[classIndexer].classDept;
            tbClassTaughtID.Text = listOfClasses[classIndexer].classID;
            cbTeacherFullName.Text = listOfClasses[classIndexer].classTeacher;
            tbClassTaughtDescription.Text = listOfClasses[classIndexer].classDescription;
        }

        private void pbClearClass_Click(object sender, EventArgs e)
        {
            cbClassDepartment.Text = "English";
            tbClassTaughtID.Text = "";
            cbTeacherFullName.Text = "";
            tbClassTaughtDescription.Text = "";
        }

        private void pbNextClass_Click(object sender, EventArgs e)
        {
            if (classIndexer < listOfClasses.Count - 1)
            {
                classIndexer++;
                UpdateClassTextbox();
            }
        }

        private void pbPreviousClass_Click(object sender, EventArgs e)
        {
            if (classIndexer > 0)
            {
                classIndexer--;
                UpdateClassTextbox();
            }
        }

        private void pbDeleteClass_Click(object sender, EventArgs e)
        {
            listOfClasses.RemoveAt(classIndexer);
            if (classIndexer > 0) { classIndexer--; } else { classIndexer = 0; }
            UpdateClassTextbox();
        }

        private void tbClassTaughtDescription_TextChanged(object sender, EventArgs e)  { }
        private void cbHourDescription01_SelectedIndexChanged(object sender, EventArgs e){ }

        private void pbFirstClass_Click(object sender, EventArgs e)
        {
            classIndexer = 0;
            UpdateClassTextbox();
        }

        private void pbLastClass_Click(object sender, EventArgs e)
        {
            classIndexer = listOfClasses.Count - 1;
            UpdateClassTextbox();
        }
    }

}
