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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

