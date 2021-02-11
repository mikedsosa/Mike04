using System;
using System.ComponentModel.DataAnnotations;

namespace Mike04.Models
{
    public class Restaurant
    {
        [Required]
        public int RestRanking { get; set; }
        [Required]
        public string RestName { get; set; }
        public string? RestDish { get; set; } = "It’s all tasty!";
        [Required]
        public string RestAddress { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string? RestPhone { get; set; } = "NA";
        public string? RestLink { get; set; } = "Coming soon.";



        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant {
                RestRanking = 1,
                RestName = "Chick-fil-a",
                RestDish = "Chicken Sandwich",
                RestAddress = "484 Bulldog Ln",
                RestPhone = "(801) 374-2697",
                RestLink = "https://www.chick-fil-a.com/",
            };
            Restaurant r2 = new Restaurant {
                RestRanking = 2,
                RestName = "R&R",
                RestDish = "Ribs",
                RestAddress = "4801 N University Ave #490",
                RestPhone = "(801) 281-5508",
                RestLink = "https://randrbbq.com/",
            };
            Restaurant r3 = new Restaurant {
                RestRanking = 3,
                RestName = "Taste",
                RestDish = "Chocolate Mousse",
                RestAddress = "117 N University Ave",
                RestPhone = "(801) 900-4061",
                RestLink = "https://havetaste.com/",
            };
            Restaurant r4 = new Restaurant {
                RestRanking = 4,
                RestName = "Waffle Love",
                RestDish = "Waffle Strawberry",
                RestAddress = "1831 N State St",
                RestPhone = "(801) 923-3588",
                RestLink = "http://www.waffluv.com/",
            };
            Restaurant r5 = new Restaurant {
                RestRanking = 5,
                RestName = "Don Joaquins",
                RestDish = "Tacos al Pastor",
                RestAddress = "150 W 1230 N St",
                RestPhone = "(801) 400-2894",
                RestLink = "https://stdonjoaquin.com/",
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
