using System;
using System.Collections.Generic;

namespace Assignment4.Models



{
    public class TempStorage
    {
        private static List<Suggestion> suggestionList = new List<Suggestion>();

        public static IEnumerable<Suggestion> Restaurants => suggestionList;

        public static void AddSuggestion(Suggestion restaurant)
        {
            suggestionList.Add(restaurant);
        }
    }
}
