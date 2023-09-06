using KonicaTracking.Services.Models;
using System.Text.Json.Serialization;

namespace KonicaTracking.Models.Request
{
    public class LocalitationRequest : ILocation
    {
        /// <inheritdoc/>
        [JsonIgnore]
        public int Id { get; set; }

        /// <inheritdoc/>
        [JsonIgnore]
        public DateTime Date { get; set; }

        /// <inheritdoc/>
        public decimal Latitude { get; set; }

        /// <inheritdoc/>
        public decimal Longitude { get; set; }
    }
}
