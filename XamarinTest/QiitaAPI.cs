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
        //public List<QiitaArticleEntity> articleList;

        // QiitaAPIのURl
        public string API_URL = "https://qiita.com//api/v2/items";

        // データを取得するメソッド
        public async Task<List<QiitaArticleEntity>> AsyncGetWebAPIData()
        {
            // Listの作成
            //var articleList = new List<QiitaArticleEntity>();
            // HttpClientの作成 
            HttpClient httpClient = new HttpClient();
            // 非同期でAPIからデータを取得
            string result = await httpClient.GetStringAsync(API_URL);
            // JSON形式のデータをデシリアライズ
            var articleList = JsonConvert.DeserializeObject<List<QiitaArticleEntity>>(result);

            // List でデータを返す
            return articleList;
        }
    }

    // QiitaApiから取得するデータのEntity
    public class QiitaArticleEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
    }
}