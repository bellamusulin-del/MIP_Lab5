namespace MIP_Lab5
{
    partial class AddExistingProduct
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
            this.productIdLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.addQuantityButton = new System.Windows.Forms.Button();
            this.quantityInput = new System.Windows.Forms.NumericUpDown();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Location = new System.Drawing.Point(288, 199);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(69, 16);
            this.productIdLabel.TabIndex = 0;
            this.productIdLabel.Text = "\tProduct ID";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(288, 228);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(96, 16);
            this.quantityLabel.TabIndex = 1;
            this.quantityLabel.Text = "Quantity to add";
            // 
            // addQuantityButton
            // 
            this.addQuantityButton.Location = new System.Drawing.Point(312, 280);
            this.addQuantityButton.Name = "addQuantityButton";
            this.addQuantityButton.Size = new System.Drawing.Size(129, 23);
            this.addQuantityButton.TabIndex = 2;
            this.addQuantityButton.Text = "\tAdd Quantity";
            this.addQuantityButton.UseVisualStyleBackColor = true;
            this.addQuantityButton.Click += new System.EventHandler(this.addQuantityButton_Click);
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(390, 224);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(120, 22);
            this.quantityInput.TabIndex = 3;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(361, 196);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.productIdTextBox.TabIndex = 4;
            // 
            // AddExistingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.addQuantityButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productIdLabel);
            this.Name = "AddExistingProduct";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddExistingProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button addQuantityButton;
        private System.Windows.Forms.NumericUpDown quantityInput;
        private System.Windows.Forms.TextBox productIdTextBox;
    }
}