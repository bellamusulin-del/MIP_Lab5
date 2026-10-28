namespace MIP_Lab5
{
    partial class SellProductForm
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.availableQuantityLabel = new System.Windows.Forms.Label();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.entryDateLabel = new System.Windows.Forms.Label();
            this.sellQuantityLabel = new System.Windows.Forms.Label();
            this.sellQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.sellButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sellQuantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(216, 133);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(90, 16);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product name";
            this.productNameLabel.Click += new System.EventHandler(this.productNameLabel_Click);
            // 
            // availableQuantityLabel
            // 
            this.availableQuantityLabel.AutoSize = true;
            this.availableQuantityLabel.Location = new System.Drawing.Point(216, 160);
            this.availableQuantityLabel.Name = "availableQuantityLabel";
            this.availableQuantityLabel.Size = new System.Drawing.Size(113, 16);
            this.availableQuantityLabel.TabIndex = 1;
            this.availableQuantityLabel.Text = "Available quantity";
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Location = new System.Drawing.Point(216, 193);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(74, 16);
            this.expiryDateLabel.TabIndex = 2;
            this.expiryDateLabel.Text = "Expiry date";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(216, 233);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(75, 16);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            // 
            // entryDateLabel
            // 
            this.entryDateLabel.AutoSize = true;
            this.entryDateLabel.Location = new System.Drawing.Point(223, 272);
            this.entryDateLabel.Name = "entryDateLabel";
            this.entryDateLabel.Size = new System.Drawing.Size(67, 16);
            this.entryDateLabel.TabIndex = 4;
            this.entryDateLabel.Text = "Entry date";
            // 
            // sellQuantityLabel
            // 
            this.sellQuantityLabel.AutoSize = true;
            this.sellQuantityLabel.Location = new System.Drawing.Point(223, 307);
            this.sellQuantityLabel.Name = "sellQuantityLabel";
            this.sellQuantityLabel.Size = new System.Drawing.Size(93, 16);
            this.sellQuantityLabel.TabIndex = 5;
            this.sellQuantityLabel.Text = "Quantity to sell";
            // 
            // sellQuantityInput
            // 
            this.sellQuantityInput.Location = new System.Drawing.Point(223, 341);
            this.sellQuantityInput.Name = "sellQuantityInput";
            this.sellQuantityInput.Size = new System.Drawing.Size(120, 22);
            this.sellQuantityInput.TabIndex = 6;
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(268, 393);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 23);
            this.sellButton.TabIndex = 7;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // SellProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.sellQuantityInput);
            this.Controls.Add(this.sellQuantityLabel);
            this.Controls.Add(this.entryDateLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.expiryDateLabel);
            this.Controls.Add(this.availableQuantityLabel);
            this.Controls.Add(this.productNameLabel);
            this.Name = "SellProductForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SellProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellQuantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label availableQuantityLabel;
        private System.Windows.Forms.Label expiryDateLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label entryDateLabel;
        private System.Windows.Forms.Label sellQuantityLabel;
        private System.Windows.Forms.NumericUpDown sellQuantityInput;
        private System.Windows.Forms.Button sellButton;
    }
}