﻿using Microsoft.AspNetCore.SignalR;

namespace KonicaTracking.SignalRComunication
{
    public class VehicleLocationHub : Hub
    {
        public async Task SendOrderLocation(int vehicleId, decimal latitude, decimal longitude)
        {
            await Clients.All.SendAsync("receivevehiclelocation", vehicleId, latitude, longitude);
        }
    }
}
