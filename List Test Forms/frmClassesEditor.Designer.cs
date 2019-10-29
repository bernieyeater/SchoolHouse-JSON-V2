namespace SchoolHouse
{
    partial class frmClassesTaughtEditor
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
            this.tbClassTaughtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbClassTaughtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMainTitle = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.pbUpdateClass = new System.Windows.Forms.Button();
            this.pbLastClass = new System.Windows.Forms.Button();
            this.pbAddClass = new System.Windows.Forms.Button();
            this.pbDeleteClass = new System.Windows.Forms.Button();
            this.readClassJSON = new System.Windows.Forms.Button();
            this.writeClassJson = new System.Windows.Forms.Button();
            this.pbPreviousClass = new System.Windows.Forms.Button();
            this.pbClearClass = new System.Windows.Forms.Button();
            this.pbNextClass = new System.Windows.Forms.Button();
            this.pbFirstClass = new System.Windows.Forms.Button();
            this.cbClassDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTeacherFullName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbClassTaughtDescription
            // 
            this.tbClassTaughtDescription.Location = new System.Drawing.Point(162, 170);
            this.tbClassTaughtDescription.Name = "tbClassTaughtDescription";
            this.tbClassTaughtDescription.Size = new System.Drawing.Size(340, 20);
            this.tbClassTaughtDescription.TabIndex = 4;
            this.tbClassTaughtDescription.TextChanged += new System.EventHandler(this.tbClassTaughtDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Class ID:";
            // 
            // tbClassTaughtID
            // 
            this.tbClassTaughtID.Location = new System.Drawing.Point(162, 118);
            this.tbClassTaughtID.Name = "tbClassTaughtID";
            this.tbClassTaughtID.Size = new System.Drawing.Size(100, 20);
            this.tbClassTaughtID.TabIndex = 6;
            this.tbClassTaughtID.TextChanged += new System.EventHandler(this.tbClassTaughtID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teacher:";
            // 
            // lbMainTitle
            // 
            this.lbMainTitle.AutoSize = true;
            this.lbMainTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainTitle.Location = new System.Drawing.Point(156, 33);
            this.lbMainTitle.Name = "lbMainTitle";
            this.lbMainTitle.Size = new System.Drawing.Size(305, 32);
            this.lbMainTitle.TabIndex = 9;
            this.lbMainTitle.Text = "Classes Taught Editor";
            this.lbMainTitle.Click += new System.EventHandler(this.lbMainTitle_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(285, 329);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(59, 26);
            this.Exit.TabIndex = 63;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pbUpdateClass
            // 
            this.pbUpdateClass.Location = new System.Drawing.Point(350, 229);
            this.pbUpdateClass.Name = "pbUpdateClass";
            this.pbUpdateClass.Size = new System.Drawing.Size(62, 26);
            this.pbUpdateClass.TabIndex = 62;
            this.pbUpdateClass.Text = "Update";
            this.pbUpdateClass.UseVisualStyleBackColor = true;
            this.pbUpdateClass.Click += new System.EventHandler(this.pbUpdate_Click);
            // 
            // pbLastClass
            // 
            this.pbLastClass.Location = new System.Drawing.Point(350, 261);
            this.pbLastClass.Name = "pbLastClass";
            this.pbLastClass.Size = new System.Drawing.Size(62, 26);
            this.pbLastClass.TabIndex = 61;
            this.pbLastClass.Text = "Last";
            this.pbLastClass.UseVisualStyleBackColor = true;
            this.pbLastClass.Click += new System.EventHandler(this.pbLastClass_Click);
            // 
            // pbAddClass
            // 
            this.pbAddClass.Location = new System.Drawing.Point(145, 229);
            this.pbAddClass.Name = "pbAddClass";
            this.pbAddClass.Size = new System.Drawing.Size(61, 26);
            this.pbAddClass.TabIndex = 60;
            this.pbAddClass.Text = "Add";
            this.pbAddClass.UseVisualStyleBackColor = true;
            this.pbAddClass.Click += new System.EventHandler(this.pbAddClass_Click);
            // 
            // pbDeleteClass
            // 
            this.pbDeleteClass.Location = new System.Drawing.Point(216, 229);
            this.pbDeleteClass.Name = "pbDeleteClass";
            this.pbDeleteClass.Size = new System.Drawing.Size(60, 26);
            this.pbDeleteClass.TabIndex = 59;
            this.pbDeleteClass.Text = "Delete";
            this.pbDeleteClass.UseVisualStyleBackColor = true;
            this.pbDeleteClass.Click += new System.EventHandler(this.pbDeleteClass_Click);
            // 
            // readClassJSON
            // 
            this.readClassJSON.Location = new System.Drawing.Point(418, 229);
            this.readClassJSON.Name = "readClassJSON";
            this.readClassJSON.Size = new System.Drawing.Size(61, 26);
            this.readClassJSON.TabIndex = 58;
            this.readClassJSON.Text = "Read";
            this.readClassJSON.UseVisualStyleBackColor = true;
            this.readClassJSON.Click += new System.EventHandler(this.readClassJSON_Click);
            // 
            // writeClassJson
            // 
            this.writeClassJson.Location = new System.Drawing.Point(420, 261);
            this.writeClassJson.Name = "writeClassJson";
            this.writeClassJson.Size = new System.Drawing.Size(59, 26);
            this.writeClassJson.TabIndex = 57;
            this.writeClassJson.Text = "Write";
            this.writeClassJson.UseVisualStyleBackColor = true;
            this.writeClassJson.Click += new System.EventHandler(this.writeStudentJson_Click);
            // 
            // pbPreviousClass
            // 
            this.pbPreviousClass.Location = new System.Drawing.Point(216, 261);
            this.pbPreviousClass.Name = "pbPreviousClass";
            this.pbPreviousClass.Size = new System.Drawing.Size(60, 26);
            this.pbPreviousClass.TabIndex = 54;
            this.pbPreviousClass.Text = "Previous";
            this.pbPreviousClass.UseVisualStyleBackColor = true;
            this.pbPreviousClass.Click += new System.EventHandler(this.pbPreviousClass_Click);
            // 
            // pbClearClass
            // 
            this.pbClearClass.Location = new System.Drawing.Point(282, 229);
            this.pbClearClass.Name = "pbClearClass";
            this.pbClearClass.Size = new System.Drawing.Size(62, 26);
            this.pbClearClass.TabIndex = 56;
            this.pbClearClass.Text = "Clear";
            this.pbClearClass.UseVisualStyleBackColor = true;
            this.pbClearClass.Click += new System.EventHandler(this.pbClearClass_Click);
            // 
            // pbNextClass
            // 
            this.pbNextClass.Location = new System.Drawing.Point(282, 261);
            this.pbNextClass.Name = "pbNextClass";
            this.pbNextClass.Size = new System.Drawing.Size(62, 26);
            this.pbNextClass.TabIndex = 55;
            this.pbNextClass.Text = "Next";
            this.pbNextClass.UseVisualStyleBackColor = true;
            this.pbNextClass.Click += new System.EventHandler(this.pbNextClass_Click);
            // 
            // pbFirstClass
            // 
            this.pbFirstClass.Location = new System.Drawing.Point(145, 261);
            this.pbFirstClass.Name = "pbFirstClass";
            this.pbFirstClass.Size = new System.Drawing.Size(65, 26);
            this.pbFirstClass.TabIndex = 53;
            this.pbFirstClass.Text = "First";
            this.pbFirstClass.UseVisualStyleBackColor = true;
            this.pbFirstClass.Click += new System.EventHandler(this.pbFirstClass_Click);
            // 
            // cbClassDepartment
            // 
            this.cbClassDepartment.FormattingEnabled = true;
            this.cbClassDepartment.Location = new System.Drawing.Point(162, 92);
            this.cbClassDepartment.Name = "cbClassDepartment";
            this.cbClassDepartment.Size = new System.Drawing.Size(121, 21);
            this.cbClassDepartment.TabIndex = 64;
            this.cbClassDepartment.SelectedIndexChanged += new System.EventHandler(this.cbClassDepartment_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Dept:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Discription:";
            // 
            // cbTeacherFullName
            // 
            this.cbTeacherFullName.FormattingEnabled = true;
            this.cbTeacherFullName.Location = new System.Drawing.Point(162, 144);
            this.cbTeacherFullName.Name = "cbTeacherFullName";
            this.cbTeacherFullName.Size = new System.Drawing.Size(230, 21);
            this.cbTeacherFullName.TabIndex = 83;
            this.cbTeacherFullName.SelectedIndexChanged += new System.EventHandler(this.cbHourDescription01_SelectedIndexChanged);
            // 
            // frmClassesTaughtEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 382);
            this.Controls.Add(this.cbTeacherFullName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbClassDepartment);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pbUpdateClass);
            this.Controls.Add(this.pbLastClass);
            this.Controls.Add(this.pbAddClass);
            this.Controls.Add(this.pbDeleteClass);
            this.Controls.Add(this.readClassJSON);
            this.Controls.Add(this.writeClassJson);
            this.Controls.Add(this.pbPreviousClass);
            this.Controls.Add(this.pbClearClass);
            this.Controls.Add(this.pbNextClass);
            this.Controls.Add(this.pbFirstClass);
            this.Controls.Add(this.lbMainTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbClassTaughtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClassTaughtDescription);
            this.Name = "frmClassesTaughtEditor";
            this.Text = "frmClassesTaughtEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbClassTaughtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbClassTaughtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMainTitle;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button pbUpdateClass;
        private System.Windows.Forms.Button pbLastClass;
        private System.Windows.Forms.Button pbAddClass;
        private System.Windows.Forms.Button pbDeleteClass;
        private System.Windows.Forms.Button readClassJSON;
        private System.Windows.Forms.Button writeClassJson;
        private System.Windows.Forms.Button pbPreviousClass;
        private System.Windows.Forms.Button pbClearClass;
        private System.Windows.Forms.Button pbNextClass;
        private System.Windows.Forms.Button pbFirstClass;
        private System.Windows.Forms.ComboBox cbClassDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTeacherFullName;
    }
}