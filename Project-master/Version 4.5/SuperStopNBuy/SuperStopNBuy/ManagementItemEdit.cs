/********************************
 * ManagementItemEdit.cs
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
    public partial class ManagementItemEdit : Form
    {
        ItemClass anItem = new ItemClass();

        public ManagementItemEdit()
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

        public ManagementItemEdit(ItemClass anItem)
        {
            InitializeComponent();

            textboxName.Text = anItem.itemName;
            textboxPrice.Text = anItem.itemPrice.ToString();
            textboxQuantity.Text = anItem.itemQuantity.ToString();
            textboxNumber.Text = anItem.itemNumber.ToString();
            textboxDesc.Text = anItem.itemDesc.ToString();
            comboBoxCategory.Text = anItem.itemCategory.ToString();

        }

        private void ManagementItemEdit_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            anItem.itemName = textboxName.Text;
            anItem.itemNumber = Convert.ToInt32(textboxNumber.Text);
            anItem.itemDesc = textboxDesc.Text;
            anItem.itemQuantity = Convert.ToInt32(textboxQuantity.Text);
            anItem.itemPrice = Convert.ToDouble(textboxPrice.Text);
            anItem.itemCategory = comboBoxCategory.Text;

            bool wasSucessful = anItem.UpdateDatabaseItem(anItem);
            if(wasSucessful)
            {
                MessageBox.Show("Update Successful");
            }
            else
            {
                MessageBox.Show("Update Not Successful");
            }

            this.Hide();
            var formTemp = new ManagementItemView();
            formTemp.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes will not be saved");
            this.Hide();
            var formTemp = new ManagementItemView();
            formTemp.Show();
        }
    }
}
