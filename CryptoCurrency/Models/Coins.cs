using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoCurrency.Models
{
    public class Coins
    {
        public string status { get; set; }
        public Data data { get; set; }
        public class Stats
        {
            public int total { get; set; }
            public int offset { get; set; }
            public int limit { get; set; }
            public string order { get; set; }
            public string @base { get; set; }
            public int totalMarkets { get; set; }
            public int totalExchanges { get; set; }
            public double totalMarketCap { get; set; }
            public double total24hVolume { get; set; }
        }

        public class Base
        {
            public string symbol { get; set; }
            public string sign { get; set; }
        }

        public class Social
        {
            public string name { get; set; }
            public string url { get; set; }
            public string type { get; set; }
        }

        public class Link
        {
            public string name { get; set; }
            public string type { get; set; }
            public string url { get; set; }
        }

        public class AllTimeHigh
        {
            public string price { get; set; }
            public object timestamp { get; set; }
        }

        public class Coin
        {
            public int id { get; set; }
            public string uuid { get; set; }
            public string slug { get; set; }
            public string symbol { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string color { get; set; }
            public string iconType { get; set; }
            public string iconUrl { get; set; }
            public string websiteUrl { get; set; }
            public List<Social> socials { get; set; }
            public List<Link> links { get; set; }
            public bool confirmedSupply { get; set; }
            public int numberOfMarkets { get; set; }
            public int numberOfExchanges { get; set; }
            public string type { get; set; }
            public object volume { get; set; }
            public object marketCap { get; set; }
            public string price { get; set; }
            public double circulatingSupply { get; set; }
            public double? totalSupply { get; set; }
            public bool approvedSupply { get; set; }
            public object firstSeen { get; set; }
            public int listedAt { get; set; }
            public double change { get; set; }
            public int rank { get; set; }
            public List<string> history { get; set; }
            public AllTimeHigh allTimeHigh { get; set; }
            public bool penalty { get; set; }
        }

        public class Data
        {
            public Stats stats { get; set; }
            public Base @base { get; set; }
            public List<Coin> coins { get; set; }
        }
    }
}
