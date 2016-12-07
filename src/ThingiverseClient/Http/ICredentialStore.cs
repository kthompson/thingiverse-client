﻿using System.Threading.Tasks;

namespace ThingiverseClient.Http
{
    /// <summary>
    /// Abstraction for interacting with credentials
    /// </summary>
    public interface ICredentialStore
    {
        /// <summary>
        /// Retrieve the credentials from the underlying store
        /// </summary>
        /// <returns>A continuation containing credentials</returns>
        Task<Credentials> GetCredentials();
    }
}