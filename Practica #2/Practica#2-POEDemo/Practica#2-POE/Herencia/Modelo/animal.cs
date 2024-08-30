using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_POE.Herencia.modelos
{
	public class Animal
	{
		public string Nombre { get; set; }
		public int Edad { get; set; }

		public void Comer()
		{
			MessageBox.Show($"{Nombre} de {Edad} años está comiendo.");
		}
	}

	public class Perro : Animal
	{
		public string Color { get; set; }

		public void Ladrar()
		{
			MessageBox.Show($"El perro {Nombre} de color {Color} está ladrando.");
		}
	}
}
