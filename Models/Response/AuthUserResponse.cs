﻿using KonicaTracking.Services.Models;
using System.Text.Json.Serialization;

namespace KonicaTracking.Models.Response
{
    public class AuthUserResponse : IUser
    {
        ///<inheritdoc/>
        [JsonIgnore]
        public int Id { get; set; }

        ///<inheritdoc/>
        public string? Name { get; set; }

        ///<inheritdoc/>
        [JsonIgnore]
        public string? Password { get; set; }

        ///<inheritdoc/>        
        public string? Token { get; set; }
    }
}
