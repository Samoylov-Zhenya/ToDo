using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ToDo.BL.Model;
using System.Text.Json.Serialization;

namespace ToDo.BL.Controller
{
    internal class UserController
    {
        #region --- Поля ---
        // небезопасно List<>
        public List<User> Users { get; }
        #endregion
        #region --- Конструктор ---
        public UserController()
        {
            Users = GetUsersData();
        }
        /*private ~UserController()
        {
            SetUsersData();
        }*/
        #endregion
        #region --- Методы ---
        /// <summary>
        /// Сохранение данных.
        /// </summary>
        public void SetUsersData()
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<User>));

            using (var file = new FileStream("user.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(file, Users);
            }
        }

        /// <summary>
        /// Чтение данных.
        /// </summary>
        /// <returns></returns>
        private List<User> GetUsersData()
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<User>));

            using (var file = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                //var newUsers = jsonFormatter.ReadObject(file) as List<User>;

                if (jsonFormatter.ReadObject(file) is List<User> Users)
                {
                    return Users;
                }
                else
                {
                    return new List<User>();
                }

                /*if (newUsers != null)
                {
                    foreach (var student in newUsers)
                    {
                        Console.WriteLine(student);
                    }
                }*/
            }





            // TODO: перейти на XML или JSON
            /*var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                //if (fs.Length>0 && formatter.Deserialize(fs) is List<User> users)
                if (formatter.Deserialize(fs) is List<User> users)
                {
                    return users;
                }
                else
                {
                    return new List<User>();
                }
                // TODO: если пользователя не прочитали
            }*/
        }

        #endregion
    }
}
