using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
			string op = " ";
			double var1 = 0;
			
		void Button7Click(object sender, EventArgs e)
		{
			textBox1.Text += "1";
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			textBox1.Text += "2";
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			textBox1.Text += "3";			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			textBox1.Text += "4";
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			textBox1.Text += "5";			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			textBox1.Text += "6";			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			textBox1.Text += "7";			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text += "8";			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text += "9";			
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			if (textBox1.Text!="0" && textBox1.Text!="") textBox1.Text += "0";
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			var1=Convert.ToDouble(textBox1.Text);
			textBox1.Text = "";
			op="+";
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			var1=Convert.ToDouble(textBox1.Text);
			textBox1.Text = "";
			op="-";		
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			var1=Convert.ToDouble(textBox1.Text);
			textBox1.Text = "";
			op="*";			
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			var1=Convert.ToDouble(textBox1.Text);
			textBox1.Text = "";
			op="/";			
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			textBox1.Text = (Math.Sqrt(Convert.ToDouble(textBox1.Text))).ToString(); 
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			switch(op)
			{
				case "+": textBox1.Text = (var1+Convert.ToDouble(textBox1.Text)).ToString(); break;
				case "-": textBox1.Text = (var1-Convert.ToDouble(textBox1.Text)).ToString(); break;
				case "*": textBox1.Text = (var1*Convert.ToDouble(textBox1.Text)).ToString(); break;
				case "/": textBox1.Text = (var1/Convert.ToDouble(textBox1.Text)).ToString(); break;				
				
			}
		}
		
		void Button17Click(object sender, EventArgs e)
		{
			var1=0;
			textBox1.Text = "";			
		}
	}
}
