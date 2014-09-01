using System.Threading.Tasks;

namespace Test
{
    public class ClassBuilder
    {
        public async Task<dynamic> CreateAsync(dynamic input)
        {
            var results = new dynamic[input.quantity];
            await Task.Run(() =>
            {
                for (int i = 0; i < input.quantity; i++)
                {
                    results[i] = new { tile = string.Format("{0} {1}", input.model.title, i), description = string.Format("{0} {1}", input.model.description, i), active = (i > 5) ? true : false };
                }
            });
            return results;
        }
    }
}

