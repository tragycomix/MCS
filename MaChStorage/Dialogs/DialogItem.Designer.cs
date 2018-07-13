namespace MaChStorage.Dialogs
{
    partial class DialogItem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label itemDescLabel;
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label placementLabel;
            System.Windows.Forms.Label supplierIdLabel;
            this.itemsVWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.itemDescTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.placementTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            itemDescLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            placementLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemsVWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsVWBindingSource
            // 
            this.itemsVWBindingSource.DataSource = typeof(MaChStorage.Data.ItemsVW);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(96, 28);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsVWBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(121, 25);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(72, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // itemDescLabel
            // 
            itemDescLabel.AutoSize = true;
            itemDescLabel.Location = new System.Drawing.Point(57, 80);
            itemDescLabel.Name = "itemDescLabel";
            itemDescLabel.Size = new System.Drawing.Size(58, 13);
            itemDescLabel.TabIndex = 3;
            itemDescLabel.Text = "Item Desc:";
            // 
            // itemDescTextBox
            // 
            this.itemDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsVWBindingSource, "ItemDesc", true));
            this.itemDescTextBox.Location = new System.Drawing.Point(121, 77);
            this.itemDescTextBox.Name = "itemDescTextBox";
            this.itemDescTextBox.Size = new System.Drawing.Size(300, 20);
            this.itemDescTextBox.TabIndex = 4;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(54, 54);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(61, 13);
            itemNameLabel.TabIndex = 4;
            itemNameLabel.Text = "Item Name:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsVWBindingSource, "ItemName", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(121, 51);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.itemNameTextBox.TabIndex = 5;
            // 
            // placementLabel
            // 
            placementLabel.AutoSize = true;
            placementLabel.Location = new System.Drawing.Point(55, 106);
            placementLabel.Name = "placementLabel";
            placementLabel.Size = new System.Drawing.Size(60, 13);
            placementLabel.TabIndex = 6;
            placementLabel.Text = "Placement:";
            // 
            // placementTextBox
            // 
            this.placementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsVWBindingSource, "Placement", true));
            this.placementTextBox.Location = new System.Drawing.Point(121, 103);
            this.placementTextBox.Name = "placementTextBox";
            this.placementTextBox.Size = new System.Drawing.Size(137, 20);
            this.placementTextBox.TabIndex = 7;
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(55, 154);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(60, 13);
            supplierIdLabel.TabIndex = 8;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsVWBindingSource, "SupplierId", true));
            this.comboBox1.DataSource = this.supplierBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Id";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(MaChStorage.Data.Supplier);
            // 
            // DialogItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(supplierIdLabel);
            this.Controls.Add(placementLabel);
            this.Controls.Add(this.placementTextBox);
            this.Controls.Add(itemNameLabel);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(itemDescLabel);
            this.Controls.Add(this.itemDescTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Name = "DialogItem";
            this.Text = "DialogItem";
            ((System.ComponentModel.ISupportInitialize)(this.itemsVWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource itemsVWBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox itemDescTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox placementTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource supplierBindingSource;
    }
}