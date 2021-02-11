using System;
using System.Collections.Generic;

namespace Mike04.Models
{
    public class TempStorageClass
    {
        private static List<RestResponse> restaurants = new List<RestResponse>();

        public static IEnumerable<RestResponse> Restaurants => restaurants;

        public static void AddRestaurant(RestResponse restaurant)
        {
            restaurants.Add(restaurant);
        }
    }
}
