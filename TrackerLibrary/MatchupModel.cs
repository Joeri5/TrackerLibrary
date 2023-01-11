using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one match in the tournament.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represents the teams that have gotten into the round.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner of the match.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the round that the game is played in.
        /// Refering to the tournament.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
