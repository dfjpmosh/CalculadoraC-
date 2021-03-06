﻿using System;
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
        Button boton;
        double resultado, numero;
        char opAnt, operador;
        bool bNum1, bOp;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            boton = (Button)sender;

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
                case "8": 
                case "9": escribeNumero(boton.Text); break;
            }
        }

        private void escribeNumero(string numero)
        {
            if(bOp)
            {
                txtDisplay.Text = "";
                bOp = false;
            }

            //TODO Validar que si puede existir un cero, si se escribre otro numero se borrar el cero y se escribe el numero
            if (numero != "0" || txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text += numero;
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            boton = (Button)sender;

            if (!txtDisplay.Text.Contains("."))
            {
                if (txtDisplay.Text.Length == 0)
                {
                    txtDisplay.Text = "0.";
                }
                else
                {
                    if (txtDisplay.Text == "-")
                    {
                        txtDisplay.Text = "-0.";
                    }
                    else
                    {
                        txtDisplay.Text += boton.Text;
                    }
                }                
            }            
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            
            boton = (Button)sender;

            if (!txtDisplay.Text.Contains("-") && txtDisplay.Text.Length == 0)
            {
                txtDisplay.Text += boton.Text;
            }
            else
            {
                if(Double.TryParse(txtDisplay.Text, out numero))
                {
                    escribeCalcula(numero, '-');
                }
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtDisplay.Text, out numero))
            {
                escribeCalcula(numero, '+');
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtDisplay.Text, out numero))
            {
                escribeCalcula(numero, 'x');
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtDisplay.Text, out numero))
            {
                escribeCalcula(numero, '÷');
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtDisplay.Text, out numero))
            {
                escribeCalcula(numero, '=');
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            resultado = numero = 0;
            opAnt = operador = ' ';
            bNum1 = bOp = false;
            txtDisplay.Text = "";
        }

        private void btnLimpiarEntrada_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            bOp = true;
        }

        private void escribeCalcula(double numero, char op)
        {
            opAnt = operador;
            operador = op;
            
            if (resultado == 0 || !bNum1)
            {
                resultado = numero;
                bNum1 = true;
            }
            else
            {
                if (!bOp)
                {
                    switch (opAnt)
                    {
                        case '+':
                            resultado += numero;
                            break;
                        case '-':
                            resultado -= numero;
                            break;
                        case 'x':
                            resultado *= numero;
                            break;
                        case '÷':
                            //TODO Validar la division entre cero
                            resultado /= numero;
                            break;
                    }

                    txtDisplay.Text = resultado.ToString();
                }
            }

            bOp = true;
        }
    }
}
