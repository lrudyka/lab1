using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб19
{
    // Интерфейс IDataObserver представляет наблюдателя, который должен быть уведомлен об изменении данных.
    public interface IDataObserver
    {
        // Метод для обновления данных.
        // Этот метод будет вызываться для обновления данных у наблюдателя.
        void UpdateData();
    }
}
