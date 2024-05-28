using BLL1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeLibrary.ViewModels;

namespace SruveyApp
{
    public partial class Results : Form
    {
        DBHandler db;
        private Survey1 frmSurvey;
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            frmSurvey = new Survey1();
            frmSurvey.Hide();

            db = new DBHandler();
            lblFrmSurvey.ForeColor = Color.Black;
            lblFrmResult.ForeColor = Color.Blue;

            List<GetResponses> res = db.GetData();

            foreach (GetResponses item in res)
            {
                lblSurveys.Text = item.TotalSurvey.ToString();
                lblAverage.Text = item.Average.ToString();
                lblOldest.Text = item.Oldest.ToString();
                lblYoungest.Text = item.Youngest.ToString();

                lblPizza.Text = item.Pizza.ToString();
                lblPasta.Text = item.Pasta.ToString();
                lblPapWors.Text = item.PapWors.ToString();


                lblEatOut.Text = item.EatOut.ToString();
                lblMovie.Text = item.Movies.ToString();
                lblRadio.Text = item.Radio.ToString();
                lblWatchTV.Text = item.WatchTV.ToString(); 
            }
        }

        private void lblFrmSurvey_Click(object sender, EventArgs e)
        {
            frmSurvey = new Survey1();
            frmSurvey.Show();
            this.Hide();
        }

        private void Results_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
