using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Filters
{
    public partial class Form1 : Form
    {
        Stack<Bitmap> bitmapStack = new Stack<Bitmap>();
        Bitmap image;
        bool haveBackup = false;
        bool isBusy = false;
        private structElement currentStructElement = structElement.Cube;
        private int structElementSize = 3;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(Enum.GetNames(typeof(structElement)));
            comboBox1.SelectedIndex = 0;

            structSizeNumeric.Minimum = 0;
            structSizeNumeric.Maximum = 100;
            structSizeNumeric.Value = 5;
            structSizeNumeric.Increment = 2; 
        }

        private void SetBusy(bool busy)
        {
            isBusy = busy;
            menuStrip1.Enabled = !busy;
        }

        private void SetBackup()
        {
            bitmapStack.Push(image);
            haveBackup = true;
        }

        private void verifBackup()
        {
            haveBackup = bitmapStack.Count != 0;
            button2.Enabled = haveBackup;
        }

        private void GetBackup()
        {
            image = bitmapStack.Pop();
            pictureBox1.Image = image;
            pictureBox1.Refresh();
            verifBackup();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void открToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();

                bitmapStack.Clear();
                verifBackup();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                saveFileDialog.Title = "Сохранить изображение";
                saveFileDialog.FileName = "image";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        case 2:
                            image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case 3:
                            image.Save(filePath, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                    }

                    MessageBox.Show("Изображение успешно сохранено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Нет изображения для сохранения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SetBackup();
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
            {
                image = newImage;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
                verifBackup();
            }
            SetBusy(false);
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GetBackup();
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрГауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void чБToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void повыситьЯркостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new IncreaseBrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрСобеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new SobelFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void повыситьРезкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void тиснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new EmbossingFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void переносВправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new MoveRightFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сдвигВлевоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new MoveLeftFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void поворотНа90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new Rotate90DegreesFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void вертикальныеВолныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new VerticalWaveFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void горизонтальныеВолныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new HorizontalWaveFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void стеклоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new GlassFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеВДвиженииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new MotionBlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void щарраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new ScharraFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void прюитаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new PruittaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void расширениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new DilationFilter(currentStructElement, structElementSize);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            structElementSize = (int)structSizeNumeric.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentStructElement = (structElement)comboBox1.SelectedIndex;
        }

        private void эрозияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new ErosionFilter(currentStructElement, structElementSize);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void открытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new OpeningFilter(currentStructElement, structElementSize);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void закрытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new ClosingFilter(currentStructElement, structElementSize);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new TopHatFilter(currentStructElement, structElementSize);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void медианныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void линейноеРастяжениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new LinearStretch();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void серыйМирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new GrayWorldFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new Assignment(15);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBusy(true);
            Filters filter = new Assignment2();
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}