using Microsoft.Graph.Me.Authentication.WindowsHelloForBusinessMethods.Item.Device.RegisteredOwners.Item.AppRoleAssignment;
using Microsoft.Graph.Me.Authentication.WindowsHelloForBusinessMethods.Item.Device.RegisteredOwners.Item.Endpoint;
using Microsoft.Graph.Me.Authentication.WindowsHelloForBusinessMethods.Item.Device.RegisteredOwners.Item.Ref;
using Microsoft.Graph.Me.Authentication.WindowsHelloForBusinessMethods.Item.Device.RegisteredOwners.Item.ServicePrincipal;
using Microsoft.Graph.Me.Authentication.WindowsHelloForBusinessMethods.Item.Device.RegisteredOwners.Item.User;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace Microsoft.Graph.Me.Authentication.WindowsHelloForBusinessMethods.Item.Device.RegisteredOwners.Item {
    /// <summary>Builds and executes requests for operations under \me\authentication\windowsHelloForBusinessMethods\{windowsHelloForBusinessAuthenticationMethod-id}\device\registeredOwners\{directoryObject-id}</summary>
    public class DirectoryObjectItemRequestBuilder {
        /// <summary>The appRoleAssignment property</summary>
        public AppRoleAssignmentRequestBuilder AppRoleAssignment { get =>
            new AppRoleAssignmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The endpoint property</summary>
        public EndpointRequestBuilder Endpoint { get =>
            new EndpointRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The ref property</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The servicePrincipal property</summary>
        public ServicePrincipalRequestBuilder ServicePrincipal { get =>
            new ServicePrincipalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The user property</summary>
        public UserRequestBuilder User { get =>
            new UserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/authentication/windowsHelloForBusinessMethods/{windowsHelloForBusinessAuthenticationMethod%2Did}/device/registeredOwners/{directoryObject%2Did}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DirectoryObjectItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/authentication/windowsHelloForBusinessMethods/{windowsHelloForBusinessAuthenticationMethod%2Did}/device/registeredOwners/{directoryObject%2Did}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
