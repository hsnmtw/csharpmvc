using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Utils.Net {
    public static class CURL {
        public async static void Read(string url,
                                      Action<string> actionWhenResponsed,
                                      string httpMethod = "POST", 
                                      Dictionary<string,string> parameters = null) {
            var client = new HttpClient();

            // Create the HttpContent for the form to be posted.
            var requestContent = parameters==null ? null : new FormUrlEncodedContent(parameters.ToArray());

            // Get the response.
            HttpResponseMessage response = await client.PostAsync(url,requestContent);

            // Get the response content.
            HttpContent responseContent = response.Content;

            // Get the stream of the content.
            using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync())) {
                // Write the output.
                actionWhenResponsed?.Invoke(await reader.ReadToEndAsync());
            }
        }
    }
}
