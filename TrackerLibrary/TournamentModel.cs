using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a tournament, including participating teams, prizes, and rounds.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Gets or sets the name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Gets or sets the fee to enter the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Gets or sets the list of teams that have entered the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Gets or sets the list of prizes available in the tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Gets or sets the list of rounds in the tournament. Each round is a list of matchups.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
