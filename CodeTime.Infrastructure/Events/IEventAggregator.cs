using System;

namespace CodeTime.Infrastructure.Events
{
    public interface IEventAggregator
    {
        void Register<T>(Action<T> subscriptionAction);
        void Publish<T>(T eventToPublish);
    }
}