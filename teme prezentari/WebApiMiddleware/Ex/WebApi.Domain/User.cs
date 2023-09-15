using System.Text.Json.Serialization;

namespace WebApi.Domain
{
    public class User
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}