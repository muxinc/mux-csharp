# Mux.Csharp.Sdk.Api.DRMConfigurationsApi

All URIs are relative to *https://api.mux.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDrmConfiguration**](DRMConfigurationsApi.md#getdrmconfiguration) | **GET** /video/v1/drm-configurations/{DRM_CONFIGURATION_ID} | Retrieve a DRM Configuration
[**ListDrmConfigurations**](DRMConfigurationsApi.md#listdrmconfigurations) | **GET** /video/v1/drm-configurations | List DRM Configurations


<a name="getdrmconfiguration"></a>
# **GetDrmConfiguration**
> DRMConfigurationResponse GetDrmConfiguration (string DRM_CONFIGURATION_ID)

Retrieve a DRM Configuration

Retrieves a single DRM Configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetDrmConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DRMConfigurationsApi(config);
            var DRM_CONFIGURATION_ID = "DRM_CONFIGURATION_ID_example";  // string | The DRM Configuration ID.

            try
            {
                // Retrieve a DRM Configuration
                DRMConfigurationResponse result = apiInstance.GetDrmConfiguration(DRM_CONFIGURATION_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DRMConfigurationsApi.GetDrmConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **DRM_CONFIGURATION_ID** | **string**| The DRM Configuration ID. | 

### Return type

[**DRMConfigurationResponse**](DRMConfigurationResponse.md)

### Authorization

[accessToken](../README.md#accessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdrmconfigurations"></a>
# **ListDrmConfigurations**
> ListDRMConfigurationsResponse ListDrmConfigurations (int? page = null, int? limit = null)

List DRM Configurations

Returns a list of DRM Configurations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListDrmConfigurationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DRMConfigurationsApi(config);
            var page = 1;  // int? | Offset by this many pages, of the size of `limit` (optional)  (default to 1)
            var limit = 25;  // int? | Number of items to include in the response (optional)  (default to 25)

            try
            {
                // List DRM Configurations
                ListDRMConfigurationsResponse result = apiInstance.ListDrmConfigurations(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DRMConfigurationsApi.ListDrmConfigurations: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Offset by this many pages, of the size of &#x60;limit&#x60; | [optional] [default to 1]
 **limit** | **int?**| Number of items to include in the response | [optional] [default to 25]

### Return type

[**ListDRMConfigurationsResponse**](ListDRMConfigurationsResponse.md)

### Authorization

[accessToken](../README.md#accessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

