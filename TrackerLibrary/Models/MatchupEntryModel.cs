using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Одна команда-участник в матче.
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Одна команда-участник в матче.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Очки для данной команды.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Предыдущий матч, в котором победила данная команда.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
