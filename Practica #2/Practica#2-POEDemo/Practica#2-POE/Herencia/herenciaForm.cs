using Practica_2_POE.Herencia.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_POE.Herencia
{
	public partial class herenciaForm : Form
	{
		Perro miPerro = new Perro();

		public herenciaForm()
		{
			InitializeComponent();
		}

		private void CrearButton_Click(object sender, EventArgs e)
		{
			miPerro.Nombre = NombreTextBox.Text;
			miPerro.Edad = int.Parse(EdadTextBox.Text);
			miPerro.Color = ColorTextBox.Text;
			comerButton.Enabled = true;
			LadrarButton.Enabled = true;
		}

		private void comerButton_Click(object sender, EventArgs e)
		{
			miPerro.Comer();
		}

		private void LadrarButton_Click(object sender, EventArgs e)
		{
			miPerro.Ladrar();
		}

		private void herenciaForm_Load(object sender, EventArgs e)
		{

		}
	}
}
