using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;


namespace XamarinTest
{
    public class QiitaAPI
    {
        public string BASE_URL = "https://qiita.com//api/v2/items";

        // データを取得するメソッド
        public async Task<List<Article>> AsyncGetWebAPIData(int page)
        {
            HttpClient httpClient = new HttpClient();
            string result = await httpClient.GetStringAsync(EndPoint(page));
            var articleList = JsonConvert.DeserializeObject<List<Article>>(result);

            return articleList;
        }

        private string EndPoint(int page) {
            return BASE_URL + "?page=" + page;
        }
    }

    // QiitaApiから取得するデータのEntity
    public class Article
    {
    
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }
    }
}