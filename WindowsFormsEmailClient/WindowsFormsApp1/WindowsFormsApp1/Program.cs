using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormEmailClient
{
	static class Program
	{

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new EmailClient());
		}

		/// handles sending the email
		public static void Send(string to, string from, string password, string domain, int port, string subject, string body)
		{
			var message = CreateMailMessage(from, to, subject, body);
			
			using (SmtpClient client = CreateSmtpClient(domain, port, from, password))
			{
				client.Send(message);
			}
		}

		/// Defines the SmtpClient for the mail message 
		/// setups up the network credentials to send the email
		/// EnableSsl line needs to be removed/ set to false if you are using a non authenticated SMTP server
		private static SmtpClient CreateSmtpClient(string host, int port, string from, string password)
		{
			SmtpClient client = null;

			client = new SmtpClient()
			{
				Host = host,
				Port = port,
				EnableSsl = true,
				Credentials = new NetworkCredential(from, password)
			};

			return client;
		}

		/// defines what is contained in the email and where it will be sent
		/// also makes all messages send as HTML
		private static MailMessage CreateMailMessage(string from, string to, string subject, string body)
		{
			MailMessage message = null;

			message = new MailMessage(from, to)
			{
				Subject = subject,
				Body = body
			};

			message.IsBodyHtml = true;
			return message;
		}
	}
}