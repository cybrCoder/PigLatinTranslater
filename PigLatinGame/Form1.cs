using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinGame
{
    public partial class Form1 : Form
    {
        Translate tran = new Translate();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            AutoSize = false;
            Size = new Size(325, 283);
            lblResult.AutoSize = false;
            lblResult.ForeColor = Color.Black;
            lblResult.Text = "";
            string temp = txtEnglish.Text;

            if(Regex.IsMatch(temp, @"^[a-zA-Z]+$"))
            {
                lblResult.Text = tran.GetResult(temp.ToLower());
            }
            else
            {
                AutoSize = true;
                lblResult.AutoSize = true;
                string temp2 = "The textbox must contain only one word, no letters, or blank spaces!";
                lblResult.ForeColor = Color.Red;
                lblResult.Text = temp2;
            }
        }
    }
}
