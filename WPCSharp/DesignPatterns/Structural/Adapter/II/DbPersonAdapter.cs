using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural.Adapter.II
{
    public class DbPersonAdapter : IPerson
    {
        private DbPerson _dbPerson;

        public DbPersonAdapter(DbPerson dbPerson)
        {
            _dbPerson = dbPerson;
        }

        public string Name => $"{_dbPerson.FirstName} {_dbPerson.LastName}";

        public int Age => DateTime.Now.Year - _dbPerson.BirthDate.Year;
    }
}
