using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();
        public DemoDataAccess()
        {
            people.Add(item: new PersonModel { Id = 1, FirstName = "Ali", LastName = "Yılmaz" });
            people.Add(item: new PersonModel { Id = 2, FirstName = "Can", LastName = "Gök" });
            people.Add(item: new PersonModel { Id = 3, FirstName = "Cem", LastName = "Ateş" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new() { FirstName = firstName, LastName = lastName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }

        public void DeletePerson(int id)
        {
            PersonModel p = people.Find(x => x.Id == id);
            people.Remove(p);
        }
    }
}
