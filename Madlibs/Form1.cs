using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madlibs
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void madliblogo_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void madlibsLogo_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label13_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string[] entry = new string[6];
			entry[0] = name.Text;
			entry[1] = partofthebody.Text;
			entry[2] = typeoffluid.Text;
			entry[3] = substance.Text;
			entry[4] = signedby.Text;
			entry[5] = date.Text; 

			string output = "Date: " + (entry[5]) + Environment.NewLine + "Name: " + (entry[0]) + Environment.NewLine
				+ "Part of the body: " + (entry[1]) + Environment.NewLine
				+ "Type of Fluid: " + (entry[2]) + Environment.NewLine
				+ "Substance: " + (entry[3]) + Environment.NewLine
				+ "Signed by: " + (entry[4]) + Environment.NewLine;

			MessageBox.Show(output);
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2(); 
			this.Hide();
			form2.Show();
		}
	}
}
