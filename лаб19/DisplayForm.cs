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
    public partial class DisplayForm : Form, IDataObserver
    {
        public DisplayForm()
        {
            InitializeComponent();
            // Обновляем данные сразу после инициализации формы
            UpdateData();
        }

        // Реализация метода UpdateData из интерфейса IDataObserver.
        // Обновляет источник данных для DataGridView, загружая список пациентов из базы данных.
        public void UpdateData()
        {
            dgvPatients.DataSource = null;
            dgvPatients.DataSource = PatientDatabase.LoadPatients();
        }

        // Обработчик события клика по кнопке "Обновить".
        // Обновляет данные в DataGridView.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        // Обработчик события клика по кнопке "Закрыть".
        // Закрывает форму.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
