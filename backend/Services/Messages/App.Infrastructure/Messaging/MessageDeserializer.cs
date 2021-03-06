﻿using Confluent.Kafka;
using Newtonsoft.Json;
using System;
using System.Text;

namespace App.Infrastructure.Messaging
{
    internal sealed class MessageDeserializer<T> : IDeserializer<T>
    {

        public T Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
        {
            if (typeof(T) == typeof(Null))
            {
                if (data.Length > 0)
                    throw new ArgumentException("Null data provided.");
                return default;
            }

            if (typeof(T) == typeof(Ignore))
                return default;

            var dataJson = Encoding.UTF8.GetString(data);


            return JsonConvert.DeserializeObject<T>(dataJson);
        }
    }
}
