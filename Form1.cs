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
using MySql.Data.MySqlClient;

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
            labelRegLog.Hide();
            labelRegPass.Hide();
            RegLogField.Hide();
            RegPassField.Hide();
            PozImage.Hide();
            Generate.Hide();
            SexCheckBox.Hide();
            OralCheckBox.Hide();
            buttonRegister.Hide();
            labelMin.Hide();
            labelSec.Hide();
            labelMs.Hide();
            Poses = new PoseManager();
            labelMin.Text = "00 :";
            labelSec.Text = "00 :";
            labelMs.Text = "00";
            timer1.Interval = 1;
        }
        private int ms, sec, min;

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
            timer1.Enabled = false;
            labelMin.Hide();
            labelSec.Hide();
            labelMs.Hide();
        }

        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnect());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                PozImage.Show();
                Generate.Show();
                SexCheckBox.Show();
                OralCheckBox.Show();
                labelMin.Show();
                labelSec.Show();
                labelMs.Show();
                loginField.Hide();
                passField.Hide();
                buttonSignIn.Hide();
                buttonSignOut.Hide();
                labelLogin.Hide();
                labelPass.Hide();
                LogoTextImage.Hide();
                MessageBox.Show("Yes");
            }
            else
                MessageBox.Show("No");
            
        }

        private void buttonSingOut_Click(object sender, EventArgs e)
        {
            loginField.Hide();
            passField.Hide();
            labelLogin.Hide();
            labelPass.Hide();
            buttonSignIn.Hide();
            buttonSignOut.Hide();
            RegLogField.Show();
            RegPassField.Show();
            labelRegPass.Show();
            labelRegLog.Show();
            buttonRegister.Show();
        }

        public Boolean isUserExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnect());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = RegLogField.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This login already exists!");
                return true;
            }
            else
            return false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (RegLogField.Text == "")
            {
                MessageBox.Show("Enter login!");
                return;
            }
            if (RegPassField.Text == "")
            {
                MessageBox.Show("Enter password!");
                return;
            }

            if (isUserExists())
                return;

            buttonRegister.Hide();
            labelRegLog.Hide();
            labelRegPass.Hide();
            RegLogField.Hide();
            RegPassField.Hide();
            loginField.Show();
            passField.Show();
            labelLogin.Show();
            labelPass.Show();
            buttonSignIn.Show();
            buttonSignOut.Show();
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`) VALUES (@login, @pass)", db.getConnect());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = RegLogField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = RegPassField.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Account has been created.");
            else
                MessageBox.Show("Account was not created.");
            db.closeConnection();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            LogoTextImage.Hide();
            BackButton.Show();
            PozImage.Show();
            labelMin.Show();
            labelSec.Show();
            labelMs.Show();
            if (timer1.Enabled)
            {
                min = 0;
                sec = 0;
                ms = 0;
            }
            else
                timer1.Enabled = true;

            if (SexCheckBox.Checked && OralCheckBox.Checked)
            {
                PozImage.Image = Poses.GetRandomBitmap(PoseType.Both);
            }
            else if (SexCheckBox.Checked)
            {
                PozImage.Image = Poses.GetRandomBitmap(PoseType.Sex);
            }
            else if (OralCheckBox.Checked)
            {
                PozImage.Image = Poses.GetRandomBitmap(PoseType.Oral);
            }
            else
            {
                PozImage.Hide();
                timer1.Enabled = true;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ms == 0)
            {
                if (sec == 0)
                {
                    if (min == 0)
                        min = 03;
                    else
                        min--;
                    sec = 59;
                } else
                    sec--;
                ms = 99;
            }else
                ms--;
            if (min.ToString().Length == 1)
                labelMin.Text = "0" + min.ToString() + " : ";
            else
                labelMin.Text = min.ToString();
            if (sec.ToString().Length == 1)
                labelSec.Text = "0" + sec.ToString();
            else
                labelSec.Text = sec.ToString() + " : ";
            if (ms.ToString().Length == 1)
                labelMs.Text = "0" + ms.ToString();
            else
                labelMs.Text = ms.ToString();
        }
    }
}
