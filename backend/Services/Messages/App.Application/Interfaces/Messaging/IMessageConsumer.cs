﻿using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>

namespace App.Application.Interfaces.Messaging
{
    public interface IMessageConsumer<TKey, TValue> where TValue : class
    {

        public Task Consume(string topic, CancellationToken cancellationToken);

        public void Close();

        public void Dispose();
    }
}
