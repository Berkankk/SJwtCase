// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace SJwtCase.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),

                   };
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("resource_catalog"){Scopes = {"catalog_fullpermission","catalog_readpermission"}},
            new ApiResource("resource_discount"){Scopes ={"discount_fullpermission","discount_readpermission"}},
            new ApiResource("resource_order"){Scopes ={"order_fullpermission"}},
            new ApiResource("resource_ocelot"){Scopes ={"ocelot_fullpermission"}},
            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("catalog_fullpermission","Full Permission for catalog operations"), //katalog full yetkisi olacak
                new ApiScope("catalog_readpermission","Reading Permission for catalog service"), //katalog da okuma yapacak 
                new ApiScope("discount_fullpermission","Full Permission for discount operations"),
                new ApiScope("discount_readpermission","Reading Permission for discount operations"),
                new ApiScope("order_fullpermission","Full Permission for order operations"),
                new ApiScope("ocelot_fullpermission","Full Permission for ocelot operations"), //Tam yetki verdik 
                new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                //Admin
               new Client
               {
                   ClientId="SJwtCaseAdminClient",//Bu bir admindir
                   ClientName="SJwtCase Admin User",
                   ClientSecrets={new Secret("secret".Sha256())},//adı ve şifreleme yöntemi 
                   AllowedGrantTypes=GrantTypes.ResourceOwnerPassword, //admin şifresi ve yetkileri olduğu yeri vereceğiz
                   AllowedScopes={ "catalog_fullpermission", "order_fullpermission", "discount_fullpermission","ocelot_fullpermission",
                       IdentityServerConstants.LocalApi.ScopeName,
                       IdentityServerConstants.StandardScopes.Email,
                       IdentityServerConstants.StandardScopes.OpenId,
                       IdentityServerConstants.StandardScopes.Profile
                       
                   },//nerelere erişimi var 

                   AccessTokenLifetime = 600 //Kaç saniye olduğunu verdik 
               },
               //Visitor
               new Client
               {
                   ClientId ="SJwtCaseVisitorClient", //Bu bir misafirdir
                   ClientName ="SJwtCase Visitor User",
                   ClientSecrets = {new Secret("secret".Sha256())},
                   AllowedGrantTypes = GrantTypes.ClientCredentials,
                   AllowedScopes = {"catalog_readpermission", "ocelot_fullpermission", IdentityServerConstants.LocalApi.ScopeName}
               }
            };
    }
}