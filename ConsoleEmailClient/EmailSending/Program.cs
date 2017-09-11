using System;
using System.Net;
using System.Net.Mail;

namespace EmailSendingProgram
{
	public class EmailSendingClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Type your Gmail Address: ");
			string from = Console.ReadLine();

			Console.WriteLine("Type your Gmail Password: ");
			string password = Console.ReadLine();

			Console.WriteLine("Type the Email Address you wish to send to: ");
			string to = Console.ReadLine();

			Console.WriteLine("Type the Subject of the email: ");
			string subject = Console.ReadLine();

			Console.WriteLine("Type or paste in your email (either text or HTML): ");
			string body = Console.ReadLine();

			EmailSendingClass email = new EmailSendingClass();
			email.Send(from, password, to, subject, body);
		}

		/// handles sending the email
		/// hardcoded to work with gmail just change the CreateSmtpClient from 
		/// "smtp.gmail.com", 587 to whatever you want to use
		public void Send(string from, string password, string to, string subject, string body)
		{ 
			var message = CreateMailMessage(from, to, subject, body);

			// Host and Port setup for use with Gmail
			using (SmtpClient client = CreateSmtpClient("smtp.gmail.com", 587, from, password))
			{
				client.Send(message);
			}
		}

		/// Defines the SmtpClient for the mail message 
		/// setups up the network credentials to send the email
		private SmtpClient CreateSmtpClient(string host, int port, string from, string password)
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
		private MailMessage CreateMailMessage(string from, string to, string subject, string body)
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