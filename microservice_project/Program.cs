using System.Collections.Specialized;
using System.Drawing;
using System.Net;
using microservice_project.Accounts;

namespace microservice_project
{
    // просто создание репозитория
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            // Создаём пользователей
            User user1 = new User("Алексей", "Казимиров", "Александрович", new DateTime(2003, 11, 4), "0000000000000000", "Астраханская область, город Ступино, пер. Сталина, 99", "Астраханская область, город Ступино, улица Горького, 21", new DateTime(2023, 06, 23), "Alex", "123456");
            User user2 = new User("Иван", "Петров", "Сергеевич", new DateTime(2002, 5, 12), "1111222233334444", "Московская область, город Зеленоград, ул. Ленина, 10", "Московская область, город Зеленоград, к339А", new DateTime(2023, 06, 25), "IvanP", "qwerty123");
            User user3 = new User("Мария", "Иванова", "Алексеевна", new DateTime(2004, 8, 20), "5555666677778888", "Санкт-Петербург, ул. Невская, д.5, кв.10", "Санкт-Петербург, Стремянная улица, 2 / 4", new DateTime(2023, 06, 27), "MariaI", "password123");

            //while (true)
            //{
            //    Console.WriteLine("Добрый день!\nВведите логин и пароль для входа в учётную запись:\n");
            //    string loginNow = Console.ReadLine();
            //    string passwordNow = Console.ReadLine();
            //    if (loginNow == user1.Login && user1.Password == passwordNow)
            //    {
            //        Console.WriteLine("Аутентификация прошла успешно");
            //        Console.WriteLine("Выберите операцию, которую хотите выполнить:\n" +
            //            "1. Информация об учётной записи.\n" +
            //            "2. Оставить заявку на заказ.\n" +
            //            "3. Выйти из учётной записи.\n");
            //        int InputUser;
            //        while (int.TryParse(Console.ReadLine(), out InputUser) && InputUser != 3)
            //        {
            //            switch (InputUser)
            //            {
            //                case 1:
            //                    Console.WriteLine("Информация об учётной записи:\n " +
            //                        "ФИО:" + user1.Surname + " " + user1.Name + " " + user1.Patronymic + "\n" +
            //                        "Дата рождения: " + user1.DateOfBirth + "\n" +
            //                        "Номер привязанной карты: " + user1.CardNumber + "\n"
            //                        + "Адрес проживания: " + user1.address + "\n" +
            //                        "Адрес пункта выдачи заказов: " + user1.pick_upPoint + "\n" +
            //                        "Дата создания аккаунта: " + user1.AccountCreationDate + "\n");
            //                    break;
            //                case 2:

            //                    break;
            //                case 3:
            //                    break;
            //                default:
            //                    Console.WriteLine("Неизвестная операция");
            //                    break;

            //            }
            //        }
            //    }
            //    else if (loginNow == user2.Login && user2.Password == passwordNow)
            //    {
            //        Console.WriteLine("Аутентификация прошла успешно");
            //        Console.WriteLine("Выберите операцию, которую хотите выполнить:\n" +
            //            "1. Информация об учётной записи.\n" +
            //            "2. Оставить заявку на заказ.\n" +
            //            "3. Выйти из учётной записи.\n");
            //        int InputUser;
            //        while (int.TryParse(Console.ReadLine(), out InputUser) && InputUser != 3)
            //        {
            //            switch (InputUser)
            //            {
            //                case 1:
            //                    Console.WriteLine("Информация об учётной записи:\n " +
            //                        "ФИО:" + user2.Surname + " " + user2.Name + " " + user2.Patronymic + "\n" +
            //                        "Дата рождения: " + user2.DateOfBirth + "\n" +
            //                        "Номер привязанной карты: " + user2.CardNumber + "\n"
            //                        + "Адрес проживания: " + user2.address + "\n" +
            //                        "Адрес пункта выдачи заказов: " + user2.pick_upPoint + "\n" +
            //                        "Дата создания аккаунта: " + user2.AccountCreationDate + "\n");
            //                    break;
            //                case 2:

            //                    break;
            //                case 3:
            //                    break;
            //                default:
            //                    Console.WriteLine("Неизвестная операция");
            //                    break;

            //            }
            //        }
            //    }
            //    else if (loginNow == user3.Login && user3.Password == passwordNow)
            //    {
            //        Console.WriteLine("Аутентификация прошла успешно");
            //        Console.WriteLine("Выберите операцию, которую хотите выполнить:\n" +
            //            "1. Информация об учётной записи.\n" +
            //            "2. Оставить заявку на заказ.\n" +
            //            "3. Выйти из учётной записи.\n");
            //        int InputUser;
            //        while (int.TryParse(Console.ReadLine(), out InputUser) && InputUser != 3)
            //        {
            //            switch (InputUser)
            //            {
            //                case 1:
            //                    Console.WriteLine("Информация об учётной записи:\n " +
            //                        "ФИО:" + user3.Surname + " " + user3.Name + " " + user3.Patronymic + "\n" +
            //                        "Дата рождения: " + user3.DateOfBirth + "\n" +
            //                        "Номер привязанной карты: " + user3.CardNumber + "\n"
            //                        + "Адрес проживания: " + user3.address + "\n" +
            //                        "Адрес пункта выдачи заказов: " + user3.pick_upPoint + "\n" +
            //                        "Дата создания аккаунта: " + user3.AccountCreationDate + "\n");
            //                    break;
            //                case 2:

            //                    break;
            //                case 3:
            //                    break;
            //                default:
            //                    Console.WriteLine("Неизвестная операция");
            //                    break;

            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Неверно введён логин или пароль");
            //    }
            //}
        }
    }
}
///////////////////////////////////////////