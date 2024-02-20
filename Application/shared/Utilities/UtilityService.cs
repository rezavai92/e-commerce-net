using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.shared.Utilities
{
    public class UtilityService
    {
        public T CloneObject<T>(T source) where T : class
        {
            var jsonString = JsonSerializer.Serialize(source);

            var cloned = JsonSerializer.Deserialize<T>(jsonString);

            return cloned;
        }
    }
}
