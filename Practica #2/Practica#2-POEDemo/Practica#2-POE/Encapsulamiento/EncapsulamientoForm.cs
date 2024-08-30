using Practica_2_POE.Encapsulamiento.Modelo;
using Practica_2_POE.Herencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_POE.Encapsulamiento
{
	public partial class EncapsulamientoForm : Form
	{
		Cuenta cuenta = new Cuenta();

		public EncapsulamientoForm()
		{
			InitializeComponent();
		}

		private void EncapsulamientoForm_Load(object sender, EventArgs e)
		{

		}

		private void DepositarButton_Click(object sender, EventArgs e)
		{
			cuenta.RealizarDeposito(double.Parse(MontoTextBox.Text));
			Limpiar();

		}

		private void RetirarButton_Click(object sender, EventArgs e)
		{
			cuenta.RealizarRetiro(double.Parse(MontoTextBox.Text));
			Limpiar();
		}

		private void SaldoButton_Click(object sender, EventArgs e)
		{
			cuenta.SaldoActual();
		}

		public void Limpiar()
		{
			MontoTextBox.Clear();
		}
	}
}
