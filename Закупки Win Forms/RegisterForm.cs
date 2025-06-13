using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;
using System.Drawing.Text;

namespace Закупки_Win_Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);

            userNameField.Text = "Введите имя"; // deafault consistance of field
            userNameField.ForeColor = Color.Gray;

            userSurnameField.Text = "Введите фамилию"; // deafault consistance of field
            userSurnameField.ForeColor = Color.Gray;

            loginField.Text = "Введите логин"; // deafault consistance of field
            userSurnameField.ForeColor = Color.Gray;

            passField.Text = "Введите пароль"; // deafault consistance of field
            userSurnameField.ForeColor = Color.Gray;

        }

        private void closeButton_Click(object sender, EventArgs e) // close button activity
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

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string name = userNameField.Text.Trim();
            string surname = userSurnameField.Text.Trim();
            string login = loginField.Text.Trim();
            string password = passField.Text.Trim();

            // Проверяем, не используются ли значения по умолчанию
            if (name == "Введите имя" || surname == "Введите фамилию" ||
                login == "Введите логин" || password == "Введите пароль")
            {
                MessageBox.Show("Поля не должны содержать значения по умолчанию.");
                return;
            }

            if (IsUserExists())
                return;
            // Проверяем, что поля не пустые
            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(login) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Все поля должны быть заполнены.");
                return;
            }
            try
            {
                db.openConnnection();
                {
                    //conn.Open();
                    // SQL-запрос с параметрами
                    string sql = @"INSERT INTO users (login, password, name, surname) VALUES (@login, @password, @name, @surname);";

                    using (var cmd = new NpgsqlCommand(sql, db.getConnection()))
                    {
                        // Добавляем параметры
                        cmd.Parameters.AddWithValue("login", login);
                        cmd.Parameters.AddWithValue("password", password);
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("surname", surname);

                        // Выполняем запрос
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Регистрация успешна!");
                            this.Close(); // Закрываем форму
                        }
                        else
                        {
                            MessageBox.Show("Ошибка регистрации. Попробуйте снова.");
                        }
                    }
                }
                db.closeConnnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }
        bool passVisionOnRegForm = true;               // переменная для видимости пароля
        private void passwordPictureBox_Click(object sender, EventArgs e) // отображение и скрытие пароля
        {
            if (passVisionOnRegForm)
            {
                passField.UseSystemPasswordChar = false;
                passVisionOnRegForm = false;
            }
            else
            {
                passField.UseSystemPasswordChar = true;
                passVisionOnRegForm = true;
            }
        }

        public Boolean IsUserExists() //проверка наличия логина в БД, возвращает true, когда логин есть в системе и false - когда нет
        {
            String loginUser = loginField.Text; // record text from username field into sring loginUser
            String passUser = passField.Text; // record text from passwor field into sring passUser

            DB dB = new DB();

            DataTable table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users WHERE login = @uL", dB.getConnection()); // generate string to DB and point at database that has been used for work
            command.Parameters.Add("@uL", NpgsqlTypes.NpgsqlDbType.Text).Value = loginField.Text; // zaglushka 1

            adapter.SelectCommand = command; // run our command
            adapter.Fill(table); // filling into table

            if (table.Rows.Count > 0) // checking that user exist in query table
            {
                MessageBox.Show("Логин уже занят, введите другой");
                return true;
            }
            else
                return false;
        }

        private void autorisationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
