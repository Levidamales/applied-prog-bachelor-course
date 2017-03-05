using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    class Model
    {
        string filePath;
        public void loadFile(TextBox textBox)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            filePath = dialog.FileName;
            StreamReader rStream = new StreamReader(filePath);
            textBox.Text = rStream.ReadToEnd();
            rStream.Close();
        }
        public void saveFile(TextBox textBox)
        {
            if (filePath == null)
            {
                MessageBox.Show("Не выбран файл!");
                return;
            }
            using (StreamWriter wStream = new StreamWriter(filePath))
            {
                wStream.Write(textBox.Text);
                MessageBox.Show("Изменения сохранены.");
            }
        }
    }
}