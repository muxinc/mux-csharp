# Mux.Csharp.Sdk.Api.PlaybackRestrictionsApi

All URIs are relative to *https://api.mux.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePlaybackRestriction**](PlaybackRestrictionsApi.md#createplaybackrestriction) | **POST** /video/v1/playback-restrictions | Create a Playback Restriction
[**DeletePlaybackRestriction**](PlaybackRestrictionsApi.md#deleteplaybackrestriction) | **DELETE** /video/v1/playback-restrictions/{PLAYBACK_RESTRICTION_ID} | Delete a Playback Restriction
[**GetPlaybackRestriction**](PlaybackRestrictionsApi.md#getplaybackrestriction) | **GET** /video/v1/playback-restrictions/{PLAYBACK_RESTRICTION_ID} | Retrieve a Playback Restriction
[**ListPlaybackRestrictions**](PlaybackRestrictionsApi.md#listplaybackrestrictions) | **GET** /video/v1/playback-restrictions | List Playback Restrictions
[**UpdateReferrerDomainRestriction**](PlaybackRestrictionsApi.md#updatereferrerdomainrestriction) | **PUT** /video/v1/playback-restrictions/{PLAYBACK_RESTRICTION_ID}/referrer | Update the Referrer Playback Restriction


<a name="createplaybackrestriction"></a>
# **CreatePlaybackRestriction**
> PlaybackRestrictionResponse CreatePlaybackRestriction (CreatePlaybackRestrictionRequest createPlaybackRestrictionRequest)

Create a Playback Restriction

Create a new Playback Restriction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class CreatePlaybackRestrictionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PlaybackRestrictionsApi(config);
            var createPlaybackRestrictionRequest = new CreatePlaybackRestrictionRequest(); // CreatePlaybackRestrictionRequest | 

            try
            {
                // Create a Playback Restriction
                PlaybackRestrictionResponse result = apiInstance.CreatePlaybackRestriction(createPlaybackRestrictionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaybackRestrictionsApi.CreatePlaybackRestriction: " + e.Message );
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
 **createPlaybackRestrictionRequest** | [**CreatePlaybackRestrictionRequest**](CreatePlaybackRestrictionRequest.md)|  | 

### Return type

[**PlaybackRestrictionResponse**](PlaybackRestrictionResponse.md)

### Authorization

[accessToken](../README.md#accessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteplaybackrestriction"></a>
# **DeletePlaybackRestriction**
> void DeletePlaybackRestriction (string PLAYBACK_RESTRICTION_ID)

Delete a Playback Restriction

Deletes a single Playback Restriction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class DeletePlaybackRestrictionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PlaybackRestrictionsApi(config);
            var PLAYBACK_RESTRICTION_ID = "PLAYBACK_RESTRICTION_ID_example";  // string | ID of the Playback Restriction.

            try
            {
                // Delete a Playback Restriction
                apiInstance.DeletePlaybackRestriction(PLAYBACK_RESTRICTION_ID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaybackRestrictionsApi.DeletePlaybackRestriction: " + e.Message );
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
 **PLAYBACK_RESTRICTION_ID** | **string**| ID of the Playback Restriction. | 

### Return type

void (empty response body)

### Authorization

[accessToken](../README.md#accessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplaybackrestriction"></a>
# **GetPlaybackRestriction**
> PlaybackRestrictionResponse GetPlaybackRestriction (string PLAYBACK_RESTRICTION_ID)

Retrieve a Playback Restriction

Retrieves a Playback Restriction associated with the unique identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetPlaybackRestrictionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PlaybackRestrictionsApi(config);
            var PLAYBACK_RESTRICTION_ID = "PLAYBACK_RESTRICTION_ID_example";  // string | ID of the Playback Restriction.

            try
            {
                // Retrieve a Playback Restriction
                PlaybackRestrictionResponse result = apiInstance.GetPlaybackRestriction(PLAYBACK_RESTRICTION_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaybackRestrictionsApi.GetPlaybackRestriction: " + e.Message );
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
 **PLAYBACK_RESTRICTION_ID** | **string**| ID of the Playback Restriction. | 

### Return type

[**PlaybackRestrictionResponse**](PlaybackRestrictionResponse.md)

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

<a name="listplaybackrestrictions"></a>
# **ListPlaybackRestrictions**
> ListPlaybackRestrictionsResponse ListPlaybackRestrictions (int? page = null, int? limit = null)

List Playback Restrictions

Returns a list of all Playback Restrictions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListPlaybackRestrictionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PlaybackRestrictionsApi(config);
            var page = 1;  // int? | Offset by this many pages, of the size of `limit` (optional)  (default to 1)
            var limit = 25;  // int? | Number of items to include in the response (optional)  (default to 25)

            try
            {
                // List Playback Restrictions
                ListPlaybackRestrictionsResponse result = apiInstance.ListPlaybackRestrictions(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaybackRestrictionsApi.ListPlaybackRestrictions: " + e.Message );
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

[**ListPlaybackRestrictionsResponse**](ListPlaybackRestrictionsResponse.md)

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

<a name="updatereferrerdomainrestriction"></a>
# **UpdateReferrerDomainRestriction**
> PlaybackRestrictionResponse UpdateReferrerDomainRestriction (string PLAYBACK_RESTRICTION_ID, UpdateReferrerDomainRestrictionRequest updateReferrerDomainRestrictionRequest)

Update the Referrer Playback Restriction

Allows you to modify the list of domains or change how Mux validates playback requests without the `Referer` HTTP header. The Referrer restriction fully replaces the old list with this new list of domains.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class UpdateReferrerDomainRestrictionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PlaybackRestrictionsApi(config);
            var PLAYBACK_RESTRICTION_ID = "PLAYBACK_RESTRICTION_ID_example";  // string | ID of the Playback Restriction.
            var updateReferrerDomainRestrictionRequest = new UpdateReferrerDomainRestrictionRequest(); // UpdateReferrerDomainRestrictionRequest | 

            try
            {
                // Update the Referrer Playback Restriction
                PlaybackRestrictionResponse result = apiInstance.UpdateReferrerDomainRestriction(PLAYBACK_RESTRICTION_ID, updateReferrerDomainRestrictionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaybackRestrictionsApi.UpdateReferrerDomainRestriction: " + e.Message );
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
 **PLAYBACK_RESTRICTION_ID** | **string**| ID of the Playback Restriction. | 
 **updateReferrerDomainRestrictionRequest** | [**UpdateReferrerDomainRestrictionRequest**](UpdateReferrerDomainRestrictionRequest.md)|  | 

### Return type

[**PlaybackRestrictionResponse**](PlaybackRestrictionResponse.md)

### Authorization

[accessToken](../README.md#accessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

