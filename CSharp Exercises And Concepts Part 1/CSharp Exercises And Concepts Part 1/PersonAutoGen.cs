using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Exercises_And_Concepts_Part_1
{
    public partial class Person
    {
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }
        public string Greeting => $"{Name} says Hello!";
        public int Age => DateTime.Today.Year - DateOfBirth.Year;
        public string FavoriteIceCream { get; set; }
        private string favoritePrimaryColor;

        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;

                    default:
                        throw new ArgumentException
                            ($"{value} is not a primary color." + "Choose from: red, green or blue.");
                }
            }
        }
    }
}
