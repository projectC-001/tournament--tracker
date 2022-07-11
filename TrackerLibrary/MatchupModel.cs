using System;
namespace TrackerLibrary
{
	public class MatchupModel
	{
        /// <summary>
        /// Represents the teams in a matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner of the particular matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the round of the particular matchup
        /// </summary>
        public int MatchupRound { get; set; }
    }
}

