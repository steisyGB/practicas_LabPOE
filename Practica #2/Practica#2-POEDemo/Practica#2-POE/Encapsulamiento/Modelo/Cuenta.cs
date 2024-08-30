using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_POE.Encapsulamiento.Modelo
{
	public class Cuenta
	{
		private double saldo;

		public double Saldo
		{
			get { return saldo; }
			set { saldo = value; }
		}

		public void Depositar(double monto)
		{
			Saldo += monto;
			MessageBox.Show("Deposito realizado con éxito.");
		}

		private void Retirar(double monto)
		{
			if (monto <= Saldo)
			{
				Saldo -= monto;
				MessageBox.Show("Retiro realizado con éxito.");
			}
			else
			{
				MessageBox.Show("Saldo insuficiente.");
			}
		}

		public void RealizarDeposito(double monto)
		{
			Depositar(monto);
		}

		public void RealizarRetiro(double monto)
		{
			Retirar(monto);
		}

		public void SaldoActual()
		{
			MessageBox.Show($"Su saldo actual es de {saldo}");
		}
	}
}
