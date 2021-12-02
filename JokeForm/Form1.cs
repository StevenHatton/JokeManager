/*
 * Steven Hatton
 * hattonsn@mail.uc.edu
 * IT3045 Final Exam
 * Create a GUI
 * Due December 7th, 2021
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JokeManagerNamespace;

namespace JokeForm
{
    public partial class Form1 : Form
    {
        private String mJoke;
        public String joke { get { return mJoke; } set { mJoke = value; } }
        private String mUsername;
        public String username { get { return mUsername; } set { mUsername = value; } }
        public Form1()
        {
            InitializeComponent();
        }
        private void cmdCheck_Click(object sender, EventArgs e)
        {
            username = txtInput1.Text;
            joke = txtInput2.Text;
            lblResult.Text = sendData().ToString();
        }
        private int sendData()
        {
            int status;
            status = JokeManager.SaveJoke(username, joke);
            return status;
        }
    }
}