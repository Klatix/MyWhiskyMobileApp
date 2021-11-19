using MyWhiskyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWhiskyApp.Services
{
    public class MockDataStore
    {
        public static List<WhiskyItem> items = new List<WhiskyItem>()
            {
                new WhiskyItem { Id = 101, Name = "Jack Daniels",
                                           Description="A true classic in the world of whisky, although it's not the most complex or interesting " +
                                                       "flavor-wise, it's surely one of the most recognizable whiskeys in the world. Ideal to mix with coke and ice.",
                                           ImageName = "jack_daniels.png"},

                new WhiskyItem { Id = 102, Name = "Ballantines",
                                           Description="Ballantine’s puts the “blended” into blended scotch, " +
                                                       "combining both malt and grain whiskeys made at a handful of different distilleries. " +
                                                       "Everything that goes into a bottle of Ballantine’s has been aged for at least three years, " +
                                                       "and the whiskey is bottled at 40% alcohol. The scotch has a light gold color, and has a lovely glint on ice.",
                                           ImageName = "ballantines.png"},

                new WhiskyItem { Id = 103, Name = "Jameson",
                                           Description="Perfect for 7/7's or pickle backs. Jameson Irish Whiskey which is carefully distilled at " +
                                                        "Jameson is adored for its pear, hops, green apple and vanilla flavor notes.",
                                           ImageName = "jameson.png"},

                new WhiskyItem { Id = 104, Name = "Macallan 12",
                                           Description="The Macallan 12-year-old Triple Cask is also redolent of baked spices and vanilla, " +
                                                       "with white chocolate suggestions coming through. On the palate, it has unmistakable " +
                                                       "notes of fresh ginger alongside dark berries, caramel, black pepper and rich cocoa, " +
                                                       "all married for a mature and sophisticated drink.",
                                           ImageName = "macallan_12.png"},
            };
    }
}