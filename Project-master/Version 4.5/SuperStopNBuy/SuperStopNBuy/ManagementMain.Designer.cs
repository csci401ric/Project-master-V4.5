/********************************
 * ManagementMain.Designer.cs
 * Created by The Dev Doods
********************************/

namespace SuperStopNBuy
{
    partial class ManagementMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datagridviewMain = new System.Windows.Forms.DataGridView();
            this.datagridviewtbcColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridviewtbcColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridviewtbcColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridviewtbcColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewMain
            // 
            this.datagridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datagridviewtbcColumn1,
            this.datagridviewtbcColumn2,
            this.datagridviewtbcColumn4,
            this.datagridviewtbcColumn3});
            this.datagridviewMain.Location = new System.Drawing.Point(255, 161);
            this.datagridviewMain.Name = "datagridviewMain";
            this.datagridviewMain.Size = new System.Drawing.Size(443, 213);
            this.datagridviewMain.TabIndex = 0;
            // 
            // datagridviewtbcColumn1
            // 
            this.datagridviewtbcColumn1.HeaderText = "Product Name";
            this.datagridviewtbcColumn1.Name = "datagridviewtbcColumn1";
            // 
            // datagridviewtbcColumn2
            // 
            this.datagridviewtbcColumn2.HeaderText = "Quantity";
            this.datagridviewtbcColumn2.Name = "datagridviewtbcColumn2";
            // 
            // datagridviewtbcColumn4
            // 
            this.datagridviewtbcColumn4.HeaderText = "Product Code";
            this.datagridviewtbcColumn4.Name = "datagridviewtbcColumn4";
            // 
            // datagridviewtbcColumn3
            // 
            this.datagridviewtbcColumn3.HeaderText = "Price";
            this.datagridviewtbcColumn3.Name = "datagridviewtbcColumn3";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(64, 182);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(163, 34);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit Item";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(64, 222);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(163, 36);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add Item";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(64, 264);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(163, 30);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete Item";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonView
            // 
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.Location = new System.Drawing.Point(64, 323);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(163, 33);
            this.buttonView.TabIndex = 4;
            this.buttonView.Text = "View Details";
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Onyx", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(124, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(531, 72);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Product Inventory Management";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(41, 27);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // ManagementMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SuperStopNBuy.Properties.Resources.managementBackground;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.datagridviewMain);
            this.Name = "ManagementMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Stop \'N Buy";
            this.Load += new System.EventHandler(this.ManagementMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridviewMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagridviewtbcColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagridviewtbcColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagridviewtbcColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagridviewtbcColumn3;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonLogout;
    }
}