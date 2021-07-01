using System;
using System.Linq;

namespace GroupBy
{   
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고현정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하하", Height=171}
            };

            var listProfile = from Profile in arrProfile
                              orderby Profile.Height
                              group Profile by Profile.Height < 175 into g
                              select new { GruopKey = g.Key, Profile = g };

            foreach (var Group in listProfile)
            {
                Console.WriteLine($"- 175 미만? : {Group.GruopKey}");
                foreach (var profile in Group.Profile)
                {
                    Console.WriteLine($">>>{profile.Name}, {profile.Height}");
                }
            }
        }
    }
}
