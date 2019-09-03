using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Участник турнира
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Имя участника
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия участника
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Адрес электронной почты участника
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Номер мобильного телефона участника
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
