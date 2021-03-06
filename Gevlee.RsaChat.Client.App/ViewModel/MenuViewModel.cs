﻿using Akka.Actor;
using GalaSoft.MvvmLight;
using Gevlee.RsaChat.Client.App.Actors;
using Gevlee.RsaChat.Client.App.Core.ViewModel;
using Gevlee.RsaChat.Client.App.Services;
using Gevlee.RsaChat.Client.Model;
using Prism.Commands;
using Prism.Events;
using ServerConnection = Gevlee.RsaChat.Common.Messages.ServerConnection;

namespace Gevlee.RsaChat.Client.App.ViewModel
{
	public class MenuViewModel : ViewModelBase, IMenuViewModel
	{
		private readonly IActorService actorService;
		private readonly IEventAggregator eventAggregator;
		private readonly IKeysStorage keysStorage;

		public MenuViewModel(
			IEventAggregator eventAggregator,
			IActorService actorService,
			IApplicationState applicationState,
			IKeysStorage keysStorage)
		{
			this.eventAggregator = eventAggregator;
			this.actorService = actorService;
			ApplicationState = applicationState;
			this.keysStorage = keysStorage;

			ConnectToServerCommand = new DelegateCommand(() =>
			{
				var core = actorService.CreateActor<ClientCoreActor>("core");
				core.Tell(new ServerConnection());
			});
		}

		public IApplicationState ApplicationState { get; }

		public DelegateCommand ConnectToServerCommand { get; }
	}
}