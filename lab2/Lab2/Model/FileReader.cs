using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab2.Model
{
    class FileReader
    {
        public void read(ContentHolder holder)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            holder.path = dialog.FileName;
            StreamReader rStream = new StreamReader(holder.path);
            holder.text = rStream.ReadToEnd();
            rStream.Close();
        }
    }
}
