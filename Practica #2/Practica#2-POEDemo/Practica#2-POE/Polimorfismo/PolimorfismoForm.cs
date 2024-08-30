using Practica_2_POE.Polimorfismo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_POE.Polimorfismo
{
	public partial class PolimorfismoForm : Form
	{
		private List<Computadora> computadores;

		public PolimorfismoForm()
		{
			InitializeComponent();
			computadores = new List<Computadora>
			{
				new Computadora(),
				new ComputadoraPortatil(),
				new ComputadoraEscritorio()
			};
		}

		private void EncenderButton_Click(object sender, EventArgs e)
		{
			foreach (Computadora computadora in computadores)
			{
				computadora.Encender();
			}
		}
	}
}
