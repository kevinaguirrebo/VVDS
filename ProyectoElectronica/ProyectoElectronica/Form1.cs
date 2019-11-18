using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoElectronica
{
	public partial class Form1 : Form
	{
		private int sala1 = 0;
		private int cocina = 0;
		private int sala2 = 0;
		private int fachada = 0;

		System.IO.Ports.SerialPort arduino;
		public Form1()
		{
			InitializeComponent();
			arduino = new System.IO.Ports.SerialPort();
			arduino.PortName = "COM4";
			arduino.BaudRate = 9600;
			arduino.Open();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (arduino.IsOpen) arduino.Close();
		}

		private void Btn_Sala1_Click(object sender, EventArgs e)
		{
			if(sala1 == 0)
			{
				arduino.Write("a");
				sala1 = 1;
			}
			else
			{
				arduino.Write("b");
				sala1 = 0;
			}
		}

		private void Btn_Cocina_Click(object sender, EventArgs e)
		{
			if (cocina == 0)
			{
				arduino.Write("c");
				cocina = 1;
			}
			else
			{
				arduino.Write("d");
				cocina = 0;
			}
		}

		private void Btn_Sala2_Click(object sender, EventArgs e)
		{
			if (sala2 == 0)
			{
				arduino.Write("e");
				sala2 = 1;
			}
			else
			{
				arduino.Write("f");
				sala2 = 0;
			}
		}

		private void Btn_Fachada_Click(object sender, EventArgs e)
		{
			if (fachada == 0)
			{
				arduino.Write("g");
				fachada = 1;
			}
			else
			{
				arduino.Write("h");
				fachada = 0;
			}
		}
	}
}
