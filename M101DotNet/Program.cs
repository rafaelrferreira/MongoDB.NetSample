using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M101DotNet {
    class Program {
        static void Main(string[] args) {
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);

            var db = client.GetDatabase("test");
            var collection = db.GetCollection<BsonDocument>("name");
            var list = collection.Find(new BsonDocument()).ToList();

            Console.WriteLine();
            foreach(var document in list) {
                Console.WriteLine(document["name"]);
            }
            Console.WriteLine("Pressione ENTER");
            Console.ReadLine();
        }
    }

    public class Person {
        public ObjectId _id { get; set; }
        public  string name { get; set; }
    }
}
