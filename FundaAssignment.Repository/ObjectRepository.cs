using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FundaAssignment.Repository
{
    public class ObjectRepository : IObjectRepository
    {
        static HttpClient client = new HttpClient();
        IEnumerable<Entities.Object> objects;
        public ObjectRepository()
        {
            objects = new List<Entities.Object>()
            {
                new Entities.Object(){Id="Object1", MakelaarNaam = "Maaklaar1"},
                new Entities.Object(){Id="Object2", MakelaarNaam = "Maaklaar1"},
                new Entities.Object(){Id="Object3", MakelaarNaam = "Maaklaar2"},
                new Entities.Object(){Id="Object4", MakelaarNaam = "Maaklaar2"},
                new Entities.Object(){Id="Object5", MakelaarNaam = "Maaklaar3"},
            };
        }
        public async Task<IEnumerable<Entities.Object>> GetObjects()
        {
            var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            //var repositories = await JsonSerializer.DeserializeAsync<List<object>>(await streamTask);
            return await Task<IEnumerable<Entities.Object>>.Run(() => { return objects; });
        }

    }
}
