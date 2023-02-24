namespace Cash_Register
{
    partial class carDealerships
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carDealerships));
            this.bugattiLabel = new System.Windows.Forms.Label();
            this.lamborghinilabel = new System.Windows.Forms.Label();
            this.mokeAmericalabel = new System.Windows.Forms.Label();
            this.BugattiInput = new System.Windows.Forms.TextBox();
            this.lamborghiniInput = new System.Windows.Forms.TextBox();
            this.mokeInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxTotalOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.wholeTotalOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bugattiLabel
            // 
            this.bugattiLabel.BackColor = System.Drawing.Color.Blue;
            this.bugattiLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bugattiLabel.Location = new System.Drawing.Point(13, 13);
            this.bugattiLabel.Name = "bugattiLabel";
            this.bugattiLabel.Size = new System.Drawing.Size(99, 30);
            this.bugattiLabel.TabIndex = 0;
            this.bugattiLabel.Text = "Number of bugatti Chiron Pur Sport";
            // 
            // lamborghinilabel
            // 
            this.lamborghinilabel.BackColor = System.Drawing.Color.Red;
            this.lamborghinilabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lamborghinilabel.Location = new System.Drawing.Point(12, 58);
            this.lamborghinilabel.Name = "lamborghinilabel";
            this.lamborghinilabel.Size = new System.Drawing.Size(100, 32);
            this.lamborghinilabel.TabIndex = 1;
            this.lamborghinilabel.Text = "Number of lamborghini LM002";
            // 
            // mokeAmericalabel
            // 
            this.mokeAmericalabel.BackColor = System.Drawing.Color.Fuchsia;
            this.mokeAmericalabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mokeAmericalabel.Location = new System.Drawing.Point(12, 101);
            this.mokeAmericalabel.Name = "mokeAmericalabel";
            this.mokeAmericalabel.Size = new System.Drawing.Size(100, 30);
            this.mokeAmericalabel.TabIndex = 2;
            this.mokeAmericalabel.Text = "Number of Moke America";
            // 
            // BugattiInput
            // 
            this.BugattiInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BugattiInput.Location = new System.Drawing.Point(132, 12);
            this.BugattiInput.Name = "BugattiInput";
            this.BugattiInput.Size = new System.Drawing.Size(100, 31);
            this.BugattiInput.TabIndex = 3;
            // 
            // lamborghiniInput
            // 
            this.lamborghiniInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lamborghiniInput.Location = new System.Drawing.Point(132, 59);
            this.lamborghiniInput.Name = "lamborghiniInput";
            this.lamborghiniInput.Size = new System.Drawing.Size(100, 31);
            this.lamborghiniInput.TabIndex = 4;
            // 
            // mokeInput
            // 
            this.mokeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mokeInput.Location = new System.Drawing.Point(132, 101);
            this.mokeInput.Name = "mokeInput";
            this.mokeInput.Size = new System.Drawing.Size(100, 31);
            this.mokeInput.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.calculateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(15, 145);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(97, 25);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(12, 183);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(100, 23);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subTotalOutput.Location = new System.Drawing.Point(150, 183);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(100, 23);
            this.subTotalOutput.TabIndex = 8;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taxLabel.Location = new System.Drawing.Point(11, 224);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(120, 24);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax amount";
            // 
            // taxTotalOutput
            // 
            this.taxTotalOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxTotalOutput.Location = new System.Drawing.Point(150, 224);
            this.taxTotalOutput.Name = "taxTotalOutput";
            this.taxTotalOutput.Size = new System.Drawing.Size(100, 23);
            this.taxTotalOutput.TabIndex = 10;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(11, 269);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(110, 24);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total Prcie";
            // 
            // wholeTotalOutput
            // 
            this.wholeTotalOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wholeTotalOutput.Location = new System.Drawing.Point(150, 269);
            this.wholeTotalOutput.Name = "wholeTotalOutput";
            this.wholeTotalOutput.Size = new System.Drawing.Size(100, 23);
            this.wholeTotalOutput.TabIndex = 12;
            // 
            // carDealerships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(504, 347);
            this.Controls.Add(this.wholeTotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxTotalOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mokeInput);
            this.Controls.Add(this.lamborghiniInput);
            this.Controls.Add(this.BugattiInput);
            this.Controls.Add(this.mokeAmericalabel);
            this.Controls.Add(this.lamborghinilabel);
            this.Controls.Add(this.bugattiLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "carDealerships";
            this.Text = "Car Dealerships";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bugattiLabel;
        private System.Windows.Forms.Label lamborghinilabel;
        private System.Windows.Forms.Label mokeAmericalabel;
        private System.Windows.Forms.TextBox BugattiInput;
        private System.Windows.Forms.TextBox lamborghiniInput;
        private System.Windows.Forms.TextBox mokeInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxTotalOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label wholeTotalOutput;
    }
}

