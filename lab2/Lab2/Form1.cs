using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Form1 : Form
    {
        Model.ContentHolder content = new Model.ContentHolder();
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            Model.FileReader reader = new Model.FileReader();
            reader.read(content);
            textBox1.Text = content.text;
            Text = content.path;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            content.text = textBox1.Text;
            Model.FileWriter writer = new Model.FileWriter();
            writer.write(content);
        }
    }
}
