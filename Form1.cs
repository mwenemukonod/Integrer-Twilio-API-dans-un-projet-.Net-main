using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const string accountSid = "ACa39c9706fccd01ad253cef814dacaebd";
        const string authToken = "69b3160487c0dc24c100afb40853ef01";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {}
        private void btn_envoyermessage_Click(object sender, EventArgs e)
        {
           

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "DODY TESTE Twilio" + "\n" +txtmessage.Text.ToString(),
                from: new Twilio.Types.PhoneNumber("+14159426382"),
                to: new Twilio.Types.PhoneNumber("+243972889392")
            );
            MessageBox.Show(message.Sid);
           // Console.WriteLine(message.Sid);
        }
    }
}
