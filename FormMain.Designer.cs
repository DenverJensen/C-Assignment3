
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
            this.lblNumberOfStudents = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumberOfAssignments = new System.Windows.Forms.Label();
            this.txtNumberOfStudents = new System.Windows.Forms.TextBox();
            this.gb_count.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_count
            // 
            this.gb_count.Controls.Add(this.txtNumberOfStudents);
            this.gb_count.Controls.Add(this.lblNumberOfAssignments);
            this.gb_count.Controls.Add(this.lblNumberOfStudents);
            this.gb_count.Location = new System.Drawing.Point(69, 21);
            this.gb_count.Name = "gb_count";
            this.gb_count.Size = new System.Drawing.Size(419, 118);
            this.gb_count.TabIndex = 0;
            this.gb_count.TabStop = false;
            this.gb_count.Text = "Counts";
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
            this.btnReset.Location = new System.Drawing.Point(589, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 51);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset Scores";
            this.btnReset.UseVisualStyleBackColor = true;
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
            // txtNumberOfStudents
            // 
            this.txtNumberOfStudents.Location = new System.Drawing.Point(161, 34);
            this.txtNumberOfStudents.Name = "txtNumberOfStudents";
            this.txtNumberOfStudents.Size = new System.Drawing.Size(70, 20);
            this.txtNumberOfStudents.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gb_count);
            this.Name = "FormMain";
            this.Text = "Scores";
            this.gb_count.ResumeLayout(false);
            this.gb_count.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_count;
        private System.Windows.Forms.Label lblNumberOfStudents;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtNumberOfStudents;
        private System.Windows.Forms.Label lblNumberOfAssignments;
    }
}

