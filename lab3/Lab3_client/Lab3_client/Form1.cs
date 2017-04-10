using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Lab3_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var request = HttpWebRequest.Create("http://localhost:50666/data/read/?path="+pathField.Text);
            var response = request.GetResponse();
            string data = "";
            using (var stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream);
                data = reader.ReadToEnd();
                reader.Close();
            }
            string holdi = JsonConvert.DeserializeObject<string>(data);
            contentField.Text = holdi;
        }
    }
}
//C:\Users\samae_000.SATANS_TOWER\Desktop\test.txt