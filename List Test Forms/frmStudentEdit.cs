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
using System.Drawing.Printing;

namespace SchoolHouse
{
    public partial class frmStudentEdit : Form
    {
        //Get the students and the methods for students.
        StudentService studentService = new StudentService();
        List<Student2> listOfStudents = new List<Student2>();
        String[] sDepartment = { "", "Business", "English", "History", "Math", "Music", "Science", "Pys Ed" };

        //Get the classes taught so we can assign students
        List<ClassesTaught> listOfClasses = new List<ClassesTaught>();
        ClassesService classesTaughtService = new ClassesService();
        int studentIndexer;

        private void ClassesRead()
        {
            listOfClasses.Clear();
            listOfClasses = classesTaughtService.getClasslist();
        }

        public frmStudentEdit()
        {
            InitializeComponent();
            StudentRead();
            studentIndexer = 0;
        }

        private void pbFirstName_Click(object sender, EventArgs e)
        {
            //First Student Button
            studentIndexer = 0;
            upDateTextBoxes();
        }

        private void pbNext_Click(object sender, EventArgs e) {
            if (studentIndexer < listOfStudents.Count - 1) {
                studentIndexer++;
                upDateTextBoxes(); } }

        private void button4_Click(object sender, EventArgs e) {
            //Clear Button
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbGrade.Text = "";
            cbHourID01.Text = "";
            cbHourID02.Text = "";
            cbHourID03.Text = "";
            cbHourID04.Text = "";
            cbHourID05.Text = "";
            cbHourID06.Text = "";
            cbHourDescription01.Text = "";
            cbHourDescription02.Text = "";
            cbHourDescription03.Text = "";
            cbHourDescription04.Text = "";
            cbHourDescription05.Text = "";
            cbHourDescription06.Text = "";

        }

        private void pbPrevious_Click(object sender, EventArgs e) {
            //Previous Button
            if (studentIndexer > 0) {
                studentIndexer--;
                upDateTextBoxes(); } }

        private void upDateTextBoxes() {
            tbFirstName.Text = listOfStudents[studentIndexer].firstName;
            tbLastName.Text = listOfStudents[studentIndexer].lastName;
            tbGrade.Text = listOfStudents[studentIndexer].grade;
            lbStudentIDNo.Text = listOfStudents[studentIndexer].studentId.ToString();
            lbRecordNumber.Text = (studentIndexer + 1).ToString();
            lbTotalRecords.Text = listOfStudents.Count().ToString();
            cbHourDescription01.Text = listOfStudents[studentIndexer].HourDescription[0];
            cbHourDescription02.Text = listOfStudents[studentIndexer].HourDescription[1];
            cbHourDescription03.Text = listOfStudents[studentIndexer].HourDescription[2];
            cbHourDescription04.Text = listOfStudents[studentIndexer].HourDescription[3];
            cbHourDescription05.Text = listOfStudents[studentIndexer].HourDescription[4];
            cbHourDescription06.Text = listOfStudents[studentIndexer].HourDescription[5];
            cbHourID01.Text = listOfStudents[studentIndexer].HourId[0];
            cbHourID02.Text = listOfStudents[studentIndexer].HourId[1];
            cbHourID03.Text = listOfStudents[studentIndexer].HourId[2];
            cbHourID04.Text = listOfStudents[studentIndexer].HourId[3];
            cbHourID05.Text = listOfStudents[studentIndexer].HourId[4];
            cbHourID06.Text = listOfStudents[studentIndexer].HourId[5];
            cbHourID01.Items.Clear();
            cbHourID02.Items.Clear();
            cbHourID03.Items.Clear();
            cbHourID04.Items.Clear();
            cbHourID05.Items.Clear();
            cbHourID06.Items.Clear();
            cbHourID01.Items.AddRange(sDepartment);
            cbHourID02.Items.AddRange(sDepartment);
            cbHourID03.Items.AddRange(sDepartment);
            cbHourID04.Items.AddRange(sDepartment);
            cbHourID05.Items.AddRange(sDepartment);
            cbHourID06.Items.AddRange(sDepartment); }

        private void updateListFromForm() {
            listOfStudents[studentIndexer].firstName = tbFirstName.Text;
            listOfStudents[studentIndexer].lastName = tbLastName.Text;
            listOfStudents[studentIndexer].grade = tbGrade.Text;
            listOfStudents[studentIndexer].HourDescription[0] = cbHourDescription01.Text;
            listOfStudents[studentIndexer].HourDescription[1] = cbHourDescription02.Text;
            listOfStudents[studentIndexer].HourDescription[2] = cbHourDescription03.Text;
            listOfStudents[studentIndexer].HourDescription[3] = cbHourDescription04.Text;
            listOfStudents[studentIndexer].HourDescription[4] = cbHourDescription05.Text;
            listOfStudents[studentIndexer].HourDescription[5] = cbHourDescription06.Text;
            listOfStudents[studentIndexer].HourId[0] = cbHourID01.Text;
            listOfStudents[studentIndexer].HourId[1] = cbHourID02.Text;
            listOfStudents[studentIndexer].HourId[2] = cbHourID03.Text;
            listOfStudents[studentIndexer].HourId[3] = cbHourID04.Text;
            listOfStudents[studentIndexer].HourId[4] = cbHourID05.Text;
            listOfStudents[studentIndexer].HourId[5] = cbHourID06.Text; }



        private void writeStudentJson_Click(object sender, EventArgs e) {
            studentWrite(); }

        private void studentWrite() {
            var userJson = studentService.ToJson(); ;
            var path = @"C:\List\Students2.json";
            System.IO.File.WriteAllText(path, userJson); }

        private void readStudentsJSON_Click(object sender, EventArgs e) {
            StudentRead();
        }

        private void StudentRead() {
            listOfStudents.Clear();
            listOfStudents = studentService.getStudentlist();
            if (studentService.theJson == "File Not Found")
            { MessageBox.Show("Student File Not Found on C at LIST"); }
            else { 
            upDateTextBoxes();
            studentIndexer = 0; } }

        private void StudentEdit_Load(object sender, EventArgs e) { }

        private void pbDeleteStudent_Click(object sender, EventArgs e)
        {
            listOfStudents.RemoveAt(studentIndexer);
            studentIndexer = 0;
            upDateTextBoxes();
        }

        private void tbAddStudent_Click(object sender, EventArgs e)
        {
            //Add Student
            string sfname = tbFirstName.Text;
            string slname = tbLastName.Text;
            string sgrade = tbGrade.Text;
            int sId = listOfStudents.Count;
            string[] hId = { "", "", "", "", "", "" };
            string[] hDesc = { "", "", "", "", "", "" };
            hId[0] = cbHourID01.Text;
            hId[1] = cbHourID02.Text;
            hId[2] = cbHourID03.Text;
            hId[3] = cbHourID04.Text;
            hId[4] = cbHourID05.Text;
            hId[5] = cbHourID06.Text;
            hDesc[0] = cbHourDescription01.Text;
            hDesc[1] = cbHourDescription02.Text;
            hDesc[2] = cbHourDescription03.Text;
            hDesc[3] = cbHourDescription04.Text;
            hDesc[4] = cbHourDescription05.Text;
            hDesc[5] = cbHourDescription06.Text;
            studentService.AddStudents(sId, sfname, slname, sgrade, hId, hDesc);
        }

        private void pbLastStudent_Click(object sender, EventArgs e)
        {
            studentIndexer = listOfStudents.Count - 1;
            upDateTextBoxes();
        }

        private void Exit_Click(object sender, EventArgs e) {
            this.Close(); }
        
        private void pbUpdate_Click(object sender, EventArgs e) {
            updateListFromForm();
            studentWrite(); }
        
        private void cbHourID01_SelectedIndexChanged(object sender, EventArgs e) {
            ClassesRead();
            int y = listOfClasses.Count; int x = 0;
            cbHourDescription01.Items.Clear();
            for (x = 0; x < y; x++) {
                if (cbHourID01.Text == listOfClasses[x].classDept)
                { cbHourDescription01.Items.Add(listOfClasses[x].classDescription);} } }

        private void cbHourID02_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassesRead();
            int y = listOfClasses.Count; int x = 0;
            cbHourDescription02.Items.Clear();
            for (x = 0; x < y; x++)
            {
                if (cbHourID02.Text == listOfClasses[x].classDept)
                { cbHourDescription02.Items.Add(listOfClasses[x].classDescription); } } }
            

        private void cbHourID03_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassesRead();
            int y = listOfClasses.Count; int x = 0;
            cbHourDescription03.Items.Clear();
            for (x = 0; x < y; x++)
            {
                if (cbHourID03.Text == listOfClasses[x].classDept)
                { cbHourDescription03.Items.Add(listOfClasses[x].classDescription); } } }

        private void cbHourID04_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassesRead();
            int y = listOfClasses.Count; int x = 0;
            cbHourDescription04.Items.Clear();
            for (x = 0; x < y; x++)
            {
                if (cbHourID04.Text == listOfClasses[x].classDept)
                { cbHourDescription04.Items.Add(listOfClasses[x].classDescription); }
            }
        }

        private void cbHourID05_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassesRead();
            int y = listOfClasses.Count; int x = 0;
            cbHourDescription05.Items.Clear();
            for (x = 0; x < y; x++)
            {
                if (cbHourID05.Text == listOfClasses[x].classDept)
                { cbHourDescription05.Items.Add(listOfClasses[x].classDescription); } } }

        private void cbHourID06_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectCLasses = listOfClasses.Where(p => p.classDept == cbHourID06.Text);
            cbHourDescription06.Items.Clear();
            foreach (var person in selectCLasses)
                cbHourDescription06.Items.Add(person.classDescription);
        }
        //Bitmap memoryImage;
        private void pbPrintStudent_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        //Garbage events marked for deletion .Net created these.
        private void pbHourSelect02_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }
        private void tbHourDescription01_TextChanged(object sender, EventArgs e) { }
        private void cbHourDescription01_SelectedIndexChanged(object sender, EventArgs e) { }
        private void pbHourSelect01_Click(object sender, EventArgs e) { }
        private void readStudentsButton_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void cbHourDescription04_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void cbHourDescription02_SelectedIndexChanged(object sender, EventArgs e){ }
        //private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e) {  }

    }
}
