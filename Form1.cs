using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Collections;

namespace sourse
{

    public partial class Form1 : Form
    {
        public enum PoseType
        {
            Oral,
            Sex,
            Both
        }

        public class PoseManager
        {
            private List<Bitmap> OralBitmaps;
            private List<Bitmap> SexBitmaps;
            public PoseManager()
            {
                var oralManager = new ResourceManager("sourse.Resources.ResourceOral", this.GetType().Assembly);
                OralBitmaps = oralManager.GetResourceSet(CultureInfo.CurrentCulture, true, true).Cast<DictionaryEntry>().Select(x => (Bitmap)x.Value).ToList();

                var sexManager = new ResourceManager("sourse.Resources.ResourceSex", this.GetType().Assembly);
                SexBitmaps = sexManager.GetResourceSet(CultureInfo.CurrentCulture, true, true).Cast<DictionaryEntry>().Select(x => (Bitmap)x.Value).ToList();
            }

            public Bitmap GetRandomBitmap(PoseType type)
            {
                Random rnd = new Random();
                Bitmap a;
                if (type == PoseType.Sex)
                {
                    a = SexBitmaps[(rnd.Next(SexBitmaps.Count))];
                }
                else if (type == PoseType.Oral)
                {
                    a = OralBitmaps[(rnd.Next(OralBitmaps.Count))];
                }
                else
                {
                    int randomNum = rnd.Next(0, SexBitmaps.Count + OralBitmaps.Count);
                    if (randomNum < OralBitmaps.Count)
                    {
                        a = OralBitmaps[randomNum];
                    }
                    else
                    {
                        randomNum -= OralBitmaps.Count;
                        a = SexBitmaps[randomNum];
                    }
                }
                return a;
            }

            internal void GetRandomBitmap()
            {
                throw new NotImplementedException();
            }
        }

        private PoseManager Poses;

        public Form1()
        {
            
            InitializeComponent();
            BackButton.Hide();
            PozImage.Hide();
            Poses = new PoseManager();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.FromArgb(217, 97, 33);
        }

        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        Point lastPoint3;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint3.X;
                this.Top += e.Y - lastPoint3.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint3 = new Point(e.X, e.Y);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LogoImage.Show();
            LogoTextImage.Show();
            BackButton.Hide();
            PozImage.Hide();
            timer1.Stop();
            timeLabel.Text = "";
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            LogoImage.Hide();
            LogoTextImage.Hide();
            BackButton.Show();
            PozImage.Show();
            if (SexCheckBox.Checked && OralCheckBox.Checked)
            {
                PozImage.Image = Poses.GetRandomBitmap(PoseType.Both);
            }
            else if (SexCheckBox.Checked)
            {
                PozImage.Image = Poses.GetRandomBitmap(PoseType.Sex);
            }
            else
            {
                PozImage.Image = Poses.GetRandomBitmap(PoseType.Oral);
            }
            timeLeft = randomizer.Next(180, 600);
            timer1.Start();
        }

        Random randomizer = new Random();
        int timeLeft;


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft -= 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                Generate.Enabled = true;
            }
        }
    }
}
