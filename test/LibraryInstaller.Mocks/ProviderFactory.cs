﻿using LibraryInstaller.Contracts;

namespace LibraryInstaller.Mocks
{
    /// <summary>
    /// A mock <see cref="IProviderFactory"/> class for use in unit tests.
    /// </summary>
    /// <seealso cref="LibraryInstaller.Contracts.IProviderFactory" />
    public class ProviderFactory : IProviderFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderFactory"/> class.
        /// </summary>
        /// <param name="provider">The provider.</param>
        public ProviderFactory(IProvider provider)
        {
            Provider = provider;
        }

        /// <summary>
        /// Gets or sets the provider to return from <see cref="CreateProvider"/>.
        /// </summary>
        public IProvider Provider { get; set; }

        /// <summary>
        /// Creates an <see cref="T:LibraryInstaller.Contracts.IProvider" /> instance and assigns the <paramref name="hostInteraction"/> to it.
        /// </summary>
        /// <param name="hostInteraction">The <see cref="T:LibraryInstaller.Contracts.IHostInteraction" /> provided by the host to handle file system writes etc.</param>
        /// <returns>A <see cref="T:LibraryInstaller.Contracts.IProvider" /> instance.</returns>
        public IProvider CreateProvider(IHostInteraction hostInteraction)
        {
            Provider.HostInteraction = hostInteraction;
            return Provider;
        }
    }
}