using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BL.Model;

namespace ToDo.BL.Controller
{
    public class Controller
    {
        private NoteController NoteC { get; set; }
        private UserController UserC { get; set; }

        private User CurrentUser { get; set; }
        private Note NoteUser { get; set; }

        public string NameUser()
        {
            return CurrentUser.Name;
        }

        public Controller()
        {
            UserC = new UserController();
            NoteC = new NoteController();

            CurrentUser = null;
            NoteUser = null;
        }

        public bool IsLogIn(int id, string password)
        {
            if (IsExistsUser(id))
            {
                CurrentUser = UserC.Users.SingleOrDefault(u => u.Id == id && u.Password == password);
                if(CurrentUser == null)
                    return false;
                return true;
            }
            else
                return false;
        }

        public bool IsNewUser(int id, string name, string password)
        {
            if (IsExistsUser(id))
                return false;
            else
            {
                CurrentUser = new User(id, name, password);
                UserC.Users.Add(CurrentUser);
                UserC.SetUsersData();
                return true;
            }
        }


        public bool IsExistsUser()
        {
            if (CurrentUser == null)
                return true;
            else
                return false;
        }

        private bool IsExistsUser(int id)
        {
            if (UserC.Users.SingleOrDefault(u => u.Id == id) == null)
                return false;
            else
                return true;
        }


        public bool IsNewNote(string txt)
        {
            if (CurrentUser == null)
                return false;

            NoteUser = new Note(NoteC.Notes.Count, CurrentUser.Id, txt);
            NoteC.Notes.Add(NoteUser);
            NoteC.SetNotesData();
            return true;
        }
        //public (List<Note>, List<bool>) ListUserNotes()
        //{
        //   return (List<Note>, List<bool>);

        //}
        public List<Note> ListUserNotes()
        {
            /*List<Note> notes = new List<Note>();

            foreach (var item in NoteC.Notes)
            {
                if (item.IdUser == CurrentUser.Id)
                {
                    notes.Add(item);
                }
            }*/

            var notes = NoteC.Notes.Where(n =>
                                    n.IdUser == CurrentUser.Id
                                    ).ToList();
            return notes;
        }

        public bool IsCheckedNote(int id)
        {
            if (CurrentUser == null)
                return false;

            var index = NoteC.Notes.FindIndex((n) => n.Id == id && n.IdUser == CurrentUser.Id);
            if(index == -1)
                return false;
            NoteC.Notes[index].IsChecked = !NoteC.Notes[index].IsChecked;
            NoteC.SetNotesData();
            return true;
        }
    }
}
