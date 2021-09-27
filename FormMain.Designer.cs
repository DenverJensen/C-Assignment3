
namespace Assignment3
{
    partial class FormMain
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
            this.gb_count = new System.Windows.Forms.GroupBox();
            this.btnSubmitCounts = new System.Windows.Forms.Button();
            this.txtNumberOfAssignments = new System.Windows.Forms.TextBox();
            this.txtNumberOfStudents = new System.Windows.Forms.TextBox();
            this.lblNumberOfAssignments = new System.Windows.Forms.Label();
            this.lblNumberOfStudents = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLastStudent = new System.Windows.Forms.Button();
            this.btnNextStudent = new System.Windows.Forms.Button();
            this.btnPrevStudent = new System.Windows.Forms.Button();
            this.btnFirstStudent = new System.Windows.Forms.Button();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.btnSaveName = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.gbStudentScoreInfo = new System.Windows.Forms.GroupBox();
            this.btnSaveScore = new System.Windows.Forms.Button();
            this.txtAssignmentScore = new System.Windows.Forms.TextBox();
            this.lblAssignmentScore = new System.Windows.Forms.Label();
            this.txtAssignmentNumber = new System.Windows.Forms.TextBox();
            this.lblNumberAssignments = new System.Windows.Forms.Label();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.btnDisplayScores = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.gb_count.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbStudentInfo.SuspendLayout();
            this.gbStudentScoreInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_count
            // 
            this.gb_count.Controls.Add(this.btnSubmitCounts);
            this.gb_count.Controls.Add(this.txtNumberOfAssignments);
            this.gb_count.Controls.Add(this.txtNumberOfStudents);
            this.gb_count.Controls.Add(this.lblNumberOfAssignments);
            this.gb_count.Controls.Add(this.lblNumberOfStudents);
            this.gb_count.Location = new System.Drawing.Point(61, 12);
            this.gb_count.Name = "gb_count";
            this.gb_count.Size = new System.Drawing.Size(419, 118);
            this.gb_count.TabIndex = 0;
            this.gb_count.TabStop = false;
            this.gb_count.Text = "Counts";
            // 
            // btnSubmitCounts
            // 
            this.btnSubmitCounts.Location = new System.Drawing.Point(289, 41);
            this.btnSubmitCounts.Name = "btnSubmitCounts";
            this.btnSubmitCounts.Size = new System.Drawing.Size(75, 46);
            this.btnSubmitCounts.TabIndex = 4;
            this.btnSubmitCounts.Text = "Submit Counts";
            this.btnSubmitCounts.UseVisualStyleBackColor = true;
            this.btnSubmitCounts.Click += new System.EventHandler(this.btnSubmitCounts_Click);
            // 
            // txtNumberOfAssignments
            // 
            this.txtNumberOfAssignments.Location = new System.Drawing.Point(162, 78);
            this.txtNumberOfAssignments.Name = "txtNumberOfAssignments";
            this.txtNumberOfAssignments.Size = new System.Drawing.Size(69, 20);
            this.txtNumberOfAssignments.TabIndex = 3;
            // 
            // txtNumberOfStudents
            // 
            this.txtNumberOfStudents.Location = new System.Drawing.Point(161, 34);
            this.txtNumberOfStudents.MaxLength = 1;
            this.txtNumberOfStudents.Name = "txtNumberOfStudents";
            this.txtNumberOfStudents.Size = new System.Drawing.Size(70, 20);
            this.txtNumberOfStudents.TabIndex = 2;
            // 
            // lblNumberOfAssignments
            // 
            this.lblNumberOfAssignments.AutoSize = true;
            this.lblNumberOfAssignments.Location = new System.Drawing.Point(31, 78);
            this.lblNumberOfAssignments.Name = "lblNumberOfAssignments";
            this.lblNumberOfAssignments.Size = new System.Drawing.Size(124, 13);
            this.lblNumberOfAssignments.TabIndex = 1;
            this.lblNumberOfAssignments.Text = "Number of Assignments: ";
            // 
            // lblNumberOfStudents
            // 
            this.lblNumberOfStudents.AutoSize = true;
            this.lblNumberOfStudents.Location = new System.Drawing.Point(48, 37);
            this.lblNumberOfStudents.Name = "lblNumberOfStudents";
            this.lblNumberOfStudents.Size = new System.Drawing.Size(107, 13);
            this.lblNumberOfStudents.TabIndex = 0;
            this.lblNumberOfStudents.Text = "Number of Students: ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(573, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 50);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset Scores";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLastStudent);
            this.groupBox1.Controls.Add(this.btnNextStudent);
            this.groupBox1.Controls.Add(this.btnPrevStudent);
            this.groupBox1.Controls.Add(this.btnFirstStudent);
            this.groupBox1.Location = new System.Drawing.Point(61, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // btnLastStudent
            // 
            this.btnLastStudent.Location = new System.Drawing.Point(519, 24);
            this.btnLastStudent.Name = "btnLastStudent";
            this.btnLastStudent.Size = new System.Drawing.Size(91, 23);
            this.btnLastStudent.TabIndex = 3;
            this.btnLastStudent.Text = "Last Student >>";
            this.btnLastStudent.UseVisualStyleBackColor = true;
            this.btnLastStudent.Click += new System.EventHandler(this.btnLastStudent_Click);
            // 
            // btnNextStudent
            // 
            this.btnNextStudent.Location = new System.Drawing.Point(360, 24);
            this.btnNextStudent.Name = "btnNextStudent";
            this.btnNextStudent.Size = new System.Drawing.Size(101, 23);
            this.btnNextStudent.TabIndex = 2;
            this.btnNextStudent.Text = "Next Student >";
            this.btnNextStudent.UseVisualStyleBackColor = true;
            this.btnNextStudent.Click += new System.EventHandler(this.btnNextStudent_Click);
            // 
            // btnPrevStudent
            // 
            this.btnPrevStudent.Location = new System.Drawing.Point(185, 24);
            this.btnPrevStudent.Name = "btnPrevStudent";
            this.btnPrevStudent.Size = new System.Drawing.Size(110, 23);
            this.btnPrevStudent.TabIndex = 1;
            this.btnPrevStudent.Text = "< Prev Student";
            this.btnPrevStudent.UseVisualStyleBackColor = true;
            this.btnPrevStudent.Click += new System.EventHandler(this.btnPrevStudent_Click);
            // 
            // btnFirstStudent
            // 
            this.btnFirstStudent.Location = new System.Drawing.Point(30, 24);
            this.btnFirstStudent.Name = "btnFirstStudent";
            this.btnFirstStudent.Size = new System.Drawing.Size(103, 23);
            this.btnFirstStudent.TabIndex = 0;
            this.btnFirstStudent.Text = "<< First Student";
            this.btnFirstStudent.UseVisualStyleBackColor = true;
            this.btnFirstStudent.Click += new System.EventHandler(this.btnFirstStudent_Click);
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.btnSaveName);
            this.gbStudentInfo.Controls.Add(this.txtStudentName);
            this.gbStudentInfo.Controls.Add(this.lblStudentName);
            this.gbStudentInfo.Location = new System.Drawing.Point(61, 232);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(642, 78);
            this.gbStudentInfo.TabIndex = 3;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Student Info";
            // 
            // btnSaveName
            // 
            this.btnSaveName.Location = new System.Drawing.Point(512, 31);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(75, 23);
            this.btnSaveName.TabIndex = 2;
            this.btnSaveName.Text = "Save Name";
            this.btnSaveName.UseVisualStyleBackColor = true;
            this.btnSaveName.Click += new System.EventHandler(this.btnSaveName_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(114, 33);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(336, 20);
            this.txtStudentName.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(30, 36);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(66, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student #1: ";
            // 
            // gbStudentScoreInfo
            // 
            this.gbStudentScoreInfo.Controls.Add(this.btnSaveScore);
            this.gbStudentScoreInfo.Controls.Add(this.txtAssignmentScore);
            this.gbStudentScoreInfo.Controls.Add(this.lblAssignmentScore);
            this.gbStudentScoreInfo.Controls.Add(this.txtAssignmentNumber);
            this.gbStudentScoreInfo.Controls.Add(this.lblNumberAssignments);
            this.gbStudentScoreInfo.Location = new System.Drawing.Point(61, 327);
            this.gbStudentScoreInfo.Name = "gbStudentScoreInfo";
            this.gbStudentScoreInfo.Size = new System.Drawing.Size(642, 106);
            this.gbStudentScoreInfo.TabIndex = 4;
            this.gbStudentScoreInfo.TabStop = false;
            this.gbStudentScoreInfo.Text = "Student Score Info";
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.Location = new System.Drawing.Point(448, 50);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(75, 23);
            this.btnSaveScore.TabIndex = 4;
            this.btnSaveScore.Text = "Save Score";
            this.btnSaveScore.UseVisualStyleBackColor = true;
            // 
            // txtAssignmentScore
            // 
            this.txtAssignmentScore.Location = new System.Drawing.Point(289, 72);
            this.txtAssignmentScore.Name = "txtAssignmentScore";
            this.txtAssignmentScore.Size = new System.Drawing.Size(74, 20);
            this.txtAssignmentScore.TabIndex = 3;
            // 
            // lblAssignmentScore
            // 
            this.lblAssignmentScore.AutoSize = true;
            this.lblAssignmentScore.Location = new System.Drawing.Point(151, 72);
            this.lblAssignmentScore.Name = "lblAssignmentScore";
            this.lblAssignmentScore.Size = new System.Drawing.Size(98, 13);
            this.lblAssignmentScore.TabIndex = 2;
            this.lblAssignmentScore.Text = "Assignment Score: ";
            // 
            // txtAssignmentNumber
            // 
            this.txtAssignmentNumber.Location = new System.Drawing.Point(289, 31);
            this.txtAssignmentNumber.Name = "txtAssignmentNumber";
            this.txtAssignmentNumber.Size = new System.Drawing.Size(74, 20);
            this.txtAssignmentNumber.TabIndex = 1;
            // 
            // lblNumberAssignments
            // 
            this.lblNumberAssignments.AutoSize = true;
            this.lblNumberAssignments.Location = new System.Drawing.Point(89, 34);
            this.lblNumberAssignments.Name = "lblNumberAssignments";
            this.lblNumberAssignments.Size = new System.Drawing.Size(160, 13);
            this.lblNumberAssignments.TabIndex = 0;
            this.lblNumberAssignments.Text = "Enter Assignment Number (1-X): ";
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(12, 453);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(776, 206);
            this.rtbResults.TabIndex = 5;
            this.rtbResults.Text = "";
            // 
            // btnDisplayScores
            // 
            this.btnDisplayScores.Location = new System.Drawing.Point(573, 86);
            this.btnDisplayScores.Name = "btnDisplayScores";
            this.btnDisplayScores.Size = new System.Drawing.Size(105, 44);
            this.btnDisplayScores.TabIndex = 6;
            this.btnDisplayScores.Text = "Display Scores";
            this.btnDisplayScores.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(130, 133);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(278, 13);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "Please enter a valid number of Students and Assignments";
            this.lblError.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnDisplayScores);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.gbStudentScoreInfo);
            this.Controls.Add(this.gbStudentInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gb_count);
            this.Name = "FormMain";
            this.Text = "Scores";
            this.gb_count.ResumeLayout(false);
            this.gb_count.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.gbStudentScoreInfo.ResumeLayout(false);
            this.gbStudentScoreInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_count;
        private System.Windows.Forms.Label lblNumberOfStudents;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtNumberOfStudents;
        private System.Windows.Forms.Label lblNumberOfAssignments;
        private System.Windows.Forms.Button btnSubmitCounts;
        private System.Windows.Forms.TextBox txtNumberOfAssignments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrevStudent;
        private System.Windows.Forms.Button btnFirstStudent;
        private System.Windows.Forms.Button btnLastStudent;
        private System.Windows.Forms.Button btnNextStudent;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.Button btnSaveName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.GroupBox gbStudentScoreInfo;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Button btnSaveScore;
        private System.Windows.Forms.TextBox txtAssignmentScore;
        private System.Windows.Forms.Label lblAssignmentScore;
        private System.Windows.Forms.TextBox txtAssignmentNumber;
        private System.Windows.Forms.Label lblNumberAssignments;
        private System.Windows.Forms.Button btnDisplayScores;
        private System.Windows.Forms.Label lblError;
    }
}

