using MongoDB.Bson.Serialization.Attributes;

namespace BuyingLibrary.models.classes
{
    public class Client
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("email")]
        public string? Email { get; set; }

        public string Password { get;set; }
        
        public Client(string name, string email, string password) 
        {
            Name = name;
            Email = email;
            Password = BCrypt.Net.BCrypt.HashPassword(password,BCrypt.Net.BCrypt.GenerateSalt());
            
        }


    }
}
