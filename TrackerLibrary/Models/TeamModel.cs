using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents a team, including its members and team name.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Gets or sets the list of members in the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Gets or sets the name of the team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
