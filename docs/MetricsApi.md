# Mux.Csharp.Sdk.Api.MetricsApi

All URIs are relative to *https://api.mux.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMetricTimeseriesData**](MetricsApi.md#getmetrictimeseriesdata) | **GET** /data/v1/metrics/{METRIC_ID}/timeseries | Get metric timeseries data
[**GetOverallValues**](MetricsApi.md#getoverallvalues) | **GET** /data/v1/metrics/{METRIC_ID}/overall | Get Overall values
[**ListAllMetricValues**](MetricsApi.md#listallmetricvalues) | **GET** /data/v1/metrics/comparison | List all metric values
[**ListBreakdownValues**](MetricsApi.md#listbreakdownvalues) | **GET** /data/v1/metrics/{METRIC_ID}/breakdown | List breakdown values
[**ListInsights**](MetricsApi.md#listinsights) | **GET** /data/v1/metrics/{METRIC_ID}/insights | List Insights


<a name="getmetrictimeseriesdata"></a>
# **GetMetricTimeseriesData**
> GetMetricTimeseriesDataResponse GetMetricTimeseriesData (string METRIC_ID, List<string> timeframe = null, List<string> filters = null, string measurement = null, string orderDirection = null, string groupBy = null)

Get metric timeseries data

Returns timeseries data for a specific metric.  Each interval represented in the data array contains an array with the following values:   * the first element is the interval time   * the second element is the calculated metric value    * the third element is the number of views in the interval that have a valid metric value 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetMetricTimeseriesDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MetricsApi(config);
            var METRIC_ID = video_startup_time;  // string | ID of the Metric
            var timeframe = new List<string>(); // List<string> | Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]=).  Accepted formats are...    * array of epoch timestamps e.g. `timeframe[]=1498867200&timeframe[]=1498953600`   * duration string e.g. `timeframe[]=24:hours or timeframe[]=7:days`  (optional) 
            var filters = new List<string>(); // List<string> | Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a `!` character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * `filters[]=operating_system:windows&filters[]=!country:US`  (optional) 
            var measurement = "95th";  // string | Measurement for the provided metric. If omitted, the default for the metric will be used. (optional) 
            var orderDirection = "asc";  // string | Sort order. (optional) 
            var groupBy = "ten_minutes";  // string | Time granularity to group results by. If this value is omitted, a default granularity is chosen based on the timeframe.  For timeframes of 6 hours or less, the default granularity is `ten_minutes`. Between 6 hours and 15 days inclusive, the default granularity is `hour`. The granularity of timeframes that exceed 15 days is `day`. This default behavior is subject to change; it is strongly suggested that you explicitly specify the granularity.  (optional) 

            try
            {
                // Get metric timeseries data
                GetMetricTimeseriesDataResponse result = apiInstance.GetMetricTimeseriesData(METRIC_ID, timeframe, filters, measurement, orderDirection, groupBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GetMetricTimeseriesData: " + e.Message );
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
 **METRIC_ID** | **string**| ID of the Metric | 
 **timeframe** | [**List&lt;string&gt;**](string.md)| Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  | [optional] 
 **filters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  | [optional] 
 **measurement** | **string**| Measurement for the provided metric. If omitted, the default for the metric will be used. | [optional] 
 **orderDirection** | **string**| Sort order. | [optional] 
 **groupBy** | **string**| Time granularity to group results by. If this value is omitted, a default granularity is chosen based on the timeframe.  For timeframes of 6 hours or less, the default granularity is &#x60;ten_minutes&#x60;. Between 6 hours and 15 days inclusive, the default granularity is &#x60;hour&#x60;. The granularity of timeframes that exceed 15 days is &#x60;day&#x60;. This default behavior is subject to change; it is strongly suggested that you explicitly specify the granularity.  | [optional] 

### Return type

[**GetMetricTimeseriesDataResponse**](GetMetricTimeseriesDataResponse.md)

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

<a name="getoverallvalues"></a>
# **GetOverallValues**
> GetOverallValuesResponse GetOverallValues (string METRIC_ID, List<string> timeframe = null, List<string> filters = null, string measurement = null)

Get Overall values

Returns the overall value for a specific metric, as well as the total view count, watch time, and the Mux Global metric value for the metric.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetOverallValuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MetricsApi(config);
            var METRIC_ID = video_startup_time;  // string | ID of the Metric
            var timeframe = new List<string>(); // List<string> | Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]=).  Accepted formats are...    * array of epoch timestamps e.g. `timeframe[]=1498867200&timeframe[]=1498953600`   * duration string e.g. `timeframe[]=24:hours or timeframe[]=7:days`  (optional) 
            var filters = new List<string>(); // List<string> | Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a `!` character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * `filters[]=operating_system:windows&filters[]=!country:US`  (optional) 
            var measurement = "95th";  // string | Measurement for the provided metric. If omitted, the default for the metric will be used. (optional) 

            try
            {
                // Get Overall values
                GetOverallValuesResponse result = apiInstance.GetOverallValues(METRIC_ID, timeframe, filters, measurement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GetOverallValues: " + e.Message );
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
 **METRIC_ID** | **string**| ID of the Metric | 
 **timeframe** | [**List&lt;string&gt;**](string.md)| Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  | [optional] 
 **filters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  | [optional] 
 **measurement** | **string**| Measurement for the provided metric. If omitted, the default for the metric will be used. | [optional] 

### Return type

[**GetOverallValuesResponse**](GetOverallValuesResponse.md)

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

<a name="listallmetricvalues"></a>
# **ListAllMetricValues**
> ListAllMetricValuesResponse ListAllMetricValues (List<string> timeframe = null, List<string> filters = null, string dimension = null, string value = null)

List all metric values

List all of the values across every breakdown for a specific metric.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListAllMetricValuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MetricsApi(config);
            var timeframe = new List<string>(); // List<string> | Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]=).  Accepted formats are...    * array of epoch timestamps e.g. `timeframe[]=1498867200&timeframe[]=1498953600`   * duration string e.g. `timeframe[]=24:hours or timeframe[]=7:days`  (optional) 
            var filters = new List<string>(); // List<string> | Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a `!` character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * `filters[]=operating_system:windows&filters[]=!country:US`  (optional) 
            var dimension = "asn";  // string | Dimension the specified value belongs to (optional) 
            var value = "value_example";  // string | Value to show all available metrics for (optional) 

            try
            {
                // List all metric values
                ListAllMetricValuesResponse result = apiInstance.ListAllMetricValues(timeframe, filters, dimension, value);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.ListAllMetricValues: " + e.Message );
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
 **timeframe** | [**List&lt;string&gt;**](string.md)| Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  | [optional] 
 **filters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  | [optional] 
 **dimension** | **string**| Dimension the specified value belongs to | [optional] 
 **value** | **string**| Value to show all available metrics for | [optional] 

### Return type

[**ListAllMetricValuesResponse**](ListAllMetricValuesResponse.md)

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

<a name="listbreakdownvalues"></a>
# **ListBreakdownValues**
> ListBreakdownValuesResponse ListBreakdownValues (string METRIC_ID, string groupBy = null, string measurement = null, List<string> filters = null, int? limit = null, int? page = null, string orderBy = null, string orderDirection = null, List<string> timeframe = null)

List breakdown values

List the breakdown values for a specific metric.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListBreakdownValuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MetricsApi(config);
            var METRIC_ID = video_startup_time;  // string | ID of the Metric
            var groupBy = "asn";  // string | Breakdown value to group the results by (optional) 
            var measurement = "95th";  // string | Measurement for the provided metric. If omitted, the default for the metric will be used. (optional) 
            var filters = new List<string>(); // List<string> | Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a `!` character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * `filters[]=operating_system:windows&filters[]=!country:US`  (optional) 
            var limit = 25;  // int? | Number of items to include in the response (optional)  (default to 25)
            var page = 1;  // int? | Offset by this many pages, of the size of `limit` (optional)  (default to 1)
            var orderBy = "negative_impact";  // string | Value to order the results by (optional) 
            var orderDirection = "asc";  // string | Sort order. (optional) 
            var timeframe = new List<string>(); // List<string> | Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]=).  Accepted formats are...    * array of epoch timestamps e.g. `timeframe[]=1498867200&timeframe[]=1498953600`   * duration string e.g. `timeframe[]=24:hours or timeframe[]=7:days`  (optional) 

            try
            {
                // List breakdown values
                ListBreakdownValuesResponse result = apiInstance.ListBreakdownValues(METRIC_ID, groupBy, measurement, filters, limit, page, orderBy, orderDirection, timeframe);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.ListBreakdownValues: " + e.Message );
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
 **METRIC_ID** | **string**| ID of the Metric | 
 **groupBy** | **string**| Breakdown value to group the results by | [optional] 
 **measurement** | **string**| Measurement for the provided metric. If omitted, the default for the metric will be used. | [optional] 
 **filters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  | [optional] 
 **limit** | **int?**| Number of items to include in the response | [optional] [default to 25]
 **page** | **int?**| Offset by this many pages, of the size of &#x60;limit&#x60; | [optional] [default to 1]
 **orderBy** | **string**| Value to order the results by | [optional] 
 **orderDirection** | **string**| Sort order. | [optional] 
 **timeframe** | [**List&lt;string&gt;**](string.md)| Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  | [optional] 

### Return type

[**ListBreakdownValuesResponse**](ListBreakdownValuesResponse.md)

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

<a name="listinsights"></a>
# **ListInsights**
> ListInsightsResponse ListInsights (string METRIC_ID, string measurement = null, string orderDirection = null, List<string> timeframe = null)

List Insights

Returns a list of insights for a metric. These are the worst performing values across all breakdowns sorted by how much they negatively impact a specific metric.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListInsightsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MetricsApi(config);
            var METRIC_ID = video_startup_time;  // string | ID of the Metric
            var measurement = "95th";  // string | Measurement for the provided metric. If omitted, the default for the metric will be used. (optional) 
            var orderDirection = "asc";  // string | Sort order. (optional) 
            var timeframe = new List<string>(); // List<string> | Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]=).  Accepted formats are...    * array of epoch timestamps e.g. `timeframe[]=1498867200&timeframe[]=1498953600`   * duration string e.g. `timeframe[]=24:hours or timeframe[]=7:days`  (optional) 

            try
            {
                // List Insights
                ListInsightsResponse result = apiInstance.ListInsights(METRIC_ID, measurement, orderDirection, timeframe);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.ListInsights: " + e.Message );
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
 **METRIC_ID** | **string**| ID of the Metric | 
 **measurement** | **string**| Measurement for the provided metric. If omitted, the default for the metric will be used. | [optional] 
 **orderDirection** | **string**| Sort order. | [optional] 
 **timeframe** | [**List&lt;string&gt;**](string.md)| Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  | [optional] 

### Return type

[**ListInsightsResponse**](ListInsightsResponse.md)

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

