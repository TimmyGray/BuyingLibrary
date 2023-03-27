using BuyingLibrary.models.classes;
using BuyingLibrary.models.interfaces;
using DnsClient.Protocol;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.Actions
{
    public class DeserAction : IActions<Item>
    {
        public Item DeserBson(BsonDocument itemofprice)
        {
            
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"item of price:\n{itemofprice}");
            Console.ResetColor();

            if (itemofprice.Contains("length")&& itemofprice.Contains("typeofsignal"))
            {
               
                Item coil = BsonSerializer.Deserialize<Coil>(itemofprice);
                
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine(coil.ToString());
                Console.ResetColor();

                return coil;
                
            }
            else
            {

                Item conn = BsonSerializer.Deserialize<Connector>(itemofprice);
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(conn.ToString());
                Console.ResetColor();

                return conn;

            }

            
        }

    }
}
