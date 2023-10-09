using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents a person, including their name and contact information.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Gets or sets the unique identifier of the person.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the first name of the person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email address of the person.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the cellphone number of the person.
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
