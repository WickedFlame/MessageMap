﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Gaucho.Diagnostics
{
    public class Logger : ILogger
    {
        private readonly List<ILogWriter> _writers;
        
        public Logger()
        {
            _writers = new List<ILogWriter>();
        }

        public List<ILogWriter> Writers => _writers;

        public void Write<T>(T @event, Category category) where T : ILogEvent
        {
            foreach(var writer in _writers.Where(w => w.Category == category))
            {
                //var w = (ILogWriter<T>)Convert.ChangeType(writer, typeof(ILogWriter<T>), null);
                //w.Write(@event);
                writer.Write(@event);
            }
        }
    }

    public static class LoggerExtensions
    {
        public static void Write(this ILogger logger, string message, Category category, LogLevel level = LogLevel.Info, string source = null)
        {
            switch (category)
            {
                case Category.Log:
                    logger.Write(new LogEvent(message, level, source), category);
                    break;
            }
        }

        public static void Write(this ILogger logger, string message, StatisticType metric)
        {
            logger.Write(new StatisticEvent(message, metric), Category.EventStatistic);
        }
    }
}
