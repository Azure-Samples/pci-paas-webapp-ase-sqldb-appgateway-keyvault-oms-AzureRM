using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.SqlServer.Management.AlwaysEncrypted.AzureKeyVaultProvider;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ContosoWebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static ClientCredential _clientCredential;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            InitializeAzureKeyVaultProvider();
        }
        static void InitializeAzureKeyVaultProvider()
        {
            //var keyvalutclient = new keyvalutclient
            string clientId = ConfigurationManager.AppSettings["AuthClientId"];
            string clientSecret = ConfigurationManager.AppSettings["AuthClientSecret"];
            _clientCredential = new ClientCredential(clientId, clientSecret);

            // Direct the provider to the authentication delegate
            SqlColumnEncryptionAzureKeyVaultProvider azureKeyVaultProvider = new SqlColumnEncryptionAzureKeyVaultProvider(GetToken);

            Dictionary<string, SqlColumnEncryptionKeyStoreProvider> providers = new Dictionary<string, SqlColumnEncryptionKeyStoreProvider>();
            providers.Add(SqlColumnEncryptionAzureKeyVaultProvider.ProviderName, azureKeyVaultProvider);

            // register the provider with ADO.net
            SqlConnection.RegisterColumnEncryptionKeyStoreProviders(providers);
        }

        /// <summary>
        /// A callback to redeem the application id/key for a token for Azure Key Vault
        /// </summary>
        public async static Task<string> GetToken(string authority, string resource, string scope)
        {
            var authContext = new AuthenticationContext(authority);
            AuthenticationResult result = await authContext.AcquireTokenAsync(resource, _clientCredential);

            if (result == null)
                throw new InvalidOperationException("Failed to obtain the JWT token");

            return result.AccessToken;
        }

    }
}
