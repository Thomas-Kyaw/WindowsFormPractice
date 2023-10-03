using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a matchup between two or more teams.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Gets or sets the list of entries competing in this matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Gets or sets the winner of this matchup.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Gets or sets the round in which this matchup occurs.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
