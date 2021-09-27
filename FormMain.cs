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
        #region attributes
        /// <summary>
        ///  Current selected student index. started at 1 to default to first student on the form
        /// </summary>
        public int studentIndex = 1;

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

        #region constructor
        public FormMain()
        {
            InitializeComponent();
        }
        #endregion

        #region methods
        /// <summary>
        /// submit student and assignment inputs and initialize components if input is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                lblNumberAssignments.Text = "Enter Assignment Number (1-" + numAssignments + "): ";

                //initialize student array
                students = new string[numStudents];

                //add blank students to list with placeholder
                for (int i = 0; i < students.Length; i++)
                {
                    students[i] = "Student #" + (i + 1);

                }

                //initialize new grades array
                grades = new int[numStudents, numAssignments];

                //default all scores to 0
                for (int i = 0; i < numStudents; i++)
                {
                    for (int j = 0; j < numAssignments; j++)
                    {
                        grades[i, j] = 0;

                    }
                }
                putResults();
            }
        }

        /// <summary>
        /// Update result textbox with formatted results from student and grade arrays
        /// </summary>
        private void putResults()
        {
            if (students.Length < 1)
            {
                rtbResults.Text = "Enter a number of students and assignments above";
            }
            else
            {

                string headers = "Student" + "\t"; // column headers for output

                for (int i = 0; i < grades.GetLength(1); i++)
                {
                    headers = headers + "\t" + "#" + (i + 1);
                }


                rtbResults.Text = headers;


                for (int i = 0; i < grades.GetLength(0); i++)
                {
                    rtbResults.Text = rtbResults.Text += "\n" + students[i].ToString() + ": ";
                    for (int j = 0; j < grades.GetLength(1); j++)
                    {
                        rtbResults.Text += "\t" + grades[i, j].ToString();
                    }
                }
            }
        }

        /// <summary>
        /// save new name for student at the given student index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveName_Click(object sender, EventArgs e)
        {
            students[studentIndex - 1] = txtStudentName.Text;
            lblStudentName.Text = txtStudentName.Text + ": ";
            txtStudentName.Text = "";
            putResults();
        }

        /// <summary>
        /// update the current student index to go to the next student in the students array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextStudent_Click(object sender, EventArgs e)
        {
            if (studentIndex != students.Length)
            {
                studentIndex = studentIndex + 1;
                lblStudentName.Text = students[studentIndex - 1].ToString();
            }
        }
        /// <summary>
        /// update the current student index to go to the previous student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevStudent_Click(object sender, EventArgs e)
        {
            if (studentIndex != 1)
            {
                studentIndex = studentIndex - 1;
                lblStudentName.Text = students[studentIndex - 1].ToString();
            }
        }

        /// <summary>
        /// update the current student index to be the first student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirstStudent_Click(object sender, EventArgs e)
        {
            studentIndex = 1;
            lblStudentName.Text = students[studentIndex - 1].ToString();
        }

        /// <summary>
        /// update the current student index to be the last student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLastStudent_Click(object sender, EventArgs e)
        {
            studentIndex = students.Length;
            lblStudentName.Text = students[studentIndex - 1].ToString();
        }
        #endregion

        /// <summary>
        /// save the score for a given assignment for the selected student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            int assignmentNumber; //The current number of assignments 
            int score; //The current number of students 
            if ((!Int32.TryParse(txtAssignmentScore.Text, out score)) || (!Int32.TryParse(txtAssignmentNumber.Text, out assignmentNumber)))
            {
                lblError2.Visible = true;
            }
            else if ((score > 100 || score < 1) || (assignmentNumber > grades.GetLength(1)))
            {
                lblError2.Visible = true;
            }
            else
            {
                lblError2.Visible = false;
                grades[(studentIndex - 1), (assignmentNumber - 1)] = score;
                putResults();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            students = new string[0];
            grades = new int[0, 0];
            putResults();

        }
    }
}
