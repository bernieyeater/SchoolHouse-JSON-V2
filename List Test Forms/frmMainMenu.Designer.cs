namespace SchoolHouse
{
    partial class frmMainMenu
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
            this.pbStudentEditor = new System.Windows.Forms.Button();
            this.lbMainTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pbClassesTaughtEditor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbStudentEditor
            // 
            this.pbStudentEditor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbStudentEditor.Location = new System.Drawing.Point(202, 154);
            this.pbStudentEditor.Name = "pbStudentEditor";
            this.pbStudentEditor.Size = new System.Drawing.Size(115, 36);
            this.pbStudentEditor.TabIndex = 0;
            this.pbStudentEditor.Text = "Student Editor";
            this.pbStudentEditor.UseVisualStyleBackColor = true;
            this.pbStudentEditor.Click += new System.EventHandler(this.pbStudentEditor_Click);
            // 
            // lbMainTitle
            // 
            this.lbMainTitle.AutoSize = true;
            this.lbMainTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainTitle.Location = new System.Drawing.Point(184, 39);
            this.lbMainTitle.Name = "lbMainTitle";
            this.lbMainTitle.Size = new System.Drawing.Size(405, 32);
            this.lbMainTitle.TabIndex = 1;
            this.lbMainTitle.Text = "School Management Program";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(444, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Staff Editor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbClassesTaughtEditor
            // 
            this.pbClassesTaughtEditor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbClassesTaughtEditor.Location = new System.Drawing.Point(323, 154);
            this.pbClassesTaughtEditor.Name = "pbClassesTaughtEditor";
            this.pbClassesTaughtEditor.Size = new System.Drawing.Size(115, 36);
            this.pbClassesTaughtEditor.TabIndex = 3;
            this.pbClassesTaughtEditor.Text = "Class Editor";
            this.pbClassesTaughtEditor.UseVisualStyleBackColor = true;
            this.pbClassesTaughtEditor.Click += new System.EventHandler(this.pbClassesTaughtEditor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Note:  You must have the three json files file at C:\\LIST\\ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "for this program to work.";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbClassesTaughtEditor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbMainTitle);
            this.Controls.Add(this.pbStudentEditor);
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pbStudentEditor;
        private System.Windows.Forms.Label lbMainTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pbClassesTaughtEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}