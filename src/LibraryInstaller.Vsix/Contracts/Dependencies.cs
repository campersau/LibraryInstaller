﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using LibraryInstaller.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

namespace LibraryInstaller.Vsix
{
    public class Dependencies : IDependencies
    {
        private IHostInteraction _hostInteraction;
        private static List<IProvider> _providers = new List<IProvider>();
        private static Dictionary<string, Dependencies> _cache = new Dictionary<string, Dependencies>();

        [ImportMany(typeof(IProviderFactory))]
        private IEnumerable<IProviderFactory> _providerFactories { get; set; }

        private Dependencies(IHostInteraction hostInteraction)
        {
            _hostInteraction = hostInteraction;
            Initialize();
        }

        public IHostInteraction GetHostInteractions() => _hostInteraction;

        public static Dependencies FromConfigFile(string configFilePath)
        {
            if (!_cache.ContainsKey(configFilePath))
            {
                var hostInteraction = new HostInteraction(configFilePath);
                _cache[configFilePath] = new Dependencies(hostInteraction);
            }

            return _cache[configFilePath];
        }

        public IProvider GetProvider(string providerId)
        {
            return _providers?.FirstOrDefault(p => p.Id.Equals(providerId, StringComparison.OrdinalIgnoreCase));
        }

        private void Initialize()
        {
            if (_providers.Any())
                return;

            this.SatisfyImportsOnce();

            foreach (IProviderFactory factory in _providerFactories)
            {
                IProvider provider = factory.CreateProvider(_hostInteraction);

                if (provider != null && !_providers.Contains(provider))
                {
                    _providers.Add(provider);
                }
            }
        }
    }
}
