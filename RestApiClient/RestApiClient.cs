using System;
namespace RestApiClient
{
	public class RestApiClient
	{
		public string endPoint { get; set; }

        private static readonly HttpClient client = new HttpClient();


        public RestApiClient()
		{
        }
        #region GetRequest

        public async Task<string> makeRequest()
		{
            try
            {
                string responseBody = await client.GetStringAsync(this.endPoint);

                return responseBody;
            }
            catch (Exception e)
            {
                throw new HttpRequestException(e.ToString());
            }
        }
        #endregion
    }
}

