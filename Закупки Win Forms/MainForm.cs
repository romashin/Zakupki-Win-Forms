using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Закупки_Win_Forms
{
   public partial class MainForm : Form
        {
            private DB db = new DB();

            public MainForm()
            {
                //InitializeComponent();
                InitializeComponents();
                CheckDatabaseConnection();
            }

            private void InitializeComponents() // определение элементов окна в коде
            {
                this.Text = "Закупки WinForms — Главное меню";
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Width = 500;
                this.Height = 750;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MaximizeBox = false;

                // === Приветствие ===
                Label labelWelcome = new Label
                {
                    Text = "Добро пожаловать!",
                    Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                    Location = new System.Drawing.Point(150, 30),
                    AutoSize = true
                };
                this.Controls.Add(labelWelcome);

                // === Кнопки ===
                int buttonWidth = 300;
                int buttonHeight = 40;
                int x = 100;
                int y = 100;

                Button btnSuppliersWriteable = new Button
                {
                    Text = "Поставщики (редактируемые)",
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new System.Drawing.Point(x, y)
                };
                btnSuppliersWriteable.Click += (sender, args) => OpenForm<SuppliersWriteableForm>();
                this.Controls.Add(btnSuppliersWriteable);
                y += 50;

                Button btnSuppliersReadOnly = new Button
                {
                    Text = "Поставщики (только чтение)",
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new System.Drawing.Point(x, y)
                };
                btnSuppliersReadOnly.Click += (sender, args) => OpenForm<SuppliersMainForm>();
                this.Controls.Add(btnSuppliersReadOnly);
                y += 50;

                Button btnSuppliersMainForm = new Button
                {
                    Text = "Поставщики (новая форма)",
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new System.Drawing.Point(x, y)
                };
                btnSuppliersMainForm.Click += (sender, args) => OpenForm<SuppliersWorkForm>();
                this.Controls.Add(btnSuppliersMainForm);
                y += 50;

                Button btnContracts = new Button
                {
                    Text = "Договоры",
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new System.Drawing.Point(x, y)
                };
                btnContracts.Click += (sender, args) => OpenForm<ContractWriteableForm>();
                this.Controls.Add(btnContracts);
                y += 50;

                Button btnInvoices = new Button
                {
                    Text = "Закрывающие документы",
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new System.Drawing.Point(x, y)
                };
                btnInvoices.Click += (sender, args) => OpenForm<InvoicesWriteableForm>();
                this.Controls.Add(btnInvoices);
                y += 50;

                Button btnPayments = new Button
                {
                    Text = "Платежные документы",
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new System.Drawing.Point(x, y)
                };
                btnPayments.Click += (sender, args) => OpenForm<PaymentOrdersWritableForm>();
                this.Controls.Add(btnPayments);
                y += 50;

                Button btnLoginForm = new Button
                {
                    Text = "Отобразить форму входа",
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new System.Drawing.Point(x, y)
                };
                btnLoginForm.Click += (sender, args) => OpenForm<LoginForm>();
                this.Controls.Add(btnLoginForm);
                y += 50;

                Button btnUserAdminForm = new Button
                {
                    Text = "Администирование пользователей",
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new System.Drawing.Point(x, y)
                };
                btnUserAdminForm.Click += (sender, args) => OpenForm<UserAdministrationForm>();
                this.Controls.Add(btnUserAdminForm);
                y += 50;

            Button btnRegister = new Button
                {
                    Text = "Регистрация нового пользователя",
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new System.Drawing.Point(x, y)
                };
                btnRegister.Click += (sender, args) => OpenForm<RegisterForm>();
                this.Controls.Add(btnRegister);
                y += 60;

                Button btnExit = new Button
                {
                    Text = "Выход",
                    Width = 150,
                    Height = 40,
                    Location = new System.Drawing.Point(x + 75, y)
                };
                btnExit.Click += (sender, args) => Application.Exit();
                this.Controls.Add(btnExit);

                // === Статус подключения к БД ===
                StatusStrip statusStrip = new StatusStrip();
                ToolStripStatusLabel statusLabel = new ToolStripStatusLabel();
                statusLabel.Name = "toolStripStatusConnection";
                statusLabel.Text = "Подключение к БД...";
                statusStrip.Items.Add(statusLabel);
                this.Controls.Add(statusStrip);
                statusStrip.Dock = DockStyle.Bottom;
            }

            private void CheckDatabaseConnection()
            {
                try
                {
                    db.openConnnection();
                    if (db.getConnection().State == ConnectionState.Open)
                    {
                        UpdateStatusBar("Соединение с БД установлено");
                    }
                    else
                    {
                        UpdateStatusBar("Ошибка соединения с БД");
                    }
                }
                catch (Exception ex)
                {
                    UpdateStatusBar("Ошибка подключения: " + ex.Message);
                }
                finally
                {
                    db.closeConnnection();
                }
            }

            private void UpdateStatusBar(string message)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is StatusStrip statusStrip)
                    {
                        var statusLabel = statusStrip.Items[0] as ToolStripStatusLabel;
                        if (statusLabel != null)
                        {
                            statusLabel.Text = message;
                        }
                    }
                }
            }

            private void OpenForm<T>() where T : Form, new()
            {
                T form = new T();
                form.Show();
            }
        
    }
}
