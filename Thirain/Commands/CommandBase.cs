﻿using Discord.Commands;
using Fergun.Interactive;
using System.Collections.Generic;
using Thirain.Data.DataAccess;

namespace Thirain.Commands
{
    public abstract class CommandBase : ModuleBase<SocketCommandContext>
    {
        protected readonly IUnitOfWorkServer _dal;
        protected readonly List<string> _channels;
        public InteractiveService Interactive { get; set; }
        protected CommandBase(IUnitOfWorkServer dal)
        {
            _dal = dal;
            _channels = FillChannelCommands();
        }

        private List<string> FillChannelCommands()
        {
            List<string> retList = new List<string>();
            retList.Add("merchant");
            retList.Add("event");

            return retList;
        }
    }
}
