using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_and_Else_instrucions_using_WFA_instead_of_WPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Almost a copy paste from previous task, with trying to notice diffrences between WFA and WPF

        private void button1_Click(object sender, EventArgs e)
        {
            if (myCheckBox.Checked == true)
            {
                if (myLabel.Text == "Z prawej")
                {
                    myLabel.Text = "Z lewej";
                    myLabel.TextAlign = ContentAlignment.MiddleLeft; //We use ContentAligment to set location of label
                }
                else
                {
                    myLabel.Text = "Z prawej";
                    myLabel.TextAlign = ContentAlignment.MiddleRight; 
                }
            }
            else
            {
                myLabel.Text = "Możliwość zmiany tekstu została wyłączona";
                myLabel.TextAlign = ContentAlignment.MiddleCenter;
            }
            }
        }
    }

