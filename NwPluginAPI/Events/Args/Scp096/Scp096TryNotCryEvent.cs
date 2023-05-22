using PluginAPI.Core;
using PluginAPI.Enums;
using PluginAPI.Core.Attributes;

namespace PluginAPI.Events.Args.Scp096
{
	public class Scp096TryNotCryEvent : IEventArguments
	{
		public ServerEventType BaseType { get; } = ServerEventType.Scp096TryNotCry;
		[EventArgument]
		public Core.Player Player { get; }

		public Scp096TryNotCryEvent(ReferenceHub hub)
		{
			Player = Core.Player.Get(hub);
		}

		Scp096TryNotCryEvent() { }
	}
}
