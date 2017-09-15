using System;
using System.Windows.Forms;

namespace WindowsFormEmailClient
{
	public partial class EmailClient : Form
	{
		string to;
		string from;
		string fromPassword;
		string domain;
		int port;
		string portPlaceholder;     // to ensure that there are no errors while typing in port # we keep it as a string.
		string subject;
		string body;

		public EmailClient()
		{
			InitializeComponent();
		}

		/// <summary>
		/// On button press we convert the portPlaceholder into an integer and then send the email
		/// Try catches are put around both converting the port to an int and sending of the email
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				port = Convert.ToInt32(portPlaceholder);

				try
				{
					Program.Send(to, from, fromPassword, domain, port, subject, body);
				}
				catch
				{
					MessageBox.Show("Email was not sent correctly, please check that all forms were input correctly.", 
							"Email not sent", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch
			{
				MessageBox.Show("Port # is not being converted correctly to an Int", 
						"Port# isn't an Integer", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Textbox onChange functions  
		private void TextBox1_TextChanged(object sender, System.EventArgs e)
		{
			to = ((System.Windows.Forms.TextBox)sender).Text;
		}

		private void TextBox2_TextChanged(object sender, System.EventArgs e)
		{
			from = ((System.Windows.Forms.TextBox)sender).Text;
		}

		private void TextBox3_TextChanged(object sender, System.EventArgs e)
		{
			fromPassword = ((System.Windows.Forms.TextBox)sender).Text;
		}

		private void TextBox6_TextChanged(object sender, EventArgs e)
		{
			domain = ((System.Windows.Forms.TextBox)sender).Text;
		}

		private void TextBox7_TextChanged(object sender, EventArgs e)
		{
			portPlaceholder = ((System.Windows.Forms.TextBox)sender).Text;
		}

		private void TextBox4_TextChanged(object sender, System.EventArgs e)
		{
			subject = ((System.Windows.Forms.TextBox)sender).Text;
		}

		private void TextBox5_TextChanged(object sender, System.EventArgs e)
		{
			body = ((System.Windows.Forms.TextBox)sender).Text;
		}

		private void EmailClient_Load(object sender, System.EventArgs e) { }
	}
}