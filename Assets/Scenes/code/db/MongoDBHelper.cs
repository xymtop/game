using MongoDB.Driver;
using System.Collections;
using System.Reflection;
using UnityEngine;

namespace Assets.Scenes.code.db
{
    public class MongoDBHelper
    {
        public static FilterDefinition<T> BuildNonNullPropertiesFilter<T>(T searchCriteria)
        {
            var filterBuilder = Builders<T>.Filter;
            FilterDefinition<T> filter = FilterDefinition<T>.Empty; 

            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                var value = property.GetValue(searchCriteria);
                if (value != null)
                {
              
                    var propertyFilter = filterBuilder.Eq(property.Name, value);
                    filter = filter == FilterDefinition<T>.Empty ? propertyFilter : filter & propertyFilter;
                }
            }

            return filter;
        }
    }
}