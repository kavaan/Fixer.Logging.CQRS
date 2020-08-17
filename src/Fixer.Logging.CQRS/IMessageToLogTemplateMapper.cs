using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.Logging.CQRS
{
    public interface IMessageToLogTemplateMapper
    {
        HandlerLogTemplate Map<TMessage>(TMessage message) where TMessage : class;
    }
}
