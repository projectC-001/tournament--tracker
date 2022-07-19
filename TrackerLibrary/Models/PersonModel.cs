using System;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the first name of the player
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the last name of the player
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the email address of the player
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the cellphone number of the player
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}

