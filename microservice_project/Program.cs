using System.Collections.Specialized;
using System.Drawing;
using System.Net;
using microservice_project.Accounts;

namespace microservice_project
{
    // ������ �������� �����������
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            // ������ �������������
            User user1 = new User("�������", "���������", "�������������", new DateTime(2003, 11, 4), "0000000000000000", "������������ �������, ����� �������, ���. �������, 99", "������������ �������, ����� �������, ����� ��������, 21", new DateTime(2023, 06, 23), "Alex", "123456");
            User user2 = new User("����", "������", "���������", new DateTime(2002, 5, 12), "1111222233334444", "���������� �������, ����� ����������, ��. ������, 10", "���������� �������, ����� ����������, �339�", new DateTime(2023, 06, 25), "IvanP", "qwerty123");
            User user3 = new User("�����", "�������", "����������", new DateTime(2004, 8, 20), "5555666677778888", "�����-���������, ��. �������, �.5, ��.10", "�����-���������, ���������� �����, 2 / 4", new DateTime(2023, 06, 27), "MariaI", "password123");

            //while (true)
            //{
            //    Console.WriteLine("������ ����!\n������� ����� � ������ ��� ����� � ������� ������:\n");
            //    string loginNow = Console.ReadLine();
            //    string passwordNow = Console.ReadLine();
            //    if (loginNow == user1.Login && user1.Password == passwordNow)
            //    {
            //        Console.WriteLine("�������������� ������ �������");
            //        Console.WriteLine("�������� ��������, ������� ������ ���������:\n" +
            //            "1. ���������� �� ������� ������.\n" +
            //            "2. �������� ������ �� �����.\n" +
            //            "3. ����� �� ������� ������.\n");
            //        int InputUser;
            //        while (int.TryParse(Console.ReadLine(), out InputUser) && InputUser != 3)
            //        {
            //            switch (InputUser)
            //            {
            //                case 1:
            //                    Console.WriteLine("���������� �� ������� ������:\n " +
            //                        "���:" + user1.Surname + " " + user1.Name + " " + user1.Patronymic + "\n" +
            //                        "���� ��������: " + user1.DateOfBirth + "\n" +
            //                        "����� ����������� �����: " + user1.CardNumber + "\n"
            //                        + "����� ����������: " + user1.address + "\n" +
            //                        "����� ������ ������ �������: " + user1.pick_upPoint + "\n" +
            //                        "���� �������� ��������: " + user1.AccountCreationDate + "\n");
            //                    break;
            //                case 2:

            //                    break;
            //                case 3:
            //                    break;
            //                default:
            //                    Console.WriteLine("����������� ��������");
            //                    break;

            //            }
            //        }
            //    }
            //    else if (loginNow == user2.Login && user2.Password == passwordNow)
            //    {
            //        Console.WriteLine("�������������� ������ �������");
            //        Console.WriteLine("�������� ��������, ������� ������ ���������:\n" +
            //            "1. ���������� �� ������� ������.\n" +
            //            "2. �������� ������ �� �����.\n" +
            //            "3. ����� �� ������� ������.\n");
            //        int InputUser;
            //        while (int.TryParse(Console.ReadLine(), out InputUser) && InputUser != 3)
            //        {
            //            switch (InputUser)
            //            {
            //                case 1:
            //                    Console.WriteLine("���������� �� ������� ������:\n " +
            //                        "���:" + user2.Surname + " " + user2.Name + " " + user2.Patronymic + "\n" +
            //                        "���� ��������: " + user2.DateOfBirth + "\n" +
            //                        "����� ����������� �����: " + user2.CardNumber + "\n"
            //                        + "����� ����������: " + user2.address + "\n" +
            //                        "����� ������ ������ �������: " + user2.pick_upPoint + "\n" +
            //                        "���� �������� ��������: " + user2.AccountCreationDate + "\n");
            //                    break;
            //                case 2:

            //                    break;
            //                case 3:
            //                    break;
            //                default:
            //                    Console.WriteLine("����������� ��������");
            //                    break;

            //            }
            //        }
            //    }
            //    else if (loginNow == user3.Login && user3.Password == passwordNow)
            //    {
            //        Console.WriteLine("�������������� ������ �������");
            //        Console.WriteLine("�������� ��������, ������� ������ ���������:\n" +
            //            "1. ���������� �� ������� ������.\n" +
            //            "2. �������� ������ �� �����.\n" +
            //            "3. ����� �� ������� ������.\n");
            //        int InputUser;
            //        while (int.TryParse(Console.ReadLine(), out InputUser) && InputUser != 3)
            //        {
            //            switch (InputUser)
            //            {
            //                case 1:
            //                    Console.WriteLine("���������� �� ������� ������:\n " +
            //                        "���:" + user3.Surname + " " + user3.Name + " " + user3.Patronymic + "\n" +
            //                        "���� ��������: " + user3.DateOfBirth + "\n" +
            //                        "����� ����������� �����: " + user3.CardNumber + "\n"
            //                        + "����� ����������: " + user3.address + "\n" +
            //                        "����� ������ ������ �������: " + user3.pick_upPoint + "\n" +
            //                        "���� �������� ��������: " + user3.AccountCreationDate + "\n");
            //                    break;
            //                case 2:

            //                    break;
            //                case 3:
            //                    break;
            //                default:
            //                    Console.WriteLine("����������� ��������");
            //                    break;

            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("������� ����� ����� ��� ������");
            //    }
            //}
        }
    }
}
///////////////////////////////////////////