using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class Top_Restaurants
    {
        [Required]
        public int Rank { get; set; }

        [Required]
        public string Restaurant_Name { get; set; }

        public string Favorite_Dish { get; set; }

        [Required]
        public string Address { get; set; }

        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}")]
            public string Restaurant_Phone { get; set; }

            public string Web_Link { get; set; }

            public static Top_Restaurants[] GetTop_Restaurants()
            {

            Top_Restaurants r1 = new Top_Restaurants
            {
                Rank = 1,
                Restaurant_Name = "Cubbys",
                Favorite_Dish = "Tri-Tip Steak Sandwich",
                Address = "Corner of University and State Street",
                Restaurant_Phone = "801-555-1234",
                Web_Link = "cubbys.com"
            };

            Top_Restaurants r2 = new Top_Restaurants
            {
                Rank = 2,
                Restaurant_Name = "Panda Express",
                
                Address = "Cougar and University Ave",
                Restaurant_Phone = "801-555-1235",
                Web_Link = "PandaXPrexsx.com"
            };

            Top_Restaurants r3 = new Top_Restaurants
            {
                Rank = 3,
                Restaurant_Name = "Don Quoquins",
                Favorite_Dish = "Horchata Milk Shake",
                Address = "900 E by the Vasa",
                Restaurant_Phone = "801-555-1236",
                Web_Link = "Donquoquinsbaby.com"
            };

            Top_Restaurants r4 = new Top_Restaurants
            {
                Rank = 4,
                Restaurant_Name = "7 Eleven",
                Favorite_Dish = "Hot Dog",
                Address = "University Ave 500 N",
                Restaurant_Phone = "801-555-1237"
             
            };


            Top_Restaurants r5 = new Top_Restaurants
            {
                Rank = 5,
                Restaurant_Name = "Slab Pizza",
                Favorite_Dish = "Rosemary Potato Bacon Slab",
                Address = "700 E 800 N",
                Restaurant_Phone = "801-555-1238",
                Web_Link = "Slab.com"
            };

                return (new Top_Restaurants[] { r1, r2, r3, r4, r5});
            }

        
    }
}
