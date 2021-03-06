﻿using Gevlee.RsaChat.Client.Model;

namespace Gevlee.RsaChat.Client.App.Core.ViewModel
{
	public interface IMainViewModel
	{
		IMenuViewModel MenuViewModel { get; }
		IStatusBarViewModel StatusBarViewModel { get; }
		IChatBoxViewModel ChatBoxViewModel { get; }
		IMessageTypingViewModel MessageTypingViewModel { get; }
		IApplicationState ApplicationState { get; }
	}
}