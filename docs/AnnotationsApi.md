# Mux.Csharp.Sdk.Api.AnnotationsApi

All URIs are relative to *https://api.mux.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAnnotation**](AnnotationsApi.md#createannotation) | **POST** /data/v1/annotations | Create Annotation
[**DeleteAnnotation**](AnnotationsApi.md#deleteannotation) | **DELETE** /data/v1/annotations/{ANNOTATION_ID} | Delete Annotation
[**GetAnnotation**](AnnotationsApi.md#getannotation) | **GET** /data/v1/annotations/{ANNOTATION_ID} | Get Annotation
[**ListAnnotations**](AnnotationsApi.md#listannotations) | **GET** /data/v1/annotations | List Annotations
[**UpdateAnnotation**](AnnotationsApi.md#updateannotation) | **PATCH** /data/v1/annotations/{ANNOTATION_ID} | Update Annotation


<a name="createannotation"></a>
# **CreateAnnotation**
> AnnotationResponse CreateAnnotation (AnnotationInput annotationInput)

Create Annotation

Creates a new annotation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class CreateAnnotationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AnnotationsApi(config);
            var annotationInput = new AnnotationInput(); // AnnotationInput | 

            try
            {
                // Create Annotation
                AnnotationResponse result = apiInstance.CreateAnnotation(annotationInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnnotationsApi.CreateAnnotation: " + e.Message );
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
 **annotationInput** | [**AnnotationInput**](AnnotationInput.md)|  | 

### Return type

[**AnnotationResponse**](AnnotationResponse.md)

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

<a name="deleteannotation"></a>
# **DeleteAnnotation**
> void DeleteAnnotation (Guid ANNOTATION_ID)

Delete Annotation

Deletes an annotation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class DeleteAnnotationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AnnotationsApi(config);
            var ANNOTATION_ID = "ANNOTATION_ID_example";  // Guid | The annotation ID

            try
            {
                // Delete Annotation
                apiInstance.DeleteAnnotation(ANNOTATION_ID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnnotationsApi.DeleteAnnotation: " + e.Message );
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
 **ANNOTATION_ID** | **Guid**| The annotation ID | 

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

<a name="getannotation"></a>
# **GetAnnotation**
> AnnotationResponse GetAnnotation (Guid ANNOTATION_ID)

Get Annotation

Returns the details of a specific annotation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetAnnotationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AnnotationsApi(config);
            var ANNOTATION_ID = "ANNOTATION_ID_example";  // Guid | The annotation ID

            try
            {
                // Get Annotation
                AnnotationResponse result = apiInstance.GetAnnotation(ANNOTATION_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnnotationsApi.GetAnnotation: " + e.Message );
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
 **ANNOTATION_ID** | **Guid**| The annotation ID | 

### Return type

[**AnnotationResponse**](AnnotationResponse.md)

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

<a name="listannotations"></a>
# **ListAnnotations**
> ListAnnotationsResponse ListAnnotations (int? limit = null, int? page = null, string orderDirection = null, List<string> timeframe = null)

List Annotations

Returns a list of annotations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListAnnotationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AnnotationsApi(config);
            var limit = 25;  // int? | Number of items to include in the response (optional)  (default to 25)
            var page = 1;  // int? | Offset by this many pages, of the size of `limit` (optional)  (default to 1)
            var orderDirection = "asc";  // string | Sort order. (optional) 
            var timeframe = new List<string>(); // List<string> | Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]=).  Accepted formats are...    * array of epoch timestamps e.g. `timeframe[]=1498867200&timeframe[]=1498953600`   * duration string e.g. `timeframe[]=24:hours or timeframe[]=7:days`  (optional) 

            try
            {
                // List Annotations
                ListAnnotationsResponse result = apiInstance.ListAnnotations(limit, page, orderDirection, timeframe);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnnotationsApi.ListAnnotations: " + e.Message );
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
 **orderDirection** | **string**| Sort order. | [optional] 
 **timeframe** | [**List&lt;string&gt;**](string.md)| Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  | [optional] 

### Return type

[**ListAnnotationsResponse**](ListAnnotationsResponse.md)

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

<a name="updateannotation"></a>
# **UpdateAnnotation**
> AnnotationResponse UpdateAnnotation (Guid ANNOTATION_ID, AnnotationInput annotationInput)

Update Annotation

Updates an existing annotation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class UpdateAnnotationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AnnotationsApi(config);
            var ANNOTATION_ID = "ANNOTATION_ID_example";  // Guid | The annotation ID
            var annotationInput = new AnnotationInput(); // AnnotationInput | 

            try
            {
                // Update Annotation
                AnnotationResponse result = apiInstance.UpdateAnnotation(ANNOTATION_ID, annotationInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnnotationsApi.UpdateAnnotation: " + e.Message );
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
 **ANNOTATION_ID** | **Guid**| The annotation ID | 
 **annotationInput** | [**AnnotationInput**](AnnotationInput.md)|  | 

### Return type

[**AnnotationResponse**](AnnotationResponse.md)

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

