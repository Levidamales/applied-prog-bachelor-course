using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab2.Model
{
    class FileWriter
    {
        public void write(ContentHolder holder)
        {
            if (holder.path == null)
            {
                MessageBox.Show("Не выбран файл!");
                return;
            }
            using (StreamWriter wStream = new StreamWriter(holder.path))
            {
                wStream.Write(holder.text);
                MessageBox.Show("Изменения сохранены.");
            }
        }
    }
}
