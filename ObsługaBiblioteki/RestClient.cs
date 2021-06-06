using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Web;
using Search_EngineModels;
using System.Windows.Forms;
//using System.Web.Mvc;
//using Search_Engine.Models;


namespace Search_EngineModels
{
    public enum httpVerb
    {
        GET, POST, PUT, DELETE
    }

    class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        //public string makeRequest()
        //{
        //    string strResponseValue = string.Empty;

        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

        //    request.Method = httpMethod.ToString();

        //    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //    {
        //        if (response.StatusCode != HttpStatusCode.OK)
        //        {
        //            throw new ApplicationException("error code: " + response.StatusCode.ToString());

        //        }
        //        Process the response stream...(could be JSON, XML or HTML etc...)

        //        using (Stream responseStream = response.GetResponseStream())
        //        {
        //            if (responseStream != null)
        //            {
        //                using (StreamReader reader = new StreamReader(responseStream))
        //                {
        //                    strResponseValue = reader.ReadToEnd();
        //                    reader.Close();
        //                }//End of StreamReader
        //            }
        //        }//End of using ResponseStream

        //    }//End od using response

        //    return strResponseValue;
        //}

        //public object[] makeRequest()
        //{
        //    //string searchQuery = Request["search"];
        //    var request = WebRequest.Create(endPoint);
        //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //    Stream dataStream = response.GetResponseStream();
        //    StreamReader reader = new StreamReader(dataStream);
        //    string responseString = reader.ReadToEnd();
        //    dynamic jsonData = JsonConvert.DeserializeObject(responseString);

        //    var results = new List<Result>();
        //    foreach (var item in jsonData.items)
        //    {
        //        results.Add(new Result
        //        {
        //            Title = item.volumeInfo.title,
        //            Authors = item.volumeInfo.authors,
        //            Publisher = item.volumeInfo.publisher,
        //            Description = item.volumeInfo.description,
        //        });
        //    }

        //    string wynik = string.Format("Książki autorstwa {0}\n",
        //        results[0].ToString());
        //    //Console.log(userData.email);
        //    results.ToList();
        //    MessageBox.Show(results.ToList(), "Książki danego autora po ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    return wynik;
        //}

        public string makeRequest()
        {
            //string searchQuery = Request["search"];
            var request = WebRequest.Create(endPoint);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseString = reader.ReadToEnd();
            dynamic jsonData = JsonConvert.DeserializeObject(responseString);

            //var results = new List<Result>();
            //foreach (var item in jsonData.items)
            //{
            //    results.Add(new Result
            //    {
            //        volumeInfo = item.volumeInfo,
            //        Title = item.volumeInfo.title,
            //        //Authors = item.volumeInfo.authors,
            //        Publisher = item.volumeInfo.publisher,
            //        Description = item.volumeInfo.description,
            //    });
            //}

            string wynik = string.Format("\n Wyszukiwanie: {0}\n", jsonData.items);
          //  string strResponseValue = string.Empty;
            //var userData = jsonData.Parse(strResponseValue);
            //strResponseValue= Console.WriteLine(userData.item.volumeInfo);
            return wynik;
        }
    }
}
