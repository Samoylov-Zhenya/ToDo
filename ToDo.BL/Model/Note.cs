using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ToDo.BL.Controller;

namespace ToDo.BL.Model
{
    [DataContract]
    public class Note
    {
        #region --- Поля  ---
        [DataMember]
        internal int Id;
        [DataMember]
        internal int IdUser;
        [DataMember]
        internal bool IsChecked;

        //ToDo : переделать на заголовок и текст заметки 
        [DataMember]
        string Text;
        #endregion

        #region --- Конструктор  ---
        public Note(int id, int idUser, string text, bool isChecked = false)
        {
            Id = id;
            IdUser = idUser;
            IsChecked = isChecked;
            Text = text;
        }
        #endregion

        #region --- Методы  ---
        public bool IsCheckedF()
        {
            return IsChecked;
        }
        public string TextF()
        {
            return Text;
        }
        public override string ToString()
        {
            /*return
                $"\nId\t{Id} " +
                $"\nIdUser\t{IdUser} " +
                $"\nIsChecked\t{IsChecked} " +
                $"\nText\t{Text} " +
                $"\nType\t{base.ToString()}";*/
            /*return
                $"\nId\t{Id} " +
                $"\nIdUser\t{IdUser} " +
                $"\nIsChecked\t{IsChecked} " +
                $"\nText\t{Text} ";*/
            return
                $"\nId:\t{Id}" +
                $"\tChec\t{IsChecked}" +
                $"\nText:\n{Text}";
        }
        #endregion
    }
}
