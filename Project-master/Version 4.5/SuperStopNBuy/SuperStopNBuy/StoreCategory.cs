/********************************
 * StoreCategory.cs
 * Created by Michael M.
********************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperStopNBuy.SuperStopNBuyClasses;

namespace SuperStopNBuy
{
    public partial class StoreCategory : Form
    {

        ItemClass anItem = new ItemClass();
        String passedCategory;
        bool isSearch = false;

        public StoreCategory()
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

        public StoreCategory(String passed)
        {
            passedCategory = passed;
            InitializeComponent();
        }

        public StoreCategory(String passed, bool passedBool)
        {
            isSearch = passedBool;
            passedCategory = passed;
            InitializeComponent();
        }

        private void labelLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new StoreMain();
            formTemp.Show();
        }

        private void StoreCategory_Load(object sender, EventArgs e)
        {
            if (isSearch == false)
            {
                DataTable databaseTable = anItem.SelectCategory(passedCategory);
                dataGridCategory.DataSource = databaseTable;
            }
            else
            {
                DataTable databaseTable = anItem.SelectSearch(passedCategory, false);
                dataGridCategory.DataSource = databaseTable;
            }
        }

        private void buttonProduce_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectCategory("Produce");
            dataGridCategory.DataSource = databaseTable;
        }

        private void buttonMeatDeli_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectCategory("Meat/Deli");
            dataGridCategory.DataSource = databaseTable;
        }

        private void buttonFrozen_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectCategory("Frozen");
            dataGridCategory.DataSource = databaseTable;
        }

        private void buttonGrocery_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectCategory("Grocery");
            dataGridCategory.DataSource = databaseTable;
        }

        private void buttonDairy_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectCategory("Dairy");
            dataGridCategory.DataSource = databaseTable;
        }

        private void buttonBakery_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectCategory("Bakery");
            dataGridCategory.DataSource = databaseTable;
        }

        private void textboxSearch_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectSearch(textboxSearch.Text, false);
            dataGridCategory.DataSource = databaseTable;
        }
    }
}
