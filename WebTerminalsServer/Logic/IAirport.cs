﻿using WebTerminalsServer.Models;

namespace WebTerminalsServer.Logic
{
    public interface IAirport
    {
         void ProccessFlight(Flight flight);
        void AddLandingFLight(Flight flight);
        void AddDepartureFlight(Flight flight);
        Task<IEnumerable<Flight>> GetFlights();
        Task<IEnumerable<Logger>> GetLogs();
        Task<IEnumerable<LegModel>> GetLegs();
    }
}
