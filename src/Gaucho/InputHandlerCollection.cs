﻿using System.Collections;
using System.Collections.Generic;

namespace Gaucho
{
    /// <summary>
    /// 
    /// </summary>
    public class InputHandlerCollection : IEnumerable<IInputHandler>
    {
        private readonly Dictionary<string, IInputHandler> _plugins;

        /// <summary>
        /// 
        /// </summary>
        public InputHandlerCollection()
        {
            _plugins = new Dictionary<string, IInputHandler>();
        }

        /// <summary>
        /// Register a <see cref="IInputHandler"/>
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="plugin"></param>
        public void Register(string pipelineId, IInputHandler plugin)
        {
            plugin.PipelineId = pipelineId;

            _plugins[pipelineId.ToLower()] = plugin;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pipelineId"></param>
        /// <returns></returns>
        public IInputHandler<T> GetHandler<T>(string pipelineId)
        {
            var id = pipelineId.ToLower();
            if (!_plugins.ContainsKey(id))
            {
                return null;
            }

            return _plugins[id] as IInputHandler<T>;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		public IEnumerator<IInputHandler> GetEnumerator()
        {
            return _plugins.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
