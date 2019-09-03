using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Команда-участник турнира
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Состав команды
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Название команды
        /// </summary>
        public string TeamName { get; set; }

    }
}
