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
using System.Threading;

namespace Photo_Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void get_photo_dir_Click(object sender, EventArgs e)
        {
            if (photo_dir.ShowDialog() == DialogResult.OK)
            {
                photos_dir.Text = photo_dir.SelectedPath;
            }
        }

        private void get_new_dir_Click(object sender, EventArgs e)
        {
            if (new_photo_dir.ShowDialog() == DialogResult.OK)
            {
                new_dir.Text = new_photo_dir.SelectedPath;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (new_dir.Text == "" || photos_dir.Text == "")
            {
                start_button.Enabled = false;
            }
            else
            {
                start_button.Enabled = true;
            }   
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            start_button.Enabled = false;
            get_photo_dir.Enabled = false;
            get_new_dir.Enabled = false;

            string[] photos = Directory.GetFiles(photos_dir.Text);
            int step = 100 / photos.Length;
            progressBar1.Step = step;
            string name_s = "";

            string new_folder = new_dir.Text;

            if (!Directory.Exists(new_folder))
                Directory.CreateDirectory(new_folder);
            
            for (int i = 0; i < photos.Length; i++)
            {
                FileInfo file = new FileInfo(photos[i]);
                string date = file.LastWriteTime.ToShortDateString();
                string[] hp = date.Split('.');
                string mounth = hp[1];
                string year = hp[2];

                string full_path = "";
                
                if (mounth == "12" || mounth == "01" || mounth == "02")
                    name_s = "Зима";
                else if (mounth == "03" || mounth == "04" || mounth == "05")
                    name_s = "Весна";
                else if (mounth == "06" || mounth == "07" || mounth == "08")
                    name_s = "Літо";
                else if (mounth == "09" || mounth == "10" || mounth == "11")
                    name_s = "Осінь";

                if (!Directory.Exists(new_folder + "/" + name_s))
                    Directory.CreateDirectory(new_folder + "/" + name_s);

                if (!Directory.Exists(new_folder + "/" + name_s + "/" + year))
                    Directory.CreateDirectory(new_folder + "/" + name_s + "/" + year);

                full_path = new_folder + "/" + name_s + "/" + year;

                try
                {
                    File.Copy(photos[i], full_path + "/" + i + ".jpg");
                }
                catch (Exception ex)
                {
                    continue;
                }

                progressBar1.PerformStep();
                Thread.Sleep(300);
            }

            MessageBox.Show("Файли успішно відсортовано", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar1.Value = 0;
            start_button.Enabled = true;
            get_photo_dir.Enabled = true;
            get_new_dir.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версія програми 1.0. Програму створив Сергій Мандрикін", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
