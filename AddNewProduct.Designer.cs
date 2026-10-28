namespace MIP_Lab5
{
    partial class AddNewProduct
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
            this.saveProductButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.expiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.quantityInput = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // saveProductButton
            // 
            this.saveProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.saveProductButton.Location = new System.Drawing.Point(312, 319);
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(139, 56);
            this.saveProductButton.TabIndex = 9;
            this.saveProductButton.Text = "Add Product";
            this.saveProductButton.UseVisualStyleBackColor = false;
            this.saveProductButton.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(240, 149);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(96, 16);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Product Name ";
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Location = new System.Drawing.Point(261, 262);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(74, 16);
            this.expiryDateLabel.TabIndex = 7;
            this.expiryDateLabel.Text = "\tExpiry date";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(281, 223);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(55, 16);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Quantity";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(261, 183);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(75, 16);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(351, 143);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.Text = "Enter Name";
            // 
            // expiryDatePicker
            // 
            this.expiryDatePicker.Location = new System.Drawing.Point(357, 262);
            this.expiryDatePicker.Name = "expiryDatePicker";
            this.expiryDatePicker.Size = new System.Drawing.Size(200, 22);
            this.expiryDatePicker.TabIndex = 11;
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(357, 217);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(120, 22);
            this.quantityInput.TabIndex = 12;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(351, 177);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(105, 22);
            this.descriptionTextBox.TabIndex = 13;
            this.descriptionTextBox.Text = "Enter description";
            // 
            // AddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.expiryDatePicker);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveProductButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.expiryDateLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Name = "AddNewProduct";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddNewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveProductButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label expiryDateLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker expiryDatePicker;
        private System.Windows.Forms.NumericUpDown quantityInput;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}