using System;
using System.Collections.Generic;

namespace PoultryFarm.Models
{
    public partial class PoultryFeed
    {
        public int TagId { get; set; }
        public string TypesOfFeeds { get; set; } = null!;
        public string ChickenBreed { get; set; } = null!;
        public string ChickenMeds { get; set; } = null!;
        public int NumberOfFeeds { get; set; }
    }  
}
