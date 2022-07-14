using System;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Represents the list of the players that are in a particular team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>(); // This is a constructor in the same line since C# 6

        /// <summary>
        /// Represents the name of the particular team
        /// </summary>
        public string TeamName { get; set; }
    }
}

