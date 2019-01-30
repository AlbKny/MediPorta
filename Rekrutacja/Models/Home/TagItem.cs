using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rekrutacja.Models.Home
{
    public class TagItem
    {
        public string Name { get; set; }
        public long Count { get; set; }
        public string Is_required { get; set; }
        public string Is_moderator_only { get; set; }
        public string Has_synonyms { get; set; }
        public double InCollectionPopularity { get; set; }
        public List<TagItem> TagItems { get; set; }
    }
}