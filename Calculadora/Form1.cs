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
        Button boton;

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
            if (numero != "0" || txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text += numero;
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            boton = (Button)sender;

            if (!txtDisplay.Text.Contains(".") && txtDisplay.Text.Length == 0)
            {
                txtDisplay.Text = "0.";
                //TODO: Validar con signo -
            }
            else
            {
                txtDisplay.Text += boton.Text;
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
                MessageBox.Show("Operación Resta");
                //TODO: Validar que no intente operación o converción si sólo es el signo -
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación Suma");
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación Multiplicación");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación División");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resultado");
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Retroceder");
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Borrar Todo");            
        }

        private void btnLimpiarEntrada_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Borrar Entrada");
        }
    }
}
