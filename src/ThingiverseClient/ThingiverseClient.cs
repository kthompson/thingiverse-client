using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using ThingiverseClient.Http;

namespace ThingiverseClient
{
    public class ThingiverseClient : IThingiverseClient
    {

        public static readonly Uri ThingiverseApiUrl = new Uri("https://api.thingiverse.com/");

        public ThingiverseClient(ProductHeaderValue header)
            : this(new Connection(header, ThingiverseApiUrl))
        {
        }

        public ThingiverseClient(ProductHeaderValue header, ICredentialStore credentialStore)
            : this(new Connection(header, credentialStore))
        {
        }

        public ThingiverseClient(ProductHeaderValue productInformation, Uri baseAddress)
            : this(new Connection(productInformation, baseAddress))
        {
        }

        public ThingiverseClient(ProductHeaderValue productInformation, ICredentialStore credentialStore, Uri baseAddress)
            : this(new Connection(productInformation, baseAddress, credentialStore))
        {
        }

        private ThingiverseClient(Connection connection)
        {
            throw new NotImplementedException();
        }


        public IConnection Connection { get; }
        public IUsersClient Users { get; }
        public IThingsClient Things { get; }
        public IFilesClient Files { get; }
        public ICollectionsClient Collections { get; }
    }

    public class Connection : IConnection
    {
        public Connection(ProductHeaderValue header, Uri baseUri)
        {
            throw new NotImplementedException();
        }

        public Connection(ProductHeaderValue header, ICredentialStore credentialStore)
        {
            throw new NotImplementedException();
        }

        public Connection(ProductHeaderValue productInformation, Uri baseUri, ICredentialStore credentialStore1)
        {
            throw new NotImplementedException();
        }
    }

    public interface IThingiverseClient
    {
        IConnection Connection { get; }

        IUsersClient Users { get; }

        IThingsClient Things { get; }
        
        IFilesClient Files { get; }

        ICollectionsClient Collections { get; }
    }

    public interface ICollectionsClient
    {
    }

    public interface IUsersClient
    {
    }

    public interface IFilesClient
    {
    }

    public interface IThingsClient
    {
    }
}
