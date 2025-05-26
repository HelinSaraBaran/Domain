using System.Collections.Generic;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IAnimalRepository
    {
        // Henter alle dyr
        List<Animal> GetAll();

        // Henter et dyr baseret på dets id
        Animal GetById(int id);

        // Gemmer hele listen af dyr (bruges fx efter ændringer i VisitLog)
        void SaveAll(List<Animal> animals);

       
        void Add(Animal animal);
    }
}
