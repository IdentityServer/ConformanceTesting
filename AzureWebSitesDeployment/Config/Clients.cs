using System.Collections.Generic;
using Thinktecture.IdentityServer.Core.Models;

namespace AzureWebSitesDeployment.Config
{
    public class Clients
    {
        public static List<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientName = "Basic",
                    Enabled = true,

                    ClientId = "basic",
                    ClientSecrets = new List<ClientSecret>
                    {
                        new ClientSecret("secret".Sha256())
                    },

                    Flow = Flows.AuthorizationCode,
                    
                    RedirectUris = new List<string>
                    {
                        "https://op.certification.openid.net:60274/authz_cb",
                    }
                },
                new Client
                {
                    ClientName = "Implicit",
                    Enabled = true,

                    ClientId = "implicit",
                    ClientSecrets = new List<ClientSecret>
                    {
                        new ClientSecret("secret".Sha256())
                    },

                    Flow = Flows.Implicit,
                    
                    RedirectUris = new List<string>
                    {
                        "https://op.certification.openid.net:60275/authz_cb",
                    }
                },
                new Client
                {
                    ClientName = "Hybrid",
                    Enabled = true,

                    ClientId = "hybrid",
                    ClientSecrets = new List<ClientSecret>
                    {
                        new ClientSecret("secret".Sha256())
                    },

                    Flow = Flows.Hybrid,
                    
                    RedirectUris = new List<string>
                    {
                        "https://op.certification.openid.net:60276/authz_cb",
                    }
                }
            };
        }
    }
}