# Mux.Csharp.Sdk.Api.DeliveryUsageApi

All URIs are relative to *https://api.mux.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListDeliveryUsage**](DeliveryUsageApi.md#listdeliveryusage) | **GET** /video/v1/delivery-usage | List Usage


<a name="listdeliveryusage"></a>
# **ListDeliveryUsage**
> ListDeliveryUsageResponse ListDeliveryUsage (int? page = null, int? limit = null, string assetId = null, string liveStreamId = null, List<string> timeframe = null)

List Usage

Returns a list of delivery usage records and their associated Asset IDs or Live Stream IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListDeliveryUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DeliveryUsageApi(config);
            var page = 1;  // int? | Offset by this many pages, of the size of `limit` (optional)  (default to 1)
            var limit = 100;  // int? | Number of items to include in the response (optional)  (default to 100)
            var assetId = "assetId_example";  // string | Filter response to return delivery usage for this asset only. You cannot specify both the `asset_id` and `live_stream_id` parameters together. (optional) 
            var liveStreamId = "liveStreamId_example";  // string | Filter response to return delivery usage for assets for this live stream. You cannot specify both the `asset_id` and `live_stream_id` parameters together. (optional) 
            var timeframe = new List<string>(); // List<string> | Time window to get delivery usage information. timeframe[0] indicates the start time, timeframe[1] indicates the end time in seconds since the Unix epoch. Default time window is 1 hour representing usage from 13th to 12th hour from when the request is made. (optional) 

            try
            {
                // List Usage
                ListDeliveryUsageResponse result = apiInstance.ListDeliveryUsage(page, limit, assetId, liveStreamId, timeframe);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveryUsageApi.ListDeliveryUsage: " + e.Message );
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
 **limit** | **int?**| Number of items to include in the response | [optional] [default to 100]
 **assetId** | **string**| Filter response to return delivery usage for this asset only. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. | [optional] 
 **liveStreamId** | **string**| Filter response to return delivery usage for assets for this live stream. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. | [optional] 
 **timeframe** | [**List&lt;string&gt;**](string.md)| Time window to get delivery usage information. timeframe[0] indicates the start time, timeframe[1] indicates the end time in seconds since the Unix epoch. Default time window is 1 hour representing usage from 13th to 12th hour from when the request is made. | [optional] 

### Return type

[**ListDeliveryUsageResponse**](ListDeliveryUsageResponse.md)

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

