using AzureWebSitesDeployment.Config;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;
using Thinktecture.IdentityServer.Core.Configuration;
using Thinktecture.IdentityServer.Core.Logging;
using Thinktecture.IdentityServer.Core.Services;

namespace AzureWebSitesDeployment
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            LogProvider.SetCurrentLogProvider(new DiagnosticsTraceLogProvider());

            var factory = InMemoryFactory.Create(
                users:   Users.Get(),
                clients: Clients.Get(),
                scopes:  Scopes.Get());

            var idsrvOptions = new IdentityServerOptions
            {
                SiteName = "IdentityServer3 Conformance Testing",
                Factory = factory,
                SigningCertificate = Cert.Load(),
            };

            app.UseIdentityServer(idsrvOptions);
        }
    }
}