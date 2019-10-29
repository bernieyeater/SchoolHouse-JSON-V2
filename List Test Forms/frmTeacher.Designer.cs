namespace SchoolHouse
{
    partial class frmTeacher
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
            this.pbUpdate = new System.Windows.Forms.Button();
            this.pbAdd = new System.Windows.Forms.Button();
            this.pbDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbClear = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.pbExit = new System.Windows.Forms.Button();
            this.pbLastStudent = new System.Windows.Forms.Button();
            this.readJSON = new System.Windows.Forms.Button();
            this.writeJson = new System.Windows.Forms.Button();
            this.pbPrevious = new System.Windows.Forms.Button();
            this.pbNext = new System.Windows.Forms.Button();
            this.pbFirstName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalRecords = new System.Windows.Forms.Label();
            this.lbRecordNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbUpdate
            // 
            this.pbUpdate.Location = new System.Drawing.Point(483, 90);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(50, 26);
            this.pbUpdate.TabIndex = 58;
            this.pbUpdate.Text = "Update";
            this.pbUpdate.UseVisualStyleBackColor = true;
            // 
            // pbAdd
            // 
            this.pbAdd.Location = new System.Drawing.Point(427, 90);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(50, 26);
            this.pbAdd.TabIndex = 57;
            this.pbAdd.Text = "Add";
            this.pbAdd.UseVisualStyleBackColor = true;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbDelete
            // 
            this.pbDelete.Location = new System.Drawing.Point(427, 58);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(50, 26);
            this.pbDelete.TabIndex = 56;
            this.pbDelete.Text = "Delete";
            this.pbDelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "First Name";
            // 
            // pbClear
            // 
            this.pbClear.Location = new System.Drawing.Point(483, 58);
            this.pbClear.Name = "pbClear";
            this.pbClear.Size = new System.Drawing.Size(50, 26);
            this.pbClear.TabIndex = 55;
            this.pbClear.Text = "Clear";
            this.pbClear.UseVisualStyleBackColor = true;
            this.pbClear.Click += new System.EventHandler(this.pbClear_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(297, 90);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 52;
            this.tbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(297, 66);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 51;
            this.tbFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // pbExit
            // 
            this.pbExit.Location = new System.Drawing.Point(559, 142);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(59, 26);
            this.pbExit.TabIndex = 65;
            this.pbExit.Text = "Exit";
            this.pbExit.UseVisualStyleBackColor = true;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbLastStudent
            // 
            this.pbLastStudent.Location = new System.Drawing.Point(333, 142);
            this.pbLastStudent.Name = "pbLastStudent";
            this.pbLastStudent.Size = new System.Drawing.Size(62, 26);
            this.pbLastStudent.TabIndex = 64;
            this.pbLastStudent.Text = "Last";
            this.pbLastStudent.UseVisualStyleBackColor = true;
            this.pbLastStudent.Click += new System.EventHandler(this.pbLastStudent_Click);
            // 
            // readJSON
            // 
            this.readJSON.Location = new System.Drawing.Point(427, 142);
            this.readJSON.Name = "readJSON";
            this.readJSON.Size = new System.Drawing.Size(61, 26);
            this.readJSON.TabIndex = 63;
            this.readJSON.Text = "Read";
            this.readJSON.UseVisualStyleBackColor = true;
            this.readJSON.Click += new System.EventHandler(this.readJSON_Click);
            // 
            // writeJson
            // 
            this.writeJson.Location = new System.Drawing.Point(494, 142);
            this.writeJson.Name = "writeJson";
            this.writeJson.Size = new System.Drawing.Size(59, 26);
            this.writeJson.TabIndex = 62;
            this.writeJson.Text = "Write";
            this.writeJson.UseVisualStyleBackColor = true;
            this.writeJson.Click += new System.EventHandler(this.writeStudentJson_Click);
            // 
            // pbPrevious
            // 
            this.pbPrevious.Location = new System.Drawing.Point(199, 142);
            this.pbPrevious.Name = "pbPrevious";
            this.pbPrevious.Size = new System.Drawing.Size(60, 26);
            this.pbPrevious.TabIndex = 60;
            this.pbPrevious.Text = "Previous";
            this.pbPrevious.UseVisualStyleBackColor = true;
            this.pbPrevious.Click += new System.EventHandler(this.pbPrevious_Click);
            // 
            // pbNext
            // 
            this.pbNext.Location = new System.Drawing.Point(265, 142);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(62, 26);
            this.pbNext.TabIndex = 61;
            this.pbNext.Text = "Next";
            this.pbNext.UseVisualStyleBackColor = true;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // pbFirstName
            // 
            this.pbFirstName.Location = new System.Drawing.Point(128, 142);
            this.pbFirstName.Name = "pbFirstName";
            this.pbFirstName.Size = new System.Drawing.Size(65, 26);
            this.pbFirstName.TabIndex = 59;
            this.pbFirstName.Text = "First";
            this.pbFirstName.UseVisualStyleBackColor = true;
            this.pbFirstName.Click += new System.EventHandler(this.pbFirstName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 70;
            this.label1.Text = "Teacher Editor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Total Records:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Record Number:";
            // 
            // lbTotalRecords
            // 
            this.lbTotalRecords.AutoSize = true;
            this.lbTotalRecords.Location = new System.Drawing.Point(440, 41);
            this.lbTotalRecords.Name = "lbTotalRecords";
            this.lbTotalRecords.Size = new System.Drawing.Size(14, 13);
            this.lbTotalRecords.TabIndex = 69;
            this.lbTotalRecords.Text = "#";
            // 
            // lbRecordNumber
            // 
            this.lbRecordNumber.AutoSize = true;
            this.lbRecordNumber.Location = new System.Drawing.Point(318, 39);
            this.lbRecordNumber.Name = "lbRecordNumber";
            this.lbRecordNumber.Size = new System.Drawing.Size(14, 13);
            this.lbRecordNumber.TabIndex = 68;
            this.lbRecordNumber.Text = "#";
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTotalRecords);
            this.Controls.Add(this.lbRecordNumber);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbLastStudent);
            this.Controls.Add(this.readJSON);
            this.Controls.Add(this.writeJson);
            this.Controls.Add(this.pbPrevious);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbFirstName);
            this.Controls.Add(this.pbUpdate);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbClear);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Name = "frmTeacher";
            this.Text = "frmTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pbUpdate;
        private System.Windows.Forms.Button pbAdd;
        private System.Windows.Forms.Button pbDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pbClear;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button pbExit;
        private System.Windows.Forms.Button pbLastStudent;
        private System.Windows.Forms.Button readJSON;
        private System.Windows.Forms.Button writeJson;
        private System.Windows.Forms.Button pbPrevious;
        private System.Windows.Forms.Button pbNext;
        private System.Windows.Forms.Button pbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotalRecords;
        private System.Windows.Forms.Label lbRecordNumber;
    }
}