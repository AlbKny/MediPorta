using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rekrutacja.Models.Home;

namespace Rekrutacja.Services
{
    public class UrlLogic
    {
        public IndexModel GetIndexModel()
        {
            TagItemPopularityInCollection tagItemPopularityInCollection = new TagItemPopularityInCollection();
            JsonOperation jsonOperation;

            var model = new IndexModel();
            List<TagItem> TagItemList = new List<TagItem>();
            var jsontext = string.Empty;
            for (int i = 1; i < 11; i++)        // i = page number
            {
                var url = "https://api.stackexchange.com/2.2/tags?page=" + i + "&pagesize=100&order=desc&sort=popular&site=stackoverflow";
                jsonOperation = new JsonOperation();
                var text = jsonOperation.GetJsonFileFromUrl(url);
                var jo = jsonOperation.JsonData(text);
                var jtok = jsonOperation.TagProperties(jo);
                jsonOperation.TagItemFill(jtok, TagItemList);
                tagItemPopularityInCollection.SumCollectionPopularity(TagItemList);
                tagItemPopularityInCollection.PercentageInCollection(TagItemList);
            }
            model.TagItemList = TagItemList;
            return model;
        }
    }
}