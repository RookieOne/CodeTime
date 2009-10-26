using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeTime.Infrastructure.Events
{
    public class EventAggregator : IEventAggregator
    {
        Dictionary<Type, List<object>> _subscriptions;

        public EventAggregator()
        {
            
        }

        public void Register<T>(Action<T> subscriptionAction)
        {
            throw new NotImplementedException();
        }

        public void Publish<T>(T eventToPublish)
        {
            throw new NotImplementedException();
        }
    }
}
