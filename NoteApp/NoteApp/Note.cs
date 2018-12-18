using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс "заметка", содержащая всю информацию о заметке.
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Поле "Название заметки".
        /// </summary>
        private string _title;
        /// <summary>
        /// Поле с перечислением "Категории заметки".
        /// </summary>
        private NoteCategory _category;
        /// <summary>
        /// Поле "Текст заметки".
        /// </summary>
        private string   _text;
        /// <summary>
        /// Поле "Время создания".
        /// </summary>
        private DateTime _creationTime;
        /// <summary>
        /// Поле "Время последнего изменения".
        /// </summary>
        private DateTime _lastModifiedTime;
        /// <summary>
        /// Конструктор без параметров класса Note для инициализации полей.
        /// </summary>
        public Note()
        {
            _title = "";
            _category = NoteCategory.Other;
            _text = "";
            _creationTime = DateTime.Now;
            _lastModifiedTime = DateTime.Now;
        }
        /// <summary>
        /// Конструктор с параметрами класса Note.
        /// </summary>
        /// <param name="title">Название заметки</param>
        /// <param name="category">Категория заметки</param>
        /// <param name="text">Текст заметки</param>
        public Note(string title, NoteCategory category, string text)
        {
            _title = title;
            _category = category;
            _text = text;
            _creationTime = DateTime.Now;
            _lastModifiedTime = DateTime.Now;
        }
        /// <summary>
        /// Возвращает и задаёт название заметки.
        /// При получении данных проводит проверку на количество символов.
        /// </summary>
        public string Title
        {
            set
            {
                // Условие для проверки количества символов (не больше 50)
                if (value.Length > 50)
                    // Сообщение о возникновении исключения
                    throw new ArgumentException("Название заметки не может превышать 50 символов");
            }
            get { return _title; }
        }
        /// <summary>
        /// Метод для копирования заметок.
        /// </summary>
        /// <returns> Копирует поля заметки в новую заметку. </returns>
        public object Clone()
        {
            return new Note
            {
                _title = this._title,
                _category = this._category,
                _text = this._text,
                _creationTime = this._creationTime,
                _lastModifiedTime = this._lastModifiedTime
            };
        }
        /// <summary>
        /// Возвращает и задаёт категорию заметки.
        /// </summary>
        public NoteCategory Category
        {
            set { _category = value; }
            get { return _category; }
        }
        /// <summary>
        /// Возвращает и задаёт текст в заметке.
        /// </summary>
        public string Text
        {
            set { _text = value; }
            get { return _text; }
        }
        /// <summary>
        /// Возвращает и задаёт время создания заметки.
        /// </summary>
        public DateTime CreationTime
        {
            set { _creationTime = value; }
            get { return _creationTime; }
        }
        /// <summary>
        /// Возвращает и задаёт время последнего изменения в заметке.
        /// </summary>
        public DateTime LastModifiedTime
        {
            set { _lastModifiedTime = value; }
            get { return _lastModifiedTime; }
        }
    }
}
