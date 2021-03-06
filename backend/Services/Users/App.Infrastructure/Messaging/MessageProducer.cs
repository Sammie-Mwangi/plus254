﻿using App.Infrastructure.Messaging.Interfaces;
using Confluent.Kafka;
using System;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>

namespace App.Infrastructure.Messaging
{
    public class MessageProducer<TKey, TValue> : IDisposable, IMessageProducer<TKey, TValue> where TValue : class
    {
        private readonly IProducer<TKey, TValue> _producer;
        public MessageProducer(ProducerConfig config)
        {
            _producer = new ProducerBuilder<TKey, TValue>(config).SetValueSerializer(new MessageSerializer<TValue>()).Build();
        }


        public async Task ProduceAsync(string topic, TKey key, TValue value)
        {
            await _producer.ProduceAsync(topic, new Message<TKey, TValue> { Key = key, Value = value });
        }

        public void Dispose()
        {
            _producer.Flush();
            _producer.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
