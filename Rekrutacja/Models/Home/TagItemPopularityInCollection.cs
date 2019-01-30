using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rekrutacja.Models.Home;
namespace Rekrutacja.Models.Home
{
    public class TagItemPopularityInCollection
    {
        public TagItem TagItem;
        public long CollectionPopularity;

        public long SumCollectionPopularity(List<TagItem> tagItems)
        {
            long popularityInCollectionSum = 0;
            foreach (var item in tagItems)
            {
                popularityInCollectionSum += item.Count;
            }
            this.CollectionPopularity = popularityInCollectionSum;
            return popularityInCollectionSum;
        }

        public void PercentageInCollection(List<TagItem> tagItems)
        {
            foreach (var item in tagItems)
            {
                double s1 = (double)item.Count;
                double s2 = (double)CollectionPopularity;
                double sum =100* s1 / s2;
                sum = Math.Round(sum, 2);
                item.InCollectionPopularity = sum;
            }
        }

    }
}