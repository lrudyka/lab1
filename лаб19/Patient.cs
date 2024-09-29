using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб19
{
    // Класс Patient представляет информацию о пациенте.
    // Отмечен атрибутом Serializable, чтобы объекты этого класса могли быть сериализованы.
    [Serializable]
    public class Patient
    {
        // Полное имя пациента.
        public string FullName { get; set; }

        // Год рождения пациента.
        public int BirthYear { get; set; }

        // Дата поступления пациента.
        public DateTime AdmissionDate { get; set; }

        // Предварительный диагноз пациента.
        public string PreliminaryDiagnosis { get; set; }

        // Номер отделения, в котором находится пациент.
        public int DepartmentNumber { get; set; }
    }
}
