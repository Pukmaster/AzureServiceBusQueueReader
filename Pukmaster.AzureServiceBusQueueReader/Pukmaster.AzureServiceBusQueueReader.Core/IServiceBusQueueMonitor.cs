﻿using System.Threading.Tasks;

namespace Pukmaster.AzureServiceBusQueueReader.Core
{
    public interface IServiceBusQueueMonitor
    {
        void RegisterServiceBusQueueMonitor(string queueName, string serviceBusConnectionString);

        Task DeregisterServiceBusQueueMonitorAsync();
    }
}