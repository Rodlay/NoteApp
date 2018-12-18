using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс "Менеджер проекта", который сохраняет в файл и
    /// загружает из файла проект "Проект".
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Поле константы, в котором хранится путь к файлу системы.
        /// </summary>
        private static string _pathMyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NoteApp.notes";
        /// <summary>
        /// Метод для записи проекта в файл.
        /// </summary>
        /// <param name="notes">Объект проекта для сериализации</param>
        public static void Serialization(Project notes)
        {
            //Создадим экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для записи в файл с указанием пути.
            using (StreamWriter sw = new StreamWriter(_pathMyDocuments))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Открываем сериализацию и передаём объект,
                //который хотим сериализовать.
                serializer.Serialize(writer, notes);
            }
        }
        /// <summary>
        /// Метод для чтения проекта из файла.
        /// </summary>
        /// <returns>Объект проекта</returns>
        public static Project Deserialization()
        {
            //Создаёт переменная, в которую помещается результат десериализации.
            Project project = null;
            //Создаётся экземпляр сериализатора.
            JsonSerializer serializer = new JsonSerializer();
            //Открывается поток для чтения из файла с указанием пути.
            using (StreamReader sr = new StreamReader(_pathMyDocuments))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызывается десериализация и явно преобразуется результат в целевой тип данных
                project = (Project)serializer.Deserialize<Project>(reader);
            }
            return project;
        }
    }
}
