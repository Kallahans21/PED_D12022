﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafío1
{
    public partial class Archivo : Form
    {
        
        ArbolPacientes arbol = new ArbolPacientes();
        Graphics area;



        public Archivo()
        {
            InitializeComponent();
            area = CreateGraphics();
        }

        private void nPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void pGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sangre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void npresion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

private void btnSalir_Click(object sender, EventArgs e)
{
    Application.Exit();
}

private void archivo_Load(object sender, EventArgs e)
{

}

private void archivo_Paint(object sender, PaintEventArgs e)
{

}

public void limpiar()
{
    nPaciente.Text = "";
    pGenero.Text = "";
    Sangre.Text = "";
    npresion.Text = "";

}
string Paciente;
        public int i = 0;


        public void DrawString()
        {
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            string drawString = Paciente;
            System.Drawing.Font drawFont = new System.Drawing.Font("Consolas", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            float x = 100.0F;
            float y = 200.0F;

            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            formGraphics.DrawString("Pacientes", drawFont, drawBrush, 400, x, drawFormat);
            formGraphics.DrawString("Genero", drawFont, drawBrush, 100, y, drawFormat);
            formGraphics.DrawLine(Pens.Black, 450, 125, 150, 200);
            formGraphics.DrawLine(Pens.Black, 450, 125, 450, 200);
            formGraphics.DrawLine(Pens.Black, 450, 125, 740, 200);
            formGraphics.DrawString("Tipo de  \n Sangre", drawFont, drawBrush, 400, y, drawFormat);
            formGraphics.DrawString("presion", drawFont, drawBrush, 700, y, drawFormat);

            float y2 = 300.0F;
            string genero = pGenero.Text;
            formGraphics.DrawString("Hombre", drawFont, drawBrush, 25, y2, drawFormat);
            formGraphics.DrawString("Mujer", drawFont, drawBrush, 150, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 70, 300, 130, 225);
                   formGraphics.DrawLine(Pens.Black, 180, 300, 140, 225);


            float y3 = 400.0F;
            Paciente = nPaciente.Text;
            if (pGenero.Text != "Mujer")
            {
                formGraphics.DrawLine(Pens.Black, 70, y3, 70, 325);
                formGraphics.DrawString(Paciente, drawFont, drawBrush, 25, y3, drawFormat);
            }
            else
            {
               
                formGraphics.DrawLine(Pens.Black, 180, y3, 180, 325);
                formGraphics.DrawString(Paciente, drawFont, drawBrush, 160, y3, drawFormat);
            }


            formGraphics.DrawString("A", drawFont, drawBrush, 250, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 450, 250, 260, y2);
            formGraphics.DrawString("B", drawFont, drawBrush, 350, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 450, 250, 360, y2);
            formGraphics.DrawString("AB", drawFont, drawBrush, 450, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 450, 250, 460, y2);
            formGraphics.DrawString("O", drawFont, drawBrush, 550, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 450, 250, 560, y2);


            formGraphics.DrawString("Alta", drawFont, drawBrush, 625, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 650, y2, 740, 225);
            formGraphics.DrawString("Media", drawFont, drawBrush, 725, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 750, y2, 740, 225);
            formGraphics.DrawString("Baja", drawFont, drawBrush, 825, y2, drawFormat);
            formGraphics.DrawLine(Pens.Black, 850, y2, 740, 225);

            if (Sangre.Text == "A")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 250, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 260, y3, 260, 325); }
            else if (Sangre.Text == "B")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 350, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 360, y3, 360, 325); }
            else if (Sangre.Text == "AB")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 450, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 460, y3, 460, 325); }
            else if (Sangre.Text == "O")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 550, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 560, y3, 560, 325); }


            if (npresion.Text == "Alta")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 650, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 650, y3, 650, 325); }
            else if (npresion.Text == "Baja")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 850, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 850, y3, 850, 325); }
            else if (npresion.Text == "Media")
            { formGraphics.DrawString(Paciente, drawFont, drawBrush, 750, y3, drawFormat); formGraphics.DrawLine(Pens.Black, 750, y3, 750, 325); }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nPaciente.Text == " " || pGenero.Text == "" || Sangre.Text == "" || npresion.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los datos.");
            }

            else
            {

                MessageBox.Show("Se ha registrado correctamente el paciente.", "Registro exitoso" );
                Nodo r;

                r = arbol.MostrarArbol(nPaciente.Text, Sangre.Text, pGenero.Text, npresion.Text);
                arbol.TransversaPreO(r);


            }
        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            area.Clear(Color.DeepSkyBlue);
            limpiar();
        }

        private void Dibujarbtn_Click(object sender, EventArgs e)
        {
            DrawString();
        }
    }

}

