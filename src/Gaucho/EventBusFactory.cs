﻿using System;
using System.Collections.Generic;
using Gaucho.Server.Monitoring;

namespace Gaucho
{
    public interface IEventBusFactory
    {
        IEnumerable<string> Pipelines { get; }

        void Register(string pipelineId, Func<IEventPipeline> factory);

        void Register(string pipelineId, IEventBus eventBus);

        IEventBus GetEventBus(string pipelineId);
    }

    public class EventBusFactory : IEventBusFactory
    {
        private readonly Dictionary<string, IPipelineFactory> _pipelineRegistrations;
        private readonly Dictionary<string, IEventBus> _activeEventBus;

        public EventBusFactory()
        {
            _pipelineRegistrations = new Dictionary<string, IPipelineFactory>();
            _activeEventBus = new Dictionary<string, IEventBus>();
        }

        public IEnumerable<string> Pipelines => _pipelineRegistrations.Keys;

        public void Register(string pipelineId, Func<IEventPipeline> factory)
        {
            _pipelineRegistrations[pipelineId] = new PipelineFactory(factory);
        }

        public void Register(string pipelineId, IEventBus eventBus)
        {
            if (_activeEventBus.ContainsKey(pipelineId))
            {
                throw new Exception($"Pipeline {pipelineId} is already running. The EventBus for the Pipeline {pipelineId} cannot be changed.");
            }

            if (pipelineId != eventBus.PipelineId)
            {
                throw new Exception($"The EventBus with PipelineId {eventBus.PipelineId} cannot be registered to the pipeline {pipelineId}");
            }

            var factory = _pipelineRegistrations[pipelineId];
            eventBus.SetPipeline(factory);

            _activeEventBus[pipelineId] = eventBus;
        }

        public IEventBus GetEventBus(string pipelineId)
        {
            if (!_activeEventBus.ContainsKey(pipelineId))
            {
                var factory = _pipelineRegistrations[pipelineId];
                var eventBus = new EventBus(factory, pipelineId);

                _activeEventBus[pipelineId] = eventBus;
            }

            return _activeEventBus[pipelineId];
        }
    }
}
