using System;
using System.ComponentModel.DataAnnotations;
namespace Assignment4.Models
{
    public class Suggestion
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Restaurant_Name { get; set; }

        public string Favorite_Dish { get; set; }

        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}", ErrorMessage = "Input phone number in this form (xxx)-xxx-xxxx")]
        public string Restaurant_Phone { get; set; }

        public static Suggestion[] GetSuggestions()
        {

           

            return (new Suggestion[] {  });
        }
        
    }
}
