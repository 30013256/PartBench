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

            forums.Add(new Forums { Title = "Need assistance with pc", Topics = 42, Posts = 552, RecentTopicPosts = "Does this RAM look good in my build?"});
            forums.Add(new Forums { Title = "yes", Topics = 28, Posts = 1446, RecentTopicPosts = "yes" });
            forums.Add(new Forums { Title = "Need assistance with pc", Topics = 42, Posts = 552, RecentTopicPosts = "Does this RAM look good in my build?" });
            forums.Add(new Forums { Title = "Need assistance with pc", Topics = 42, Posts = 552, RecentTopicPosts = "Does this RAM look good in my build?" });

            return forums;
        }
    }
}
