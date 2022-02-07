using System;
using ToDo.BL.Controller;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BL.Model;

namespace ToDo.UI
{
    internal class Menu
    {
        private Controller controller;
        public Menu()
        {
            controller = new Controller();
        }
        public void Start()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Выберите действие (-h помощь): ");

                switch (Console.ReadLine())
                {
                    //case "-nua":
                    //    NewUserAdmin();
                    //    break;
                    //case "-aun":
                    //    AllUserlNotes();
                    //    break;

                    case "-an":
                        AllNotesUser();
                        break;
                    case "-si":
                        SignIn();
                        break;
                    case "-cn":
                        CheckedNote();
                        break;
                    case "-nu":
                        NewUser();
                        break;
                    case "-nn":
                        NewNote();
                        break;
                    case "-en":
                        break;

                    case "-h":
                        Hellp();
                        break;
                    case "-e":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
        }

        private void CheckedNote()
        {
            if (controller.IsExistsUser())
            {
                Hellper.PrintRedLine("Водите в систему.");
                return;
            }
            Console.Write("Id заметки состояние которой изменить: ");
            int id = Convert.ToInt32(Console.ReadLine()); //TODO: проверка

            if (controller.IsCheckedNote(id))
            {
                Hellper.PrintGreenLine("Изменения внесены :)");
            }
            else
            {
                Hellper.PrintRedLine("Что-то пошло нетак :(");
            }
        }

        private void NewNote()
        {
            if (controller.IsExistsUser())
            {
                Hellper.PrintRedLine("Водите в систему.");
                return;
            }
            Console.WriteLine("Что вы хотите запомнить: ");
            var str = Console.ReadLine();
            if (controller.IsNewNote(str))
            {
                Hellper.PrintGreenLine("Заметка создана.");
            }
            else
            {
                //ошибка
                Hellper.PrintRedLine("Водите в систему.");
            }
            //if (userController == null)
            //{
            //    hellper.PrintRed("Войдите в систему");
            //    return;
            //}

            //Console.WriteLine("Что вы хотите запомнить: ");
            //var str = Console.ReadLine();
            ////var noteController = new NoteController(userController.CurrentUser.Id, str);
        }

        private void AllNotesUser()
        {
            if (controller.IsExistsUser())
            {
                Hellper.PrintRedLine("Водите в систему.");
                return;
            }
            // TODO: если нет заметок
            var Notes = controller.ListUserNotes();
            if (Notes.Count == 0)
            {
                Hellper.PrintRedLine("У вас нет заметок. ");
                return;
            }
            foreach (var item in Notes)
            {
                Console.WriteLine(item);
            }
            /*if (controller.ListUserNotes() == null)
            {
                Hellper.PrintRed("Нет заметок :(");

            }*/

            //hellper.PrintRed("Пароль: ");
            //if (Console.ReadLine() != "qqq")
            //{
            //    return;
            //}
            //var noteController = new NoteController();

            //for (int i = 0; i < noteController.Notes.Count; i++)
            //{
            //    Console.WriteLine(noteController.Notes[i]);
            //}
        }

        private void NewUser()
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Имя: ");
            var name = Console.ReadLine();
            Console.Write("Пароль:");
            var password = Console.ReadLine();

            if (controller.IsNewUser(id, name, password))
            {
                Hellper.PrintGreenLine("Успешно создан новый пользователь.");
            }
            else
            {
                Hellper.PrintRedLine("Такой пользовател с таким Id уже сушествует.");
            }
        }

        private void SignIn()
        {
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine()); //TODO: проверка
            Console.Write("Пароль: ");
            var password = Console.ReadLine();

            if (controller.IsLogIn(id, password))
            {
                Hellper.PrintGreen("Здраствейте ");
                Console.Write(controller.NameUser());
                Hellper.PrintGreenLine(" вы вошли :)");
            }
            else
            {
                Hellper.PrintRedLine("Пользователь не найден :(");
                Console.WriteLine("Хотите зарегистрироваться? (-nu)");
            }
        }

        private void Hellp()
        {
            Console.WriteLine(
                            $"-li войти в систему\n" +
                            $"-nu новый пользователь\n" +
                            $"-nn новая заметка\n" +
                            $"-an вивести мои записки \n" +
                            $"-cn изменить состояние заметки (выполнить заметку)\n" +
                            $"-h  помощь\n" +
                            $"-e  выход\n"
                           );
        }





        private void AllUserlNotes()
        {
            //if (userController == null)
            //{
            //    hellper.PrintRed("Войдите в систему");
            //    return;
            //}

            //List<Note> notes = userController.UserlNotes();

            //if (notes == null)
            //{
            //    hellper.PrintRed("У вас нет заметок :(");
            //    return;
            //}
            //foreach (Note note in notes)
            //{
            //    Console.WriteLine(note);
            //}
        }

        private void NewUserAdmin()
        {
            //hellper.PrintRed("Пароль: ");
            //if (Console.ReadLine() != "qqq")
            //{
            //    return;
            //}
            //userController = new UserController(1111, "tq", "1111");
        }

        private void NewNoteAdmin()
        {
            //Console.Write("Text: ");
            //var str = Console.ReadLine();

            //var noteController = new NoteController(str);
        }
    }
}
