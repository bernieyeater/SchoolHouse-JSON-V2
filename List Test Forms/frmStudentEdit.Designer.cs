namespace SchoolHouse
{
    partial class frmStudentEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbFirstName = new System.Windows.Forms.Button();
            this.lbRecordNumber = new System.Windows.Forms.Label();
            this.lbTotalRecords = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.pbNext = new System.Windows.Forms.Button();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.pbClearStudent = new System.Windows.Forms.Button();
            this.pbPrevious = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.writeStudentJson = new System.Windows.Forms.Button();
            this.readStudentsJSON = new System.Windows.Forms.Button();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.pbDeleteStudent = new System.Windows.Forms.Button();
            this.pbAddStudent = new System.Windows.Forms.Button();
            this.pbLastStudent = new System.Windows.Forms.Button();
            this.pbUpdate = new System.Windows.Forms.Button();
            this.lbStudentIDNo = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.pbPrintStudent = new System.Windows.Forms.Button();
            this.pbStudentReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbHourDescription01 = new System.Windows.Forms.ComboBox();
            this.cbHourID01 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbHourID02 = new System.Windows.Forms.ComboBox();
            this.cbHourDescription02 = new System.Windows.Forms.ComboBox();
            this.cbHourDescription03 = new System.Windows.Forms.ComboBox();
            this.cbHourID03 = new System.Windows.Forms.ComboBox();
            this.cbHourDescription04 = new System.Windows.Forms.ComboBox();
            this.cbHourID04 = new System.Windows.Forms.ComboBox();
            this.cbHourDescription05 = new System.Windows.Forms.ComboBox();
            this.cbHourID05 = new System.Windows.Forms.ComboBox();
            this.cbHourDescription06 = new System.Windows.Forms.ComboBox();
            this.cbHourID06 = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // pbFirstName
            // 
            this.pbFirstName.Location = new System.Drawing.Point(145, 363);
            this.pbFirstName.Name = "pbFirstName";
            this.pbFirstName.Size = new System.Drawing.Size(65, 26);
            this.pbFirstName.TabIndex = 20;
            this.pbFirstName.Text = "First";
            this.pbFirstName.UseVisualStyleBackColor = true;
            this.pbFirstName.Click += new System.EventHandler(this.pbFirstName_Click);
            // 
            // lbRecordNumber
            // 
            this.lbRecordNumber.AutoSize = true;
            this.lbRecordNumber.Location = new System.Drawing.Point(328, 41);
            this.lbRecordNumber.Name = "lbRecordNumber";
            this.lbRecordNumber.Size = new System.Drawing.Size(14, 13);
            this.lbRecordNumber.TabIndex = 40;
            this.lbRecordNumber.Text = "#";
            // 
            // lbTotalRecords
            // 
            this.lbTotalRecords.AutoSize = true;
            this.lbTotalRecords.Location = new System.Drawing.Point(450, 43);
            this.lbTotalRecords.Name = "lbTotalRecords";
            this.lbTotalRecords.Size = new System.Drawing.Size(14, 13);
            this.lbTotalRecords.TabIndex = 41;
            this.lbTotalRecords.Text = "#";
            this.lbTotalRecords.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(252, 86);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(252, 110);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 2;
            this.tbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbNext
            // 
            this.pbNext.Location = new System.Drawing.Point(282, 363);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(62, 26);
            this.pbNext.TabIndex = 22;
            this.pbNext.Text = "Next";
            this.pbNext.UseVisualStyleBackColor = true;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(252, 132);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(100, 20);
            this.tbGrade.TabIndex = 3;
            this.tbGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbGrade.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pbClearStudent
            // 
            this.pbClearStudent.Location = new System.Drawing.Point(432, 100);
            this.pbClearStudent.Name = "pbClearStudent";
            this.pbClearStudent.Size = new System.Drawing.Size(50, 26);
            this.pbClearStudent.TabIndex = 26;
            this.pbClearStudent.Text = "Clear";
            this.pbClearStudent.UseVisualStyleBackColor = true;
            this.pbClearStudent.Click += new System.EventHandler(this.button4_Click);
            // 
            // pbPrevious
            // 
            this.pbPrevious.Location = new System.Drawing.Point(216, 363);
            this.pbPrevious.Name = "pbPrevious";
            this.pbPrevious.Size = new System.Drawing.Size(60, 26);
            this.pbPrevious.TabIndex = 21;
            this.pbPrevious.Text = "Previous";
            this.pbPrevious.UseVisualStyleBackColor = true;
            this.pbPrevious.Click += new System.EventHandler(this.pbPrevious_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Record Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Records:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 134);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Grade of Student";
            // 
            // writeStudentJson
            // 
            this.writeStudentJson.Location = new System.Drawing.Point(543, 363);
            this.writeStudentJson.Name = "writeStudentJson";
            this.writeStudentJson.Size = new System.Drawing.Size(59, 26);
            this.writeStudentJson.TabIndex = 43;
            this.writeStudentJson.Text = "Write";
            this.writeStudentJson.UseVisualStyleBackColor = true;
            this.writeStudentJson.Click += new System.EventHandler(this.writeStudentJson_Click);
            // 
            // readStudentsJSON
            // 
            this.readStudentsJSON.Location = new System.Drawing.Point(476, 363);
            this.readStudentsJSON.Name = "readStudentsJSON";
            this.readStudentsJSON.Size = new System.Drawing.Size(61, 26);
            this.readStudentsJSON.TabIndex = 44;
            this.readStudentsJSON.Text = "Read";
            this.readStudentsJSON.UseVisualStyleBackColor = true;
            this.readStudentsJSON.Click += new System.EventHandler(this.readStudentsJSON_Click);
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentID.Location = new System.Drawing.Point(174, 64);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(74, 20);
            this.lbStudentID.TabIndex = 46;
            this.lbStudentID.Text = "Student ID:";
            // 
            // pbDeleteStudent
            // 
            this.pbDeleteStudent.Location = new System.Drawing.Point(376, 100);
            this.pbDeleteStudent.Name = "pbDeleteStudent";
            this.pbDeleteStudent.Size = new System.Drawing.Size(50, 26);
            this.pbDeleteStudent.TabIndex = 47;
            this.pbDeleteStudent.Text = "Delete";
            this.pbDeleteStudent.UseVisualStyleBackColor = true;
            this.pbDeleteStudent.Click += new System.EventHandler(this.pbDeleteStudent_Click);
            // 
            // pbAddStudent
            // 
            this.pbAddStudent.Location = new System.Drawing.Point(376, 132);
            this.pbAddStudent.Name = "pbAddStudent";
            this.pbAddStudent.Size = new System.Drawing.Size(50, 26);
            this.pbAddStudent.TabIndex = 48;
            this.pbAddStudent.Text = "Add";
            this.pbAddStudent.UseVisualStyleBackColor = true;
            this.pbAddStudent.Click += new System.EventHandler(this.tbAddStudent_Click);
            // 
            // pbLastStudent
            // 
            this.pbLastStudent.Location = new System.Drawing.Point(350, 363);
            this.pbLastStudent.Name = "pbLastStudent";
            this.pbLastStudent.Size = new System.Drawing.Size(62, 26);
            this.pbLastStudent.TabIndex = 49;
            this.pbLastStudent.Text = "Last";
            this.pbLastStudent.UseVisualStyleBackColor = true;
            this.pbLastStudent.Click += new System.EventHandler(this.pbLastStudent_Click);
            // 
            // pbUpdate
            // 
            this.pbUpdate.Location = new System.Drawing.Point(432, 132);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(50, 26);
            this.pbUpdate.TabIndex = 50;
            this.pbUpdate.Text = "Update";
            this.pbUpdate.UseVisualStyleBackColor = true;
            this.pbUpdate.Click += new System.EventHandler(this.pbUpdate_Click);
            // 
            // lbStudentIDNo
            // 
            this.lbStudentIDNo.AutoSize = true;
            this.lbStudentIDNo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentIDNo.Location = new System.Drawing.Point(270, 63);
            this.lbStudentIDNo.Name = "lbStudentIDNo";
            this.lbStudentIDNo.Size = new System.Drawing.Size(65, 20);
            this.lbStudentIDNo.TabIndex = 51;
            this.lbStudentIDNo.Text = "#######";
            this.lbStudentIDNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(608, 363);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(59, 26);
            this.Exit.TabIndex = 52;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pbPrintStudent
            // 
            this.pbPrintStudent.Location = new System.Drawing.Point(142, 465);
            this.pbPrintStudent.Name = "pbPrintStudent";
            this.pbPrintStudent.Size = new System.Drawing.Size(87, 26);
            this.pbPrintStudent.TabIndex = 53;
            this.pbPrintStudent.Text = "Print Student";
            this.pbPrintStudent.UseVisualStyleBackColor = true;
            this.pbPrintStudent.Click += new System.EventHandler(this.pbPrintStudent_Click);
            // 
            // pbStudentReport
            // 
            this.pbStudentReport.Location = new System.Drawing.Point(237, 465);
            this.pbStudentReport.Name = "pbStudentReport";
            this.pbStudentReport.Size = new System.Drawing.Size(87, 26);
            this.pbStudentReport.TabIndex = 54;
            this.pbStudentReport.Text = "Student Report";
            this.pbStudentReport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 55;
            this.label1.Text = "Student Editor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Future Functions:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Hour 1 Class:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Hour 2 Class:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(92, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "Hour 4 Class:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(92, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 67;
            this.label11.Text = "Hour 3 Class:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(92, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 78;
            this.label12.Text = "Hour 6 Class:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(92, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 75;
            this.label13.Text = "Hour 5 Class:";
            // 
            // cbHourDescription01
            // 
            this.cbHourDescription01.FormattingEnabled = true;
            this.cbHourDescription01.Location = new System.Drawing.Point(283, 193);
            this.cbHourDescription01.Name = "cbHourDescription01";
            this.cbHourDescription01.Size = new System.Drawing.Size(305, 21);
            this.cbHourDescription01.TabIndex = 82;
            this.cbHourDescription01.SelectedIndexChanged += new System.EventHandler(this.cbHourDescription01_SelectedIndexChanged);
            // 
            // cbHourID01
            // 
            this.cbHourID01.FormattingEnabled = true;
            this.cbHourID01.Location = new System.Drawing.Point(195, 194);
            this.cbHourID01.Name = "cbHourID01";
            this.cbHourID01.Size = new System.Drawing.Size(80, 21);
            this.cbHourID01.TabIndex = 83;
            this.cbHourID01.SelectedIndexChanged += new System.EventHandler(this.cbHourID01_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(191, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 20);
            this.label14.TabIndex = 84;
            this.label14.Text = "Dept";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(284, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 20);
            this.label15.TabIndex = 85;
            this.label15.Text = "Class Description";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // cbHourID02
            // 
            this.cbHourID02.FormattingEnabled = true;
            this.cbHourID02.Location = new System.Drawing.Point(195, 222);
            this.cbHourID02.Name = "cbHourID02";
            this.cbHourID02.Size = new System.Drawing.Size(80, 21);
            this.cbHourID02.TabIndex = 86;
            this.cbHourID02.SelectedIndexChanged += new System.EventHandler(this.cbHourID02_SelectedIndexChanged);
            // 
            // cbHourDescription02
            // 
            this.cbHourDescription02.FormattingEnabled = true;
            this.cbHourDescription02.Location = new System.Drawing.Point(281, 222);
            this.cbHourDescription02.Name = "cbHourDescription02";
            this.cbHourDescription02.Size = new System.Drawing.Size(305, 21);
            this.cbHourDescription02.TabIndex = 87;
            this.cbHourDescription02.SelectedIndexChanged += new System.EventHandler(this.cbHourDescription02_SelectedIndexChanged);
            // 
            // cbHourDescription03
            // 
            this.cbHourDescription03.FormattingEnabled = true;
            this.cbHourDescription03.Location = new System.Drawing.Point(281, 251);
            this.cbHourDescription03.Name = "cbHourDescription03";
            this.cbHourDescription03.Size = new System.Drawing.Size(305, 21);
            this.cbHourDescription03.TabIndex = 89;
            // 
            // cbHourID03
            // 
            this.cbHourID03.FormattingEnabled = true;
            this.cbHourID03.Location = new System.Drawing.Point(195, 251);
            this.cbHourID03.Name = "cbHourID03";
            this.cbHourID03.Size = new System.Drawing.Size(80, 21);
            this.cbHourID03.TabIndex = 88;
            this.cbHourID03.SelectedIndexChanged += new System.EventHandler(this.cbHourID03_SelectedIndexChanged);
            // 
            // cbHourDescription04
            // 
            this.cbHourDescription04.FormattingEnabled = true;
            this.cbHourDescription04.Location = new System.Drawing.Point(281, 277);
            this.cbHourDescription04.Name = "cbHourDescription04";
            this.cbHourDescription04.Size = new System.Drawing.Size(305, 21);
            this.cbHourDescription04.TabIndex = 91;
            this.cbHourDescription04.SelectedIndexChanged += new System.EventHandler(this.cbHourDescription04_SelectedIndexChanged);
            // 
            // cbHourID04
            // 
            this.cbHourID04.FormattingEnabled = true;
            this.cbHourID04.Location = new System.Drawing.Point(195, 277);
            this.cbHourID04.Name = "cbHourID04";
            this.cbHourID04.Size = new System.Drawing.Size(80, 21);
            this.cbHourID04.TabIndex = 90;
            this.cbHourID04.SelectedIndexChanged += new System.EventHandler(this.cbHourID04_SelectedIndexChanged);
            // 
            // cbHourDescription05
            // 
            this.cbHourDescription05.FormattingEnabled = true;
            this.cbHourDescription05.Location = new System.Drawing.Point(281, 303);
            this.cbHourDescription05.Name = "cbHourDescription05";
            this.cbHourDescription05.Size = new System.Drawing.Size(305, 21);
            this.cbHourDescription05.TabIndex = 93;
            // 
            // cbHourID05
            // 
            this.cbHourID05.FormattingEnabled = true;
            this.cbHourID05.Location = new System.Drawing.Point(195, 303);
            this.cbHourID05.Name = "cbHourID05";
            this.cbHourID05.Size = new System.Drawing.Size(80, 21);
            this.cbHourID05.TabIndex = 92;
            this.cbHourID05.SelectedIndexChanged += new System.EventHandler(this.cbHourID05_SelectedIndexChanged);
            // 
            // cbHourDescription06
            // 
            this.cbHourDescription06.FormattingEnabled = true;
            this.cbHourDescription06.Location = new System.Drawing.Point(281, 330);
            this.cbHourDescription06.Name = "cbHourDescription06";
            this.cbHourDescription06.Size = new System.Drawing.Size(305, 21);
            this.cbHourDescription06.TabIndex = 95;
            // 
            // cbHourID06
            // 
            this.cbHourID06.FormattingEnabled = true;
            this.cbHourID06.Location = new System.Drawing.Point(195, 330);
            this.cbHourID06.Name = "cbHourID06";
            this.cbHourID06.Size = new System.Drawing.Size(80, 21);
            this.cbHourID06.TabIndex = 94;
            this.cbHourID06.SelectedIndexChanged += new System.EventHandler(this.cbHourID06_SelectedIndexChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // frmStudentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 507);
            this.Controls.Add(this.cbHourDescription06);
            this.Controls.Add(this.cbHourID06);
            this.Controls.Add(this.cbHourDescription05);
            this.Controls.Add(this.cbHourID05);
            this.Controls.Add(this.cbHourDescription04);
            this.Controls.Add(this.cbHourID04);
            this.Controls.Add(this.cbHourDescription03);
            this.Controls.Add(this.cbHourID03);
            this.Controls.Add(this.cbHourDescription02);
            this.Controls.Add(this.cbHourID02);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbHourID01);
            this.Controls.Add(this.cbHourDescription01);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbStudentReport);
            this.Controls.Add(this.pbPrintStudent);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.lbStudentIDNo);
            this.Controls.Add(this.pbUpdate);
            this.Controls.Add(this.pbLastStudent);
            this.Controls.Add(this.pbAddStudent);
            this.Controls.Add(this.pbDeleteStudent);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.readStudentsJSON);
            this.Controls.Add(this.writeStudentJson);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbPrevious);
            this.Controls.Add(this.pbClearStudent);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbTotalRecords);
            this.Controls.Add(this.lbRecordNumber);
            this.Controls.Add(this.pbFirstName);
            this.Name = "frmStudentEdit";
            this.Text = "Student Edit";
            this.Load += new System.EventHandler(this.StudentEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pbFirstName;
        private System.Windows.Forms.Label lbRecordNumber;
        private System.Windows.Forms.Label lbTotalRecords;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button pbNext;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Button pbClearStudent;
        private System.Windows.Forms.Button pbPrevious;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button writeStudentJson;
        private System.Windows.Forms.Button readStudentsJSON;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Button pbDeleteStudent;
        private System.Windows.Forms.Button pbAddStudent;
        private System.Windows.Forms.Button pbLastStudent;
        private System.Windows.Forms.Button pbUpdate;
        private System.Windows.Forms.Label lbStudentIDNo;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button pbPrintStudent;
        private System.Windows.Forms.Button pbStudentReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbHourDescription01;
        private System.Windows.Forms.ComboBox cbHourID01;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbHourID02;
        private System.Windows.Forms.ComboBox cbHourDescription02;
        private System.Windows.Forms.ComboBox cbHourDescription03;
        private System.Windows.Forms.ComboBox cbHourID03;
        private System.Windows.Forms.ComboBox cbHourDescription04;
        private System.Windows.Forms.ComboBox cbHourID04;
        private System.Windows.Forms.ComboBox cbHourDescription05;
        private System.Windows.Forms.ComboBox cbHourID05;
        private System.Windows.Forms.ComboBox cbHourDescription06;
        private System.Windows.Forms.ComboBox cbHourID06;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

