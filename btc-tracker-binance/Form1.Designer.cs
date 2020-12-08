namespace btc_tracker_binance
{
    partial class Form1
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.btcValueLabel = new System.Windows.Forms.Label();
            this.buyThresholdTextBox = new System.Windows.Forms.TextBox();
            this.sellThresholdTextBox = new System.Windows.Forms.TextBox();
            this.closeThresholdTextBox = new System.Windows.Forms.TextBox();
            this.buyCheckBox = new System.Windows.Forms.CheckBox();
            this.sellCheckBox = new System.Windows.Forms.CheckBox();
            this.closeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.mainLabel.Location = new System.Drawing.Point(13, 23);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(405, 46);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Price of BTC in USD";
            // 
            // btcValueLabel
            // 
            this.btcValueLabel.AutoSize = true;
            this.btcValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btcValueLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btcValueLabel.Location = new System.Drawing.Point(21, 73);
            this.btcValueLabel.Name = "btcValueLabel";
            this.btcValueLabel.Size = new System.Drawing.Size(101, 39);
            this.btcValueLabel.TabIndex = 1;
            this.btcValueLabel.Text = "$x.xx";
            // 
            // buyThresholdTextBox
            // 
            this.buyThresholdTextBox.Location = new System.Drawing.Point(621, 23);
            this.buyThresholdTextBox.Name = "buyThresholdTextBox";
            this.buyThresholdTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyThresholdTextBox.TabIndex = 3;
            // 
            // sellThresholdTextBox
            // 
            this.sellThresholdTextBox.Location = new System.Drawing.Point(621, 73);
            this.sellThresholdTextBox.Name = "sellThresholdTextBox";
            this.sellThresholdTextBox.Size = new System.Drawing.Size(100, 20);
            this.sellThresholdTextBox.TabIndex = 4;
            // 
            // closeThresholdTextBox
            // 
            this.closeThresholdTextBox.Location = new System.Drawing.Point(621, 126);
            this.closeThresholdTextBox.Name = "closeThresholdTextBox";
            this.closeThresholdTextBox.Size = new System.Drawing.Size(100, 20);
            this.closeThresholdTextBox.TabIndex = 5;
            // 
            // buyCheckBox
            // 
            this.buyCheckBox.AutoSize = true;
            this.buyCheckBox.Location = new System.Drawing.Point(563, 26);
            this.buyCheckBox.Name = "buyCheckBox";
            this.buyCheckBox.Size = new System.Drawing.Size(44, 17);
            this.buyCheckBox.TabIndex = 6;
            this.buyCheckBox.Text = "Buy";
            this.buyCheckBox.UseVisualStyleBackColor = true;
            // 
            // sellCheckBox
            // 
            this.sellCheckBox.AutoSize = true;
            this.sellCheckBox.Location = new System.Drawing.Point(563, 76);
            this.sellCheckBox.Name = "sellCheckBox";
            this.sellCheckBox.Size = new System.Drawing.Size(43, 17);
            this.sellCheckBox.TabIndex = 7;
            this.sellCheckBox.Text = "Sell";
            this.sellCheckBox.UseVisualStyleBackColor = true;
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.AutoSize = true;
            this.closeCheckBox.Location = new System.Drawing.Point(563, 128);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(52, 17);
            this.closeCheckBox.TabIndex = 8;
            this.closeCheckBox.Text = "Close";
            this.closeCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeCheckBox);
            this.Controls.Add(this.sellCheckBox);
            this.Controls.Add(this.buyCheckBox);
            this.Controls.Add(this.closeThresholdTextBox);
            this.Controls.Add(this.sellThresholdTextBox);
            this.Controls.Add(this.buyThresholdTextBox);
            this.Controls.Add(this.btcValueLabel);
            this.Controls.Add(this.mainLabel);
            this.Name = "Form1";
            this.Text = "BTC tracker with Binance.NET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label btcValueLabel;
        private System.Windows.Forms.TextBox buyThresholdTextBox;
        private System.Windows.Forms.TextBox sellThresholdTextBox;
        private System.Windows.Forms.TextBox closeThresholdTextBox;
        private System.Windows.Forms.CheckBox buyCheckBox;
        private System.Windows.Forms.CheckBox sellCheckBox;
        private System.Windows.Forms.CheckBox closeCheckBox;
    }
}

