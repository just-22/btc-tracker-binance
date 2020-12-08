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
        public Form1()
        {
            InitializeComponent();

        }

        public void RunTheSocket()
        {
            var client = new BinanceSocketClient();
            client.Spot.SubscribeToSymbolTickerUpdates("BTCUSDT", data =>
            {
                if (btcValueLabel.InvokeRequired)
                    btcValueLabel.Invoke(new MethodInvoker(delegate { btcValueLabel.Text = data.LastPrice.ToString(); }));
            });
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            RunTheSocket();
        }
    }
}
