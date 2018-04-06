/********************************
 * ManagementItemAdd.cs
 * Created by The Dev Doods
********************************/

using SuperStopNBuy.SuperStopNBuyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperStopNBuy
{
    public partial class ManagementItemAdd : Form
    {
        ItemClass anItem = new ItemClass();

        public ManagementItemAdd()
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            anItem.itemName = textboxName.Text;
            anItem.itemNumber = Convert.ToInt32(textboxNumber.Text);
            anItem.itemQuantity = Convert.ToInt32(textboxQuantity.Text);
            anItem.itemPrice = Convert.ToDouble(textboxPrice.Text);
            anItem.itemDesc = textboxDesc.Text;
            anItem.itemCategory = comboBoxCategory.Text;

            bool wasSuccessful = anItem.InsertToDatabase(anItem);
            if(wasSuccessful)
            {
                MessageBox.Show("Successful");
            }

            this.Hide();
            var formTemp = new ManagementItemView();
            formTemp.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new ManagementItemView();
            formTemp.Show();
        }
    }
}
