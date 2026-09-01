using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace C_OOP06
{
    internal static class PersonCloner
    {
        private static readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            IncludeFields = true
        };
        public static Person DeepCopyBySerialization(Person source)
        {
            string json = JsonSerializer.Serialize(source, options);//Object Original => String 

            return JsonSerializer.Deserialize<Person>(json, options)!;//string => new Object
        }
    }
}
