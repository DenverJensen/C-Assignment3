using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class FormMain : Form
    {
        #region
        /// <summary>
        ///  Current selected student index
        /// </summary>
        public int studentIndex = 1;

        /// <summary>
        /// number of students entered in form
        /// </summary>
        public int numberOfStudents;

        /// <summary>
        /// array of students
        /// </summary>
        //public Array students;
        public string[] students;

        /// <summary>
        ///  multi dimensional array for students grades
        /// </summary>
        public int[,] grades;




        #endregion
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnSubmitCounts_Click(object sender, EventArgs e)
        {
            int numAssignments; //The current number of assignments 
            int numStudents; //The current number of students 
            if ((!Int32.TryParse(txtNumberOfStudents.Text, out numStudents)) || (!Int32.TryParse(txtNumberOfAssignments.Text, out numAssignments)))
            {
                lblError.Visible = true;
            }
            else if ((numStudents > 9 || numStudents < 1) || (numAssignments > 99 || numAssignments < 1))
            {
                lblError.Visible = true;
            }
            else
            {
                //clear errors and create arrays
                lblError.Visible = false;
                rtbResults.Text = "";

                //initialize student array
                students = new string[numStudents];

                //add blank students to list with placeholder
                for (int i = 0; i < students.Length; i++)
                {
                    students[i] = "Student #" + (i + 1);

                }
                putResults();
            }
        }

        private void putResults()
        {
            rtbResults.Text = "";
            for (int i = 0; i < students.Length; i++)
            {
                rtbResults.Text = rtbResults.Text += "\n" + students[i].ToString() + ": ";
            }
        }

        private void btnSaveName_Click(object sender, EventArgs e)
        {
            students[studentIndex - 1] = txtStudentName.Text;
            lblStudentName.Text = txtStudentName.Text + ": ";
            txtStudentName.Text = "";
            putResults();
        }

        private void btnNextStudent_Click(object sender, EventArgs e)
        {
            if (studentIndex != students.Length)
            {
                studentIndex = studentIndex + 1;
                lblStudentName.Text = students[studentIndex - 1].ToString();
            }
        }

        private void btnPrevStudent_Click(object sender, EventArgs e)
        {
            if(studentIndex != 1)
            {
            studentIndex = studentIndex - 1;
            lblStudentName.Text = students[studentIndex - 1].ToString();
            }
        }

        private void btnFirstStudent_Click(object sender, EventArgs e)
        {
            studentIndex = 1;
            lblStudentName.Text = students[studentIndex - 1].ToString();
        }

        private void btnLastStudent_Click(object sender, EventArgs e)
        {
            studentIndex = students.Length;
            lblStudentName.Text = students[studentIndex - 1].ToString();
        }
    }
}
