using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a prize awarded in a tournament for a specific placement.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Gets or sets the placement number for this prize (e.g., 1 for first place).
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the placement (e.g., "First Place").
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Gets or sets the monetary amount of the prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Gets or sets the percentage of the total prize pool this prize represents.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
