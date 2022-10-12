using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using _Project._Scripts.DTO;
using _Project._Scripts.WebServices;
using Newtonsoft.Json;
using UnityEngine;


namespace _Project._Scripts
{
    public class HttpTest : MonoBehaviour
    {
        public async Task<IEnumerable<WithNameDto>> GetTypes(string url)
        {
            using var client = new HttpClient();
            var request = await client.GetStringAsync(url);

                
            var test = new List<WithNameDto>();
            var deserializeAnonymousType = JsonConvert.DeserializeAnonymousType(request,test);

            return deserializeAnonymousType;
        }
        
    }

}
