using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаб19
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Обработчик события клика по кнопке "Добавить".
        // Создает нового пациента и добавляет его в базу данных.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Создаем объект пациента и заполняем его данными из текстовых полей и других элементов управления
            Patient patient = new Patient
            {
                FullName = txtFullName.Text,
                BirthYear = (int)numBirthYear.Value,
                AdmissionDate = dtpAdmissionDate.Value,
                PreliminaryDiagnosis = txtDiagnosis.Text,
                DepartmentNumber = (int)numDepartment.Value
            };

            // Добавляем пациента в базу данных
            PatientDatabase.AddPatient(patient);

            // Уведомляем всех наблюдателей об изменении данных
            NotifyObservers();
        }

        // Обработчик события клика по кнопке "Обновить".
        // Обновляет данные существующего пациента в базе данных.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Получаем полное имя пациента, данные которого нужно обновить
            string fullName = txtFullName.Text;

            // Создаем объект пациента с обновленными данными
            Patient updatedPatient = new Patient
            {
                FullName = txtFullName.Text,
                BirthYear = (int)numBirthYear.Value, // Проверьте, что здесь нет приведения типов к меньшему числовому типу
                AdmissionDate = dtpAdmissionDate.Value,
                PreliminaryDiagnosis = txtDiagnosis.Text,
                DepartmentNumber = (int)numDepartment.Value
            };

            // Обновляем данные пациента в базе данных
            PatientDatabase.UpdatePatient(fullName, updatedPatient);

            // Уведомляем всех наблюдателей об изменении данных
            NotifyObservers();
        }

        // Обработчик события клика по кнопке "Показать данные".
        // Открывает форму для отображения списка пациентов.
        private void btnShowData_Click(object sender, EventArgs e)
        {
            // Создаем и показываем форму для отображения списка пациентов
            DisplayForm displayForm = new DisplayForm();
            displayForm.Show();

            // Добавляем форму в список наблюдателей
            Observers.Add(displayForm);
        }

        // Уведомляет всех наблюдателей об изменении данных.
        private void NotifyObservers()
        {
            // Уведомляем всех наблюдателей, если список наблюдателей не пуст
            if (Observers != null)
            {
                foreach (var observer in Observers)
                {
                    observer.UpdateData();
                }
            }
        }

        // Список наблюдателей, которые должны быть уведомлены об изменении данных.
        public List<IDataObserver> Observers { get; set; } = new List<IDataObserver>();
    }
}
