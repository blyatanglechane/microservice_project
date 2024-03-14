using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microservice_project.Accounts
{
    // Класс реализовывает интерфейс IAccounts
    class User : IAccounts
    {
        public string Name;
        public string Surname;
        public string Patronymic;
        public DateTime DateOfBirth; 
        public string CardNumber; 
        public string address; 
        public string pick_upPoint;
        public DateTime AccountCreationDate; 
        string _login; 
        string _password;

        // Публичные свойства для логина и пароля
        public string Login { get { return _login; } }
        public string Password { get { return _password; } }

        // Конструктор класса
        public User(string Name, string Surname, string Patronymic, DateTime DateOfBirth, string CardNumber, string address, string pick_upPoint, DateTime AccountCreationDate, string login, string password) 
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.DateOfBirth = DateOfBirth;
            this.CardNumber = CardNumber;
            this.address = address;
            this.pick_upPoint = pick_upPoint;
            this.AccountCreationDate = AccountCreationDate;
            _login = login;
            _password = password;
        }

        // Информация о клиенте
        public void CustomerInformation()
        {
            Console.WriteLine("Информация о клиенте:\n" +
                   "ФИО: " + Surname + " " + Name + " " + Patronymic + "\n" +
                   "Дата рождения: " + DateOfBirth + "\n" +
                   "Номер привязанной карты: " + CardNumber + "\n" +
                   "Адрес проживания: " + address + "\n" +
                   "Указанный адрес пункта выдачи: " + pick_upPoint + "\n" + 
                   "Дата создания учётной записи: " + AccountCreationDate + "\n");
        }

        // Оставить заявку на интернет заказ
        public bool SubmitYourApplication()
        {
            return false;
        }

        // Выйти из учётной записи
        public bool LogOutOfYourAccount()
        {
            return true;
        }
    }
}
