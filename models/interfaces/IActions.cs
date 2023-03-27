using BuyingLibrary.models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.models.interfaces
{
    internal interface IActions<T>
    {

        T DeserBson(BsonDocument b);


    }
}
