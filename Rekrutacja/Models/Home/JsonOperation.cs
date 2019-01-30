using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using Rekrutacja.Models.Home;

namespace Rekrutacja.Models.Home
{
    public class JsonOperation
    {
        public string Content { get; set; }
        public JEnumerable<JToken> TagProperties(JObject jObject)
        {
            var item = jObject["items"].Children();
            return item;
        }

        public JObject JsonData(string text)
        {
            return (JObject)JsonConvert.DeserializeObject(text);
        }

        public string GetJsonFileFromUrl(string url)
        {
            var content = string.Empty;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        content = sr.ReadToEnd();
                    }
                }
            }
            this.Content = content;
            return content;
        }

        public void TagItemFill(JEnumerable<JToken> TagProperties, List<TagItem> tagItems)
        {
            TagItem tagItem;
            foreach (var item in TagProperties)
            {
                tagItem = new TagItem();
                tagItem.Name = item["name"].Value<string>();
                tagItem.Count = item["count"].Value<long>();
                tagItems.Add(tagItem);
            }
        }

    }
}