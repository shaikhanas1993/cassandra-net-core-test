
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cassandra;


namespace ca
{
    class Program
    {
        static void Main(string[] args)
        {
            var cluster = Cluster.Builder()
                     .AddContactPoints("localhost")
                     .Build();
            // Connect to the nodes using a keyspace
            var session = cluster.Connect("cycling");
            // Execute a query on a connection synchronously
            var rs = session.Execute("SELECT * FROM MusicPlaylist");
            // Iterate through the RowSet
            foreach (var row in rs)
            {
                Console.WriteLine(row[0]);
                Console.WriteLine(row[1]);
                Console.WriteLine(row[2]);
               
            }

        }
    }
}
