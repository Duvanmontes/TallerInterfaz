using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerInterfazz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String Sexo;

        int Edad = 0;
        int Pulsaciones;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            int n = DataGridPersona.Rows.Add();

            DataGridPersona.Rows[n].Cells[0].Value = TxtNombre.Text;
            DataGridPersona.Rows[n].Cells[1].Value = TxtCedula.Text;
            DataGridPersona.Rows[n].Cells[2].Value = TxtGenero.Text;
            DataGridPersona.Rows[n].Cells[3].Value = TxtEdad.Text;

            if (TxtGenero.Text == "m")
            {
                Edad = int.Parse(TxtEdad.Text);
                Pulsaciones = (220 - Edad) / 10;
                DataGridPersona.Rows[n].Cells[2].Value = "Masculino";
            }



            if (TxtGenero.Text == "f")
            {
                Edad = int.Parse(TxtEdad.Text);
                Pulsaciones = (210 - Edad) / 10;
                DataGridPersona.Rows[n].Cells[2].Value = "Femenino";
            }

            DataGridPersona.Rows[n].Cells[4].Value = Pulsaciones.ToString();

            TxtNombre.Text = "";
            TxtCedula.Text = "";
            TxtGenero.Text = "";
            TxtEdad.Text = "";


        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                DataGridPersona.Rows.RemoveAt(n);
            }
        }

        int n;
        private void DataGridPersona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
        }

        private void TxtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
