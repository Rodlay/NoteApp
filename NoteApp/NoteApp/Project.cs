using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс "Проект", в котором хранится список всех заметок.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список заметок.
        /// </summary>
        private List<Note> _notes;
        /// <summary>
        /// Возвращает и задаёт список.
        /// </summary>
        public List<Note> Notes
        {
            set { _notes = value; }
            get { return _notes; }
        }
    }
}
