using DBUI.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI.Interface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ServerInteraction oInteraction = new ServerInteraction
            {
                Server = ServerTextbox.Text,
                Database = DatabaseTextbox.Text,
                Table = TableTextbox.Text
            };

            if (AuthenticationCheckbox.Checked)
            {
                oInteraction.AuthenticationType = SharedResources.eAuthenticationTypes.Windows;
            }
            else
            {
                oInteraction.AuthenticationType = SharedResources.eAuthenticationTypes.Server;
                oInteraction.Username = UsernameTextbox.Text;
                SecureString secure = new SecureString();
                foreach (char c in PasswordTextbox.Text)
                {
                    secure.AppendChar(c);
                }
                oInteraction.Password = secure;
            }

        }
    }
}
