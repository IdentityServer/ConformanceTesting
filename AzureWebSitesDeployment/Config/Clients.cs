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
                        "https://op.certification.openid.net:60272/authz_cb",
                    }
                }
            };
        }
    }
}