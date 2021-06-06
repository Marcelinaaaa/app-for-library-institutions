using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_EngineModels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdGO_Click(object sender, EventArgs e)
        {
            txtResponse.Clear();
            RestClient rClient = new RestClient();
            rClient.endPoint = "https://www.googleapis.com/books/v1/volumes?q=" + txtRequestURI10.Text + " &key=AIzaSyBbfq7YoWuFx6IJ3RJv0YNyFAiFcQWC8-Y&maxResults=1";

            //debugOutput("REst Client Created\n");

            string strResponse;

            strResponse = rClient.makeRequest();

            //string aaa = "aaaaaa";
            debugOutput(strResponse);
        }
        //    https://www.googleapis.com/books/v1/volumes?q=J%C4%85drociemno%C5%9Bci+inauthor:Conrad&key=AIzaSyBbfq7YoWuFx6IJ3RJv0YNyFAiFcQWC8-Y&maxResults=2
        //private void debugOutput(string strDebugText)
        //{
        //    try
        //    {
        //        System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
        //        txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
        //        txtResponse.SelectionStart = txtResponse.TextLength;
        //        txtResponse.ScrollToCaret();
        //    }
        //    catch(Exception ex)
        //    {
        //        System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
        //    }
        //}
        private void debugOutput(string strDebugText)
        {
            try
            {
                //System.Diagnostics.Debug.Write(strDebugText);
               // txtResponse.Text =txtResponse.Text + strDebugText;
                txtResponse.Text += String.Format("{0}", strDebugText);
              //  txtResponse.SelectionStart = 0;
                //txtResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void wyszukaj_Click(object sender, EventArgs e)
        {
            txtResponse.Clear();
            RestClient rClient = new RestClient();
            rClient.endPoint = "https://www.googleapis.com/books/v1/volumes?q=" + txtRequestURI10.Text + " &key=AIzaSyBbfq7YoWuFx6IJ3RJv0YNyFAiFcQWC8-Y&maxResults=5";

            //debugOutput("REst Client Created\n");

            string strResponse;

            strResponse = rClient.makeRequest();

            //string aaa = "aaaaaa";
            debugOutput(strResponse);
        }

        private void wyszukaj2_Click(object sender, EventArgs e)
        {
            txtResponse.Clear();
            RestClient rClient = new RestClient();
            rClient.endPoint = "https://www.googleapis.com/books/v1/volumes?q=inauthor:" + txtRequestURI11.Text + "&key=AIzaSyBbfq7YoWuFx6IJ3RJv0YNyFAiFcQWC8-Y&maxResults=5";

            //debugOutput("REst Client Created\n");

            string strResponse;

            strResponse = rClient.makeRequest();

            //string aaa = "aaaaaa";
            debugOutput(strResponse);
        }

        private void wyszukaj3_Click(object sender, EventArgs e)
        {
            txtResponse.Clear();
            RestClient rClient = new RestClient();
            rClient.endPoint = "https://www.googleapis.com/books/v1/volumes?q=intitle:" + txtRequestURI10.Text + "+inauthor:" + txtRequestURI11.Text + "&key=AIzaSyBbfq7YoWuFx6IJ3RJv0YNyFAiFcQWC8-Y&maxResults=1";

            //debugOutput("REst Client Created\n");

            string strResponse;

            strResponse = rClient.makeRequest();

            //string aaa = "aaaaaa";
            debugOutput(strResponse);
        }

        private void buttonglowna4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ObsługaBiblioteki.Form1().Show();
        }

        private void buttonksiazka4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ObsługaBiblioteki.Form2().Show();
        }

        private void buttonautorwydawnictwo4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ObsługaBiblioteki.Form3().Show();
        }

        private void buttonklienci4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ObsługaBiblioteki.Form4().Show();
        }

        private void buttonwyszukiwanie4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ObsługaBiblioteki.Form5().Show();
        }

        private void buttonwyszukiwanie5_Click(object sender, EventArgs e)
        {

        }
    }
}
