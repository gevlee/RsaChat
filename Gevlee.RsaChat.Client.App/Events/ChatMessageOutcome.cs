﻿using Gevlee.RsaChat.Client.Model;
using Prism.Events;

namespace Gevlee.RsaChat.Client.App.Events
{
	public class ChatMessageOutcome : PubSubEvent<ChatMessage>
	{
	}
}