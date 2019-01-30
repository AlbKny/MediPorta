using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rekrutacja.Models.Home
{
    public class IndexModel
    {
        public List<TagItem> TagItemList { get; set; }

        public IndexModel()
        {
            TagItemList = new List<TagItem>();
        }
    }
}