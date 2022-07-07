# Mux.Csharp.Sdk.Api.TranscriptionVocabulariesApi

All URIs are relative to *https://api.mux.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTranscriptionVocabulary**](TranscriptionVocabulariesApi.md#createtranscriptionvocabulary) | **POST** /video/v1/transcription-vocabularies | Create a Transcription Vocabulary
[**DeleteTranscriptionVocabulary**](TranscriptionVocabulariesApi.md#deletetranscriptionvocabulary) | **DELETE** /video/v1/transcription-vocabularies/{TRANSCRIPTION_VOCABULARY_ID} | Delete a Transcription Vocabulary
[**GetTranscriptionVocabulary**](TranscriptionVocabulariesApi.md#gettranscriptionvocabulary) | **GET** /video/v1/transcription-vocabularies/{TRANSCRIPTION_VOCABULARY_ID} | Retrieve a Transcription Vocabulary
[**ListTranscriptionVocabularies**](TranscriptionVocabulariesApi.md#listtranscriptionvocabularies) | **GET** /video/v1/transcription-vocabularies | List Transcription Vocabularies
[**UpdateTranscriptionVocabulary**](TranscriptionVocabulariesApi.md#updatetranscriptionvocabulary) | **PUT** /video/v1/transcription-vocabularies/{TRANSCRIPTION_VOCABULARY_ID} | Update a Transcription Vocabulary


<a name="createtranscriptionvocabulary"></a>
# **CreateTranscriptionVocabulary**
> TranscriptionVocabularyResponse CreateTranscriptionVocabulary (CreateTranscriptionVocabularyRequest createTranscriptionVocabularyRequest)

Create a Transcription Vocabulary

Create a new Transcription Vocabulary.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class CreateTranscriptionVocabularyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TranscriptionVocabulariesApi(config);
            var createTranscriptionVocabularyRequest = new CreateTranscriptionVocabularyRequest(); // CreateTranscriptionVocabularyRequest | 

            try
            {
                // Create a Transcription Vocabulary
                TranscriptionVocabularyResponse result = apiInstance.CreateTranscriptionVocabulary(createTranscriptionVocabularyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranscriptionVocabulariesApi.CreateTranscriptionVocabulary: " + e.Message );
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
 **createTranscriptionVocabularyRequest** | [**CreateTranscriptionVocabularyRequest**](CreateTranscriptionVocabularyRequest.md)|  | 

### Return type

[**TranscriptionVocabularyResponse**](TranscriptionVocabularyResponse.md)

### Authorization

[accessToken](../README.md#accessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Transcription Vocabulary Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetranscriptionvocabulary"></a>
# **DeleteTranscriptionVocabulary**
> void DeleteTranscriptionVocabulary (string TRANSCRIPTION_VOCABULARY_ID)

Delete a Transcription Vocabulary

Deletes a Transcription Vocabulary. The Transcription Vocabulary's ID will be disassociated from any live streams using it. Transcription Vocabularies can be deleted while associated live streams are active. However, the words and phrases in the deleted Transcription Vocabulary will remain attached to those streams while they are active.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class DeleteTranscriptionVocabularyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TranscriptionVocabulariesApi(config);
            var TRANSCRIPTION_VOCABULARY_ID = "TRANSCRIPTION_VOCABULARY_ID_example";  // string | The ID of the Transcription Vocabulary.

            try
            {
                // Delete a Transcription Vocabulary
                apiInstance.DeleteTranscriptionVocabulary(TRANSCRIPTION_VOCABULARY_ID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranscriptionVocabulariesApi.DeleteTranscriptionVocabulary: " + e.Message );
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
 **TRANSCRIPTION_VOCABULARY_ID** | **string**| The ID of the Transcription Vocabulary. | 

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

<a name="gettranscriptionvocabulary"></a>
# **GetTranscriptionVocabulary**
> TranscriptionVocabularyResponse GetTranscriptionVocabulary (string TRANSCRIPTION_VOCABULARY_ID)

Retrieve a Transcription Vocabulary

Retrieves the details of a Transcription Vocabulary that has previously been created. Supply the unique Transcription Vocabulary ID and Mux will return the corresponding Transcription Vocabulary information. The same information is returned when creating a Transcription Vocabulary.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetTranscriptionVocabularyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TranscriptionVocabulariesApi(config);
            var TRANSCRIPTION_VOCABULARY_ID = "TRANSCRIPTION_VOCABULARY_ID_example";  // string | The ID of the Transcription Vocabulary.

            try
            {
                // Retrieve a Transcription Vocabulary
                TranscriptionVocabularyResponse result = apiInstance.GetTranscriptionVocabulary(TRANSCRIPTION_VOCABULARY_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranscriptionVocabulariesApi.GetTranscriptionVocabulary: " + e.Message );
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
 **TRANSCRIPTION_VOCABULARY_ID** | **string**| The ID of the Transcription Vocabulary. | 

### Return type

[**TranscriptionVocabularyResponse**](TranscriptionVocabularyResponse.md)

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

<a name="listtranscriptionvocabularies"></a>
# **ListTranscriptionVocabularies**
> ListTranscriptionVocabulariesResponse ListTranscriptionVocabularies (int? limit = null, int? page = null)

List Transcription Vocabularies

List all Transcription Vocabularies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListTranscriptionVocabulariesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TranscriptionVocabulariesApi(config);
            var limit = 10;  // int? | Number of items to include in the response (optional)  (default to 10)
            var page = 1;  // int? | Offset by this many pages, of the size of `limit` (optional)  (default to 1)

            try
            {
                // List Transcription Vocabularies
                ListTranscriptionVocabulariesResponse result = apiInstance.ListTranscriptionVocabularies(limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranscriptionVocabulariesApi.ListTranscriptionVocabularies: " + e.Message );
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
 **limit** | **int?**| Number of items to include in the response | [optional] [default to 10]
 **page** | **int?**| Offset by this many pages, of the size of &#x60;limit&#x60; | [optional] [default to 1]

### Return type

[**ListTranscriptionVocabulariesResponse**](ListTranscriptionVocabulariesResponse.md)

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

<a name="updatetranscriptionvocabulary"></a>
# **UpdateTranscriptionVocabulary**
> TranscriptionVocabularyResponse UpdateTranscriptionVocabulary (string TRANSCRIPTION_VOCABULARY_ID, UpdateTranscriptionVocabularyRequest updateTranscriptionVocabularyRequest)

Update a Transcription Vocabulary

Updates the details of a previously-created Transcription Vocabulary. Updates to Transcription Vocabularies are allowed while associated live streams are active. However, updates will not be applied to those streams while they are active.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class UpdateTranscriptionVocabularyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TranscriptionVocabulariesApi(config);
            var TRANSCRIPTION_VOCABULARY_ID = "TRANSCRIPTION_VOCABULARY_ID_example";  // string | The ID of the Transcription Vocabulary.
            var updateTranscriptionVocabularyRequest = new UpdateTranscriptionVocabularyRequest(); // UpdateTranscriptionVocabularyRequest | 

            try
            {
                // Update a Transcription Vocabulary
                TranscriptionVocabularyResponse result = apiInstance.UpdateTranscriptionVocabulary(TRANSCRIPTION_VOCABULARY_ID, updateTranscriptionVocabularyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranscriptionVocabulariesApi.UpdateTranscriptionVocabulary: " + e.Message );
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
 **TRANSCRIPTION_VOCABULARY_ID** | **string**| The ID of the Transcription Vocabulary. | 
 **updateTranscriptionVocabularyRequest** | [**UpdateTranscriptionVocabularyRequest**](UpdateTranscriptionVocabularyRequest.md)|  | 

### Return type

[**TranscriptionVocabularyResponse**](TranscriptionVocabularyResponse.md)

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

