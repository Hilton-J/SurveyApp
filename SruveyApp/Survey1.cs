using BLL1;
using System;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using TypeLibrary.Models;

namespace SruveyApp
{
    public partial class Survey1 : Form
    {
        DBHandler db;
        int score = 0;
        int rating1 = 0, rating2 = 0, rating3 = 0, rating4 = 0;
        public Survey1()
        {
            InitializeComponent();
        }

        private void Survey1_Load(object sender, EventArgs e)
        {
            lblFrmResult.ForeColor = Color.Black;
            lblFrmSurvey.ForeColor = Color.Blue;
            lblError.Visible = false;

            // Reset global values
            score = 0;
            rating4 = 0;
            rating1 = 0;
            rating2 = 0;
            rating3 = 0;

            //Reset form
            //Personal Details
            txtContactNum.Text = "";
            txtEmail.Text = "";
            txtFullName.Text = "";
            dtpDOB.Value = DateTime.Now;

            // Favourite food
            cbOther.Checked = false;
            cbPapWors.Checked = false; 
            cbPasta.Checked = false;
            cbPizza.Checked = false;

            // Reset radio button rating
            // Agree
            rb1Agree.Checked = false;
            rb2Agree.Checked = false;
            rb3Agree.Checked = false;
            rb4Agree.Checked = false;

            // Strongly Disagree
            rb1StronglyDisagree.Checked = false;
            rb2StronglyDisagree.Checked = false;
            rb3StronglyDisagree.Checked = false;
            rb4StronglyDisagree.Checked = false;

            // Strongly Agree
            rb1StronglyAgree.Checked = false;
            rb2StronglyAgree.Checked = false;
            rb3StronglyAgree.Checked = false;
            rb4StronglyAgree.Checked = false;

            // Neutral
            rb1Neutral.Checked = false;
            rb2Neutral.Checked = false;
            rb3Neutral.Checked = false;
            rb4Neutral.Checked = false;

            // Disagree
            rb1Disagree.Checked = false;
            rb2Disagree.Checked = false;
            rb3Disagree.Checked = false;
            rb4Disagree.Checked = false;
        }

        private void lblFrmResult_Click(object sender, EventArgs e)
        {
            Results frmResults = new Results();
            frmResults.Show();
            this.Hide();
        }
        #region Watch Movies
        private void rb1StronglyAgree_CheckedChanged(object sender, EventArgs e)
        {
            rating1 = 0;
            rating1 = GetRating(1, rb1StronglyAgree, rb1Agree, rb1Neutral, rb1Disagree, rb1StronglyDisagree);
        }

        private void rb1Agree_CheckedChanged(object sender, EventArgs e)
        {
            rating1 = 0;
            rating1 = GetRating(2, rb1Agree, rb1StronglyAgree, rb1Neutral, rb1Disagree, rb1StronglyDisagree);
        }

        private void rb1Neutral_CheckedChanged(object sender, EventArgs e)
        {
            rating1 = 0;
            rating1 = GetRating(3, rb1Neutral, rb1Agree, rb1StronglyAgree, rb1Disagree, rb1StronglyDisagree);
        }

        private void rb1Disagree_CheckedChanged(object sender, EventArgs e)
        {
            rating1 = 0;
            rating1 = GetRating(4, rb1Disagree, rb1Agree, rb1Neutral, rb1StronglyAgree, rb1StronglyDisagree);
        }

        private void rb1StronglyDisagree_CheckedChanged(object sender, EventArgs e)
        {
            rating1 = 0;
            rating1 = GetRating(5, rb1StronglyDisagree, rb1Agree, rb1Neutral, rb1Disagree, rb1StronglyAgree);
        }
        #endregion Watch Movies
        #region Listen to Radio
        private void rb2StronglyAgree_CheckedChanged(object sender, EventArgs e)
        {
            rating2 = 0;
            rating2 = GetRating(1, rb2StronglyAgree, rb2Agree, rb2Neutral, rb2Disagree, rb2StronglyDisagree);
        }

        private void rb2Agree_CheckedChanged(object sender, EventArgs e)
        {
            rating2 = 0;
            rating2 = GetRating(2, rb2Agree, rb2StronglyAgree, rb2Neutral, rb2Disagree, rb2StronglyDisagree);
        }

        private void rb2Neutral_CheckedChanged(object sender, EventArgs e)
        {
            rating2 = 0;
            rating2 = GetRating(3, rb2Neutral, rb2Agree, rb2StronglyAgree, rb2Disagree, rb2StronglyDisagree);
        }

        private void rb2Disagree_CheckedChanged(object sender, EventArgs e)
        {
            rating2 = 0;
            rating2 = GetRating(4, rb2Disagree, rb2Agree, rb2StronglyAgree, rb2Neutral, rb2StronglyDisagree);
        }

        private void rb2StronglyDisagree_CheckedChanged(object sender, EventArgs e)
        {
            rating2 = 0;
            rating2 = GetRating(5, rb2StronglyDisagree, rb2Agree, rb2Neutral, rb2Disagree, rb2StronglyAgree);
        }
        #endregion Listen to Radio
        #region Eat Out
        private void rb3StronglyAgree_CheckedChanged(object sender, EventArgs e)
        {
            rating3 = 0;
            rating3 = GetRating(1, rb3StronglyAgree, rb3Agree, rb3Neutral, rb3Disagree, rb3StronglyDisagree);
        }

        private void rb3Agree_CheckedChanged(object sender, EventArgs e)
        {
            rating3 = 0;
            rating3 = GetRating(2, rb3Agree, rb3StronglyAgree, rb3Neutral, rb3Disagree, rb3StronglyDisagree);
        }

        private void rb3Neutral_CheckedChanged(object sender, EventArgs e)
        {
            rating3 = 0;
            rating3 = GetRating(3, rb3Neutral, rb3Agree, rb3StronglyAgree, rb3Disagree, rb3StronglyDisagree);
        }

        private void rb3Disagree_CheckedChanged(object sender, EventArgs e)
        {
            rating3 = 0;
            rating3 = GetRating(4, rb3Disagree, rb3Agree, rb3StronglyAgree, rb3Neutral, rb3StronglyDisagree);
        }

        private void rb3StronglyDisagree_CheckedChanged(object sender, EventArgs e)
        {
            rating3 = 0;
            rating3 = GetRating(5, rb3StronglyDisagree, rb3Agree, rb3Neutral, rb3Disagree, rb3StronglyAgree);
        }
        #endregion Eat Out
        #region Watch TV
        private void rb4StronglyAgree_CheckedChanged(object sender, EventArgs e)
        {
            rating4 = 0;
            rating4 = GetRating(1, rb4StronglyAgree, rb4Agree, rb4Neutral, rb4Disagree, rb4StronglyDisagree);
        }

        private void rb4Agree_CheckedChanged(object sender, EventArgs e)
        {
            rating4 = 0;
            rating4 = GetRating(2, rb4Agree, rb4StronglyAgree, rb4Neutral, rb4Disagree, rb4StronglyDisagree);
        }

        private void rb4Neutral_CheckedChanged(object sender, EventArgs e)
        {
            rating4 = 0;
            rating4 = GetRating(3, rb4Neutral, rb4Agree, rb4StronglyAgree, rb4Disagree, rb4StronglyDisagree);
        }

        private void rb4Disagree_CheckedChanged(object sender, EventArgs e)
        {
            rating4 = 0;
            rating4 = GetRating(4, rb4Disagree, rb4Agree, rb4StronglyAgree, rb4Neutral, rb4StronglyDisagree);
        }

        private void rb4StronglyDisagree_CheckedChanged(object sender, EventArgs e)
        {
            rating4 = 0;
            rating4 = GetRating(5, rb4StronglyDisagree, rb4Agree, rb4Neutral, rb4Disagree, rb4StronglyAgree);
        }
        #endregion Watch TV

        // This method stores score of checked and uncheck the other radio button
        private int GetRating(int number, RadioButton rb, RadioButton rb2, RadioButton rb3, RadioButton rb4, RadioButton rb5)
        {
            if (rb.Checked)
            {
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                score = number;
            }
            return score;
        }
        // Method Validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //Calculate age
        private int CalculateAge(DateTime birth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birth.Year;
            if (birth > today.AddYears(-age)) age--;
            return age;
        }

        private void Survey1_FormClosing(object sender, FormClosingEventArgs e)
        {          
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            //Application.Exit();

        }

        // This method changes the label color of a field that has missing information
        private void Error(Label l)
        {
            l.ForeColor = Color.Red;
            l.Font = new Font(l.Font.FontFamily, l.Font.Size, FontStyle.Bold);
            lblError.Visible = true;
            return;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int cbState = GetCheckBox();
                db = new DBHandler();

                // Validate if textbox is empty
                if (txtFullName.Text == string.Empty) Error(lblFullName);
                if (txtEmail.Text == string.Empty) Error(lblEmail);
                if (txtContactNum.Text == string.Empty) Error(lblContactNum);
                if (dtpDOB.Value == DateTime.Now) Error(lblDoB);

                // 
                string fFood = "";
                if ((cbState & 1) != 0) fFood += "Pizza ";
                if ((cbState & 2) != 0) fFood += "Pasta ";
                if ((cbState & 3) != 0) fFood += "Pap and Wors ";
                if ((cbState & 4) != 0) fFood += "Other";
                if (fFood == "") Error(lblFavFood);

                // Email format validation
                string email = txtEmail.Text;
                if (!IsValidEmail(email))
                {
                    Error(lblEmail);
                    MessageBox.Show("Please enter valid email address. e.g. email@email.doimain");
                    return;
                }

                // Validate if rating is s
                if (rating1 == 0)
                {
                    Error(lblMovies);
                }
                if (rating2 == 0)
                {
                    Error(lblRadio);
                }
                if (rating3 == 0)
                {
                    Error(lblEatOut);
                }
                if (rating4 == 0)
                {
                    Error(lblWatchTV);
                }

                DateTime selected = dtpDOB.Value;
                int age = CalculateAge(selected);
                if (age > 120 || age < 5)
                {
                    MessageBox.Show("You're not aligible to take this survey!");
                    return;
                }
                else
                {
                    ParticipantRespons pr = new ParticipantRespons();
                    pr.FullName = txtFullName.Text;
                    pr.Email = txtEmail.Text;
                    pr.DOB = Convert.ToDateTime(dtpDOB.Value);
                    pr.ContactNumber = txtContactNum.Text;
                    pr.Food = fFood;
                    pr.Movies = rating1;
                    pr.Radio = rating2;
                    pr.EatOut = rating3;
                    pr.WatchTV = rating4;

                    db.AddResponse(pr);
                    MessageBox.Show("Survey Submitted!");
                }

            }
            catch
            {

            }
        }
        private int GetCheckBox()
        {
            int state = 0;
            if (cbPizza.Checked) state |= 1;
            if (cbPasta.Checked) state |= 2;
            if (cbPapWors.Checked) state |= 3;
            if (cbOther.Checked) state |= 4;
            return state;
        }
    }
}
