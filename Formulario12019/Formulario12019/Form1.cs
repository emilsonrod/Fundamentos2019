using BibliotecaClases.Manejadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario12019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Brown;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void ChangeColorButton(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void GoBackColor(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }

        private void ChangePointer(object sender, EventArgs e)
        {
            this.button1.Cursor = Cursors.Help;
        }

        private void CHangeText(object sender, EventArgs e)
        {
            string newText = textBox1.Text;
            this.Text = newText;
            ManejadorCadenas manejador = new ManejadorCadenas();

            listBox1.Items.Add(manejador.CambiarCaracteres(newText, 'a', '/'));
            
        }
    }
}
