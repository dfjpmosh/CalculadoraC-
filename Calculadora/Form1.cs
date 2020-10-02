using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            switch(boton.Text)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "9":
                case "8":
                    if (boton.Text != "0" || txtDisplay.Text.Length > 0)
                    {
                        txtDisplay.Text += boton.Text;
                    }
                    break;
                case ".":
                    if (!txtDisplay.Text.Contains("."))
                        if (txtDisplay.Text.Length == 0)
                        {
                            txtDisplay.Text = "0.";
                        }
                        else
                        {
                            txtDisplay.Text += boton.Text;
                        }
                    break;
            }
        }
    }
}
