using microservice_project.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Data.SqlClient;

namespace microservice_project
{
    public partial class LoginForm : Form
    {
        // Подключение базы данных
        MSDatabaseUser dataBase = new MSDatabaseUser();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            // Сохраняем введённые данные логина и пароля в переменные
            var loginUser = LoginInput.Text;
            var passwordUser = passwordInput.Text;

            // Пишем строки нужные для работы с БД
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            // Строка для сохранения SQL запроса. Ищем пользователя с введённым логином и паролем
            string querystring = $"SELECT * FROM UserTable WHERE _login = '{loginUser}' AND _password = '{passwordUser}'";

            // Команда для запуска запроса, передаём строку запроса и строку подключения
            SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getConnection());

            // Эта строка устанавливает объект команды в качестве команды выборки (select command) для объекта адаптера данных (data adapter)
            adapter.SelectCommand = sqlCommand;

            // Эта строка выполняет команду выборки, представленную объектом адаптера данных, и заполняет результаты выполнения запроса в объект DataTable
            adapter.Fill(table);

            // Если результат запроса выдал нам одну строку, значит мы успешно вошли, в ином
            // случае мы выводим ошибку
            if (table.Rows.Count == 1) 
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // После успешной авторизации мы на время прячем окно с интернет магазином
                Form OnlineStore = new Form();
                this.Hide();

                // Показываем окно, что мы успешно вошли и запускаем вторую форму с интернет магазином
                OnlineStore.ShowDialog();
                this.Show();

            }
            else MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
