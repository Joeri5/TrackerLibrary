using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the prizes in the tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents the endingplace in the tournament to receive the given prize.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the PlaceNumber in a string.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the amount of the particulair prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of the particular prize.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
