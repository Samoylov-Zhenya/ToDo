using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.BL.Model
{
    [DataContract]
    public class User
    {
        #region --- Поля  ---
        [DataMember]
        public int Id;
        [DataMember]
        public string Name;
        [DataMember]
        public string Password; //TODO: хранить хеш.
        #endregion

        #region --- Конструктор  ---
        public User(int id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
        #endregion

        #region --- Методы  ---
        // TODO: перед релизом убрать.
        public override string ToString()
        {
            return
                $"\nID\t{Id} " +
                $"\nName\t{Name} " +
                $"\nPass\t{Password} " +
                $"\nType\t{base.ToString()}";
        }
        #endregion

    }
}
