﻿using System;
using TS3QueryLib.Net.Core.Common;
using TS3QueryLib.Net.Core.Common.CommandHandling;

namespace TS3QueryLib.Net.Core.Server.Notification.EventArgs
{
    public class ChannelDescriptionChangedEventArgs : System.EventArgs, IDump
    {
        #region Properties

        public uint? ChannelId { get; protected set; }

        #endregion

        #region Constructors

        public ChannelDescriptionChangedEventArgs(CommandParameterGroupList commandParameterGroupList)
        {
            if (commandParameterGroupList == null)
                throw new ArgumentNullException(nameof(commandParameterGroupList));

            ChannelId = commandParameterGroupList.GetParameterValue<uint>("cid");
        }

        #endregion
    }
}