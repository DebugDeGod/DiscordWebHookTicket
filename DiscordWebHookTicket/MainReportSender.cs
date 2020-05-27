using System;
using System.Collections.Specialized;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Management;

namespace DiscordWebHookTicket
{
    public partial class MainReportSender : Office2007Form
    {
        public MainReportSender()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false; //Disabling glass from text boxes
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //We need to make a few public statics for our program here
        public static void SendWebhookDiscordyeet(string URL, string msg, string username)
        {
            Http.Post(URL, new NameValueCollection()
            {
                {"username", username },
                {"content", msg }
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            ButtonSendTicket.Enabled = true;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string uMachine = Environment.MachineName;
            string uName = Environment.UserName;
            try
            {
                //THIS IS WHERE U WILL PLACE YOUR WEBHOOK
                SendWebhookDiscordyeet("https://discordapp.com/api/webhooks/715056257308033044/FMU4S6E_PisUDPlD_OE2lXp5Ut668Yt1576LnYQ9t0oqwkXuZ9LAJP-nkulL8V468Udw", string.Concat(new string[]
                { "**Name: **" +
                TextName.Text +
                "\n**Email: **" +
                TextEmail.Text +
                "\n**Report: **" +
                TextReport.Text +
                "\n**Report Type: **" +
                ReportType.Text +
                "\n**ReportMessage **" +
                "```" +
                ReportMessageText.Text +
                "```" +
                //Security Information Clints Cant See On The Form.
                "\n\n**Security Information: **" +
                "\n```PCName: " +
                uName + 
                "\nPCInfo: " +  uMachine +
                "```"}
                ), "Ticket BOT");

                MessageBoxEx.Show("Report Sent!");

                timer1.Interval = 30; //<MLS
                timer1.Tick += timer1_Tick;
                timer1.Start();

                ButtonSendTicket.Enabled = false;

                if (ReportMessageText.Text == "")
                    MessageBoxEx.Show("Please Enter A Error To Report");

                if (TextName.Text == "")
                    MessageBoxEx.Show("Please Enter A Name To Report");
            }

            catch (Exception)
            {
                MessageBoxEx.Show("Crash Intercepted!");
            }
        }
    }
}
