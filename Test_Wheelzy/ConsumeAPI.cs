using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test_Wheelzy
{
    public class Response
    {
        public int number;
    }
    public  class ConsumeAPI
    {
        private readonly HttpClient _httpClient;
        private Interceptor _intercetor;
        const int attempt = 8;



        private void loterry(int numberCliente)
        {

            string endpont = "https://notrealapi.com/lottery/play";
            for (int i = 0; i <10 ; i++)
            {
                Random random = new Random();
                var objectLotery = this.Post(endpont, numberCliente);
                int randomNumber = random.Next(0,9999);

                if(objectLotery.number== randomNumber)
                {
                    Console.WriteLine("You win with the number: ", randomNumber);
                    break;

                }
                else
                {
                    continue;
                }

            }


        }
        public Response Post(string endpoint, int numberlient)
        {
            try
            {
                var customer = new { customerNumber = numberlient };
                var json = JsonConvert.SerializeObject(customer);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = _httpClient.PostAsync(endpoint, content).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                if ((int)response.StatusCode == 200)
                {
                    var result = JsonConvert.DeserializeObject<Response>(responseContent);
                    return result;
                }
                else
                {
                    _intercetor.validerror((int)response.StatusCode);
                    return null;
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Opps an error has occurred:");
                Console.WriteLine(Ex.ToString());
                return null;
            }
        }


    }

}

