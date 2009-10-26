using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Castle.Core.Interceptor;
using CodeTime.Infrastructure.Attributes;

namespace CodeTime.Windsor
{
    public class NotifyPropertyChangedInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            // let the original call go through first, so we can notify *after*
            invocation.Proceed();

            if (invocation.Method.Name.StartsWith("set_"))
            {
                string propertyName = invocation.Method.Name.Substring(4);
                var pi = invocation.TargetType.GetProperty(propertyName);

                // check that we have the attribute defined
                if (Attribute.GetCustomAttribute(pi, typeof (NotifyAttribute)) == null)
                    return;

                // get the field storing the delegate list that are stored by the event.
                FieldInfo info = invocation.TargetType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Where(f => f.FieldType == typeof (PropertyChangedEventHandler))
                    .FirstOrDefault();

                if (info != null)
                {
                    // get the value of the field
                    PropertyChangedEventHandler evHandler =
                        info.GetValue(invocation.InvocationTarget) as PropertyChangedEventHandler;
                    // invoke the delegate if it's not null (aka empty)
                    if (evHandler != null)
                        evHandler.Invoke(invocation.TargetType, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
    }
}