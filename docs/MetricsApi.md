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
> GetMetricTimeseriesDataResponse GetMetricTimeseriesData (string METRIC_ID, List<string> timeframe = null, List<string> filters = null, List<string> metricFilters = null, string measurement = null, string orderDirection = null, string groupBy = null)

Get metric timeseries data

Returns timeseries data for a specific metric.  Each interval represented in the data array contains an array with the following values:   * the first element is the interval time   * the second element is the calculated metric value   * the third element is the number of views in the interval that have a valid metric value 

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
            var metricFilters = new List<string>(); // List<string> | Limit the results to rows that match inequality conditions from provided metric comparison clauses. Must be provided as an array query string parameter.  Possible filterable metrics are the same as the set of metric ids, with the exceptions of `exits_before_video_start`, `unique_viewers`, `video_startup_failure_percentage`, `view_dropped_percentage`, and `views`.  Example:    * `metric_filters[]=aggregate_startup_time>=1000`  (optional) 
            var measurement = "95th";  // string | Measurement for the provided metric. If omitted, the default for the metric will be used. The default measurement for each metric is: \"sum\" : `ad_attempt_count`, `ad_break_count`, `ad_break_error_count`, `ad_error_count`, `ad_impression_count`, `playing_time` \"median\" : `ad_preroll_startup_time`, `aggregate_startup_time`, `content_startup_time`, `max_downscale_percentage`, `max_upscale_percentage`, `page_load_time`, `player_average_live_latency`, `player_startup_time`, `rebuffer_count`, `rebuffer_duration`, `requests_for_first_preroll`, `video_startup_preroll_load_time`, `video_startup_preroll_request_time`, `video_startup_time`, `view_average_request_latency`, `view_average_request_throughput`, `view_max_request_latency`, `weighted_average_bitrate` \"avg\" : `ad_break_error_percentage`, `ad_error_percentage`, `ad_exit_before_start_count`, `ad_exit_before_start_percentage`, `ad_playback_failure_percentage`, `ad_startup_error_count`, `ad_startup_error_percentage`, `content_playback_failure_percentage`, `downscale_percentage`, `exits_before_video_start`, `playback_business_exception_percentage`, `playback_failure_percentage`, `playback_success_score`, `rebuffer_frequency`, `rebuffer_percentage`, `seek_latency`, `smoothness_score`, `startup_time_score`, `upscale_percentage`, `video_quality_score`, `video_startup_business_exception_percentage`, `video_startup_failure_percentage`, `view_dropped_percentage`, `viewer_experience_score` \"count\" : `started_views`, `unique_viewers`  (optional) 
            var orderDirection = "asc";  // string | Sort order. (optional) 
            var groupBy = "minute";  // string | Time granularity to group results by. If this value is omitted, a default granularity is chosen based on the timeframe.  For timeframes of less than 90 minutes, the default granularity is `minute`. Between 90 minutes and 6 hours, the default granularity is `ten_minutes`. Between 6 hours and 15 days inclusive, the default granularity is `hour`. The granularity of timeframes that exceed 15 days is `day`. This default behavior is subject to change; it is strongly suggested that you explicitly specify the granularity.  (optional) 

            try
            {
                // Get metric timeseries data
                GetMetricTimeseriesDataResponse result = apiInstance.GetMetricTimeseriesData(METRIC_ID, timeframe, filters, metricFilters, measurement, orderDirection, groupBy);
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
 **metricFilters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match inequality conditions from provided metric comparison clauses. Must be provided as an array query string parameter.  Possible filterable metrics are the same as the set of metric ids, with the exceptions of &#x60;exits_before_video_start&#x60;, &#x60;unique_viewers&#x60;, &#x60;video_startup_failure_percentage&#x60;, &#x60;view_dropped_percentage&#x60;, and &#x60;views&#x60;.  Example:    * &#x60;metric_filters[]&#x3D;aggregate_startup_time&gt;&#x3D;1000&#x60;  | [optional] 
 **measurement** | **string**| Measurement for the provided metric. If omitted, the default for the metric will be used. The default measurement for each metric is: \&quot;sum\&quot; : &#x60;ad_attempt_count&#x60;, &#x60;ad_break_count&#x60;, &#x60;ad_break_error_count&#x60;, &#x60;ad_error_count&#x60;, &#x60;ad_impression_count&#x60;, &#x60;playing_time&#x60; \&quot;median\&quot; : &#x60;ad_preroll_startup_time&#x60;, &#x60;aggregate_startup_time&#x60;, &#x60;content_startup_time&#x60;, &#x60;max_downscale_percentage&#x60;, &#x60;max_upscale_percentage&#x60;, &#x60;page_load_time&#x60;, &#x60;player_average_live_latency&#x60;, &#x60;player_startup_time&#x60;, &#x60;rebuffer_count&#x60;, &#x60;rebuffer_duration&#x60;, &#x60;requests_for_first_preroll&#x60;, &#x60;video_startup_preroll_load_time&#x60;, &#x60;video_startup_preroll_request_time&#x60;, &#x60;video_startup_time&#x60;, &#x60;view_average_request_latency&#x60;, &#x60;view_average_request_throughput&#x60;, &#x60;view_max_request_latency&#x60;, &#x60;weighted_average_bitrate&#x60; \&quot;avg\&quot; : &#x60;ad_break_error_percentage&#x60;, &#x60;ad_error_percentage&#x60;, &#x60;ad_exit_before_start_count&#x60;, &#x60;ad_exit_before_start_percentage&#x60;, &#x60;ad_playback_failure_percentage&#x60;, &#x60;ad_startup_error_count&#x60;, &#x60;ad_startup_error_percentage&#x60;, &#x60;content_playback_failure_percentage&#x60;, &#x60;downscale_percentage&#x60;, &#x60;exits_before_video_start&#x60;, &#x60;playback_business_exception_percentage&#x60;, &#x60;playback_failure_percentage&#x60;, &#x60;playback_success_score&#x60;, &#x60;rebuffer_frequency&#x60;, &#x60;rebuffer_percentage&#x60;, &#x60;seek_latency&#x60;, &#x60;smoothness_score&#x60;, &#x60;startup_time_score&#x60;, &#x60;upscale_percentage&#x60;, &#x60;video_quality_score&#x60;, &#x60;video_startup_business_exception_percentage&#x60;, &#x60;video_startup_failure_percentage&#x60;, &#x60;view_dropped_percentage&#x60;, &#x60;viewer_experience_score&#x60; \&quot;count\&quot; : &#x60;started_views&#x60;, &#x60;unique_viewers&#x60;  | [optional] 
 **orderDirection** | **string**| Sort order. | [optional] 
 **groupBy** | **string**| Time granularity to group results by. If this value is omitted, a default granularity is chosen based on the timeframe.  For timeframes of less than 90 minutes, the default granularity is &#x60;minute&#x60;. Between 90 minutes and 6 hours, the default granularity is &#x60;ten_minutes&#x60;. Between 6 hours and 15 days inclusive, the default granularity is &#x60;hour&#x60;. The granularity of timeframes that exceed 15 days is &#x60;day&#x60;. This default behavior is subject to change; it is strongly suggested that you explicitly specify the granularity.  | [optional] 

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
> GetOverallValuesResponse GetOverallValues (string METRIC_ID, List<string> timeframe = null, List<string> filters = null, List<string> metricFilters = null, string measurement = null)

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
            var metricFilters = new List<string>(); // List<string> | Limit the results to rows that match inequality conditions from provided metric comparison clauses. Must be provided as an array query string parameter.  Possible filterable metrics are the same as the set of metric ids, with the exceptions of `exits_before_video_start`, `unique_viewers`, `video_startup_failure_percentage`, `view_dropped_percentage`, and `views`.  Example:    * `metric_filters[]=aggregate_startup_time>=1000`  (optional) 
            var measurement = "95th";  // string | Measurement for the provided metric. If omitted, the default for the metric will be used. The default measurement for each metric is: \"sum\" : `ad_attempt_count`, `ad_break_count`, `ad_break_error_count`, `ad_error_count`, `ad_impression_count`, `playing_time` \"median\" : `ad_preroll_startup_time`, `aggregate_startup_time`, `content_startup_time`, `max_downscale_percentage`, `max_upscale_percentage`, `page_load_time`, `player_average_live_latency`, `player_startup_time`, `rebuffer_count`, `rebuffer_duration`, `requests_for_first_preroll`, `video_startup_preroll_load_time`, `video_startup_preroll_request_time`, `video_startup_time`, `view_average_request_latency`, `view_average_request_throughput`, `view_max_request_latency`, `weighted_average_bitrate` \"avg\" : `ad_break_error_percentage`, `ad_error_percentage`, `ad_exit_before_start_count`, `ad_exit_before_start_percentage`, `ad_playback_failure_percentage`, `ad_startup_error_count`, `ad_startup_error_percentage`, `content_playback_failure_percentage`, `downscale_percentage`, `exits_before_video_start`, `playback_business_exception_percentage`, `playback_failure_percentage`, `playback_success_score`, `rebuffer_frequency`, `rebuffer_percentage`, `seek_latency`, `smoothness_score`, `startup_time_score`, `upscale_percentage`, `video_quality_score`, `video_startup_business_exception_percentage`, `video_startup_failure_percentage`, `view_dropped_percentage`, `viewer_experience_score` \"count\" : `started_views`, `unique_viewers`  (optional) 

            try
            {
                // Get Overall values
                GetOverallValuesResponse result = apiInstance.GetOverallValues(METRIC_ID, timeframe, filters, metricFilters, measurement);
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
 **metricFilters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match inequality conditions from provided metric comparison clauses. Must be provided as an array query string parameter.  Possible filterable metrics are the same as the set of metric ids, with the exceptions of &#x60;exits_before_video_start&#x60;, &#x60;unique_viewers&#x60;, &#x60;video_startup_failure_percentage&#x60;, &#x60;view_dropped_percentage&#x60;, and &#x60;views&#x60;.  Example:    * &#x60;metric_filters[]&#x3D;aggregate_startup_time&gt;&#x3D;1000&#x60;  | [optional] 
 **measurement** | **string**| Measurement for the provided metric. If omitted, the default for the metric will be used. The default measurement for each metric is: \&quot;sum\&quot; : &#x60;ad_attempt_count&#x60;, &#x60;ad_break_count&#x60;, &#x60;ad_break_error_count&#x60;, &#x60;ad_error_count&#x60;, &#x60;ad_impression_count&#x60;, &#x60;playing_time&#x60; \&quot;median\&quot; : &#x60;ad_preroll_startup_time&#x60;, &#x60;aggregate_startup_time&#x60;, &#x60;content_startup_time&#x60;, &#x60;max_downscale_percentage&#x60;, &#x60;max_upscale_percentage&#x60;, &#x60;page_load_time&#x60;, &#x60;player_average_live_latency&#x60;, &#x60;player_startup_time&#x60;, &#x60;rebuffer_count&#x60;, &#x60;rebuffer_duration&#x60;, &#x60;requests_for_first_preroll&#x60;, &#x60;video_startup_preroll_load_time&#x60;, &#x60;video_startup_preroll_request_time&#x60;, &#x60;video_startup_time&#x60;, &#x60;view_average_request_latency&#x60;, &#x60;view_average_request_throughput&#x60;, &#x60;view_max_request_latency&#x60;, &#x60;weighted_average_bitrate&#x60; \&quot;avg\&quot; : &#x60;ad_break_error_percentage&#x60;, &#x60;ad_error_percentage&#x60;, &#x60;ad_exit_before_start_count&#x60;, &#x60;ad_exit_before_start_percentage&#x60;, &#x60;ad_playback_failure_percentage&#x60;, &#x60;ad_startup_error_count&#x60;, &#x60;ad_startup_error_percentage&#x60;, &#x60;content_playback_failure_percentage&#x60;, &#x60;downscale_percentage&#x60;, &#x60;exits_before_video_start&#x60;, &#x60;playback_business_exception_percentage&#x60;, &#x60;playback_failure_percentage&#x60;, &#x60;playback_success_score&#x60;, &#x60;rebuffer_frequency&#x60;, &#x60;rebuffer_percentage&#x60;, &#x60;seek_latency&#x60;, &#x60;smoothness_score&#x60;, &#x60;startup_time_score&#x60;, &#x60;upscale_percentage&#x60;, &#x60;video_quality_score&#x60;, &#x60;video_startup_business_exception_percentage&#x60;, &#x60;video_startup_failure_percentage&#x60;, &#x60;view_dropped_percentage&#x60;, &#x60;viewer_experience_score&#x60; \&quot;count\&quot; : &#x60;started_views&#x60;, &#x60;unique_viewers&#x60;  | [optional] 

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
> ListAllMetricValuesResponse ListAllMetricValues (List<string> timeframe = null, List<string> filters = null, List<string> metricFilters = null, string dimension = null, string value = null)

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
            var metricFilters = new List<string>(); // List<string> | Limit the results to rows that match inequality conditions from provided metric comparison clauses. Must be provided as an array query string parameter.  Possible filterable metrics are the same as the set of metric ids, with the exceptions of `exits_before_video_start`, `unique_viewers`, `video_startup_failure_percentage`, `view_dropped_percentage`, and `views`.  Example:    * `metric_filters[]=aggregate_startup_time>=1000`  (optional) 
            var dimension = "asn";  // string | Dimension the specified value belongs to (optional) 
            var value = "value_example";  // string | Value to show all available metrics for (optional) 

            try
            {
                // List all metric values
                ListAllMetricValuesResponse result = apiInstance.ListAllMetricValues(timeframe, filters, metricFilters, dimension, value);
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
 **metricFilters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match inequality conditions from provided metric comparison clauses. Must be provided as an array query string parameter.  Possible filterable metrics are the same as the set of metric ids, with the exceptions of &#x60;exits_before_video_start&#x60;, &#x60;unique_viewers&#x60;, &#x60;video_startup_failure_percentage&#x60;, &#x60;view_dropped_percentage&#x60;, and &#x60;views&#x60;.  Example:    * &#x60;metric_filters[]&#x3D;aggregate_startup_time&gt;&#x3D;1000&#x60;  | [optional] 
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
> ListBreakdownValuesResponse ListBreakdownValues (string METRIC_ID, string groupBy = null, string measurement = null, List<string> filters = null, List<string> metricFilters = null, int? limit = null, int? page = null, string orderBy = null, string orderDirection = null, List<string> timeframe = null)

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
            var measurement = "95th";  // string | Measurement for the provided metric. If omitted, the default for the metric will be used. The default measurement for each metric is: \"sum\" : `ad_attempt_count`, `ad_break_count`, `ad_break_error_count`, `ad_error_count`, `ad_impression_count`, `playing_time` \"median\" : `ad_preroll_startup_time`, `aggregate_startup_time`, `content_startup_time`, `max_downscale_percentage`, `max_upscale_percentage`, `page_load_time`, `player_average_live_latency`, `player_startup_time`, `rebuffer_count`, `rebuffer_duration`, `requests_for_first_preroll`, `video_startup_preroll_load_time`, `video_startup_preroll_request_time`, `video_startup_time`, `view_average_request_latency`, `view_average_request_throughput`, `view_max_request_latency`, `weighted_average_bitrate` \"avg\" : `ad_break_error_percentage`, `ad_error_percentage`, `ad_exit_before_start_count`, `ad_exit_before_start_percentage`, `ad_playback_failure_percentage`, `ad_startup_error_count`, `ad_startup_error_percentage`, `content_playback_failure_percentage`, `downscale_percentage`, `exits_before_video_start`, `playback_business_exception_percentage`, `playback_failure_percentage`, `playback_success_score`, `rebuffer_frequency`, `rebuffer_percentage`, `seek_latency`, `smoothness_score`, `startup_time_score`, `upscale_percentage`, `video_quality_score`, `video_startup_business_exception_percentage`, `video_startup_failure_percentage`, `view_dropped_percentage`, `viewer_experience_score` \"count\" : `started_views`, `unique_viewers`  (optional) 
            var filters = new List<string>(); // List<string> | Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a `!` character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * `filters[]=operating_system:windows&filters[]=!country:US`  (optional) 
            var metricFilters = new List<string>(); // List<string> | Limit the results to rows that match inequality conditions from provided metric comparison clauses. Must be provided as an array query string parameter.  Possible filterable metrics are the same as the set of metric ids, with the exceptions of `exits_before_video_start`, `unique_viewers`, `video_startup_failure_percentage`, `view_dropped_percentage`, and `views`.  Example:    * `metric_filters[]=aggregate_startup_time>=1000`  (optional) 
            var limit = 25;  // int? | Number of items to include in the response (optional)  (default to 25)
            var page = 1;  // int? | Offset by this many pages, of the size of `limit` (optional)  (default to 1)
            var orderBy = "negative_impact";  // string | Value to order the results by (optional) 
            var orderDirection = "asc";  // string | Sort order. (optional) 
            var timeframe = new List<string>(); // List<string> | Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]=).  Accepted formats are...    * array of epoch timestamps e.g. `timeframe[]=1498867200&timeframe[]=1498953600`   * duration string e.g. `timeframe[]=24:hours or timeframe[]=7:days`  (optional) 

            try
            {
                // List breakdown values
                ListBreakdownValuesResponse result = apiInstance.ListBreakdownValues(METRIC_ID, groupBy, measurement, filters, metricFilters, limit, page, orderBy, orderDirection, timeframe);
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
 **measurement** | **string**| Measurement for the provided metric. If omitted, the default for the metric will be used. The default measurement for each metric is: \&quot;sum\&quot; : &#x60;ad_attempt_count&#x60;, &#x60;ad_break_count&#x60;, &#x60;ad_break_error_count&#x60;, &#x60;ad_error_count&#x60;, &#x60;ad_impression_count&#x60;, &#x60;playing_time&#x60; \&quot;median\&quot; : &#x60;ad_preroll_startup_time&#x60;, &#x60;aggregate_startup_time&#x60;, &#x60;content_startup_time&#x60;, &#x60;max_downscale_percentage&#x60;, &#x60;max_upscale_percentage&#x60;, &#x60;page_load_time&#x60;, &#x60;player_average_live_latency&#x60;, &#x60;player_startup_time&#x60;, &#x60;rebuffer_count&#x60;, &#x60;rebuffer_duration&#x60;, &#x60;requests_for_first_preroll&#x60;, &#x60;video_startup_preroll_load_time&#x60;, &#x60;video_startup_preroll_request_time&#x60;, &#x60;video_startup_time&#x60;, &#x60;view_average_request_latency&#x60;, &#x60;view_average_request_throughput&#x60;, &#x60;view_max_request_latency&#x60;, &#x60;weighted_average_bitrate&#x60; \&quot;avg\&quot; : &#x60;ad_break_error_percentage&#x60;, &#x60;ad_error_percentage&#x60;, &#x60;ad_exit_before_start_count&#x60;, &#x60;ad_exit_before_start_percentage&#x60;, &#x60;ad_playback_failure_percentage&#x60;, &#x60;ad_startup_error_count&#x60;, &#x60;ad_startup_error_percentage&#x60;, &#x60;content_playback_failure_percentage&#x60;, &#x60;downscale_percentage&#x60;, &#x60;exits_before_video_start&#x60;, &#x60;playback_business_exception_percentage&#x60;, &#x60;playback_failure_percentage&#x60;, &#x60;playback_success_score&#x60;, &#x60;rebuffer_frequency&#x60;, &#x60;rebuffer_percentage&#x60;, &#x60;seek_latency&#x60;, &#x60;smoothness_score&#x60;, &#x60;startup_time_score&#x60;, &#x60;upscale_percentage&#x60;, &#x60;video_quality_score&#x60;, &#x60;video_startup_business_exception_percentage&#x60;, &#x60;video_startup_failure_percentage&#x60;, &#x60;view_dropped_percentage&#x60;, &#x60;viewer_experience_score&#x60; \&quot;count\&quot; : &#x60;started_views&#x60;, &#x60;unique_viewers&#x60;  | [optional] 
 **filters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  | [optional] 
 **metricFilters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match inequality conditions from provided metric comparison clauses. Must be provided as an array query string parameter.  Possible filterable metrics are the same as the set of metric ids, with the exceptions of &#x60;exits_before_video_start&#x60;, &#x60;unique_viewers&#x60;, &#x60;video_startup_failure_percentage&#x60;, &#x60;view_dropped_percentage&#x60;, and &#x60;views&#x60;.  Example:    * &#x60;metric_filters[]&#x3D;aggregate_startup_time&gt;&#x3D;1000&#x60;  | [optional] 
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
> ListInsightsResponse ListInsights (string METRIC_ID, string measurement = null, string orderDirection = null, List<string> timeframe = null, List<string> filters = null, List<string> metricFilters = null)

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
            var measurement = "95th";  // string | Measurement for the provided metric. If omitted, the default for the metric will be used. The default measurement for each metric is: \"sum\" : `ad_attempt_count`, `ad_break_count`, `ad_break_error_count`, `ad_error_count`, `ad_impression_count`, `playing_time` \"median\" : `ad_preroll_startup_time`, `aggregate_startup_time`, `content_startup_time`, `max_downscale_percentage`, `max_upscale_percentage`, `page_load_time`, `player_average_live_latency`, `player_startup_time`, `rebuffer_count`, `rebuffer_duration`, `requests_for_first_preroll`, `video_startup_preroll_load_time`, `video_startup_preroll_request_time`, `video_startup_time`, `view_average_request_latency`, `view_average_request_throughput`, `view_max_request_latency`, `weighted_average_bitrate` \"avg\" : `ad_break_error_percentage`, `ad_error_percentage`, `ad_exit_before_start_count`, `ad_exit_before_start_percentage`, `ad_playback_failure_percentage`, `ad_startup_error_count`, `ad_startup_error_percentage`, `content_playback_failure_percentage`, `downscale_percentage`, `exits_before_video_start`, `playback_business_exception_percentage`, `playback_failure_percentage`, `playback_success_score`, `rebuffer_frequency`, `rebuffer_percentage`, `seek_latency`, `smoothness_score`, `startup_time_score`, `upscale_percentage`, `video_quality_score`, `video_startup_business_exception_percentage`, `video_startup_failure_percentage`, `view_dropped_percentage`, `viewer_experience_score` \"count\" : `started_views`, `unique_viewers`  (optional) 
            var orderDirection = "asc";  // string | Sort order. (optional) 
            var timeframe = new List<string>(); // List<string> | Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]=).  Accepted formats are...    * array of epoch timestamps e.g. `timeframe[]=1498867200&timeframe[]=1498953600`   * duration string e.g. `timeframe[]=24:hours or timeframe[]=7:days`  (optional) 
            var filters = new List<string>(); // List<string> | Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a `!` character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * `filters[]=operating_system:windows&filters[]=!country:US`  (optional) 
            var metricFilters = new List<string>(); // List<string> | Limit the results to rows that match inequality conditions from provided metric comparison clauses. Must be provided as an array query string parameter.  Possible filterable metrics are the same as the set of metric ids, with the exceptions of `exits_before_video_start`, `unique_viewers`, `video_startup_failure_percentage`, `view_dropped_percentage`, and `views`.  Example:    * `metric_filters[]=aggregate_startup_time>=1000`  (optional) 

            try
            {
                // List Insights
                ListInsightsResponse result = apiInstance.ListInsights(METRIC_ID, measurement, orderDirection, timeframe, filters, metricFilters);
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
 **measurement** | **string**| Measurement for the provided metric. If omitted, the default for the metric will be used. The default measurement for each metric is: \&quot;sum\&quot; : &#x60;ad_attempt_count&#x60;, &#x60;ad_break_count&#x60;, &#x60;ad_break_error_count&#x60;, &#x60;ad_error_count&#x60;, &#x60;ad_impression_count&#x60;, &#x60;playing_time&#x60; \&quot;median\&quot; : &#x60;ad_preroll_startup_time&#x60;, &#x60;aggregate_startup_time&#x60;, &#x60;content_startup_time&#x60;, &#x60;max_downscale_percentage&#x60;, &#x60;max_upscale_percentage&#x60;, &#x60;page_load_time&#x60;, &#x60;player_average_live_latency&#x60;, &#x60;player_startup_time&#x60;, &#x60;rebuffer_count&#x60;, &#x60;rebuffer_duration&#x60;, &#x60;requests_for_first_preroll&#x60;, &#x60;video_startup_preroll_load_time&#x60;, &#x60;video_startup_preroll_request_time&#x60;, &#x60;video_startup_time&#x60;, &#x60;view_average_request_latency&#x60;, &#x60;view_average_request_throughput&#x60;, &#x60;view_max_request_latency&#x60;, &#x60;weighted_average_bitrate&#x60; \&quot;avg\&quot; : &#x60;ad_break_error_percentage&#x60;, &#x60;ad_error_percentage&#x60;, &#x60;ad_exit_before_start_count&#x60;, &#x60;ad_exit_before_start_percentage&#x60;, &#x60;ad_playback_failure_percentage&#x60;, &#x60;ad_startup_error_count&#x60;, &#x60;ad_startup_error_percentage&#x60;, &#x60;content_playback_failure_percentage&#x60;, &#x60;downscale_percentage&#x60;, &#x60;exits_before_video_start&#x60;, &#x60;playback_business_exception_percentage&#x60;, &#x60;playback_failure_percentage&#x60;, &#x60;playback_success_score&#x60;, &#x60;rebuffer_frequency&#x60;, &#x60;rebuffer_percentage&#x60;, &#x60;seek_latency&#x60;, &#x60;smoothness_score&#x60;, &#x60;startup_time_score&#x60;, &#x60;upscale_percentage&#x60;, &#x60;video_quality_score&#x60;, &#x60;video_startup_business_exception_percentage&#x60;, &#x60;video_startup_failure_percentage&#x60;, &#x60;view_dropped_percentage&#x60;, &#x60;viewer_experience_score&#x60; \&quot;count\&quot; : &#x60;started_views&#x60;, &#x60;unique_viewers&#x60;  | [optional] 
 **orderDirection** | **string**| Sort order. | [optional] 
 **timeframe** | [**List&lt;string&gt;**](string.md)| Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  | [optional] 
 **filters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  | [optional] 
 **metricFilters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match inequality conditions from provided metric comparison clauses. Must be provided as an array query string parameter.  Possible filterable metrics are the same as the set of metric ids, with the exceptions of &#x60;exits_before_video_start&#x60;, &#x60;unique_viewers&#x60;, &#x60;video_startup_failure_percentage&#x60;, &#x60;view_dropped_percentage&#x60;, and &#x60;views&#x60;.  Example:    * &#x60;metric_filters[]&#x3D;aggregate_startup_time&gt;&#x3D;1000&#x60;  | [optional] 

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

