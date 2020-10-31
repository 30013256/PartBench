using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartBench.Models
{
    public class Forums
    {
        public string Title { get; set; }
        public int Topics { get; set; }
        public int Posts { get; set; }
        public string RecentTopicPosts { get; set; }
    }

    public class ForumManager
    {
        public static List<Forums> GetForums()
        {
            var forums = new List<Forums>();

            forums.Add(new Forums { Title = "Part List Opinions Wanted | ", Topics = 93845, Posts = 465523, RecentTopicPosts = " | Gaming setup($2400 - $3000)"});
            forums.Add(new Forums { Title = "Creating a Part List", Topics = 24591, Posts = 144876, RecentTopicPosts = "What parts should I consider putting together for a build?" });
            forums.Add(new Forums { Title = "Troubleshooting", Topics = 10562, Posts = 48552, RecentTopicPosts = "Troubling chipset temps" });
            forums.Add(new Forums { Title = "Laptops", Topics = 942, Posts = 5479, RecentTopicPosts = "Looking for a laptop thats relatively okay for gaming as well as casual use for work" });                        

            return forums;
        }

        public static List<Forums> GetForums2()
        {
            var forums2 = new List<Forums>();

            forums2.Add(new Forums { Title = "CPU's", Topics = 9983, Posts = 243803, RecentTopicPosts = "Best price / performance Intel CPU?" });
            forums2.Add(new Forums { Title = "Coolers", Topics = 5641, Posts = 144632, RecentTopicPosts = "Best cooling for Ryzen CPU?" });
            forums2.Add(new Forums { Title = "Motherboards", Topics = 8765, Posts = 198552, RecentTopicPosts = "ASUS or Gigabyte? or possibly something else" });
            forums2.Add(new Forums { Title = "Memory", Topics = 7706, Posts = 182763, RecentTopicPosts = "Whats a good 32 GB DIMM kit?" });
            forums2.Add(new Forums { Title = "Storage", Topics = 42, Posts = 552, RecentTopicPosts = "Potential upgrades" });
            forums2.Add(new Forums { Title = "Video Cards", Topics = 42, Posts = 552, RecentTopicPosts = "GPU recommendations" });
            forums2.Add(new Forums { Title = "Cases", Topics = 42, Posts = 552, RecentTopicPosts = "NZXT cases" });
            forums2.Add(new Forums { Title = "Power Supplies", Topics = 42, Posts = 552, RecentTopicPosts = "Whats a comfortable wattage for a build" });
            forums2.Add(new Forums { Title = "Monitors", Topics = 42, Posts = 552, RecentTopicPosts = "Looking for 240Hz 1440p monitor" });
            forums2.Add(new Forums { Title = "Keyboards & Mice", Topics = 42, Posts = 552, RecentTopicPosts = "Best keyboard that lasts a long time" });
            forums2.Add(new Forums { Title = "Headphones", Topics = 42, Posts = 552, RecentTopicPosts = "HyperX? or Logitech" });
            forums2.Add(new Forums { Title = "Audio", Topics = 42, Posts = 552, RecentTopicPosts = "HS60 vs HS60 Pro" });
            forums2.Add(new Forums { Title = "Networking", Topics = 42, Posts = 552, RecentTopicPosts = "Difference between CAT5 and CAT6" });
            forums2.Add(new Forums { Title = "Modding | DIY", Topics = 42, Posts = 552, RecentTopicPosts = "Need assistance with custom cable sleeving" });
            forums2.Add(new Forums { Title = "Other", Topics = 42, Posts = 552, RecentTopicPosts = "Air cooler vs water cooler" });

            return forums2;
        }

        public static List<Forums> GetForums3()
        {
            var forums3 = new List<Forums>();

            forums3.Add(new Forums { Title = "Anti-Virus | Anti-Malware | Security", Topics = 93845, Posts = 465523, RecentTopicPosts = "Does overclocking affect system security in anyway?" });
            forums3.Add(new Forums { Title = "General Software", Topics = 24591, Posts = 144876, RecentTopicPosts = "Software for managing temps of system" });
            forums3.Add(new Forums { Title = "Operating Systems", Topics = 10562, Posts = 48552, RecentTopicPosts = "Does the windows 10 download still operate" });
            forums3.Add(new Forums { Title = "Games | Gaming", Topics = 942, Posts = 5479, RecentTopicPosts = "Minecraft 60fps w/shader build" });

            return forums3;
        }

        public static List<Forums> GetForums4()
        {
            var forums4 = new List<Forums>();

            forums4.Add(new Forums { Title = "Announcements | Application News", Topics = 93845, Posts = 465523, RecentTopicPosts = "Comment deletions and voting" });
            forums4.Add(new Forums { Title = "Deals", Topics = 24591, Posts = 144876, RecentTopicPosts = "Gigabyte RTX 2080 Super 8GB" });
            forums4.Add(new Forums { Title = "Request Part Additions | Corrections Here", Topics = 10562, Posts = 48552, RecentTopicPosts = "ASUS TUF GAMING B550-PLUS (WI-FI)" });
            forums4.Add(new Forums { Title = "For sale or trade", Topics = 942, Posts = 5479, RecentTopicPosts = "Ryzen 5 3600 + MSI B4501 Gaming Plus AC" });             
            forums4.Add(new Forums { Title = "App feedback and feature requests", Topics = 24591, Posts = 144876, RecentTopicPosts = "Skateboard parts builder" });
            forums4.Add(new Forums { Title = "General Discussion", Topics = 10562, Posts = 48552, RecentTopicPosts = "SSD Question" });
            forums4.Add(new Forums { Title = "Off topic", Topics = 10562, Posts = 48552, RecentTopicPosts = "Ceramic coating" });

            return forums4;
        }
    }
}
