using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to the database.
        /// <summary>
        /// Сохраняет призовые места в БД.
        /// </summary>
        /// <param name="model">Данные о призовых местах.</param>
        /// <returns>Данные о призовых местах, включая ИД</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
