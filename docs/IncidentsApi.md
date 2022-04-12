# Mux.Csharp.Sdk.Api.IncidentsApi

All URIs are relative to *https://api.mux.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIncident**](IncidentsApi.md#getincident) | **GET** /data/v1/incidents/{INCIDENT_ID} | Get an Incident
[**ListIncidents**](IncidentsApi.md#listincidents) | **GET** /data/v1/incidents | List Incidents
[**ListRelatedIncidents**](IncidentsApi.md#listrelatedincidents) | **GET** /data/v1/incidents/{INCIDENT_ID}/related | List Related Incidents


<a name="getincident"></a>
# **GetIncident**
> IncidentResponse GetIncident (string INCIDENT_ID)

Get an Incident

Returns the details of an incident.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetIncidentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new IncidentsApi(config);
            var INCIDENT_ID = abcd1234;  // string | ID of the Incident

            try
            {
                // Get an Incident
                IncidentResponse result = apiInstance.GetIncident(INCIDENT_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentsApi.GetIncident: " + e.Message );
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
 **INCIDENT_ID** | **string**| ID of the Incident | 

### Return type

[**IncidentResponse**](IncidentResponse.md)

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

<a name="listincidents"></a>
# **ListIncidents**
> ListIncidentsResponse ListIncidents (int? limit = null, int? page = null, string orderBy = null, string orderDirection = null, string status = null, string severity = null)

List Incidents

Returns a list of incidents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListIncidentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new IncidentsApi(config);
            var limit = 25;  // int? | Number of items to include in the response (optional)  (default to 25)
            var page = 1;  // int? | Offset by this many pages, of the size of `limit` (optional)  (default to 1)
            var orderBy = "negative_impact";  // string | Value to order the results by (optional) 
            var orderDirection = "asc";  // string | Sort order. (optional) 
            var status = "open";  // string | Status to filter incidents by (optional) 
            var severity = "warning";  // string | Severity to filter incidents by (optional) 

            try
            {
                // List Incidents
                ListIncidentsResponse result = apiInstance.ListIncidents(limit, page, orderBy, orderDirection, status, severity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentsApi.ListIncidents: " + e.Message );
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
 **orderBy** | **string**| Value to order the results by | [optional] 
 **orderDirection** | **string**| Sort order. | [optional] 
 **status** | **string**| Status to filter incidents by | [optional] 
 **severity** | **string**| Severity to filter incidents by | [optional] 

### Return type

[**ListIncidentsResponse**](ListIncidentsResponse.md)

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

<a name="listrelatedincidents"></a>
# **ListRelatedIncidents**
> ListRelatedIncidentsResponse ListRelatedIncidents (string INCIDENT_ID, int? limit = null, int? page = null, string orderBy = null, string orderDirection = null)

List Related Incidents

Returns all the incidents that seem related to a specific incident.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListRelatedIncidentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new IncidentsApi(config);
            var INCIDENT_ID = abcd1234;  // string | ID of the Incident
            var limit = 25;  // int? | Number of items to include in the response (optional)  (default to 25)
            var page = 1;  // int? | Offset by this many pages, of the size of `limit` (optional)  (default to 1)
            var orderBy = "negative_impact";  // string | Value to order the results by (optional) 
            var orderDirection = "asc";  // string | Sort order. (optional) 

            try
            {
                // List Related Incidents
                ListRelatedIncidentsResponse result = apiInstance.ListRelatedIncidents(INCIDENT_ID, limit, page, orderBy, orderDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentsApi.ListRelatedIncidents: " + e.Message );
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
 **INCIDENT_ID** | **string**| ID of the Incident | 
 **limit** | **int?**| Number of items to include in the response | [optional] [default to 25]
 **page** | **int?**| Offset by this many pages, of the size of &#x60;limit&#x60; | [optional] [default to 1]
 **orderBy** | **string**| Value to order the results by | [optional] 
 **orderDirection** | **string**| Sort order. | [optional] 

### Return type

[**ListRelatedIncidentsResponse**](ListRelatedIncidentsResponse.md)

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

