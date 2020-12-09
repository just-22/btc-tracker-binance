using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Binance.Net;
using System.Windows.Forms;

namespace btc_tracker_binance
{
    public partial class Form1 : Form
    {
        public enum ActionTrigger
        {
            BUY,
            SELL,
            CLOSE
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            RunTheSocket();
        }

        public void RunTheSocket()
        {
            // creation of the socket and subcribing to updates
            var client = new BinanceSocketClient();
            client.Spot.SubscribeToSymbolTickerUpdates("BTCUSDT", data =>
            {
                // BECAUSE WE NEED TO UPDATE UI, WE NEED TO INVOKE THAT UI ELEMENT
                if (btcValueLabel.InvokeRequired)
                    btcValueLabel.Invoke(new MethodInvoker(delegate
                    {
                        // DEPENDING ON THE CONDITION WE FIRE A TRIGGER
                        if (!string.IsNullOrWhiteSpace(buyThresholdTextBox.Text) && buyCheckBox.CheckState == CheckState.Checked && decimal.Parse(buyThresholdTextBox.Text) > data.WeightedAveragePrice)
                            RunTrigger(ActionTrigger.BUY);
                        if (!string.IsNullOrWhiteSpace(sellThresholdTextBox.Text) && sellCheckBox.CheckState == CheckState.Checked && decimal.Parse(sellThresholdTextBox.Text) <= data.WeightedAveragePrice)
                            RunTrigger(ActionTrigger.SELL);
                        if (!string.IsNullOrWhiteSpace(closeThresholdTextBox.Text) && closeCheckBox.CheckState == CheckState.Checked && decimal.Parse(closeThresholdTextBox.Text) < data.WeightedAveragePrice)
                            RunTrigger(ActionTrigger.CLOSE);
                        // HERE THE VALUE IS BEING UPDATED IN THE LABEL
                        btcValueLabel.Text = data.WeightedAveragePrice.ToString();
                    }));
            });
        }

        private void RunTrigger(ActionTrigger trigger)
        {
            switch (trigger)
            {
                case ActionTrigger.BUY:
                    buyCheckBox.CheckState = CheckState.Unchecked;
                    MessageBox.Show("BUY ACTION");
                    break;
                case ActionTrigger.SELL:
                    sellCheckBox.CheckState = CheckState.Unchecked;
                    MessageBox.Show("SELL ACTION");
                    break;
                case ActionTrigger.CLOSE:
                    closeCheckBox.CheckState = CheckState.Unchecked;
                    MessageBox.Show("CLOSE ACTION");
                    break;
                default:
                    break;
            }
        }
        // allowing only numeric input into textboxes
        private void numericBoxValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
