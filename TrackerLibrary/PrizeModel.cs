using System;
namespace TrackerLibrary
{
	public class PrizeModel
	{
        /// <summary>
        /// The unique identifier for prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the place number of the price - like 1st , 2nd , 3rd
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the place number - like winner, first runner up, second runner up
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the prize amount for the particular place number or place name
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of the prize that a particular place number or place name gets 
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        { 
        
        }

        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
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

