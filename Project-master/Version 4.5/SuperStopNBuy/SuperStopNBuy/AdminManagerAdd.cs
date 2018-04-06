/********************************
 * AdminManagerAdd.cs
 * Created by The Dev Doods
********************************/

using SuperStopNBuy.SuperStopNBuyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperStopNBuy
{
    public partial class AdminManagerAdd : Form
    {
        ManagerClass aManager = new ManagerClass();

        public AdminManagerAdd()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Initialize
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Open form
            this.Hide();
            DemoMain formDemoMain = new DemoMain();
            formDemoMain.Show();
        }

        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            int tempVal = 0;
            DateTime dt = new DateTime();

            if (String.IsNullOrEmpty(textboxFirstName.Text))
            {
                MessageBox.Show("Error: Please enter a first name");
                return;
            }
            else if (String.IsNullOrEmpty(textboxLastName.Text))
            {
                MessageBox.Show("Error: Please enter a last name");
                return;
            }
            else if (String.IsNullOrEmpty(textboxUsername.Text))
            {
                MessageBox.Show("Error: Please enter a user name");
                return;
            }
            else if (String.IsNullOrEmpty(textboxPassword.Text))
            {
                MessageBox.Show("Error: Please enter a password");
                return;
            }
            else if (String.IsNullOrEmpty(textboxDOB.Text))
            {
                MessageBox.Show("Error: Please enter a date of birth");
                return;
            }
            else if (String.IsNullOrEmpty(textboxAccessLVL.Text))
            {
                MessageBox.Show("Error: Please enter an access level");
                return;
            }

            if (!Int32.TryParse(textboxAccessLVL.Text, out tempVal))
            {
                MessageBox.Show("Error: access level must be a number");
                return;
            }

            if (!DateTime.TryParseExact(textboxDOB.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out dt))
            {
                MessageBox.Show("Error: Date of birth not in the right format (mm/dd/yyyy)");
                return;
            }

            aManager.managerUsername = textboxUsername.Text;
            aManager.managerPassword = textboxPassword.Text;
            aManager.managerFName = textboxFirstName.Text;
            aManager.managerLName = textboxLastName.Text;
            aManager.managerDOB = textboxDOB.Text;
            aManager.managerAccessLvl = Convert.ToInt32(textboxAccessLVL.Text);

            bool wasSuccessful = aManager.InsertToDatabase(aManager);
            if (wasSuccessful)
            {
                MessageBox.Show("Successful");
            }

            this.Hide();
            var formTemp = new AdminMain();
            formTemp.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new AdminMain();
            formTemp.Show();
        }
    }
}