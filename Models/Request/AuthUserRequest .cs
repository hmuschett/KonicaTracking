using KonicaTracking.Services.Models;
using System.Text.Json.Serialization;

namespace KonicaTracking.Models.Request
{
    public class AuthUserRequest : IUser
    {
        ///<inheritdoc/>
        [JsonIgnore]
        public int Id { get; set; }

        ///<inheritdoc/>
        public string? Name { get; set; }

        ///<inheritdoc/>
        public string? Password { get; set; }

        ///<inheritdoc/>
        [JsonIgnore]
        public string? Token { get; set; }
    }

}
