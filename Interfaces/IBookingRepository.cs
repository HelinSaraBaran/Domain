using System.Collections.Generic;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IBookingRepository
    {
        List<Visit> GetAll();                    // Henter alle bookinger
        void Add(Visit visit);                   // Tilføjer ny booking
        void SaveAll(List<Visit> visits);        // Gemmer hele listen
        void Delete(int id);                     // Sletter en booking ud fra ID
    }
}
