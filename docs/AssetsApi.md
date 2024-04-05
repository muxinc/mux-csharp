# Mux.Csharp.Sdk.Api.AssetsApi

All URIs are relative to *https://api.mux.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAsset**](AssetsApi.md#createasset) | **POST** /video/v1/assets | Create an asset
[**CreateAssetPlaybackId**](AssetsApi.md#createassetplaybackid) | **POST** /video/v1/assets/{ASSET_ID}/playback-ids | Create a playback ID
[**CreateAssetTrack**](AssetsApi.md#createassettrack) | **POST** /video/v1/assets/{ASSET_ID}/tracks | Create an asset track
[**DeleteAsset**](AssetsApi.md#deleteasset) | **DELETE** /video/v1/assets/{ASSET_ID} | Delete an asset
[**DeleteAssetPlaybackId**](AssetsApi.md#deleteassetplaybackid) | **DELETE** /video/v1/assets/{ASSET_ID}/playback-ids/{PLAYBACK_ID} | Delete a playback ID
[**DeleteAssetTrack**](AssetsApi.md#deleteassettrack) | **DELETE** /video/v1/assets/{ASSET_ID}/tracks/{TRACK_ID} | Delete an asset track
[**GenerateAssetTrackSubtitles**](AssetsApi.md#generateassettracksubtitles) | **POST** /video/v1/assets/{ASSET_ID}/tracks/{TRACK_ID}/generate-subtitles | Generate track subtitles
[**GetAsset**](AssetsApi.md#getasset) | **GET** /video/v1/assets/{ASSET_ID} | Retrieve an asset
[**GetAssetInputInfo**](AssetsApi.md#getassetinputinfo) | **GET** /video/v1/assets/{ASSET_ID}/input-info | Retrieve asset input info
[**GetAssetPlaybackId**](AssetsApi.md#getassetplaybackid) | **GET** /video/v1/assets/{ASSET_ID}/playback-ids/{PLAYBACK_ID} | Retrieve a playback ID
[**ListAssets**](AssetsApi.md#listassets) | **GET** /video/v1/assets | List assets
[**UpdateAsset**](AssetsApi.md#updateasset) | **PATCH** /video/v1/assets/{ASSET_ID} | Update an asset
[**UpdateAssetMasterAccess**](AssetsApi.md#updateassetmasteraccess) | **PUT** /video/v1/assets/{ASSET_ID}/master-access | Update master access
[**UpdateAssetMp4Support**](AssetsApi.md#updateassetmp4support) | **PUT** /video/v1/assets/{ASSET_ID}/mp4-support | Update MP4 support


<a name="createasset"></a>
# **CreateAsset**
> AssetResponse CreateAsset (CreateAssetRequest createAssetRequest)

Create an asset

Create a new Mux Video asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class CreateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var createAssetRequest = new CreateAssetRequest(); // CreateAssetRequest | 

            try
            {
                // Create an asset
                AssetResponse result = apiInstance.CreateAsset(createAssetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.CreateAsset: " + e.Message );
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
 **createAssetRequest** | [**CreateAssetRequest**](CreateAssetRequest.md)|  | 

### Return type

[**AssetResponse**](AssetResponse.md)

### Authorization

[accessToken](../README.md#accessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Asset Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createassetplaybackid"></a>
# **CreateAssetPlaybackId**
> CreatePlaybackIDResponse CreateAssetPlaybackId (string ASSET_ID, CreatePlaybackIDRequest createPlaybackIDRequest)

Create a playback ID

Creates a playback ID that can be used to stream the asset to a viewer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class CreateAssetPlaybackIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var ASSET_ID = "ASSET_ID_example";  // string | The asset ID.
            var createPlaybackIDRequest = new CreatePlaybackIDRequest(); // CreatePlaybackIDRequest | 

            try
            {
                // Create a playback ID
                CreatePlaybackIDResponse result = apiInstance.CreateAssetPlaybackId(ASSET_ID, createPlaybackIDRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.CreateAssetPlaybackId: " + e.Message );
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
 **ASSET_ID** | **string**| The asset ID. | 
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

<a name="createassettrack"></a>
# **CreateAssetTrack**
> CreateTrackResponse CreateAssetTrack (string ASSET_ID, CreateTrackRequest createTrackRequest)

Create an asset track

Adds an asset track (for example, subtitles, or an alternate audio track) to an asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class CreateAssetTrackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var ASSET_ID = "ASSET_ID_example";  // string | The asset ID.
            var createTrackRequest = new CreateTrackRequest(); // CreateTrackRequest | 

            try
            {
                // Create an asset track
                CreateTrackResponse result = apiInstance.CreateAssetTrack(ASSET_ID, createTrackRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.CreateAssetTrack: " + e.Message );
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
 **ASSET_ID** | **string**| The asset ID. | 
 **createTrackRequest** | [**CreateTrackRequest**](CreateTrackRequest.md)|  | 

### Return type

[**CreateTrackResponse**](CreateTrackResponse.md)

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

<a name="deleteasset"></a>
# **DeleteAsset**
> void DeleteAsset (string ASSET_ID)

Delete an asset

Deletes a video asset and all its data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class DeleteAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var ASSET_ID = "ASSET_ID_example";  // string | The asset ID.

            try
            {
                // Delete an asset
                apiInstance.DeleteAsset(ASSET_ID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.DeleteAsset: " + e.Message );
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
 **ASSET_ID** | **string**| The asset ID. | 

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

<a name="deleteassetplaybackid"></a>
# **DeleteAssetPlaybackId**
> void DeleteAssetPlaybackId (string ASSET_ID, string PLAYBACK_ID)

Delete a playback ID

Deletes a playback ID, rendering it nonfunctional for viewing an asset's video content. Please note that deleting the playback ID removes access to the underlying asset; a viewer who started playback before the playback ID was deleted may be able to watch the entire video for a limited duration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class DeleteAssetPlaybackIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var ASSET_ID = "ASSET_ID_example";  // string | The asset ID.
            var PLAYBACK_ID = "PLAYBACK_ID_example";  // string | The live stream's playback ID.

            try
            {
                // Delete a playback ID
                apiInstance.DeleteAssetPlaybackId(ASSET_ID, PLAYBACK_ID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.DeleteAssetPlaybackId: " + e.Message );
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
 **ASSET_ID** | **string**| The asset ID. | 
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

<a name="deleteassettrack"></a>
# **DeleteAssetTrack**
> void DeleteAssetTrack (string ASSET_ID, string TRACK_ID)

Delete an asset track

Removes a text track from an asset. Audio and video tracks on assets cannot be removed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class DeleteAssetTrackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var ASSET_ID = "ASSET_ID_example";  // string | The asset ID.
            var TRACK_ID = "TRACK_ID_example";  // string | The track ID.

            try
            {
                // Delete an asset track
                apiInstance.DeleteAssetTrack(ASSET_ID, TRACK_ID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.DeleteAssetTrack: " + e.Message );
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
 **ASSET_ID** | **string**| The asset ID. | 
 **TRACK_ID** | **string**| The track ID. | 

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

<a name="generateassettracksubtitles"></a>
# **GenerateAssetTrackSubtitles**
> GenerateTrackSubtitlesResponse GenerateAssetTrackSubtitles (string ASSET_ID, string TRACK_ID, GenerateTrackSubtitlesRequest generateTrackSubtitlesRequest)

Generate track subtitles

Generates subtitles (captions) for a given audio track. This API can be used for up to 7 days after an asset is created.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GenerateAssetTrackSubtitlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var ASSET_ID = "ASSET_ID_example";  // string | The asset ID.
            var TRACK_ID = "TRACK_ID_example";  // string | The track ID.
            var generateTrackSubtitlesRequest = new GenerateTrackSubtitlesRequest(); // GenerateTrackSubtitlesRequest | 

            try
            {
                // Generate track subtitles
                GenerateTrackSubtitlesResponse result = apiInstance.GenerateAssetTrackSubtitles(ASSET_ID, TRACK_ID, generateTrackSubtitlesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GenerateAssetTrackSubtitles: " + e.Message );
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
 **ASSET_ID** | **string**| The asset ID. | 
 **TRACK_ID** | **string**| The track ID. | 
 **generateTrackSubtitlesRequest** | [**GenerateTrackSubtitlesRequest**](GenerateTrackSubtitlesRequest.md)|  | 

### Return type

[**GenerateTrackSubtitlesResponse**](GenerateTrackSubtitlesResponse.md)

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

<a name="getasset"></a>
# **GetAsset**
> AssetResponse GetAsset (string ASSET_ID)

Retrieve an asset

Retrieves the details of an asset that has previously been created. Supply the unique asset ID that was returned from your previous request, and Mux will return the corresponding asset information. The same information is returned when creating an asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var ASSET_ID = "ASSET_ID_example";  // string | The asset ID.

            try
            {
                // Retrieve an asset
                AssetResponse result = apiInstance.GetAsset(ASSET_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GetAsset: " + e.Message );
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
 **ASSET_ID** | **string**| The asset ID. | 

### Return type

[**AssetResponse**](AssetResponse.md)

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

<a name="getassetinputinfo"></a>
# **GetAssetInputInfo**
> GetAssetInputInfoResponse GetAssetInputInfo (string ASSET_ID)

Retrieve asset input info

Returns a list of the input objects that were used to create the asset along with any settings that were applied to each input.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetAssetInputInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var ASSET_ID = "ASSET_ID_example";  // string | The asset ID.

            try
            {
                // Retrieve asset input info
                GetAssetInputInfoResponse result = apiInstance.GetAssetInputInfo(ASSET_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GetAssetInputInfo: " + e.Message );
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
 **ASSET_ID** | **string**| The asset ID. | 

### Return type

[**GetAssetInputInfoResponse**](GetAssetInputInfoResponse.md)

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

<a name="getassetplaybackid"></a>
# **GetAssetPlaybackId**
> GetAssetPlaybackIDResponse GetAssetPlaybackId (string ASSET_ID, string PLAYBACK_ID)

Retrieve a playback ID

Retrieves information about the specified playback ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class GetAssetPlaybackIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var ASSET_ID = "ASSET_ID_example";  // string | The asset ID.
            var PLAYBACK_ID = "PLAYBACK_ID_example";  // string | The live stream's playback ID.

            try
            {
                // Retrieve a playback ID
                GetAssetPlaybackIDResponse result = apiInstance.GetAssetPlaybackId(ASSET_ID, PLAYBACK_ID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GetAssetPlaybackId: " + e.Message );
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
 **ASSET_ID** | **string**| The asset ID. | 
 **PLAYBACK_ID** | **string**| The live stream&#39;s playback ID. | 

### Return type

[**GetAssetPlaybackIDResponse**](GetAssetPlaybackIDResponse.md)

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

<a name="listassets"></a>
# **ListAssets**
> ListAssetsResponse ListAssets (int? limit = null, int? page = null, string liveStreamId = null, string uploadId = null)

List assets

List all Mux assets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class ListAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var limit = 25;  // int? | Number of items to include in the response (optional)  (default to 25)
            var page = 1;  // int? | Offset by this many pages, of the size of `limit` (optional)  (default to 1)
            var liveStreamId = "liveStreamId_example";  // string | Filter response to return all the assets for this live stream only (optional) 
            var uploadId = "uploadId_example";  // string | Filter response to return an asset created from this direct upload only (optional) 

            try
            {
                // List assets
                ListAssetsResponse result = apiInstance.ListAssets(limit, page, liveStreamId, uploadId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.ListAssets: " + e.Message );
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
 **liveStreamId** | **string**| Filter response to return all the assets for this live stream only | [optional] 
 **uploadId** | **string**| Filter response to return an asset created from this direct upload only | [optional] 

### Return type

[**ListAssetsResponse**](ListAssetsResponse.md)

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

<a name="updateasset"></a>
# **UpdateAsset**
> AssetResponse UpdateAsset (string ASSET_ID, UpdateAssetRequest updateAssetRequest)

Update an asset

Updates the details of an already-created Asset with the provided Asset ID. This currently supports only the `passthrough` field.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class UpdateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var ASSET_ID = "ASSET_ID_example";  // string | The asset ID.
            var updateAssetRequest = new UpdateAssetRequest(); // UpdateAssetRequest | 

            try
            {
                // Update an asset
                AssetResponse result = apiInstance.UpdateAsset(ASSET_ID, updateAssetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.UpdateAsset: " + e.Message );
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
 **ASSET_ID** | **string**| The asset ID. | 
 **updateAssetRequest** | [**UpdateAssetRequest**](UpdateAssetRequest.md)|  | 

### Return type

[**AssetResponse**](AssetResponse.md)

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

<a name="updateassetmasteraccess"></a>
# **UpdateAssetMasterAccess**
> AssetResponse UpdateAssetMasterAccess (string ASSET_ID, UpdateAssetMasterAccessRequest updateAssetMasterAccessRequest)

Update master access

Allows you to add temporary access to the master (highest-quality) version of the asset in MP4 format. A URL will be created that can be used to download the master version for 24 hours. After 24 hours Master Access will revert to \"none\". This master version is not optimized for web and not meant to be streamed, only downloaded for purposes like archiving or editing the video offline.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class UpdateAssetMasterAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var ASSET_ID = "ASSET_ID_example";  // string | The asset ID.
            var updateAssetMasterAccessRequest = new UpdateAssetMasterAccessRequest(); // UpdateAssetMasterAccessRequest | 

            try
            {
                // Update master access
                AssetResponse result = apiInstance.UpdateAssetMasterAccess(ASSET_ID, updateAssetMasterAccessRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.UpdateAssetMasterAccess: " + e.Message );
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
 **ASSET_ID** | **string**| The asset ID. | 
 **updateAssetMasterAccessRequest** | [**UpdateAssetMasterAccessRequest**](UpdateAssetMasterAccessRequest.md)|  | 

### Return type

[**AssetResponse**](AssetResponse.md)

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

<a name="updateassetmp4support"></a>
# **UpdateAssetMp4Support**
> AssetResponse UpdateAssetMp4Support (string ASSET_ID, UpdateAssetMP4SupportRequest updateAssetMP4SupportRequest)

Update MP4 support

Allows you to add or remove mp4 support for assets that were created without it. The values supported are `capped-1080p`, `audio-only`, `audio-only,capped-1080p`, `standard`(deprecated),  and `none`. `none` means that an asset *does not* have mp4 support, so submitting a request with `mp4_support` set to `none` will delete the mp4 assets from the asset in question.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class UpdateAssetMp4SupportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mux.com";
            // Configure HTTP basic authorization: accessToken
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AssetsApi(config);
            var ASSET_ID = "ASSET_ID_example";  // string | The asset ID.
            var updateAssetMP4SupportRequest = new UpdateAssetMP4SupportRequest(); // UpdateAssetMP4SupportRequest | 

            try
            {
                // Update MP4 support
                AssetResponse result = apiInstance.UpdateAssetMp4Support(ASSET_ID, updateAssetMP4SupportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.UpdateAssetMp4Support: " + e.Message );
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
 **ASSET_ID** | **string**| The asset ID. | 
 **updateAssetMP4SupportRequest** | [**UpdateAssetMP4SupportRequest**](UpdateAssetMP4SupportRequest.md)|  | 

### Return type

[**AssetResponse**](AssetResponse.md)

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

