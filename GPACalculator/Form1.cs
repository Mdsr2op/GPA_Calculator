using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPACalculator
{
    public partial class Form1 : Form
    {
        private List<TextBox> gpaTextBoxes = new List<TextBox>();
        private List<TextBox> creditHoursTextBoxes = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnGenerateSemesters_Click(object sender, EventArgs e)
        {
            pnlSemesters.Controls.Clear();
            gpaTextBoxes.Clear();
            creditHoursTextBoxes.Clear();

            int semesterCount = (int)numSemesters.Value;

            for (int i = 0; i < semesterCount; i++)
            {
                Label lblSemester = new Label();
                lblSemester.Text = string.Format("Semester {0}", i + 1);
                lblSemester.Location = new Point(10, 10 + i * 60);
                lblSemester.AutoSize = true;
                lblSemester.Font = new Font(lblSemester.Font, FontStyle.Bold);
                pnlSemesters.Controls.Add(lblSemester);

                Label lblGPA = new Label();
                lblGPA.Text = "GPA:";
                lblGPA.Location = new Point(20, 35 + i * 60);
                lblGPA.AutoSize = true;
                pnlSemesters.Controls.Add(lblGPA);

                TextBox txtGPA = new TextBox();
                txtGPA.Location = new Point(60, 32 + i * 60);
                txtGPA.Size = new Size(60, 20);
                txtGPA.Name = string.Format("txtGPA{0}", i);
                txtGPA.Tag = i;
                gpaTextBoxes.Add(txtGPA);
                pnlSemesters.Controls.Add(txtGPA);

                Label lblCreditHours = new Label();
                lblCreditHours.Text = "Credit Hours:";
                lblCreditHours.Location = new Point(160, 35 + i * 60);
                lblCreditHours.AutoSize = true;
                pnlSemesters.Controls.Add(lblCreditHours);

                TextBox txtCreditHours = new TextBox();
                txtCreditHours.Location = new Point(240, 32 + i * 60);
                txtCreditHours.Size = new Size(60, 20);
                txtCreditHours.Name = string.Format("txtCreditHours{0}", i);
                txtCreditHours.Tag = i;
                creditHoursTextBoxes.Add(txtCreditHours);
                pnlSemesters.Controls.Add(txtCreditHours);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (gpaTextBoxes.Count == 0)
            {
                MessageBox.Show("Please generate semester input fields first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalWeightedGPA = 0;
            double totalCreditHours = 0;

            for (int i = 0; i < gpaTextBoxes.Count; i++)
            {
                double semesterGPA;
                int creditHours;

                if (!double.TryParse(gpaTextBoxes[i].Text, out semesterGPA))
                {
                    MessageBox.Show(string.Format("Invalid GPA for Semester {0}. Please enter a valid number.", i + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gpaTextBoxes[i].Focus();
                    return;
                }

                if (semesterGPA < 0 || semesterGPA > 4.0)
                {
                    MessageBox.Show(string.Format("GPA for Semester {0} must be between 0.00 and 4.00.", i + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gpaTextBoxes[i].Focus();
                    return;
                }

                if (!int.TryParse(creditHoursTextBoxes[i].Text, out creditHours))
                {
                    MessageBox.Show(string.Format("Invalid Credit Hours for Semester {0}. Please enter a valid number.", i + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    creditHoursTextBoxes[i].Focus();
                    return;
                }

                if (creditHours < 1 || creditHours > 30)
                {
                    MessageBox.Show(string.Format("Credit Hours for Semester {0} must be between 1 and 30.", i + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    creditHoursTextBoxes[i].Focus();
                    return;
                }

                totalWeightedGPA += semesterGPA * creditHours;
                totalCreditHours += creditHours;
            }

            double cgpa = totalWeightedGPA / totalCreditHours;
            lblResult.Text = string.Format("Your CGPA: {0:F2}", cgpa);
            lblResult.ForeColor = Color.Green;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            numSemesters.Value = 1;
            pnlSemesters.Controls.Clear();
            gpaTextBoxes.Clear();
            creditHoursTextBoxes.Clear();
            lblResult.Text = "Your CGPA: 0.00";
            lblResult.ForeColor = Color.Black;
        }
    }
}
