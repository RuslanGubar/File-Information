using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_лаба_1_часть
{
    public partial class mainForm : Form
    {
        private FileInfo fiSource;
        private string fileName;
        private FileStream fsSource; 
        private StreamReader srSource; 
        private StreamWriter swSource;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            fileName = tbInput.Text;
            fiSource = new FileInfo(fileName);
            tbInfo.Clear();
            tbEdit.Clear();
            tbInput.Clear();
            try
            {
                if (fiSource.Exists) 
                {
                    lblFilename.Text = "Информация о файле: " + fileName;
                    tbInfo.Text += "Время создания файла: " +
                    fiSource.CreationTime.ToString() + "\r\n";
                    tbInfo.Text += "Размер файла " + fiSource.Length + " байт \r\n";
                    tbInfo.Text += "Полный путь к файлу: " +
                   fiSource.FullName.ToString() + "\r\n";
                }

            }
            catch (IOException ex) 
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString());
            }

            if (Path.GetExtension(fileName) == ".txt") 
            {
                btnSave.Enabled = true;
                tbEdit.ReadOnly = false;
                fsSource = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                srSource = new StreamReader(fsSource);
                string line; 
                line = srSource.ReadLine(); 
                while (line != null)
                {
                    tbEdit.Text += line + "\r\n"; 
                    line = srSource.ReadLine(); 
                }
                srSource.Close(); 
            }
            else
            {
                tbEdit.Text += "Файл не является текстовым";
                btnSave.Enabled = false;
                tbEdit.ReadOnly = true;
            }

            if (fiSource.IsReadOnly == true)
            {
                tbInfo.Text = "файл только для чтения";
                tbEdit.ReadOnly = true;
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                fsSource = new FileStream(fileName, FileMode.Truncate, FileAccess.Write);
                swSource = new StreamWriter(fsSource);
                for (int i = 0; i < tbEdit.Lines.Length; i++)
                {
                    swSource.WriteLine(tbEdit.Lines[i]);
                }
                swSource.Close(); 
                MessageBox.Show("Изменения сохранены!");
            }
            catch (IOException ex) 
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString());
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Произошла доступа: " + ex.ToString());
            }
        }

        private void tbInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
