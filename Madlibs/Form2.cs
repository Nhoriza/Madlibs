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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string[] entry = new string[5];
			entry[0] = name.Text;
			entry[1] = adjective.Text;
			entry[2] = noun.Text;
			entry[3] = signedby.Text;
			entry[4] = date.Text;

			string output = "Date: " + (entry[4]) + Environment.NewLine + "Name: " + (entry[0]) + Environment.NewLine
				+ "Adjecive: " + (entry[1]) + Environment.NewLine
				+ "Noun: " + (entry[2]) + Environment.NewLine
				+ "Signed by: " + (entry[3]) + Environment.NewLine;

			MessageBox.Show(output);
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			this.Hide();
			form1.Show();
		}
	}
}
