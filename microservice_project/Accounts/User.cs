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
        string Name; string Surname; string Patronymic; DateTime DateOfBirth; string CardNumber; string address; string pick_upPoint;
        DateTime AccountCreationDate;

        // Конструктор класса
        public User(string Name, string Surname, string Patronymic, DateTime DateOfBirth, string CardNumber, string address, string pick_upPoint, DateTime AccountCreationDate) 
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.DateOfBirth = DateOfBirth;
            this.CardNumber = CardNumber;
            this.address = address;
            this.pick_upPoint = pick_upPoint;
            this.AccountCreationDate = AccountCreationDate;
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
