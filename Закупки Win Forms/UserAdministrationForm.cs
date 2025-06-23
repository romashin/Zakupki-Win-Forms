using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Закупки_Win_Forms
{
    public partial class UserAdministrationForm : Form
    {
        private DB db = new DB();
        private int selectedUserId = -1;

        private DataGridView dataGridViewUsers;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;

        public UserAdministrationForm()
        {
            
            InitializeForm();
            InitializeComponent();
            LoadUsers();
        }

        private void InitializeForm()
        {
            this.dataGridViewUsers = new DataGridView();
            this.textBoxLogin = new TextBox();
            this.textBoxPassword = new TextBox();
            this.textBoxName = new TextBox();
            this.textBoxSurname = new TextBox();
            this.buttonAdd = new Button();
            this.buttonEdit = new Button();
            this.buttonDelete = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();

            // dataGridViewUsers
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new Point(12, 12);
            this.dataGridViewUsers.Size = new Size(600, 300);

            // textBoxLogin
            this.textBoxLogin.Location = new Point(12, 320);
            this.textBoxLogin.Width = 150;
            this.textBoxLogin.PlaceholderText = "Логин";

            // textBoxPassword
            this.textBoxPassword.Location = new Point(170, 320);
            this.textBoxPassword.Width = 150;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.PlaceholderText = "Пароль";

            // textBoxName
            this.textBoxName.Location = new Point(330, 320);
            this.textBoxName.Width = 150;
            this.textBoxName.PlaceholderText = "Имя";

            // textBoxSurname
            this.textBoxSurname.Location = new Point(490, 320);
            this.textBoxSurname.Width = 150;
            this.textBoxSurname.PlaceholderText = "Фамилия";

            // buttonAdd
            this.buttonAdd.Location = new Point(12, 360);
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Click += buttonAdd_Click;

            // buttonEdit
            this.buttonEdit.Location = new Point(110, 360);
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.Click += buttonEdit_Click;

            // buttonDelete
            this.buttonDelete.Location = new Point(220, 360);
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.Click += buttonDelete_Click;

            // Form
            this.ClientSize = new Size(760, 400);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Text = "Администрирование пользователей";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private void LoadUsers() // загрузка таблицы
        {
            DB db = new DB();
            DataTable table = new DataTable();
            try
            {
                db.openConnnection();
                string query = "SELECT id, login, name, surname, email, regdate FROM users";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, db.getConnection()))
                {
                    //DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewUsers.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки пользователей: " + ex.Message);
            }
            finally
            {
                db.closeConnnection();
            }
        }

        private void ClearFields()
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            selectedUserId = -1;
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewUsers.SelectedRows[0];
                selectedUserId = Convert.ToInt32(row.Cells["id"].Value);
                textBoxLogin.Text = row.Cells["login"].Value.ToString();
                textBoxName.Text = row.Cells["name"].Value.ToString();
                textBoxSurname.Text = row.Cells["surname"].Value.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string name = textBoxName.Text.Trim();
            string surname = textBoxSurname.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Логин и пароль обязательны!");
                return;
            }

            try
            {
                db.openConnnection();
                string query = "INSERT INTO users (login, password, name, surname) VALUES (@login, @password, @name, @surname)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@name", (object)name ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@surname", (object)surname ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Пользователь успешно добавлен.");
                ClearFields();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления пользователя: " + ex.Message);
            }
            finally
            {
                db.closeConnnection();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Выберите пользователя для редактирования.");
                return;
            }

            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string name = textBoxName.Text.Trim();
            string surname = textBoxSurname.Text.Trim();

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Логин обязателен!");
                return;
            }

            try
            {
                db.openConnnection();
                string query = "UPDATE users SET login = @login, password = @password, name = @name, surname = @surname WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@name", (object)name ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@surname", (object)surname ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", selectedUserId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Пользователь обновлён.");
                ClearFields();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления пользователя: " + ex.Message);
            }
            finally
            {
                db.closeConnnection();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Выберите пользователя для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого пользователя?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    db.openConnnection();
                    string query = "DELETE FROM users WHERE id = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.getConnection()))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedUserId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Пользователь удалён.");
                    ClearFields();
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления пользователя: " + ex.Message);
                }
                finally
                {
                    db.closeConnnection();
                }
            }
        }
    }
}