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
        /// The unique indentifier for the prize
        /// </summary>
        public int Id { get; set; }
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

        public PrizeModel()
        {

        }

        //override constructor
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
