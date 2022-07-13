using System;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the particular tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the amount of entry fee required to enter the particular tournament
        /// </summary>
        public decimal EtnryFee { get; set; }

        /// <summary>
        /// Represents the list of the teams that are in the particular tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>(); // need to create a constructor in Lists

        /// <summary>
        /// Represents the list of prizes for the particular tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the list of list which holds rounds and teams for the particular tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}

