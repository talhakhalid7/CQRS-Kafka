using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CQRS.Core.Commands;
using CQRS.Core.Infrastructure;

namespace Post.Cmd.Infrastucture.Despatchers
{
    public class CommandDespatcher : ICommandDespatcher
    {
        private readonly Dictionary<Type, Func<BaseCommand, TaskAwaiter>> _handlers = new();
        {
            if (_)
            {
                
            }
            throw new NotImplementedException();
        }

        public Task SendAsync(BaseCommand command)
        {
            throw new NotImplementedException();
        }
    }
}