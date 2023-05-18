using System;
using Microsoft.Extensions.Logging;

using CMS.Core;
using CMS.Base;

namespace XperienceAdapter.Logging
{
    public class XperienceLogger : ILogger
    {
        private readonly string _name;

        private readonly IEventLogService _eventLogService;
        public XperienceLogger(string name, IEventLogService eventLogService)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _eventLogService = eventLogService ?? throw new ArgumentNullException(nameof(eventLogService));
        }
        public IDisposable BeginScope<TState>(TState state) => null!;
        public bool IsEnabled(LogLevel logLevel) => logLevel != LogLevel.None;



        private EventTypeEnum MapLogLevel(LogLevel logLevel) =>
            logLevel switch
            {
                LogLevel.Trace => EventTypeEnum.Information,
                LogLevel.Debug => EventTypeEnum.Information,
                LogLevel.Information => EventTypeEnum.Information,
                LogLevel.Warning => EventTypeEnum.Warning,
                LogLevel.Error => EventTypeEnum.Error,
                LogLevel.Critical => EventTypeEnum.Error,
                LogLevel.None => EventTypeEnum.Error,
                _ => EventTypeEnum.Information,
            };

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            if (formatter == null)
            {
                throw new ArgumentNullException(nameof(formatter));
            }

            var message = formatter(state, exception);

            if (!string.IsNullOrEmpty(message) || exception != null)
            {
                var eventType = MapLogLevel(logLevel);
                int siteId = default;

                try
                {
                    siteId = Service.ResolveOptional<ISiteService>().CurrentSite?.SiteID ?? default;
                }
                catch
                {
                }

                EventLogData eventData;

                if (!string.IsNullOrEmpty(eventId.Name))
                {
                    eventData = new EventLogData(eventType, _name, eventId.Name)
                    {
                        SiteID = siteId,
                        EventDescription = message,
                        Exception = exception
                    };
                }
                else
                {
                    eventData = new EventLogData(eventType, _name, message)
                    {
                        SiteID = siteId,
                        Exception = exception
                    };
                }
                try
                {
                    _eventLogService.LogEvent(eventData);
                }
                catch
                {
                }
            }
        }
    }
    }
