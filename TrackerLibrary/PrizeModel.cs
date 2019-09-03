using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Призовое место
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Номер призового места
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Название призового места
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Сумма призовых для призового места
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Процент призовых для призового места
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
