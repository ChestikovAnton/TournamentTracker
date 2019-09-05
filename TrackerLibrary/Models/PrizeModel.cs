using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Призовое место
    /// </summary>
    public class PrizeModel
    {
        public int Id { get; set; }

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

        public PrizeModel()
        {

        }

        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            PlaceName = placeName;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
