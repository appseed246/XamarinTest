
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XamarinTest
{
    public class QiitaAPI
    {
        public List<QiitaArticleEntity> articleList;

        public static readonly string API_URL = "https://qiita.com//api/v2/items";

        public async Task<List<QiitaArticleEntity>> AsyncGetWebAPIData()
        {
            // リスト作成
            articleList = new List<QiitaArticleEntity>();

            // HTTPクライアント作成
            var httpClient = new HttpClient();

            var result =  await httpClient.GetStringAsync(API_URL);

            articleList = JsonConvert.DeserializeObject<List<QiitaArticleEntity>>(result);

            // Listでデータを返す
            return articleList;
        }
    }

    public class QiitaArticleEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
