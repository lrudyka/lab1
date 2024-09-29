using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace лаб19
{
    /// <summary>
    /// Статический класс для управления базой данных пациентов.
    /// </summary>
    public static class PatientDatabase
    {
        /// <summary>
        /// Путь к файлу, в котором хранятся данные пациентов.
        /// </summary>
        private static readonly string FilePath = "patients.dat";

        /// <summary>
        /// Добавляет нового пациента в базу данных.
        /// </summary>
        /// <param name="patient">Объект Patient, представляющий нового пациента.</param>
        /// <param name="filePath">Необязательный параметр, указывающий путь к файлу базы данных. Если не указан, используется путь по умолчанию.</param>
        public static void AddPatient(Patient patient, string filePath = null)
        {
            List<Patient> patients = LoadPatients(filePath);
            patients.Add(patient);
            SavePatients(patients, filePath);
        }

        /// <summary>
        /// Загружает список пациентов из файла.
        /// </summary>
        /// <param name="filePath">Необязательный параметр, указывающий путь к файлу базы данных. Если не указан, используется путь по умолчанию.</param>
        /// <returns>Список объектов Patient.</returns>
        public static List<Patient> LoadPatients(string filePath = null)
        {
            if (filePath == null) filePath = FilePath;
            if (!File.Exists(filePath)) return new List<Patient>();

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Patient>)formatter.Deserialize(fs);
            }
        }

        /// <summary>
        /// Сохраняет список пациентов в файл.
        /// </summary>
        /// <param name="patients">Список объектов Patient для сохранения.</param>
        /// <param name="filePath">Необязательный параметр, указывающий путь к файлу базы данных. Если не указан, используется путь по умолчанию.</param>
        public static void SavePatients(List<Patient> patients, string filePath = null)
        {
            if (filePath == null) filePath = FilePath;
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, patients);
            }
        }

        /// <summary>
        /// Обновляет данные пациента в базе данных.
        /// </summary>
        /// <param name="fullName">Полное имя пациента, данные которого нужно обновить.</param>
        /// <param name="updatedPatient">Объект Patient с обновленными данными.</param>
        /// <param name="filePath">Необязательный параметр, указывающий путь к файлу базы данных. Если не указан, используется путь по умолчанию.</param>
        public static void UpdatePatient(string fullName, Patient updatedPatient, string filePath = null)
        {
            List<Patient> patients = LoadPatients(filePath);
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].FullName == fullName)
                {
                    patients[i] = updatedPatient;
                    break;
                }
            }
            SavePatients(patients, filePath);
        }

        /// <summary>
        /// Выполняет поиск пациентов по заданному запросу.
        /// </summary>
        /// <param name="query">Строка для поиска по полному имени пациентов.</param>
        /// <param name="filePath">Необязательный параметр, указывающий путь к файлу базы данных. Если не указан, используется путь по умолчанию.</param>
        /// <returns>Список объектов Patient, удовлетворяющих критериям поиска.</returns>
        public static List<Patient> SearchPatients(string query, string filePath = null)
        {
            List<Patient> patients = LoadPatients(filePath);
            return patients.FindAll(p => p.FullName.Contains(query));
        }
    }
}
