# Mux.Csharp.Sdk.Api.LiveStreamsApi

All URIs are relative to *https://api.mux.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLiveStream**](LiveStreamsApi.md#createlivestream) | **POST** /video/v1/live-streams | Create a live stream
[**CreateLiveStreamPlaybackId**](LiveStreamsApi.md#createlivestreamplaybackid) | **POST** /video/v1/live-streams/{LIVE_STREAM_ID}/playback-ids | Create a live stream playback ID
[**CreateLiveStreamSimulcastTarget**](LiveStreamsApi.md#createlivestreamsimulcasttarget) | **POST** /video/v1/live-streams/{LIVE_STREAM_ID}/simulcast-targets | Create a live stream simulcast target
[**DeleteLiveStream**](LiveStreamsApi.md#deletelivestream) | **DELETE** /video/v1/live-streams/{LIVE_STREAM_ID} | Delete a live stream
[**DeleteLiveStreamPlaybackId**](LiveStreamsApi.md#deletelivestreamplaybackid) | **DELETE** /video/v1/live-streams/{LIVE_STREAM_ID}/playback-ids/{PLAYBACK_ID} | Delete a live stream playback ID
[**DeleteLiveStreamSimulcastTarget**](LiveStreamsApi.md#deletelivestreamsimulcasttarget) | **DELETE** /video/v1/live-streams/{LIVE_STREAM_ID}/simulcast-targets/{SIMULCAST_TARGET_ID} | Delete a live stream simulcast target
[**DeleteLiveStreamStaticRenditions**](LiveStreamsApi.md#deletelivestreamstaticrenditions) | **DELETE** /video/v1/live-streams/{LIVE_STREAM_ID}/new-asset-settings/static-renditions | Delete a live stream&#39;s static renditions setting for new assets
[**DisableLiveStream**](LiveStreamsApi.md#disablelivestream) | **PUT** /video/v1/live-streams/{LIVE_STREAM_ID}/disable | Disable a live stream
[**EnableLiveStream**](LiveStreamsApi.md#enablelivestream) | **PUT** /video/v1/live-streams/{LIVE_STREAM_ID}/enable | Enable a live stream
[**GetLiveStream**](LiveStreamsApi.md#getlivestream) | **GET** /video/v1/live-streams/{LIVE_STREAM_ID} | Retrieve a live stream
[**GetLiveStreamPlaybackId**](LiveStreamsApi.md#getlivestreamplaybackid) | **GET** /video/v1/live-streams/{LIVE_STREAM_ID}/playback-ids/{PLAYBACK_ID} | Retrieve a live stream playback ID
[**GetLiveStreamSimulcastTarget**](LiveStreamsApi.md#getlivestreamsimulcasttarget) | **GET** /video/v1/live-streams/{LIVE_STREAM_ID}/simulcast-targets/{SIMULCAST_TARGET_ID} | Retrieve a live stream simulcast target
[**ListLiveStreams**](LiveStreamsApi.md#listlivestreams) | **GET** /video/v1/live-streams | List live streams
[**ResetStreamKey**](LiveStreamsApi.md#resetstreamkey) | **POST** /video/v1/live-streams/{LIVE_STREAM_ID}/reset-stream-key | Reset a live stream&#39;s stream key
[**SignalLiveStreamComplete**](LiveStreamsApi.md#signallivestreamcomplete) | **PUT** /video/v1/live-streams/{LIVE_STREAM_ID}/complete | Signal a live stream is finished
[**UpdateLiveStream**](LiveStreamsApi.md#updatelivestream) | **PATCH** /video/v1/live-streams/{LIVE_STREAM_ID} | Update a live stream
[**UpdateLiveStreamEmbeddedSubtitles**](LiveStreamsApi.md#updatelivestreamembeddedsubtitles) | **PUT** /video/v1/live-streams/{LIVE_STREAM_ID}/embedded-subtitles | Update a live stream&#39;s embedded subtitles
[**UpdateLiveStreamGeneratedSubtitles**](LiveStreamsApi.md#updatelivestreamgeneratedsubtitles) | **PUT** /video/v1/live-streams/{LIVE_STREAM_ID}/generated-subtitles | Update a live stream&#39;s generated subtitles
[**UpdateLiveStreamStaticRenditions**](LiveStreamsApi.md#updatelivestreamstaticrenditions) | **PUT** /video/v1/live-streams/{LIVE_STREAM_ID}/new-asset-settings/static-renditions | Update live stream static renditions for new assets


<a name="createlivestream"></a>
# **CreateLiveStream**
> LiveStreamResponse CreateLiveStream (CreateLiveStreamRequest createLiveStreamRequest)

Create a live stream

Creates a new live stream. Once created, an encoder can connect to Mux via the specified stream key and begin streaming to an audience.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class CreateLiveStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var createLiveStreamRequest = new CreateLiveStreamRequest(); // CreateLiveStreamRequest | 

            try
            {
                // Create a live stream
                LiveStreamResponse result = apiInstance.CreateLiveStream(createLiveStreamRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.CreateLiveStream: " + e.Message );
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
 **createLiveStreamRequest** | [**CreateLiveStreamRequest**](CreateLiveStreamRequest.md)|  | 

### Return type

[**LiveStreamResponse**](LiveStreamResponse.md)

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

<a name="createlivestreamplaybackid"></a>
# **CreateLiveStreamPlaybackId**
> CreatePlaybackIDResponse CreateLiveStreamPlaybackId (string LIVE_STREAM_ID, CreatePlaybackIDRequest createPlaybackIDRequest)

Create a live stream playback ID

Create a new playback ID for this live stream, through which a viewer can watch the streamed content of the live stream.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class CreateLiveStreamPlaybackIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID
            var createPlaybackIDRequest = new CreatePlaybackIDRequest(); // CreatePlaybackIDRequest | 

            try
            {
                // Create a live stream playback ID
                CreatePlaybackIDResponse result = apiInstance.CreateLiveStreamPlaybackId(LIVE_STREAM_ID, createPlaybackIDRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.CreateLiveStreamPlaybackId: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 
 **createPlaybackIDRequest** | [**CreatePlaybackIDRequest**](CreatePlaybackIDRequest.md)|  | 

### Return type

[**CreatePlaybackIDResponse**](CreatePlaybackIDResponse.md)

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

<a name="createlivestreamsimulcasttarget"></a>
# **CreateLiveStreamSimulcastTarget**
> SimulcastTargetResponse CreateLiveStreamSimulcastTarget (string LIVE_STREAM_ID, CreateSimulcastTargetRequest createSimulcastTargetRequest)

Create a live stream simulcast target

Create a simulcast target for the parent live stream. Simulcast target can only be created when the parent live stream is in idle state. Only one simulcast target can be created at a time with this API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class CreateLiveStreamSimulcastTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID
            var createSimulcastTargetRequest = new CreateSimulcastTargetRequest(); // CreateSimulcastTargetRequest | 

            try
            {
                // Create a live stream simulcast target
                SimulcastTargetResponse result = apiInstance.CreateLiveStreamSimulcastTarget(LIVE_STREAM_ID, createSimulcastTargetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.CreateLiveStreamSimulcastTarget: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 
 **createSimulcastTargetRequest** | [**CreateSimulcastTargetRequest**](CreateSimulcastTargetRequest.md)|  | 

### Return type

[**SimulcastTargetResponse**](SimulcastTargetResponse.md)

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

<a name="deletelivestream"></a>
# **DeleteLiveStream**
> void DeleteLiveStream (string LIVE_STREAM_ID)

Delete a live stream

Deletes a live stream from the current environment. If the live stream is currently active and being streamed to, ingest will be terminated and the encoder will be disconnected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class DeleteLiveStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID

            try
            {
                // Delete a live stream
                apiInstance.DeleteLiveStream(LIVE_STREAM_ID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.DeleteLiveStream: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 

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

<a name="deletelivestreamplaybackid"></a>
# **DeleteLiveStreamPlaybackId**
> void DeleteLiveStreamPlaybackId (string LIVE_STREAM_ID, string PLAYBACK_ID)

Delete a live stream playback ID

Deletes the playback ID for the live stream. This will not disable ingest (as the live stream still exists). New attempts to play back the live stream will fail immediately. However, current viewers will be able to continue watching the stream for some period of time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class DeleteLiveStreamPlaybackIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID
            var PLAYBACK_ID = "PLAYBACK_ID_example";  // string | The live stream's playback ID.

            try
            {
                // Delete a live stream playback ID
                apiInstance.DeleteLiveStreamPlaybackId(LIVE_STREAM_ID, PLAYBACK_ID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.DeleteLiveStreamPlaybackId: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 
 **PLAYBACK_ID** | **string**| The live stream&#39;s playback ID. | 

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

<a name="deletelivestreamsimulcasttarget"></a>
# **DeleteLiveStreamSimulcastTarget**
> void DeleteLiveStreamSimulcastTarget (string LIVE_STREAM_ID, string SIMULCAST_TARGET_ID)

Delete a live stream simulcast target

Delete the simulcast target using the simulcast target ID returned when creating the simulcast target. Simulcast Target can only be deleted when the parent live stream is in idle state.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class DeleteLiveStreamSimulcastTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID
            var SIMULCAST_TARGET_ID = "SIMULCAST_TARGET_ID_example";  // string | The ID of the simulcast target.

            try
            {
                // Delete a live stream simulcast target
                apiInstance.DeleteLiveStreamSimulcastTarget(LIVE_STREAM_ID, SIMULCAST_TARGET_ID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.DeleteLiveStreamSimulcastTarget: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 
 **SIMULCAST_TARGET_ID** | **string**| The ID of the simulcast target. | 

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

<a name="deletelivestreamstaticrenditions"></a>
# **DeleteLiveStreamStaticRenditions**
> void DeleteLiveStreamStaticRenditions (string LIVE_STREAM_ID)

Delete a live stream's static renditions setting for new assets

Deletes a live stream's static renditions settings for new assets. Further assets made via this live stream will not create static renditions unless re-added.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class DeleteLiveStreamStaticRenditionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID

            try
            {
                // Delete a live stream's static renditions setting for new assets
                apiInstance.DeleteLiveStreamStaticRenditions(LIVE_STREAM_ID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.DeleteLiveStreamStaticRenditions: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 

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

<a name="disablelivestream"></a>
# **DisableLiveStream**
> DisableLiveStreamResponse DisableLiveStream (string LIVE_STREAM_ID)

Disable a live stream

Disables a live stream, making it reject incoming RTMP streams until re-enabled. The API also ends the live stream recording immediately when active. Ending the live stream recording adds the `EXT-X-ENDLIST` tag to the HLS manifest which notifies the player that this live stream is over.  Mux also closes the encoder connection immediately. Any attempt from the encoder to re-establish connection will fail till the live stream is re-enabled. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class DisableLiveStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID

            try
            {
                // Disable a live stream
                DisableLiveStreamResponse result = apiInstance.DisableLiveStream(LIVE_STREAM_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.DisableLiveStream: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 

### Return type

[**DisableLiveStreamResponse**](DisableLiveStreamResponse.md)

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

<a name="enablelivestream"></a>
# **EnableLiveStream**
> EnableLiveStreamResponse EnableLiveStream (string LIVE_STREAM_ID)

Enable a live stream

Enables a live stream, allowing it to accept an incoming RTMP stream.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class EnableLiveStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID

            try
            {
                // Enable a live stream
                EnableLiveStreamResponse result = apiInstance.EnableLiveStream(LIVE_STREAM_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.EnableLiveStream: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 

### Return type

[**EnableLiveStreamResponse**](EnableLiveStreamResponse.md)

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

<a name="getlivestream"></a>
# **GetLiveStream**
> LiveStreamResponse GetLiveStream (string LIVE_STREAM_ID)

Retrieve a live stream

Retrieves the details of a live stream that has previously been created. Supply the unique live stream ID that was returned from your previous request, and Mux will return the corresponding live stream information. The same information is returned when creating a live stream.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetLiveStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID

            try
            {
                // Retrieve a live stream
                LiveStreamResponse result = apiInstance.GetLiveStream(LIVE_STREAM_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.GetLiveStream: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 

### Return type

[**LiveStreamResponse**](LiveStreamResponse.md)

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

<a name="getlivestreamplaybackid"></a>
# **GetLiveStreamPlaybackId**
> GetLiveStreamPlaybackIDResponse GetLiveStreamPlaybackId (string LIVE_STREAM_ID, string PLAYBACK_ID)

Retrieve a live stream playback ID

Fetches information about a live stream's playback ID, through which a viewer can watch the streamed content from this live stream.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetLiveStreamPlaybackIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID
            var PLAYBACK_ID = "PLAYBACK_ID_example";  // string | The live stream's playback ID.

            try
            {
                // Retrieve a live stream playback ID
                GetLiveStreamPlaybackIDResponse result = apiInstance.GetLiveStreamPlaybackId(LIVE_STREAM_ID, PLAYBACK_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.GetLiveStreamPlaybackId: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 
 **PLAYBACK_ID** | **string**| The live stream&#39;s playback ID. | 

### Return type

[**GetLiveStreamPlaybackIDResponse**](GetLiveStreamPlaybackIDResponse.md)

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

<a name="getlivestreamsimulcasttarget"></a>
# **GetLiveStreamSimulcastTarget**
> SimulcastTargetResponse GetLiveStreamSimulcastTarget (string LIVE_STREAM_ID, string SIMULCAST_TARGET_ID)

Retrieve a live stream simulcast target

Retrieves the details of the simulcast target created for the parent live stream. Supply the unique live stream ID and simulcast target ID that was returned in the response of create simulcast target request, and Mux will return the corresponding information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetLiveStreamSimulcastTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID
            var SIMULCAST_TARGET_ID = "SIMULCAST_TARGET_ID_example";  // string | The ID of the simulcast target.

            try
            {
                // Retrieve a live stream simulcast target
                SimulcastTargetResponse result = apiInstance.GetLiveStreamSimulcastTarget(LIVE_STREAM_ID, SIMULCAST_TARGET_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.GetLiveStreamSimulcastTarget: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 
 **SIMULCAST_TARGET_ID** | **string**| The ID of the simulcast target. | 

### Return type

[**SimulcastTargetResponse**](SimulcastTargetResponse.md)

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

<a name="listlivestreams"></a>
# **ListLiveStreams**
> ListLiveStreamsResponse ListLiveStreams (int? limit = null, int? page = null, string streamKey = null, LiveStreamStatus? status = null)

List live streams

Lists the live streams that currently exist in the current environment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListLiveStreamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var limit = 25;  // int? | Number of items to include in the response (optional)  (default to 25)
            var page = 1;  // int? | Offset by this many pages, of the size of `limit` (optional)  (default to 1)
            var streamKey = "streamKey_example";  // string | Filter response to return live stream for this stream key only (optional) 
            var status = (LiveStreamStatus) "active";  // LiveStreamStatus? | Filter response to return live streams with the specified status only (optional) 

            try
            {
                // List live streams
                ListLiveStreamsResponse result = apiInstance.ListLiveStreams(limit, page, streamKey, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.ListLiveStreams: " + e.Message );
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
 **streamKey** | **string**| Filter response to return live stream for this stream key only | [optional] 
 **status** | **LiveStreamStatus?**| Filter response to return live streams with the specified status only | [optional] 

### Return type

[**ListLiveStreamsResponse**](ListLiveStreamsResponse.md)

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

<a name="resetstreamkey"></a>
# **ResetStreamKey**
> LiveStreamResponse ResetStreamKey (string LIVE_STREAM_ID)

Reset a live stream's stream key

Reset a live stream key if you want to immediately stop the current stream key from working and create a new stream key that can be used for future broadcasts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ResetStreamKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID

            try
            {
                // Reset a live stream's stream key
                LiveStreamResponse result = apiInstance.ResetStreamKey(LIVE_STREAM_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.ResetStreamKey: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 

### Return type

[**LiveStreamResponse**](LiveStreamResponse.md)

### Authorization

[accessToken](../README.md#accessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signallivestreamcomplete"></a>
# **SignalLiveStreamComplete**
> SignalLiveStreamCompleteResponse SignalLiveStreamComplete (string LIVE_STREAM_ID)

Signal a live stream is finished

(Optional) End the live stream recording immediately instead of waiting for the reconnect_window. `EXT-X-ENDLIST` tag is added to the HLS manifest which notifies the player that this live stream is over.  Mux does not close the encoder connection immediately. Encoders are often configured to re-establish connections immediately which would result in a new recorded asset. For this reason, Mux waits for 60s before closing the connection with the encoder. This 60s timeframe is meant to give encoder operators a chance to disconnect from their end. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class SignalLiveStreamCompleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID

            try
            {
                // Signal a live stream is finished
                SignalLiveStreamCompleteResponse result = apiInstance.SignalLiveStreamComplete(LIVE_STREAM_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.SignalLiveStreamComplete: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 

### Return type

[**SignalLiveStreamCompleteResponse**](SignalLiveStreamCompleteResponse.md)

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

<a name="updatelivestream"></a>
# **UpdateLiveStream**
> LiveStreamResponse UpdateLiveStream (string LIVE_STREAM_ID, UpdateLiveStreamRequest updateLiveStreamRequest)

Update a live stream

Updates the parameters of a previously-created live stream. This currently supports a subset of variables. Supply the live stream ID and the updated parameters and Mux will return the corresponding live stream information. The information returned will be the same after update as for subsequent get live stream requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class UpdateLiveStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID
            var updateLiveStreamRequest = new UpdateLiveStreamRequest(); // UpdateLiveStreamRequest | 

            try
            {
                // Update a live stream
                LiveStreamResponse result = apiInstance.UpdateLiveStream(LIVE_STREAM_ID, updateLiveStreamRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.UpdateLiveStream: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 
 **updateLiveStreamRequest** | [**UpdateLiveStreamRequest**](UpdateLiveStreamRequest.md)|  | 

### Return type

[**LiveStreamResponse**](LiveStreamResponse.md)

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

<a name="updatelivestreamembeddedsubtitles"></a>
# **UpdateLiveStreamEmbeddedSubtitles**
> LiveStreamResponse UpdateLiveStreamEmbeddedSubtitles (string LIVE_STREAM_ID, UpdateLiveStreamEmbeddedSubtitlesRequest updateLiveStreamEmbeddedSubtitlesRequest)

Update a live stream's embedded subtitles

Configures a live stream to receive embedded closed captions. The resulting Asset's subtitle text track will have `closed_captions: true` set. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class UpdateLiveStreamEmbeddedSubtitlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID
            var updateLiveStreamEmbeddedSubtitlesRequest = new UpdateLiveStreamEmbeddedSubtitlesRequest(); // UpdateLiveStreamEmbeddedSubtitlesRequest | 

            try
            {
                // Update a live stream's embedded subtitles
                LiveStreamResponse result = apiInstance.UpdateLiveStreamEmbeddedSubtitles(LIVE_STREAM_ID, updateLiveStreamEmbeddedSubtitlesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.UpdateLiveStreamEmbeddedSubtitles: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 
 **updateLiveStreamEmbeddedSubtitlesRequest** | [**UpdateLiveStreamEmbeddedSubtitlesRequest**](UpdateLiveStreamEmbeddedSubtitlesRequest.md)|  | 

### Return type

[**LiveStreamResponse**](LiveStreamResponse.md)

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

<a name="updatelivestreamgeneratedsubtitles"></a>
# **UpdateLiveStreamGeneratedSubtitles**
> LiveStreamResponse UpdateLiveStreamGeneratedSubtitles (string LIVE_STREAM_ID, UpdateLiveStreamGeneratedSubtitlesRequest updateLiveStreamGeneratedSubtitlesRequest)

Update a live stream's generated subtitles

Updates a live stream's automatic-speech-recognition-generated subtitle configuration. Automatic speech recognition subtitles can be removed by sending an empty array in the request payload. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class UpdateLiveStreamGeneratedSubtitlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID
            var updateLiveStreamGeneratedSubtitlesRequest = new UpdateLiveStreamGeneratedSubtitlesRequest(); // UpdateLiveStreamGeneratedSubtitlesRequest | 

            try
            {
                // Update a live stream's generated subtitles
                LiveStreamResponse result = apiInstance.UpdateLiveStreamGeneratedSubtitles(LIVE_STREAM_ID, updateLiveStreamGeneratedSubtitlesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.UpdateLiveStreamGeneratedSubtitles: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 
 **updateLiveStreamGeneratedSubtitlesRequest** | [**UpdateLiveStreamGeneratedSubtitlesRequest**](UpdateLiveStreamGeneratedSubtitlesRequest.md)|  | 

### Return type

[**LiveStreamResponse**](LiveStreamResponse.md)

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

<a name="updatelivestreamstaticrenditions"></a>
# **UpdateLiveStreamStaticRenditions**
> LiveStreamResponse UpdateLiveStreamStaticRenditions (string LIVE_STREAM_ID, UpdateLiveStreamNewAssetSettingsStaticRenditionsRequest updateLiveStreamNewAssetSettingsStaticRenditionsRequest)

Update live stream static renditions for new assets

Updates a live stream's static renditions settings for new assets. Further assets made via this live stream will create static renditions per the settings provided. You must provide all static renditions desired.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class UpdateLiveStreamStaticRenditionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LiveStreamsApi(config);
            var LIVE_STREAM_ID = "LIVE_STREAM_ID_example";  // string | The live stream ID
            var updateLiveStreamNewAssetSettingsStaticRenditionsRequest = new UpdateLiveStreamNewAssetSettingsStaticRenditionsRequest(); // UpdateLiveStreamNewAssetSettingsStaticRenditionsRequest | 

            try
            {
                // Update live stream static renditions for new assets
                LiveStreamResponse result = apiInstance.UpdateLiveStreamStaticRenditions(LIVE_STREAM_ID, updateLiveStreamNewAssetSettingsStaticRenditionsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.UpdateLiveStreamStaticRenditions: " + e.Message );
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
 **LIVE_STREAM_ID** | **string**| The live stream ID | 
 **updateLiveStreamNewAssetSettingsStaticRenditionsRequest** | [**UpdateLiveStreamNewAssetSettingsStaticRenditionsRequest**](UpdateLiveStreamNewAssetSettingsStaticRenditionsRequest.md)|  | 

### Return type

[**LiveStreamResponse**](LiveStreamResponse.md)

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

