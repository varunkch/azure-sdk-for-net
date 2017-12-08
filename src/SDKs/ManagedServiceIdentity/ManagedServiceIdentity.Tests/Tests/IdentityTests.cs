using Microsoft.Azure.Management.ManagedServiceIdentity;
using Microsoft.Azure.Management.ManagedServiceIdentity.Models;
using Microsoft.Rest;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xunit;

namespace ManagedServiceIdentity.Tests.Tests
{
    public class IdentityTests
    {
        private static HttpClientHandler Handler = null;

        [Fact]
        public void IdentityCreateTest()
        {
            /*var handler = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                context.GetServiceClient<ManagedServiceIdentityClient>(handlers: GetHandler());
                var msiMgmtClient = new ManagedServiceIdentityClient(new TokenCredentials("xyz"), GetHandler());
                msiMgmtClient.SubscriptionId = "f871dcf3-f8c8-42b3-933b-451c20342f55";

                Identity identityParameters = new Identity(location: "cus");
                Identity createdIdentity = msiMgmtClient.UserAssignedIdentities.CreateOrUpdate("SDKTest", "testIdentity1", identityParameters);
            }*/
        }
        private static HttpClientHandler GetHandler()
        {
            return Handler;
        }
    }
}
