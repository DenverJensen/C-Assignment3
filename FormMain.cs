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
        public string[] students = new string[0];

        /// <summary>
        ///  multi dimensional array for students grades
        /// </summary>
        public int[,] grades = new int[0, 0];

        /// <summary>
        /// array of strings to hold the letter grade for each student
        /// </summary>
        public string[] letters = new string[0];

        /// <summary>
        /// array to hold the average score for each student
        /// </summary>
        public double[] averages = new double[0];

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
            else if ((numStudents > 10 || numStudents < 1) || (numAssignments > 99 || numAssignments < 1))
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
                averages = new double[numStudents];
                letters = new string[numStudents];

                //add blank students to list with placeholder
                for (int i = 0; i < students.Length; i++)
                {
                    students[i] = "Student #" + (i + 1);
                    letters[i] = "F";

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
                string headers = "Student" + "\t";
                for (int i = 0; i < grades.GetLength(1); i++)
                {
                    headers = headers + "\t" + "#" + (i + 1);
                }

                headers += "\t" + "AVG" + "\t" + "Grade";

                rtbResults.Text = headers;

                for (int i = 0; i < grades.GetLength(0); i++)
                {
                    rtbResults.Text = rtbResults.Text += "\n" + students[i].ToString() + ": ";
                    for (int j = 0; j < grades.GetLength(1); j++)
                    {
                        rtbResults.Text += "\t" + grades[i, j].ToString();
                    }
                    rtbResults.Text += "\t" + averages[i].ToString();
                    rtbResults.Text += "\t" + letters[i].ToString() + "\t" + "";
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
            if (students.Length > 0)
            {
                students[studentIndex - 1] = txtStudentName.Text;
                lblStudentName.Text = txtStudentName.Text + ": ";
                txtStudentName.Text = "";
                putResults();
            }
        }

        /// <summary>
        /// update the current student index to go to the next student in the students array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextStudent_Click(object sender, EventArgs e)
        {
            if (students.Length > 0)
            {
                if (studentIndex != students.Length)
                {
                    studentIndex = studentIndex + 1;
                    lblStudentName.Text = students[studentIndex - 1].ToString();
                }
            }
        }
        /// <summary>
        /// update the current student index to go to the previous student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevStudent_Click(object sender, EventArgs e)
        {
            if (students.Length > 0)
            {
                if (studentIndex != 1)
                {
                    studentIndex = studentIndex - 1;
                    lblStudentName.Text = students[studentIndex - 1].ToString();
                }
            }

        }

        /// <summary>
        /// update the current student index to be the first student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirstStudent_Click(object sender, EventArgs e)
        {
            if (students.Length > 0)
            {
                studentIndex = 1;
                lblStudentName.Text = students[studentIndex - 1].ToString();
            }
        }

        /// <summary>
        /// update the current student index to be the last student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLastStudent_Click(object sender, EventArgs e)
        {
            if (students.Length > 0)
            {
                studentIndex = students.Length;
                lblStudentName.Text = students[studentIndex - 1].ToString();
            }

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
                // if valid, update score
                lblError2.Visible = false;
                grades[(studentIndex - 1), (assignmentNumber - 1)] = score;
                updateGrades();
                putResults();
            }
        }

        /// <summary>
        /// method to update averages and letter grades
        /// </summary>
        private void updateGrades()
        {
            //update averages and letter grades
            double total = 0;//total aggregate score
            for (int i = 0; i < grades.GetLength(0); i++)
            {
                if (i == (studentIndex - 1))
                {
                    for (int j = 0; j < grades.GetLength(1); j++)
                    {
                        total += grades[i, j];
                    }
                    averages[i] = (total / grades.GetLength(1));
                }
            }

            // loop thru averages to create letter grades for each student with cascading if statement
            for (int i = 0; i < averages.Length; i++)
            {
                //students[i] = "Student #" + (i + 1);
                //letters[i] = "F";
                if (averages[i] > 93)
                {
                    letters[i] = "A";
                }
                else if (averages[i] > 90)
                {
                    letters[i] = "A-";
                }
                else if (averages[i] > 87)
                {
                    letters[i] = "B+";
                }
                else if (averages[i] > 83)
                {
                    letters[i] = "B";
                }
                else if (averages[i] > 80)
                {
                    letters[i] = "B-";
                }
                else if (averages[i] > 77)
                {
                    letters[i] = "C+";
                }
                else if (averages[i] > 73)
                {
                    letters[i] = "C";
                }
                else if (averages[i] > 70)
                {
                    letters[i] = "C-";
                }
                else if (averages[i] > 67)
                {
                    letters[i] = "D+";
                }
                else if (averages[i] > 63)
                {
                    letters[i] = "D";
                }
                else if (averages[i] > 60)
                {
                    letters[i] = "D-";
                }
                else
                {
                    letters[i] = "E";
                }

            }
        }

        /// <summary>
        /// reset all student data and return form to starting position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            students = new string[0];
            grades = new int[0, 0];
            putResults();
            lblStudentName.Text = "Student #1:";
            lblNumberAssignments.Text = "Enter Assignment Number (1-X):";
            txtNumberOfStudents.Text = "";
            txtNumberOfAssignments.Text = "";
            txtStudentName.Text = "";
            txtAssignmentNumber.Text = "";
            txtAssignmentScore.Text = "";
            lblError.Text = "";
            lblError2.Text = "";
        }
    }
}
