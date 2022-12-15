using System.Net;
using System.Net.Mail;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the sender and recipient email addresses
            string sender = "studenthousing404@outlook.com";
            string recipient = "ionut1103@gmail.com";

            // Set the email subject and body
            string subject = "Test Email from C#";
            string body = "This is a test email sent from a C# program.";

            // Generate a random code and append it to the email body
            Random random = new Random();
            int code = random.Next(10000, 99999);
            body += "\n\nYour random code is: " + code;

            // Create a new MailMessage object
            MailMessage message = new MailMessage(sender, recipient, subject, body);

            // Set the sender's password
            string password = "Studenthousingbv404";

            // Create a new SmtpClient object to send the email
            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            client.EnableSsl = true;

            // Set the client's credentials
            client.Credentials = new NetworkCredential(sender, password);

            // Send the email
            client.Send(message);

            Console.WriteLine("Email sent!");
        }
    }
}
