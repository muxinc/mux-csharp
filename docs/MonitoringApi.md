# Mux.Csharp.Sdk.Api.MonitoringApi

All URIs are relative to *https://api.mux.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMonitoringBreakdown**](MonitoringApi.md#getmonitoringbreakdown) | **GET** /data/v1/monitoring/metrics/{MONITORING_METRIC_ID}/breakdown | Get Monitoring Breakdown
[**GetMonitoringHistogramTimeseries**](MonitoringApi.md#getmonitoringhistogramtimeseries) | **GET** /data/v1/monitoring/metrics/{MONITORING_HISTOGRAM_METRIC_ID}/histogram-timeseries | Get Monitoring Histogram Timeseries
[**GetMonitoringTimeseries**](MonitoringApi.md#getmonitoringtimeseries) | **GET** /data/v1/monitoring/metrics/{MONITORING_METRIC_ID}/timeseries | Get Monitoring Timeseries
[**ListMonitoringDimensions**](MonitoringApi.md#listmonitoringdimensions) | **GET** /data/v1/monitoring/dimensions | List Monitoring Dimensions
[**ListMonitoringMetrics**](MonitoringApi.md#listmonitoringmetrics) | **GET** /data/v1/monitoring/metrics | List Monitoring Metrics


<a name="getmonitoringbreakdown"></a>
# **GetMonitoringBreakdown**
> GetMonitoringBreakdownResponse GetMonitoringBreakdown (string MONITORING_METRIC_ID, string dimension = null, int? timestamp = null, List<string> filters = null, string orderBy = null, string orderDirection = null)

Get Monitoring Breakdown

Gets breakdown information for a specific dimension and metric along with the number of concurrent viewers and negative impact score.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetMonitoringBreakdownExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MonitoringApi(config);
            var MONITORING_METRIC_ID = current-concurrent-viewers;  // string | ID of the Monitoring Metric
            var dimension = "asn";  // string | Dimension the specified value belongs to (optional) 
            var timestamp = 56;  // int? | Timestamp to limit results by. This value must be provided as a unix timestamp. Defaults to the current unix timestamp. (optional) 
            var filters = new List<string>(); // List<string> | Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a `!` character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * `filters[]=operating_system:windows&filters[]=!country:US`  (optional) 
            var orderBy = "negative_impact";  // string | Value to order the results by (optional) 
            var orderDirection = "asc";  // string | Sort order. (optional) 

            try
            {
                // Get Monitoring Breakdown
                GetMonitoringBreakdownResponse result = apiInstance.GetMonitoringBreakdown(MONITORING_METRIC_ID, dimension, timestamp, filters, orderBy, orderDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoringApi.GetMonitoringBreakdown: " + e.Message );
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
 **MONITORING_METRIC_ID** | **string**| ID of the Monitoring Metric | 
 **dimension** | **string**| Dimension the specified value belongs to | [optional] 
 **timestamp** | **int?**| Timestamp to limit results by. This value must be provided as a unix timestamp. Defaults to the current unix timestamp. | [optional] 
 **filters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  | [optional] 
 **orderBy** | **string**| Value to order the results by | [optional] 
 **orderDirection** | **string**| Sort order. | [optional] 

### Return type

[**GetMonitoringBreakdownResponse**](GetMonitoringBreakdownResponse.md)

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

<a name="getmonitoringhistogramtimeseries"></a>
# **GetMonitoringHistogramTimeseries**
> GetMonitoringHistogramTimeseriesResponse GetMonitoringHistogramTimeseries (string MONITORING_HISTOGRAM_METRIC_ID, List<string> filters = null)

Get Monitoring Histogram Timeseries

Gets histogram timeseries information for a specific metric.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetMonitoringHistogramTimeseriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MonitoringApi(config);
            var MONITORING_HISTOGRAM_METRIC_ID = video-startup-time;  // string | ID of the Monitoring Histogram Metric
            var filters = new List<string>(); // List<string> | Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a `!` character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * `filters[]=operating_system:windows&filters[]=!country:US`  (optional) 

            try
            {
                // Get Monitoring Histogram Timeseries
                GetMonitoringHistogramTimeseriesResponse result = apiInstance.GetMonitoringHistogramTimeseries(MONITORING_HISTOGRAM_METRIC_ID, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoringApi.GetMonitoringHistogramTimeseries: " + e.Message );
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
 **MONITORING_HISTOGRAM_METRIC_ID** | **string**| ID of the Monitoring Histogram Metric | 
 **filters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  | [optional] 

### Return type

[**GetMonitoringHistogramTimeseriesResponse**](GetMonitoringHistogramTimeseriesResponse.md)

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

<a name="getmonitoringtimeseries"></a>
# **GetMonitoringTimeseries**
> GetMonitoringTimeseriesResponse GetMonitoringTimeseries (string MONITORING_METRIC_ID, List<string> filters = null)

Get Monitoring Timeseries

Gets Time series information for a specific metric along with the number of concurrent viewers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetMonitoringTimeseriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MonitoringApi(config);
            var MONITORING_METRIC_ID = current-concurrent-viewers;  // string | ID of the Monitoring Metric
            var filters = new List<string>(); // List<string> | Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a `!` character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * `filters[]=operating_system:windows&filters[]=!country:US`  (optional) 

            try
            {
                // Get Monitoring Timeseries
                GetMonitoringTimeseriesResponse result = apiInstance.GetMonitoringTimeseries(MONITORING_METRIC_ID, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoringApi.GetMonitoringTimeseries: " + e.Message );
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
 **MONITORING_METRIC_ID** | **string**| ID of the Monitoring Metric | 
 **filters** | [**List&lt;string&gt;**](string.md)| Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  | [optional] 

### Return type

[**GetMonitoringTimeseriesResponse**](GetMonitoringTimeseriesResponse.md)

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

<a name="listmonitoringdimensions"></a>
# **ListMonitoringDimensions**
> ListMonitoringDimensionsResponse ListMonitoringDimensions ()

List Monitoring Dimensions

Lists available monitoring dimensions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListMonitoringDimensionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MonitoringApi(config);

            try
            {
                // List Monitoring Dimensions
                ListMonitoringDimensionsResponse result = apiInstance.ListMonitoringDimensions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoringApi.ListMonitoringDimensions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ListMonitoringDimensionsResponse**](ListMonitoringDimensionsResponse.md)

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

<a name="listmonitoringmetrics"></a>
# **ListMonitoringMetrics**
> ListMonitoringMetricsResponse ListMonitoringMetrics ()

List Monitoring Metrics

Lists available monitoring metrics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListMonitoringMetricsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MonitoringApi(config);

            try
            {
                // List Monitoring Metrics
                ListMonitoringMetricsResponse result = apiInstance.ListMonitoringMetrics();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoringApi.ListMonitoringMetrics: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ListMonitoringMetricsResponse**](ListMonitoringMetricsResponse.md)

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

