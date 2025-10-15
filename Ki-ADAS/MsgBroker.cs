using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ki_ADAS
{
	public class MsgBroker
	{
		private readonly Dictionary<string, List<Action<object>>> subscribers
			= new Dictionary<string, List<Action<object>>>();
		public MsgBroker() { }
		public void Subscribe(string topic, Action<object> handler)
		{
			if (!subscribers.ContainsKey(topic))
				subscribers[topic] = new List<Action<object>>();

			subscribers[topic].Add(handler);
		}

		public void Publish(string topic, object data)
		{
			if (subscribers.ContainsKey(topic))
			{
				foreach (var handler in subscribers[topic])
					handler(data);
			}
		}
		public void Unsubscribe(string topic, Action<object> handler)
		{
			if (subscribers.ContainsKey(topic))
				subscribers[topic].Remove(handler);
		}

	}
}
