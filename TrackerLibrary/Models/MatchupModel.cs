using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Матч в турнире
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Список участников матча
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        
        /// <summary>
        /// Победитель матча
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Стадия турнира, в которой был проведен матч
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
