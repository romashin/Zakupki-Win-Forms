using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Закупки_Win_Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);
        }

        private void label1_Click(object sender, EventArgs e) // не знаю как удалить лишний созданный метод
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Blue;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text; // record text from username field into sring loginUser
            String passUser = passField.Text; // record text from passwor field into sring passUser

            DB dB = new DB();

            DataTable table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users WHERE login = @uL AND password = @uP", dB.getConnection()); // generate string to DB and point at database that has been used for work
            command.Parameters.Add("@uL", NpgsqlTypes.NpgsqlDbType.Text).Value = loginUser; // zaglushka 1
            command.Parameters.Add("@uP", NpgsqlTypes.NpgsqlDbType.Text).Value = passUser;  // zaglushka 2

            adapter.SelectCommand = command; // run our command
            adapter.Fill(table); // filling into table


            if (table.Rows.Count > 0) // checking that user exest in query table
            {
                //MessageBox.Show("Yes");
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
                MessageBox.Show("Указан неверный пароль");
        }

        bool passVisionOnLoginForm = true;               // переменная для видимости пароля
        private void passwordPictureBox_Click(object sender, EventArgs e) // отображение и скрытие пароля
        {
            if (passVisionOnLoginForm)
            {
                passField.UseSystemPasswordChar = false;
                passVisionOnLoginForm = false;
            }
            else
            {
                passField.UseSystemPasswordChar = true;
                passVisionOnLoginForm = true;
            }

        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
