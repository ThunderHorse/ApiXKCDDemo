using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	public class ApiHelper
	{
		public static HttpClient ApiClient { get; set; }

		public static void InitializeClient()
		{
			ApiClient = new HttpClient();
			//ApiClient = new Uri("http://xkcd.com/"); // Not using because we will use more than one base client for our requests
			ApiClient.DefaultRequestHeaders.Accept.Clear();
			ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}
	}
}
