using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Proxy
{
    public class DatabaseProxy : IDatabase
    {
        public const int NumberOfAvailableConnections = 5;

        private Database database;
        private SemaphoreSlim semaphore = new SemaphoreSlim(NumberOfAvailableConnections);

        public DatabaseProxy(Database database)
        {
            this.database = database;
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            if(database == null)
            {
                Console.WriteLine("New database");
                database = new Database();
            }

            await semaphore.WaitAsync();
            var result = await database.RequestAsync(parameter);
            semaphore.Release();

            if(semaphore.CurrentCount == NumberOfAvailableConnections)
            {
                database = null;
                Console.WriteLine("Dispose database");
            }

            return result;
        }
    }
}
