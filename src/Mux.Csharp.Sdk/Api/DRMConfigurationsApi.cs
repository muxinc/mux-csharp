/*
 * Mux API
 *
 * Mux is how developers build online video. This API encompasses both Mux Video and Mux Data functionality to help you build your video-related projects better and faster than ever before.
 *
 * The version of the OpenAPI document: v1
 * Contact: devex@mux.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Mux.Csharp.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDRMConfigurationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve a DRM Configuration
        /// </summary>
        /// <remarks>
        /// Retrieves a single DRM Configuration.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="DRM_CONFIGURATION_ID">The DRM Configuration ID.</param>
        /// <returns>DRMConfigurationResponse</returns>
        DRMConfigurationResponse GetDrmConfiguration(string DRM_CONFIGURATION_ID);

        /// <summary>
        /// Retrieve a DRM Configuration
        /// </summary>
        /// <remarks>
        /// Retrieves a single DRM Configuration.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="DRM_CONFIGURATION_ID">The DRM Configuration ID.</param>
        /// <returns>ApiResponse of DRMConfigurationResponse</returns>
        ApiResponse<DRMConfigurationResponse> GetDrmConfigurationWithHttpInfo(string DRM_CONFIGURATION_ID);
        /// <summary>
        /// List DRM Configurations
        /// </summary>
        /// <remarks>
        /// Returns a list of DRM Configurations
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 25)</param>
        /// <returns>ListDRMConfigurationsResponse</returns>
        ListDRMConfigurationsResponse ListDrmConfigurations(int? page = default(int?), int? limit = default(int?));

        /// <summary>
        /// List DRM Configurations
        /// </summary>
        /// <remarks>
        /// Returns a list of DRM Configurations
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 25)</param>
        /// <returns>ApiResponse of ListDRMConfigurationsResponse</returns>
        ApiResponse<ListDRMConfigurationsResponse> ListDrmConfigurationsWithHttpInfo(int? page = default(int?), int? limit = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDRMConfigurationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve a DRM Configuration
        /// </summary>
        /// <remarks>
        /// Retrieves a single DRM Configuration.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="DRM_CONFIGURATION_ID">The DRM Configuration ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DRMConfigurationResponse</returns>
        System.Threading.Tasks.Task<DRMConfigurationResponse> GetDrmConfigurationAsync(string DRM_CONFIGURATION_ID, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a DRM Configuration
        /// </summary>
        /// <remarks>
        /// Retrieves a single DRM Configuration.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="DRM_CONFIGURATION_ID">The DRM Configuration ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DRMConfigurationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DRMConfigurationResponse>> GetDrmConfigurationWithHttpInfoAsync(string DRM_CONFIGURATION_ID, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List DRM Configurations
        /// </summary>
        /// <remarks>
        /// Returns a list of DRM Configurations
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 25)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListDRMConfigurationsResponse</returns>
        System.Threading.Tasks.Task<ListDRMConfigurationsResponse> ListDrmConfigurationsAsync(int? page = default(int?), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List DRM Configurations
        /// </summary>
        /// <remarks>
        /// Returns a list of DRM Configurations
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 25)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListDRMConfigurationsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListDRMConfigurationsResponse>> ListDrmConfigurationsWithHttpInfoAsync(int? page = default(int?), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDRMConfigurationsApi : IDRMConfigurationsApiSync, IDRMConfigurationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DRMConfigurationsApi : IDRMConfigurationsApi
    {
        private Mux.Csharp.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DRMConfigurationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DRMConfigurationsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DRMConfigurationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DRMConfigurationsApi(string basePath)
        {
            this.Configuration = Mux.Csharp.Sdk.Client.Configuration.MergeConfigurations(
                Mux.Csharp.Sdk.Client.GlobalConfiguration.Instance,
                new Mux.Csharp.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Mux.Csharp.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Mux.Csharp.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Mux.Csharp.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DRMConfigurationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DRMConfigurationsApi(Mux.Csharp.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Mux.Csharp.Sdk.Client.Configuration.MergeConfigurations(
                Mux.Csharp.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Mux.Csharp.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Mux.Csharp.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Mux.Csharp.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DRMConfigurationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DRMConfigurationsApi(Mux.Csharp.Sdk.Client.ISynchronousClient client, Mux.Csharp.Sdk.Client.IAsynchronousClient asyncClient, Mux.Csharp.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Mux.Csharp.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Mux.Csharp.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Mux.Csharp.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Mux.Csharp.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Mux.Csharp.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Retrieve a DRM Configuration Retrieves a single DRM Configuration.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="DRM_CONFIGURATION_ID">The DRM Configuration ID.</param>
        /// <returns>DRMConfigurationResponse</returns>
        public DRMConfigurationResponse GetDrmConfiguration(string DRM_CONFIGURATION_ID)
        {
            Mux.Csharp.Sdk.Client.ApiResponse<DRMConfigurationResponse> localVarResponse = GetDrmConfigurationWithHttpInfo(DRM_CONFIGURATION_ID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a DRM Configuration Retrieves a single DRM Configuration.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="DRM_CONFIGURATION_ID">The DRM Configuration ID.</param>
        /// <returns>ApiResponse of DRMConfigurationResponse</returns>
        public Mux.Csharp.Sdk.Client.ApiResponse<DRMConfigurationResponse> GetDrmConfigurationWithHttpInfo(string DRM_CONFIGURATION_ID)
        {
            // verify the required parameter 'DRM_CONFIGURATION_ID' is set
            if (DRM_CONFIGURATION_ID == null)
            {
                throw new Mux.Csharp.Sdk.Client.ApiException(400, "Missing required parameter 'DRM_CONFIGURATION_ID' when calling DRMConfigurationsApi->GetDrmConfiguration");
            }

            Mux.Csharp.Sdk.Client.RequestOptions localVarRequestOptions = new Mux.Csharp.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("DRM_CONFIGURATION_ID", Mux.Csharp.Sdk.Client.ClientUtils.ParameterToString(DRM_CONFIGURATION_ID)); // path parameter

            // authentication (accessToken) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Mux.Csharp.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DRMConfigurationResponse>("/video/v1/drm-configurations/{DRM_CONFIGURATION_ID}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDrmConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a DRM Configuration Retrieves a single DRM Configuration.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="DRM_CONFIGURATION_ID">The DRM Configuration ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DRMConfigurationResponse</returns>
        public async System.Threading.Tasks.Task<DRMConfigurationResponse> GetDrmConfigurationAsync(string DRM_CONFIGURATION_ID, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Mux.Csharp.Sdk.Client.ApiResponse<DRMConfigurationResponse> localVarResponse = await GetDrmConfigurationWithHttpInfoAsync(DRM_CONFIGURATION_ID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a DRM Configuration Retrieves a single DRM Configuration.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="DRM_CONFIGURATION_ID">The DRM Configuration ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DRMConfigurationResponse)</returns>
        public async System.Threading.Tasks.Task<Mux.Csharp.Sdk.Client.ApiResponse<DRMConfigurationResponse>> GetDrmConfigurationWithHttpInfoAsync(string DRM_CONFIGURATION_ID, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'DRM_CONFIGURATION_ID' is set
            if (DRM_CONFIGURATION_ID == null)
            {
                throw new Mux.Csharp.Sdk.Client.ApiException(400, "Missing required parameter 'DRM_CONFIGURATION_ID' when calling DRMConfigurationsApi->GetDrmConfiguration");
            }


            Mux.Csharp.Sdk.Client.RequestOptions localVarRequestOptions = new Mux.Csharp.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("DRM_CONFIGURATION_ID", Mux.Csharp.Sdk.Client.ClientUtils.ParameterToString(DRM_CONFIGURATION_ID)); // path parameter

            // authentication (accessToken) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Mux.Csharp.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DRMConfigurationResponse>("/video/v1/drm-configurations/{DRM_CONFIGURATION_ID}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDrmConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List DRM Configurations Returns a list of DRM Configurations
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 25)</param>
        /// <returns>ListDRMConfigurationsResponse</returns>
        public ListDRMConfigurationsResponse ListDrmConfigurations(int? page = default(int?), int? limit = default(int?))
        {
            Mux.Csharp.Sdk.Client.ApiResponse<ListDRMConfigurationsResponse> localVarResponse = ListDrmConfigurationsWithHttpInfo(page, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List DRM Configurations Returns a list of DRM Configurations
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 25)</param>
        /// <returns>ApiResponse of ListDRMConfigurationsResponse</returns>
        public Mux.Csharp.Sdk.Client.ApiResponse<ListDRMConfigurationsResponse> ListDrmConfigurationsWithHttpInfo(int? page = default(int?), int? limit = default(int?))
        {
            Mux.Csharp.Sdk.Client.RequestOptions localVarRequestOptions = new Mux.Csharp.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }

            // authentication (accessToken) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Mux.Csharp.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ListDRMConfigurationsResponse>("/video/v1/drm-configurations", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListDrmConfigurations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List DRM Configurations Returns a list of DRM Configurations
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 25)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListDRMConfigurationsResponse</returns>
        public async System.Threading.Tasks.Task<ListDRMConfigurationsResponse> ListDrmConfigurationsAsync(int? page = default(int?), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Mux.Csharp.Sdk.Client.ApiResponse<ListDRMConfigurationsResponse> localVarResponse = await ListDrmConfigurationsWithHttpInfoAsync(page, limit, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List DRM Configurations Returns a list of DRM Configurations
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 25)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListDRMConfigurationsResponse)</returns>
        public async System.Threading.Tasks.Task<Mux.Csharp.Sdk.Client.ApiResponse<ListDRMConfigurationsResponse>> ListDrmConfigurationsWithHttpInfoAsync(int? page = default(int?), int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Mux.Csharp.Sdk.Client.RequestOptions localVarRequestOptions = new Mux.Csharp.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }

            // authentication (accessToken) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Mux.Csharp.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ListDRMConfigurationsResponse>("/video/v1/drm-configurations", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListDrmConfigurations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
