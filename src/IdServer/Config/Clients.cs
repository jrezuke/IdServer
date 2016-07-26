using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdServer.Config
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
            {
                new Client
                {
                    Enabled = true,
                    ClientName = "JS Client",
                    ClientId = "js",
                    AllowedGrantTypes = GrantTypes.Implicit,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:40875/popup.html"
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:40875"
                    },

                    AllowAccessToAllScopes = true
                },
                new Client
                {
                    Enabled = true,
                    ClientName = "IFAR Extranet",
                    ClientId = "js-oidc",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    
                    RedirectUris = new List<string>
                    {
                        "http://localhost:7017/index.html"
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:7017"
                    },

                    AllowedScopes = new List<string> { "openid", "profile", "email", "api.todo" }
                },
                new Client
                {
                    Enabled = true,
                    ClientName = "OAuth2 Client Service",
                    ClientId = "spa-demo",
                    AllowedGrantTypes = GrantTypes.Implicit,

                    RedirectUris = new List<string>
                    {
                        "https://localhost:44351"
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:37430",
                        "https://localhost:44351"
                    },

                    AllowAccessToAllScopes = true
                },
                new Client
                {
                    Enabled = true,
                    ClientName = "OAuth2 Client Service",
                    ClientId = "js_oauth",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    RedirectUris = new List<string>
                    {
                        "http://localhost:28895/index.html"
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:28895"
                    },

                    AllowAccessToAllScopes = true
                },
                new Client
                {
                    Enabled = true,
                    ClientName = "IFAR Extranet",
                    ClientId = "ifar.extranet",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    PostLogoutRedirectUris = new List<string>
                    {
                        "http://localhost:8010"
                    },
                    RedirectUris = new List<string>
                    {
                        "http://localhost:8010",
                        "http://localhost:34138"
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:8010",
                        "http://localhost:34138"
                    },

                    AllowAccessToAllScopes = true
                },
                new Client
                {
                    Enabled = true,
                    ClientName = "IFAR Extranet",
                    ClientId = "ifar.extranet2",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    RedirectUris = new List<string>
                    {
                        "http://localhost:21308"
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:21308"
                    },

                    AllowAccessToAllScopes = true
                },
                new Client
                {
                    Enabled = true,
                    ClientName = "OAuth2 Ng2 Client Service",
                    ClientId = "js.ng2",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    RedirectUris = new List<string>
                    {
                        "http://localhost:3000"
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:3000"
                    },

                    AllowAccessToAllScopes = true
                },
                new Client
                {
                    Enabled = true,
                    ClientName = "OAuth2 Client Service",
                    ClientId = "spa-demo",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    RedirectUris = new List<string>
                    {
                        "http://localhost:8080/home"
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:8080"
                    },

                    AllowAccessToAllScopes = true
                },                
                new Client
                {
                    Enabled = true,
                    ClientName = "OAuth2 Client Service",
                    ClientId = "angular2client",
                    AllowedGrantTypes = GrantTypes.Implicit,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:40005"
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:40005"
                    },

                    AllowAccessToAllScopes = true
                }
            };
        }
    }
}
