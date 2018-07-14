
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuickType;

namespace XamarinTest
{
    public class QiitaAPI
    {
        public List<ItemClass> articleList;

        public static readonly string API_URL = "https://qiita.com//api/v2/items";

        public async Task<List<ItemClass>> AsyncGetWebAPIData()
        {
            // リスト作成
            //articleList = new List<QiitaArticleEntity>();
            articleList = new List<ItemClass>();

            // HTTPクライアント作成
            var httpClient = new HttpClient();

            var result =  await httpClient.GetStringAsync(API_URL);

            articleList = JsonConvert.DeserializeObject<List<ItemClass>>(result);

            // Listでデータを返す
            return articleList;
        }
    }
}
