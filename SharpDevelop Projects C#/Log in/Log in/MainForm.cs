using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Log_in
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string username,password;
			int count;

            username = txtuser.Text;
            password = txtpass.Text;

            count = count + 1;

            if (count > 3)
            {
                MessageBox.Show("System has been blocked................................");
                Application.Exit();
            }

            if (username == "" && password == "" )
            {
                label3.Text = "Blank not be allowed";
            }
            
            else if (username.Length >= 10 && password.Length >= 10)
            {
                label3.Text = "10 charactor only allowed";
            }
            else


            if( username == "DT" && password == "danbly")
            {
                //label4.Text = "Login Successfully";

               /* progrbar1 pr = new progrbar1();
                this.Hide();
                pr.Show();
                    
                /*  Ex. progrbar1 pr = new progrbar1();
                this.Hide();
                pr.Show();*/
            
            }
            else 
            {
                label3.Text = "Invalid username and password";
                txtuser.Clear();
                txtpass.Clear();
                txtuser.Focus();						
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show("I'm So sorry you have a exit now................................");
            Application.Exit();			
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			 if (ShowAndHidePassWord.Checked)
            {
                txtpass.UseSystemPasswordChar = true;
            }
            else
            {
                txtpass.UseSystemPasswordChar = false;
            }
		}
	}
}
