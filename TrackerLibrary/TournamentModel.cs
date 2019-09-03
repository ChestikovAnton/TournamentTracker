using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Турнир
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Название турнира
        /// </summary>
        public string  TournamentName { get; set; }

        /// <summary>
        /// Взнос за участие в турнире
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Список участвующих в турнире команд
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Призовые места
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Стадии турнира
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
