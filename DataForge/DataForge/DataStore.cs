using System;
using System.Collections.Generic;
using System.Text;

namespace DataForge
{
    internal static class DataStore
    {


        #region Person

        internal static readonly string[] maleNames = new string[] { "William", "Jacob", "Ethan", "Michael", "Alexander", "Daniel", "Benjamin", "Samuel", "David", "Joseph", "James", "Matthew", "Elijah", "Anthony", "Joshua", "Andrew", "Christopher", "John", "Ryan", "Nicholas", "Tyler", "Brandon", "Zachary", "Cameron", "Kevin", "Jared", "Justin", "Lucas", "Thomas", "Jonathan", "Caleb", "Nathan", "Dylan", "Adam", "Aaron", "Peter", "George", "Henry", "Oliver", "Liam" };
        
        internal static readonly string[] femaleNames = new string[] { "Emma", "Olivia", "Sophia", "Ava", "Mia", "Isabella", "Charlotte", "Amelia", "Emily", "Abigail", "Madison", "Elizabeth", "Ella", "Victoria", "Grace", "Avery", "Lily", "Chloe", "Sofia", "Aubrey", "Hannah", "Natalie", "Addison", "Aria", "Aurora", "Camila", "Aaliyah", "Evelyn", "Aria", "Brielle", "Luna", "Stella", "Penelope", "Harper", "Aria", "Aurora", "Leah", "Nova", "Riley", "Zoe" };
        
        internal static readonly string[] neutralNames = new string[] { "Charlie", "Alex", "Robin", "Jordan", "Riley", "Avery", "Taylor", "Casey", "Skyler", "Hayden", "Bailey", "Morgan", "Mackenzie", "Harley", "Dakota", "Phoenix", "Angel", "River", "Jayden", "Avery", "Eli", "Logan", "Carter", "Parker", "Ashton", "Evan", "Drew", "Adrian", "Cameron", "Spencer", "Quinn", "Elliot", "Jamie", "Darian", "Reese", "Sawyer", "Finley", "Taylor", "Peyton", "Sage" };

        internal static readonly string[] lastNames = new string[] { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "King", "Wright", "Scott", "Green", "Baker", "Adams", "Nelson", "Carter", "Mitchell", "Perez", "Roberts", "Turner", "Phillips" };

        #endregion

        #region Address

        internal static readonly string[] streetNames = new string[] { "Main Street", "High Street", "Park Avenue", "Church Street", "Elm Street", "Oak Street", "Maple Street", "Hill Street", "Washington Street", "Broad Street", "Market Street", "Fifth Avenue", "Broadway", "King Street", "Queen Street", "George Street", "Victoria Road", "Oxford Street", "Regent Street", "Bond Street", "Baker Street", "Fleet Street", "Downing Street", "Lombard Street", "Abbey Road", "Carnaby Street", "Savile Row", "Piccadilly Circus", "Trafalgar Square", "Leicester Square", "Strand", "Pall Mall", "Portobello Road", "Shoreditch High Street", "Brick Lane", "Camden High Street", "Kensington High Street", "Brompton Road", "Notting Hill Gate", "Knightsbridge" };

        internal static readonly string[] cities = new string[] { "New York City", "London", "Paris", "Tokyo", "Los Angeles", "Rio de Janeiro", "Barcelona", "Sydney", "Rome", "Beijing", "Toronto", "Amsterdam", "Dubai", "Berlin", "Cape Town", "Hong Kong", "San Francisco", "Singapore", "Istanbul", "Bangkok" };

        #endregion

        #region Communication

        internal static readonly string[] emailDomains = new string[] { "gmail.com", "yahoo.com", "hotmail.com", "outlook.com", "aol.com", "icloud.com", "protonmail.com", "yandex.com", "mail.com", "gmx.com", "zoho.com", "tutanota.com", "live.com", "fastmail.com", "hushmail.com", "inbox.com", "aim.com", "mail.ru", "gmx.us", "me.com", "netscape.net", "comcast.net", "verizon.net", "sbcglobal.net", "att.net", "charter.net", "earthlink.net", "cox.net", "qq.com", "sina.com" };

        #endregion

        #region Miscellaneous

        internal static readonly string[] randomWords = new string[] { "cool", "happy", "sunny", "quick", "bright", "easy", "fast", "smart", "fresh", "lucky", "strong", "free", "fun", "hot", "sweet", "kind", "young", "wise", "nice", "true", "real", "big", "blue", "red", "green", "black", "white", "purple", "orange", "yellow", "golden", "silver", "cosmic", "dreamy", "dynamic", "energetic", "fantastic", "fabulous", "groovy" };
        
        internal static readonly string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        #endregion

    }
}
