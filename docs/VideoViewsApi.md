# Mux.Csharp.Sdk.Api.VideoViewsApi

All URIs are relative to *https://api.mux.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetVideoView**](VideoViewsApi.md#getvideoview) | **GET** /data/v1/video-views/{VIDEO_VIEW_ID} | Get a Video View
[**ListVideoViews**](VideoViewsApi.md#listvideoviews) | **GET** /data/v1/video-views | List Video Views


<a name="getvideoview"></a>
# **GetVideoView**
> VideoViewResponse GetVideoView (string VIDEO_VIEW_ID)

Get a Video View

Returns the details of a video view.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetVideoViewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VideoViewsApi(config);
            var VIDEO_VIEW_ID = abcd1234;  // string | ID of the Video View

            try
            {
                // Get a Video View
                VideoViewResponse result = apiInstance.GetVideoView(VIDEO_VIEW_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideoViewsApi.GetVideoView: " + e.Message );
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
 **VIDEO_VIEW_ID** | **string**| ID of the Video View | 

### Return type

[**VideoViewResponse**](VideoViewResponse.md)

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

<a name="listvideoviews"></a>
# **ListVideoViews**
> ListVideoViewsResponse ListVideoViews (int? limit = null, int? page = null, string viewerId = null, int? errorId = null, string orderDirection = null, List<string> filters = null, List<string> metricFilters = null, List<string> timeframe = null)

List Video Views

Returns a list of video views which match the filters and have a `view_end` within the specified timeframe.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListVideoViewsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VideoViewsApi(config);
            var limit = 25;  // int? | Number of items to include in the response (optional)  (default to 25)
            var page = 1;  // int? | Offset by this many pages, of the size of `limit` (optional)  (default to 1)
            var viewerId = "viewerId_example";  // string | Viewer ID to filter results by. This value may be provided by the integration, or may be created by Mux. (optional) 
            var errorId = 56;  // int? | Filter video views by the provided error ID (as returned in the error_type_id field in the list video views endpoint). If you provide any as the error ID, this will filter the results to those with any error. (optional) 
            var orderDirection = "asc";  // string | Sort order. (optional) 
            var filters = new List<string>(); // List<string> | Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a `!` character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * `filters[]=operating_system:windows&filters[]=!country:US`  (optional) 
            var metricFilters = new List<string>(); // List<string> | Limit the results to rows that match inequality conditions from provided metric comparison clauses. Must be provided as an array query string parameter.  Possible filterable metrics are the same as the set of metric ids, with the exceptions of `exits_before_video_start`, `unique_viewers`, `video_startup_failure_percentage`, and `views`.  Example:    * `metric_filters[]=aggregate_startup_time>=1000`  (optional) 
            var timeframe = new List<string>(); // List<string> | Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]=).  Accepted formats are...    * array of epoch timestamps e.g. `timeframe[]=1498867200&timeframe[]=1498953600`   * duration string e.g. `timeframe[]=24:hours or timeframe[]=7:days`  (optional) 

            try
            {
                // List Video Views
                ListVideoViewsResponse result = apiInstance.ListVideoViews(limit, page, viewerId, errorId, orderDirection, filters, metricFilters, timeframe);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideoViewsApi.ListVideoViews: " + e.Message );
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
 **limit** | **int?**| Number of items to include in the response | [optional] [default to 25]
 **page** | **int?**| Offset by this many pages, of the size of &#x60;limit&#x60; | [optional] [default to 1]
 **viewerId** | **string**| Viewer ID to filter results by. This value may be provided by the integration, or may be created by Mux. | [optional] 
 **errorId** | **int?**| Filter video views by the provided error ID (as returned in the error_type_id field in the list video views endpoint). If you provide any as the error ID, this will filter the results to those with any error. | [optional] 
 **orderDirection** | **string**| Sort order. | [optional] 
 **filters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  | [optional] 
 **metricFilters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match inequality conditions from provided metric comparison clauses. Must be provided as an array query string parameter.  Possible filterable metrics are the same as the set of metric ids, with the exceptions of &#x60;exits_before_video_start&#x60;, &#x60;unique_viewers&#x60;, &#x60;video_startup_failure_percentage&#x60;, and &#x60;views&#x60;.  Example:    * &#x60;metric_filters[]&#x3D;aggregate_startup_time&gt;&#x3D;1000&#x60;  | [optional] 
 **timeframe** | [**List&lt;string&gt;**](string.md)| Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  | [optional] 

### Return type

[**ListVideoViewsResponse**](ListVideoViewsResponse.md)

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

