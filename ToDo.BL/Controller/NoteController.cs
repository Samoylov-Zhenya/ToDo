using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using ToDo.BL.Model;

namespace ToDo.BL.Controller
{
    internal class NoteController
    {
        #region --- Поля ---
        // небезопасно List<>
        public List<Note> Notes { get; set; }
        #endregion

        #region --- Конструктор ---
        public NoteController()
        {
            Notes = GetNotesData();
        }
        
        /*public NoteController(string str) : this()
        {
            var CurrentNote = new Note(Notes.Count, 100, str);
            Notes.Add(CurrentNote);
            SetNotesData();
        }*/
        /*public NoteController(int Id,string txt) : this()
        {
            var CurrentNote = new Note(Id, 100, txt);
            Notes.Add(CurrentNote);
            SetNotesData();
        }*/
        #endregion

        #region --- Сериализация JSON (Set/Get)NotesData---
        public void SetNotesData()
        {
            // сохранение данных
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Note>));

            using (var file = new FileStream("note.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(file, Notes);
            }
        }

        private List<Note> GetNotesData()
        {
            // чтение данных
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Note>));

            using (var file = new FileStream("note.json", FileMode.OpenOrCreate))
            {
                //if() cltkfnm yjhvfkmyj
                if (jsonFormatter.ReadObject(file) is List<Note> Notes)
                {
                    return Notes;
                }
                else
                {
                    return new List<Note>();
                }
            }
        }
        #endregion


    }
}
