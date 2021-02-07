using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form1
            this.WindowState = FormWindowState.Maximized;
            // label
            int x_min = 500;
            int y_min = 0;
            int x_max = Width;
            int y_max = Height;

            int[] x = {(x_min + (x_min + x_max) / 2 ) / 2, (x_min + x_max) / 2, (x_max + (x_min + x_max) / 2 ) / 2}; // x для label (1lvl).
            int[] y = {(y_min + (y_min + y_max) / 2 ) / 2, (y_min + y_max) / 2, (y_max + (y_min + y_max) / 2 ) / 2}; // y для label (1lvl).

            int[] x2 = {(x_min + x[0]) / 2, (x[2] + x_max) / 2};
            int[] y2 = 
            {
                (y_min + ((y_min + y[0]) / 2)) / 2, (y_min + y[0]) / 2, (y[0] + ((y_min + y[0]) / 2)) / 2, // Для верхних label`od (2lvl).
                (y[0] + y[1]) / 2, y[1], (y[1] + y[2]) / 2, // Для label`ов по середине (2lvl). 
                (y[2] + ((y[2] + y_max) / 2)) / 2, (y[2] + y_max) / 2, (y_max + ((y[2] + y_max) / 2)) / 2 // Для нижних label`ов (2lvl).
            };

            message.Text = "Введите главную идею!";

            // Главная идея
            label1.Text = "";
            label1.Location = new Point(x[1], y[1]);
            // label (1lvl)
            label2.Text = "";
            label2.Location = new Point(x[0], y[0]);
            label3.Text = "";
            label3.Location = new Point(x[1], y[0]);
            label4.Text = "";
            label4.Location = new Point(x[2], y[0]);
            label5.Text = "";
            label5.Location = new Point(x[0], y[1]);
            label6.Text = "";
            label6.Location = new Point(x[2], y[1]);
            label7.Text = "";
            label7.Location = new Point(x[0], y[2]);
            label8.Text = "";
            label8.Location = new Point(x[1], y[2]);
            label9.Text = "";
            label9.Location = new Point(x[2], y[2]);
            // lavel (2lvl)
            // Относится ко label2
            label10.Text = "";
            label10.Location = new Point(x[0], y2[0]);
            label11.Text = "";
            label11.Location = new Point(x[0], y2[1]);
            label12.Text = "";
            label12.Location = new Point(x[0], y2[2]);
            // Относится ко label3
            label13.Text = "";
            label13.Location = new Point(x[1], y2[0]);
            label14.Text = "";
            label14.Location = new Point(x[1], y2[1]);
            label15.Text = "";
            label15.Location = new Point(x[1], y2[2]);
            // Относится ко label4
            label16.Text = "";
            label16.Location = new Point(x[2], y2[0]);
            label17.Text = "";
            label17.Location = new Point(x[2], y2[1]);
            label18.Text = "";
            label18.Location = new Point(x[2], y2[2]);
            // Относится ко label5
            label19.Text = "";
            label19.Location = new Point(x2[0], y2[3]);
            label20.Text = "";
            label20.Location = new Point(x2[0], y2[4]);
            label21.Text = "";
            label21.Location = new Point(x2[0], y2[5]);
            // Относится ко label6
            label22.Text = "";
            label22.Location = new Point(x2[1], y2[3]);
            label23.Text = "";
            label23.Location = new Point(x2[1], y2[4]);
            label24.Text = "";
            label24.Location = new Point(x2[1], y2[5]);
            // Относится ко label7
            label25.Text = "";
            label25.Location = new Point(x[0], y2[6]);
            label26.Text = "";
            label26.Location = new Point(x[0], y2[7]);
            label27.Text = "";
            label27.Location = new Point(x[0], y2[8]);
            // Относится ко label8
            label28.Text = "";
            label28.Location = new Point(x[1], y2[6]);
            label29.Text = "";
            label29.Location = new Point(x[1], y2[7]);
            label30.Text = "";
            label30.Location = new Point(x[1], y2[8]);
            // Относится ко label9
            label31.Text = "";
            label31.Location = new Point(x[2], y2[6]);
            label32.Text = "";
            label32.Location = new Point(x[2], y2[7]);
            label33.Text = "";
            label33.Location = new Point(x[2], y2[8]);

            // PictureBox
            const int distance_pictures= 28; // Размер картинки + расстояние до нее между ней и label
            image1.Location = new Point(x[1] - distance_pictures, y[1]);
            image2.Location = new Point(x[0] - distance_pictures, y[0]);
            image3.Location = new Point(x[1] - distance_pictures, y[0]);
            image4.Location = new Point(x[2] - distance_pictures, y[0]);
            image5.Location = new Point(x[0] - distance_pictures, y[1]);
            image6.Location = new Point(x[2] - distance_pictures, y[1]);
            image7.Location = new Point(x[0] - distance_pictures, y[2]);
            image8.Location = new Point(x[1] - distance_pictures, y[2]);
            image9.Location = new Point(x[2] - distance_pictures, y[2]);

            image10.Location = new Point(x[0] - distance_pictures, y2[0]);
            image11.Location = new Point(x[0] - distance_pictures, y2[1]);
            image12.Location = new Point(x[0] - distance_pictures, y2[2]);
            image13.Location = new Point(x[1] - distance_pictures, y2[0]);
            image14.Location = new Point(x[1] - distance_pictures, y2[1]);
            image15.Location = new Point(x[1] - distance_pictures, y2[2]);
            image16.Location = new Point(x[2] - distance_pictures, y2[0]);
            image17.Location = new Point(x[2] - distance_pictures, y2[1]);
            image18.Location = new Point(x[2] - distance_pictures, y2[2]);

            image19.Location = new Point(x2[0] - distance_pictures, y2[3]);
            image20.Location = new Point(x2[0] - distance_pictures, y2[4]);
            image21.Location = new Point(x2[0] - distance_pictures, y2[5]);
            image22.Location = new Point(x2[1] - distance_pictures, y2[3]);
            image23.Location = new Point(x2[1] - distance_pictures, y2[4]);
            image24.Location = new Point(x2[1] - distance_pictures, y2[5]);

            image25.Location = new Point(x[0] - distance_pictures, y2[6]);
            image26.Location = new Point(x[0] - distance_pictures, y2[7]);
            image27.Location = new Point(x[0] - distance_pictures, y2[8]);
            image28.Location = new Point(x[1] - distance_pictures, y2[6]);
            image29.Location = new Point(x[1] - distance_pictures, y2[7]);
            image30.Location = new Point(x[1] - distance_pictures, y2[8]);
            image31.Location = new Point(x[2] - distance_pictures, y2[6]);
            image32.Location = new Point(x[2] - distance_pictures, y2[7]);
            image33.Location = new Point(x[2] - distance_pictures, y2[8]);

            // linklabel
            linkLabel1.Text = "";
            linkLabel1.Enabled = false;

        }

        int counter_for_images = 0;

        void printImages()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                switch (counter_for_images)
                {
                    case 0: break;
                    case 1:
                        image1.Image = new Bitmap(ofd.FileName);
                        break;
                    case 2:
                        image2.Image = new Bitmap(ofd.FileName);
                        break;
                    case 3:
                        image3.Image = new Bitmap(ofd.FileName);
                        break;
                    case 4:
                        image4.Image = new Bitmap(ofd.FileName);
                        break;
                    case 5:
                        image5.Image = new Bitmap(ofd.FileName);
                        break;
                    case 6:
                        image6.Image = new Bitmap(ofd.FileName);
                        break;
                    case 7:
                        image7.Image = new Bitmap(ofd.FileName);
                        break;
                    case 8:
                        image8.Image = new Bitmap(ofd.FileName);
                        break;
                    case 9:
                        image9.Image = new Bitmap(ofd.FileName);
                        break;
                    case 10:
                        image10.Image = new Bitmap(ofd.FileName);
                        break;
                    case 11:
                        image11.Image = new Bitmap(ofd.FileName);
                        break;
                    case 12:
                        image12.Image = new Bitmap(ofd.FileName);
                        break;
                    case 13:
                        image13.Image = new Bitmap(ofd.FileName);
                        break;
                    case 14:
                        image14.Image = new Bitmap(ofd.FileName);
                        break;
                    case 15:
                        image15.Image = new Bitmap(ofd.FileName);
                        break;
                    case 16:
                        image16.Image = new Bitmap(ofd.FileName);
                        break;
                    case 17:
                        image17.Image = new Bitmap(ofd.FileName);
                        break;
                    case 18:
                        image18.Image = new Bitmap(ofd.FileName);
                        break;
                    case 19:
                        image19.Image = new Bitmap(ofd.FileName);
                        break;
                    case 20:
                        image20.Image = new Bitmap(ofd.FileName);
                        break;
                    case 21:
                        image21.Image = new Bitmap(ofd.FileName);
                        break;
                    case 22:
                        image22.Image = new Bitmap(ofd.FileName);
                        break;
                    case 23:
                        image23.Image = new Bitmap(ofd.FileName);
                        break;
                    case 24:
                        image24.Image = new Bitmap(ofd.FileName);
                        break;
                    case 25:
                        image25.Image = new Bitmap(ofd.FileName);
                        break;
                    case 26:
                        image26.Image = new Bitmap(ofd.FileName);
                        break;
                    case 27:
                        image27.Image = new Bitmap(ofd.FileName);
                        break;
                    case 28:
                        image28.Image = new Bitmap(ofd.FileName);
                        break;
                    case 29:
                        image29.Image = new Bitmap(ofd.FileName);
                        break;
                    case 30:
                        image30.Image = new Bitmap(ofd.FileName);
                        break;
                    case 31:
                        image31.Image = new Bitmap(ofd.FileName);
                        break;
                    case 32:
                        image32.Image = new Bitmap(ofd.FileName);
                        break;
                    case 33:
                        image33.Image = new Bitmap(ofd.FileName);
                        break;
                }
            }
        }

        static int level = 0;
        static int lvl2_word_counter = 0; // Счётчик слов 2 уровня (для ограниченик в 3 слова 2 уровня к одному слову 1 уровня)
        private void button1_Click(object sender, EventArgs e) // Кнопка добавить.
        {
            if (textBox1.Text != "")
            {
                switch(level)
                {
                    case 0:
                        listBox1.Items.Add(textBox1.Text);
                        counter_for_images++;
                        // Вы хотите добавить картинку?
                        // Если да, то (ИЛИ НА НОВУЮ КНОПКУ НАЗНАЧИТЬ РИСОВАНИЕ КАРТИНОК).
                        printImages();
                        // -----------
                        message.Text = "Введите слова-ассоциации!";
                        level++;
                        break;
                    case 1:
                        if (listBox1.Items.Count < 9)
                        {
                            listBox1.Items.Add(textBox1.Text);
                            counter_for_images++;
                            // Вы хотите добавить картинку?
                            // Если да, то
                            printImages();
                            // -----------
                            linkLabel1.Text = "Хочу ввести слова 2 уровня!";
                            linkLabel1.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Вы больше не можете вводить слова 1 уровня!");
                        }
                        break;
                    case 2:
                        if (lvl2_word_counter < 3)
                        {
                            listBox1.Items.Add(textBox1.Text);
                            counter_for_images++;
                            printImages();
                            lvl2_word_counter++;
                        } 
                        else
                        {
                            MessageBox.Show("Нельзя добавить больше 3 ассоциаций к одному слову!");
                        }
                        break;
                }
                textBox1.Text = "";
            }
        }

        // КОСТЫЛИ -- КАК БЕЗ НИХ?
        int[] index = { 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int i = 1;
        int j = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch(level)
            {
                case 1:
                    message.Text = "Введите ассоциацию к" + " " + listBox1.Items[i].ToString();
                    linkLabel1.Text = "Ввести ассоциацию к следующему слову!";

                    index[j] = listBox1.Items.Count; // Сохраняем в массив индекс (переход с 1 на 2 lvl).
                    level = 2;
                    i++;
                    j++;
                    break;
                case 2:
                    if (index[0] != i)
                    {
                        message.Text = "Введите ассоциацию к" + " " + listBox1.Items[i].ToString();
                        index[j] = listBox1.Items.Count; // Сохраняем в массив индекс (переход между словами во 2 lvl).
                        lvl2_word_counter = 0;
                        i++;
                        j++;

                        if (index[0] == i)
                        {
                            linkLabel1.Text = "";
                            linkLabel1.Enabled = false;
                        }
                    } 
                    else
                    {
                        MessageBox.Show("Дальше идут слова 2 уровня!");
                    }
                    break;
            }
        }
        void logic()
        {
            int x_min = 500;
            int y_min = 0;
            int x_max = Width;
            int y_max = Height;

            int[] x = { (x_min + (x_min + x_max) / 2) / 2, (x_min + x_max) / 2, (x_max + (x_min + x_max) / 2) / 2 }; // x для label (1lvl).
            int[] y = { (y_min + (y_min + y_max) / 2) / 2, (y_min + y_max) / 2, (y_max + (y_min + y_max) / 2) / 2 }; // y для label (1lvl). 


            int[] x2 = { (x_min + x[0]) / 2, (x[2] + x_max) / 2 };
            int[] y2 =
            {
                (y_min + ((y_min + y[0]) / 2)) / 2, (y_min + y[0]) / 2, (y[0] + ((y_min + y[0]) / 2)) / 2, // Для верхних label`od (2lvl).
                (y[0] + y[1]) / 2, y[1], (y[1] + y[2]) / 2, // Для label`ов по середине (2lvl). 
                (y[2] + ((y[2] + y_max) / 2)) / 2, (y[2] + y_max) / 2, (y_max + ((y[2] + y_max) / 2)) / 2 // Для нижних label`ов (2lvl).
            };

            if (label1.Text != "")
            {
                Graphics canvas = this.CreateGraphics();
                if (label2.Text != "")
                {
                    if (index[1] != 0)
                    {
                        switch (index[1] - index[0])
                        {
                            case 0: break;
                            case 1:
                                label10.Text = listBox1.Items[index[0]].ToString();
                                Pen pen1 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen1, x[0], y[0], x[0], y2[0]);
                                pen1.Dispose();
                                goto case 0;
                            case 2:
                                label11.Text = listBox1.Items[index[0] + 1].ToString();
                                goto case 1;
                            case 3:
                                label12.Text = listBox1.Items[index[0] + 2].ToString();
                                goto case 2;
                        }
                    }
                    else
                    {
                        switch (listBox1.Items.Count - index[1])
                        {
                            case 0: break;
                            case 1:
                                label10.Text = listBox1.Items[index[0]].ToString();
                                Pen pen1 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen1, x[0], y[0], x[0], y2[0]);
                                pen1.Dispose();
                                goto case 0;
                            case 2:
                                label11.Text = listBox1.Items[index[0] + 1].ToString();
                                goto case 1;
                            case 3:
                                label12.Text = listBox1.Items[index[0] + 2].ToString();
                                goto case 2;
                        }
                    }
                }
                if (label3.Text != "")
                {
                    if (index[2] != 0)
                    {
                        switch (index[2] - index[1])
                        {
                            case 0: break;
                            case 1:
                                label13.Text = listBox1.Items[index[1]].ToString();
                                Pen pen2 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen2, x[1], y[0], x[1], y2[0]);
                                pen2.Dispose();
                                goto case 0;
                            case 2:
                                label14.Text = listBox1.Items[index[1] + 1].ToString();
                                goto case 1;
                            case 3:
                                label15.Text = listBox1.Items[index[1] + 2].ToString();
                                goto case 2;
                        }
                    }
                    else
                    {
                        switch (listBox1.Items.Count - index[1])
                        {
                            case 0: break;
                            case 1:
                                label13.Text = listBox1.Items[index[1]].ToString();
                                Pen pen2 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen2, x[1], y[0], x[1], y2[0]);
                                pen2.Dispose();
                                goto case 0;
                            case 2:
                                label14.Text = listBox1.Items[index[1] + 1].ToString();
                                goto case 1;
                            case 3:
                                label15.Text = listBox1.Items[index[1] + 2].ToString();
                                goto case 2;
                        }
                    }
                }
                if (label4.Text != "")
                {
                    if (index[3] != 0)
                    {
                        switch (index[3] - index[2])
                        {
                            case 0: break;
                            case 1:
                                label16.Text = listBox1.Items[index[2]].ToString();
                                Pen pen3 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen3, x[2], y[0], x[2], y2[0]);
                                pen3.Dispose();
                                goto case 0;
                            case 2:
                                label17.Text = listBox1.Items[index[2] + 1].ToString();
                                goto case 1;
                            case 3:
                                label18.Text = listBox1.Items[index[2] + 2].ToString();
                                goto case 2;
                        }
                    }
                    else
                    {
                        switch (listBox1.Items.Count - index[2])
                        {
                            case 0: break;
                            case 1:
                                label16.Text = listBox1.Items[index[2]].ToString();
                                Pen pen3 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen3, x[2], y[0], x[2], y2[0]);
                                pen3.Dispose();
                                goto case 0;
                            case 2:
                                label17.Text = listBox1.Items[index[2] + 1].ToString();
                                goto case 1;
                            case 3:
                                label18.Text = listBox1.Items[index[2] + 2].ToString();
                                goto case 2;
                        }
                    }
                }
                if (label5.Text != "")
                {
                    if (index[4] != 0)
                    {
                        switch (index[4] - index[3])
                        {
                            case 0: break;
                            case 1:
                                label19.Text = listBox1.Items[index[3]].ToString();
                                Pen pen4 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen4, x[0], y2[3], x[0], y2[5]);
                                pen4.Dispose();
                                goto case 0;
                            case 2:
                                label20.Text = listBox1.Items[index[3] + 1].ToString();
                                goto case 1;
                            case 3:
                                label21.Text = listBox1.Items[index[3] + 2].ToString();
                                goto case 2;
                        }
                    }
                    else
                    {
                        switch (listBox1.Items.Count - index[3])
                        {
                            case 0: break;
                            case 1:
                                label19.Text = listBox1.Items[index[3]].ToString();
                                Pen pen4 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen4, x[0], y2[3], x[0], y2[5]);
                                pen4.Dispose();
                                goto case 0;
                            case 2:
                                label20.Text = listBox1.Items[index[3] + 1].ToString();
                                goto case 1;
                            case 3:
                                label21.Text = listBox1.Items[index[3] + 2].ToString();
                                goto case 2;
                        }
                    }
                }
                if (label6.Text != "")
                {
                    if (index[5] != 0)
                    {
                        switch (index[5] - index[4])
                        {
                            case 0: break;
                            case 1:
                                label22.Text = listBox1.Items[index[4]].ToString();
                                Pen pen5 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen5, x[2], y2[3], x[2], y2[5]);
                                pen5.Dispose();
                                goto case 0;
                            case 2:
                                label23.Text = listBox1.Items[index[4] + 1].ToString();
                                goto case 1;
                            case 3:
                                label24.Text = listBox1.Items[index[4] + 2].ToString();
                                goto case 2;
                        }
                    }
                    else
                    {
                        switch (listBox1.Items.Count - index[4])
                        {
                            case 0: break;
                            case 1:
                                label22.Text = listBox1.Items[index[4]].ToString();
                                Pen pen5 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen5, x[2], y2[3], x[2], y2[5]);
                                pen5.Dispose();
                                goto case 0;
                            case 2:
                                label23.Text = listBox1.Items[index[4] + 1].ToString();
                                goto case 1;
                            case 3:
                                label24.Text = listBox1.Items[index[4] + 2].ToString();
                                goto case 2;
                        }
                    }
                    
                }
                if (label7.Text != "")
                {
                    if (index[6] != 0)
                    {
                        switch (index[6] - index[5])
                        {
                            case 0: break;
                            case 1:
                                label25.Text = listBox1.Items[index[5]].ToString();
                                Pen pen6 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen6, x[0], y[2], x[0], y2[8]);
                                pen6.Dispose();
                                goto case 0;
                            case 2:
                                label26.Text = listBox1.Items[index[5] + 1].ToString();
                                goto case 1;
                            case 3:
                                label27.Text = listBox1.Items[index[5] + 2].ToString();
                                goto case 2;
                        }
                    }
                    else
                    {
                        switch (listBox1.Items.Count - index[5])
                        {
                            case 0: break;
                            case 1:
                                label25.Text = listBox1.Items[index[5]].ToString();
                                Pen pen6 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen6, x[0], y[2], x[0], y2[8]);
                                pen6.Dispose();
                                goto case 0;
                            case 2:
                                label26.Text = listBox1.Items[index[5] + 1].ToString();
                                goto case 1;
                            case 3:
                                label27.Text = listBox1.Items[index[5] + 2].ToString();
                                goto case 2;
                        }
                    }

                   
                }
                if (label8.Text != "")
                {
                    if (index[7] != 0)
                    {
                        switch (index[7] - index[6])
                        {
                            case 0: break;
                            case 1:
                                label28.Text = listBox1.Items[index[6]].ToString();
                                Pen pen7 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen7, x[1], y[2], x[1], y2[8]);
                                pen7.Dispose();
                                goto case 0;
                            case 2:
                                label29.Text = listBox1.Items[index[6] + 1].ToString();
                                goto case 1;
                            case 3:
                                label30.Text = listBox1.Items[index[6] + 2].ToString();
                                goto case 2;
                        }
                    } 
                    else
                    {
                        switch (listBox1.Items.Count - index[6])
                        {
                            case 0: break;
                            case 1:
                                label28.Text = listBox1.Items[index[6]].ToString();
                                Pen pen7 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen7, x[1], y[2], x[1], y2[8]);
                                pen7.Dispose();
                                goto case 0;
                            case 2:
                                label29.Text = listBox1.Items[index[6] + 1].ToString();
                                goto case 1;
                            case 3:
                                label30.Text = listBox1.Items[index[6] + 2].ToString();
                                goto case 2;
                        }
                    }
                }
                if (label9.Text != "")
                {
                    if (index[8] != 0)
                    {
                        switch (index[8] - index[7])
                        {
                            case 0: break;
                            case 1:
                                label31.Text = listBox1.Items[index[7]].ToString();
                                Pen pen8 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen8, x[2], y[2], x[2], y2[8]);
                                pen8.Dispose();
                                goto case 0;
                            case 2:
                                label32.Text = listBox1.Items[index[7] + 1].ToString();
                                goto case 1;
                            case 3:
                                label33.Text = listBox1.Items[index[7] + 2].ToString();
                                goto case 2;
                        }
                    } 
                    else
                    {
                        switch (listBox1.Items.Count - index[7])
                        {
                            case 0: break;
                            case 1:
                                label31.Text = listBox1.Items[index[7]].ToString();
                                Pen pen8 = new Pen(Color.Black, 2);
                                canvas.DrawLine(pen8, x[2], y[2], x[2], y2[8]);
                                pen8.Dispose();
                                goto case 0;
                            case 2:
                                label32.Text = listBox1.Items[index[7] + 1].ToString();
                                goto case 1;
                            case 3:
                                label33.Text = listBox1.Items[index[7] + 2].ToString();
                                goto case 2;
                        }
                    }
                    
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int x_min = 500;
            int y_min = 0;
            int x_max = Width;
            int y_max = Height;

            int[] x = { (x_min + (x_min + x_max) / 2) / 2, (x_min + x_max) / 2, (x_max + (x_min + x_max) / 2) / 2 }; // x для label (1lvl).
            int[] y = { (y_min + (y_min + y_max) / 2) / 2, (y_min + y_max) / 2, (y_max + (y_min + y_max) / 2) / 2 }; // y для label (1lvl).

            if (index[0] == 0)
            {
                Graphics canvas = this.CreateGraphics();
                switch (listBox1.Items.Count)
                {
                    case 1:
                        label1.Text = listBox1.Items[0].ToString();
                        break;
                    case 2:
                        label2.Text = listBox1.Items[1].ToString();
                        Pen pen1 = new Pen(Color.Red, 4);
                        canvas.DrawLine(pen1, x[1], y[1], x[0], y[0]);
                        pen1.Dispose();
                        goto case 1;
                    case 3:
                        label3.Text = listBox1.Items[2].ToString();
                        Pen pen2 = new Pen(Color.Green, 4);
                        canvas.DrawLine(pen2, x[1], y[1], x[1], y[0]);
                        pen2.Dispose();
                        goto case 2;
                    case 4:
                        label4.Text = listBox1.Items[3].ToString();
                        Pen pen3 = new Pen(Color.Black, 4);
                        canvas.DrawLine(pen3, x[1], y[1], x[2], y[0]);
                        pen3.Dispose();
                        goto case 3;
                    case 5:
                        label5.Text = listBox1.Items[4].ToString();
                        Pen pen4 = new Pen(Color.Blue, 4);
                        canvas.DrawLine(pen4, x[1], y[1], x[0], y[1]);
                        pen4.Dispose();
                        goto case 4;
                    case 6:
                        label6.Text = listBox1.Items[5].ToString();
                        Pen pen5 = new Pen(Color.Yellow, 4);
                        canvas.DrawLine(pen5, x[1], y[1], x[2], y[1]);
                        pen5.Dispose();
                        goto case 5;
                    case 7:
                        label7.Text = listBox1.Items[6].ToString();
                        Pen pen6 = new Pen(Color.Aquamarine, 4);
                        canvas.DrawLine(pen6, x[1], y[1], x[0], y[2]);
                        pen6.Dispose();
                        goto case 6;
                    case 8:
                        label8.Text = listBox1.Items[7].ToString();
                        Pen pen7 = new Pen(Color.Bisque, 4);
                        canvas.DrawLine(pen7, x[1], y[1], x[1], y[2]);
                        pen7.Dispose();
                        goto case 7;
                    case 9:
                        label9.Text = listBox1.Items[8].ToString();
                        Pen pen8 = new Pen(Color.Chocolate, 4);
                        canvas.DrawLine(pen8, x[1], y[1], x[2], y[2]);
                        pen8.Dispose();
                        goto case 8;
                }
            }
            if (index[0] != 0)
            {
                Graphics canvas = this.CreateGraphics();
                // Если есть слова 2 уровня!
                switch (index[0])
                {
                    case 1:
                        label1.Text = listBox1.Items[0].ToString();
                        logic();
                        break;
                    case 2:
                        label2.Text = listBox1.Items[1].ToString();
                        Pen pen1 = new Pen(Color.Red, 4);
                        canvas.DrawLine(pen1, x[1], y[1], x[0], y[0]);
                        pen1.Dispose();
                        goto case 1;
                    case 3:
                        label3.Text = listBox1.Items[2].ToString();
                        Pen pen2 = new Pen(Color.Green, 4);
                        canvas.DrawLine(pen2, x[1], y[1], x[1], y[0]);
                        pen2.Dispose();
                        goto case 2;
                    case 4:
                        label4.Text = listBox1.Items[3].ToString();
                        Pen pen3 = new Pen(Color.Black, 4);
                        canvas.DrawLine(pen3, x[1], y[1], x[2], y[0]);
                        pen3.Dispose();
                        goto case 3;
                    case 5:
                        label5.Text = listBox1.Items[4].ToString();
                        Pen pen4 = new Pen(Color.Blue, 4);
                        canvas.DrawLine(pen4, x[1], y[1], x[0], y[1]);
                        pen4.Dispose();
                        goto case 4;
                    case 6:
                        label6.Text = listBox1.Items[5].ToString();
                        Pen pen5 = new Pen(Color.Yellow, 4);
                        canvas.DrawLine(pen5, x[1], y[1], x[2], y[1]);
                        pen5.Dispose();
                        goto case 5;
                    case 7:
                        label7.Text = listBox1.Items[6].ToString();
                        Pen pen6 = new Pen(Color.Aquamarine, 4);
                        canvas.DrawLine(pen6, x[1], y[1], x[0], y[2]);
                        pen6.Dispose();
                        goto case 6;
                    case 8:
                        label8.Text = listBox1.Items[7].ToString();
                        Pen pen7 = new Pen(Color.Bisque, 4);
                        canvas.DrawLine(pen7, x[1], y[1], x[1], y[2]);
                        pen7.Dispose();
                        goto case 7;
                    case 9:
                        label9.Text = listBox1.Items[8].ToString();
                        Pen pen8 = new Pen(Color.Chocolate, 4);
                        canvas.DrawLine(pen8, x[1], y[1], x[2], y[2]);
                        pen8.Dispose();
                        goto case 8;
                }
            }
        }
    }
}
