﻿using System;
using Akka.Actor;
using Akka.Event;
using Gevlee.RsaChat.Common.Messages;

namespace Gevlee.RsaChat.Common.Actors
{
	public class ServerCoreActor : ReceiveActor
	{
		public ServerCoreActor()
		{
			Receive<ConnectRequest>(request =>
			{
				Sender.Tell(new ConnectionReference()
				{
					Status = true,
					ClientName = request.NicknameProposition
				});
				Context.GetLogger().Info($"Connected: {request.NicknameProposition}");
			});
		}

		protected override void PreStart()
		{
			Console.WriteLine($"[{Self.Path}] - pre start");
			base.PreStart();
		}
	}
}