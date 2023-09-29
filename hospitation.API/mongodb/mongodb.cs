using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace hospitation.API.mongodb;

class Program 
{

    private static string ConnectionString = "mongodb://0.0.0.0:8080";
    private static string Database = "flachwitze";


    static void Main(string[] args) 
    {
        MongoClient dbClient = new MongoClient(ConnectionString);
        var dbList = dbClient.ListDatabases().ToList();

        Console.WriteLine("List is: ");
        foreach (var db in dbList)
        {
            Console.WriteLine(db);
        }
    }
}

