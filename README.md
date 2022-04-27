# `mux-csharp`

Mux is how developers build online video. This API encompasses both Mux Video and Mux Data functionality to help you build your video-related projects better and faster than ever before.

**PLEASE NOTE:** This is an _extremely_ early alpha build of the C# SDK. Documentation is currently best-effort, but it'll improve over time! Instead of contacting Mux Support, please file an issue on this repository or email [Mux DevEx](devex@mux.com) for assistance.

- API version: v1
- SDK version: 0.1.0-alpha.3
    [https://docs.mux.com](https://docs.mux.com)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.4 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.7.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.7.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Example
{
    public class Example
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AssetsApi.CreateAsset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.mux.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AssetsApi* | [**CreateAsset**](docs/AssetsApi.md#createasset) | **POST** /video/v1/assets | Create an asset
*AssetsApi* | [**CreateAssetPlaybackId**](docs/AssetsApi.md#createassetplaybackid) | **POST** /video/v1/assets/{ASSET_ID}/playback-ids | Create a playback ID
*AssetsApi* | [**CreateAssetTrack**](docs/AssetsApi.md#createassettrack) | **POST** /video/v1/assets/{ASSET_ID}/tracks | Create an asset track
*AssetsApi* | [**DeleteAsset**](docs/AssetsApi.md#deleteasset) | **DELETE** /video/v1/assets/{ASSET_ID} | Delete an asset
*AssetsApi* | [**DeleteAssetPlaybackId**](docs/AssetsApi.md#deleteassetplaybackid) | **DELETE** /video/v1/assets/{ASSET_ID}/playback-ids/{PLAYBACK_ID} | Delete a playback ID
*AssetsApi* | [**DeleteAssetTrack**](docs/AssetsApi.md#deleteassettrack) | **DELETE** /video/v1/assets/{ASSET_ID}/tracks/{TRACK_ID} | Delete an asset track
*AssetsApi* | [**GetAsset**](docs/AssetsApi.md#getasset) | **GET** /video/v1/assets/{ASSET_ID} | Retrieve an asset
*AssetsApi* | [**GetAssetInputInfo**](docs/AssetsApi.md#getassetinputinfo) | **GET** /video/v1/assets/{ASSET_ID}/input-info | Retrieve asset input info
*AssetsApi* | [**GetAssetPlaybackId**](docs/AssetsApi.md#getassetplaybackid) | **GET** /video/v1/assets/{ASSET_ID}/playback-ids/{PLAYBACK_ID} | Retrieve a playback ID
*AssetsApi* | [**ListAssets**](docs/AssetsApi.md#listassets) | **GET** /video/v1/assets | List assets
*AssetsApi* | [**UpdateAsset**](docs/AssetsApi.md#updateasset) | **PATCH** /video/v1/assets/{ASSET_ID} | Update an Asset
*AssetsApi* | [**UpdateAssetMasterAccess**](docs/AssetsApi.md#updateassetmasteraccess) | **PUT** /video/v1/assets/{ASSET_ID}/master-access | Update master access
*AssetsApi* | [**UpdateAssetMp4Support**](docs/AssetsApi.md#updateassetmp4support) | **PUT** /video/v1/assets/{ASSET_ID}/mp4-support | Update MP4 support
*DeliveryUsageApi* | [**ListDeliveryUsage**](docs/DeliveryUsageApi.md#listdeliveryusage) | **GET** /video/v1/delivery-usage | List Usage
*DimensionsApi* | [**ListDimensionValues**](docs/DimensionsApi.md#listdimensionvalues) | **GET** /data/v1/dimensions/{DIMENSION_ID} | Lists the values for a specific dimension
*DimensionsApi* | [**ListDimensions**](docs/DimensionsApi.md#listdimensions) | **GET** /data/v1/dimensions | List Dimensions
*DirectUploadsApi* | [**CancelDirectUpload**](docs/DirectUploadsApi.md#canceldirectupload) | **PUT** /video/v1/uploads/{UPLOAD_ID}/cancel | Cancel a direct upload
*DirectUploadsApi* | [**CreateDirectUpload**](docs/DirectUploadsApi.md#createdirectupload) | **POST** /video/v1/uploads | Create a new direct upload URL
*DirectUploadsApi* | [**GetDirectUpload**](docs/DirectUploadsApi.md#getdirectupload) | **GET** /video/v1/uploads/{UPLOAD_ID} | Retrieve a single direct upload's info
*DirectUploadsApi* | [**ListDirectUploads**](docs/DirectUploadsApi.md#listdirectuploads) | **GET** /video/v1/uploads | List direct uploads
*ErrorsApi* | [**ListErrors**](docs/ErrorsApi.md#listerrors) | **GET** /data/v1/errors | List Errors
*ExportsApi* | [**ListExports**](docs/ExportsApi.md#listexports) | **GET** /data/v1/exports | List property video view export links
*ExportsApi* | [**ListExportsViews**](docs/ExportsApi.md#listexportsviews) | **GET** /data/v1/exports/views | List available property view exports
*FiltersApi* | [**ListFilterValues**](docs/FiltersApi.md#listfiltervalues) | **GET** /data/v1/filters/{FILTER_ID} | Lists values for a specific filter
*FiltersApi* | [**ListFilters**](docs/FiltersApi.md#listfilters) | **GET** /data/v1/filters | List Filters
*IncidentsApi* | [**GetIncident**](docs/IncidentsApi.md#getincident) | **GET** /data/v1/incidents/{INCIDENT_ID} | Get an Incident
*IncidentsApi* | [**ListIncidents**](docs/IncidentsApi.md#listincidents) | **GET** /data/v1/incidents | List Incidents
*IncidentsApi* | [**ListRelatedIncidents**](docs/IncidentsApi.md#listrelatedincidents) | **GET** /data/v1/incidents/{INCIDENT_ID}/related | List Related Incidents
*LiveStreamsApi* | [**CreateLiveStream**](docs/LiveStreamsApi.md#createlivestream) | **POST** /video/v1/live-streams | Create a live stream
*LiveStreamsApi* | [**CreateLiveStreamPlaybackId**](docs/LiveStreamsApi.md#createlivestreamplaybackid) | **POST** /video/v1/live-streams/{LIVE_STREAM_ID}/playback-ids | Create a live stream playback ID
*LiveStreamsApi* | [**CreateLiveStreamSimulcastTarget**](docs/LiveStreamsApi.md#createlivestreamsimulcasttarget) | **POST** /video/v1/live-streams/{LIVE_STREAM_ID}/simulcast-targets | Create a live stream simulcast target
*LiveStreamsApi* | [**DeleteLiveStream**](docs/LiveStreamsApi.md#deletelivestream) | **DELETE** /video/v1/live-streams/{LIVE_STREAM_ID} | Delete a live stream
*LiveStreamsApi* | [**DeleteLiveStreamPlaybackId**](docs/LiveStreamsApi.md#deletelivestreamplaybackid) | **DELETE** /video/v1/live-streams/{LIVE_STREAM_ID}/playback-ids/{PLAYBACK_ID} | Delete a live stream playback ID
*LiveStreamsApi* | [**DeleteLiveStreamSimulcastTarget**](docs/LiveStreamsApi.md#deletelivestreamsimulcasttarget) | **DELETE** /video/v1/live-streams/{LIVE_STREAM_ID}/simulcast-targets/{SIMULCAST_TARGET_ID} | Delete a Live Stream Simulcast Target
*LiveStreamsApi* | [**DisableLiveStream**](docs/LiveStreamsApi.md#disablelivestream) | **PUT** /video/v1/live-streams/{LIVE_STREAM_ID}/disable | Disable a live stream
*LiveStreamsApi* | [**EnableLiveStream**](docs/LiveStreamsApi.md#enablelivestream) | **PUT** /video/v1/live-streams/{LIVE_STREAM_ID}/enable | Enable a live stream
*LiveStreamsApi* | [**GetLiveStream**](docs/LiveStreamsApi.md#getlivestream) | **GET** /video/v1/live-streams/{LIVE_STREAM_ID} | Retrieve a live stream
*LiveStreamsApi* | [**GetLiveStreamPlaybackId**](docs/LiveStreamsApi.md#getlivestreamplaybackid) | **GET** /video/v1/live-streams/{LIVE_STREAM_ID}/playback-ids/{PLAYBACK_ID} | Retrieve a live stream playback ID
*LiveStreamsApi* | [**GetLiveStreamSimulcastTarget**](docs/LiveStreamsApi.md#getlivestreamsimulcasttarget) | **GET** /video/v1/live-streams/{LIVE_STREAM_ID}/simulcast-targets/{SIMULCAST_TARGET_ID} | Retrieve a Live Stream Simulcast Target
*LiveStreamsApi* | [**ListLiveStreams**](docs/LiveStreamsApi.md#listlivestreams) | **GET** /video/v1/live-streams | List live streams
*LiveStreamsApi* | [**ResetStreamKey**](docs/LiveStreamsApi.md#resetstreamkey) | **POST** /video/v1/live-streams/{LIVE_STREAM_ID}/reset-stream-key | Reset a live stream's stream key
*LiveStreamsApi* | [**SignalLiveStreamComplete**](docs/LiveStreamsApi.md#signallivestreamcomplete) | **PUT** /video/v1/live-streams/{LIVE_STREAM_ID}/complete | Signal a live stream is finished
*LiveStreamsApi* | [**UpdateLiveStream**](docs/LiveStreamsApi.md#updatelivestream) | **PATCH** /video/v1/live-streams/{LIVE_STREAM_ID} | Update a live stream
*LiveStreamsApi* | [**UpdateLiveStreamEmbeddedSubtitles**](docs/LiveStreamsApi.md#updatelivestreamembeddedsubtitles) | **PUT** /video/v1/live-streams/{LIVE_STREAM_ID}/embedded-subtitles | Update a live stream's embedded subtitles
*MetricsApi* | [**GetMetricTimeseriesData**](docs/MetricsApi.md#getmetrictimeseriesdata) | **GET** /data/v1/metrics/{METRIC_ID}/timeseries | Get metric timeseries data
*MetricsApi* | [**GetOverallValues**](docs/MetricsApi.md#getoverallvalues) | **GET** /data/v1/metrics/{METRIC_ID}/overall | Get Overall values
*MetricsApi* | [**ListAllMetricValues**](docs/MetricsApi.md#listallmetricvalues) | **GET** /data/v1/metrics/comparison | List all metric values
*MetricsApi* | [**ListBreakdownValues**](docs/MetricsApi.md#listbreakdownvalues) | **GET** /data/v1/metrics/{METRIC_ID}/breakdown | List breakdown values
*MetricsApi* | [**ListInsights**](docs/MetricsApi.md#listinsights) | **GET** /data/v1/metrics/{METRIC_ID}/insights | List Insights
*PlaybackIDApi* | [**GetAssetOrLivestreamId**](docs/PlaybackIDApi.md#getassetorlivestreamid) | **GET** /video/v1/playback-ids/{PLAYBACK_ID} | Retrieve an Asset or Live Stream ID
*PlaybackRestrictionsApi* | [**CreatePlaybackRestriction**](docs/PlaybackRestrictionsApi.md#createplaybackrestriction) | **POST** /video/v1/playback-restrictions | Create a Playback Restriction
*PlaybackRestrictionsApi* | [**DeletePlaybackRestriction**](docs/PlaybackRestrictionsApi.md#deleteplaybackrestriction) | **DELETE** /video/v1/playback-restrictions/{PLAYBACK_RESTRICTION_ID} | Delete a Playback Restriction
*PlaybackRestrictionsApi* | [**GetPlaybackRestriction**](docs/PlaybackRestrictionsApi.md#getplaybackrestriction) | **GET** /video/v1/playback-restrictions/{PLAYBACK_RESTRICTION_ID} | Retrieve a Playback Restriction
*PlaybackRestrictionsApi* | [**ListPlaybackRestrictions**](docs/PlaybackRestrictionsApi.md#listplaybackrestrictions) | **GET** /video/v1/playback-restrictions | List Playback Restrictions
*PlaybackRestrictionsApi* | [**UpdateReferrerDomainRestriction**](docs/PlaybackRestrictionsApi.md#updatereferrerdomainrestriction) | **PUT** /video/v1/playback-restrictions/{PLAYBACK_RESTRICTION_ID}/referrer | Update the Referrer Playback Restriction
*RealTimeApi* | [**GetRealtimeBreakdown**](docs/RealTimeApi.md#getrealtimebreakdown) | **GET** /data/v1/realtime/metrics/{REALTIME_METRIC_ID}/breakdown | Get Real-Time Breakdown
*RealTimeApi* | [**GetRealtimeHistogramTimeseries**](docs/RealTimeApi.md#getrealtimehistogramtimeseries) | **GET** /data/v1/realtime/metrics/{REALTIME_HISTOGRAM_METRIC_ID}/histogram-timeseries | Get Real-Time Histogram Timeseries
*RealTimeApi* | [**GetRealtimeTimeseries**](docs/RealTimeApi.md#getrealtimetimeseries) | **GET** /data/v1/realtime/metrics/{REALTIME_METRIC_ID}/timeseries | Get Real-Time Timeseries
*RealTimeApi* | [**ListRealtimeDimensions**](docs/RealTimeApi.md#listrealtimedimensions) | **GET** /data/v1/realtime/dimensions | List Real-Time Dimensions
*RealTimeApi* | [**ListRealtimeMetrics**](docs/RealTimeApi.md#listrealtimemetrics) | **GET** /data/v1/realtime/metrics | List Real-Time Metrics
*URLSigningKeysApi* | [**CreateUrlSigningKey**](docs/URLSigningKeysApi.md#createurlsigningkey) | **POST** /video/v1/signing-keys | Create a URL signing key
*URLSigningKeysApi* | [**DeleteUrlSigningKey**](docs/URLSigningKeysApi.md#deleteurlsigningkey) | **DELETE** /video/v1/signing-keys/{SIGNING_KEY_ID} | Delete a URL signing key
*URLSigningKeysApi* | [**GetUrlSigningKey**](docs/URLSigningKeysApi.md#geturlsigningkey) | **GET** /video/v1/signing-keys/{SIGNING_KEY_ID} | Retrieve a URL signing key
*URLSigningKeysApi* | [**ListUrlSigningKeys**](docs/URLSigningKeysApi.md#listurlsigningkeys) | **GET** /video/v1/signing-keys | List URL signing keys
*VideoViewsApi* | [**GetVideoView**](docs/VideoViewsApi.md#getvideoview) | **GET** /data/v1/video-views/{VIDEO_VIEW_ID} | Get a Video View
*VideoViewsApi* | [**ListVideoViews**](docs/VideoViewsApi.md#listvideoviews) | **GET** /data/v1/video-views | List Video Views


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AbridgedVideoView](docs/AbridgedVideoView.md)
 - [Model.Asset](docs/Asset.md)
 - [Model.AssetErrors](docs/AssetErrors.md)
 - [Model.AssetMaster](docs/AssetMaster.md)
 - [Model.AssetNonStandardInputReasons](docs/AssetNonStandardInputReasons.md)
 - [Model.AssetRecordingTimes](docs/AssetRecordingTimes.md)
 - [Model.AssetResponse](docs/AssetResponse.md)
 - [Model.AssetStaticRenditions](docs/AssetStaticRenditions.md)
 - [Model.AssetStaticRenditionsFiles](docs/AssetStaticRenditionsFiles.md)
 - [Model.BreakdownValue](docs/BreakdownValue.md)
 - [Model.CreateAssetRequest](docs/CreateAssetRequest.md)
 - [Model.CreateLiveStreamRequest](docs/CreateLiveStreamRequest.md)
 - [Model.CreatePlaybackIDRequest](docs/CreatePlaybackIDRequest.md)
 - [Model.CreatePlaybackIDResponse](docs/CreatePlaybackIDResponse.md)
 - [Model.CreatePlaybackRestrictionRequest](docs/CreatePlaybackRestrictionRequest.md)
 - [Model.CreateSimulcastTargetRequest](docs/CreateSimulcastTargetRequest.md)
 - [Model.CreateTrackRequest](docs/CreateTrackRequest.md)
 - [Model.CreateTrackResponse](docs/CreateTrackResponse.md)
 - [Model.CreateUploadRequest](docs/CreateUploadRequest.md)
 - [Model.DeliveryReport](docs/DeliveryReport.md)
 - [Model.DimensionValue](docs/DimensionValue.md)
 - [Model.DisableLiveStreamResponse](docs/DisableLiveStreamResponse.md)
 - [Model.EnableLiveStreamResponse](docs/EnableLiveStreamResponse.md)
 - [Model.Error](docs/Error.md)
 - [Model.ExportDate](docs/ExportDate.md)
 - [Model.ExportFile](docs/ExportFile.md)
 - [Model.FilterValue](docs/FilterValue.md)
 - [Model.GetAssetInputInfoResponse](docs/GetAssetInputInfoResponse.md)
 - [Model.GetAssetOrLiveStreamIdResponse](docs/GetAssetOrLiveStreamIdResponse.md)
 - [Model.GetAssetOrLiveStreamIdResponseData](docs/GetAssetOrLiveStreamIdResponseData.md)
 - [Model.GetAssetOrLiveStreamIdResponseDataObject](docs/GetAssetOrLiveStreamIdResponseDataObject.md)
 - [Model.GetAssetPlaybackIDResponse](docs/GetAssetPlaybackIDResponse.md)
 - [Model.GetLiveStreamPlaybackIDResponse](docs/GetLiveStreamPlaybackIDResponse.md)
 - [Model.GetMetricTimeseriesDataResponse](docs/GetMetricTimeseriesDataResponse.md)
 - [Model.GetOverallValuesResponse](docs/GetOverallValuesResponse.md)
 - [Model.GetRealTimeBreakdownResponse](docs/GetRealTimeBreakdownResponse.md)
 - [Model.GetRealTimeHistogramTimeseriesResponse](docs/GetRealTimeHistogramTimeseriesResponse.md)
 - [Model.GetRealTimeHistogramTimeseriesResponseMeta](docs/GetRealTimeHistogramTimeseriesResponseMeta.md)
 - [Model.GetRealTimeTimeseriesResponse](docs/GetRealTimeTimeseriesResponse.md)
 - [Model.Incident](docs/Incident.md)
 - [Model.IncidentBreakdown](docs/IncidentBreakdown.md)
 - [Model.IncidentNotification](docs/IncidentNotification.md)
 - [Model.IncidentNotificationRule](docs/IncidentNotificationRule.md)
 - [Model.IncidentResponse](docs/IncidentResponse.md)
 - [Model.InputFile](docs/InputFile.md)
 - [Model.InputInfo](docs/InputInfo.md)
 - [Model.InputSettings](docs/InputSettings.md)
 - [Model.InputSettingsOverlaySettings](docs/InputSettingsOverlaySettings.md)
 - [Model.InputTrack](docs/InputTrack.md)
 - [Model.Insight](docs/Insight.md)
 - [Model.ListAllMetricValuesResponse](docs/ListAllMetricValuesResponse.md)
 - [Model.ListAssetsResponse](docs/ListAssetsResponse.md)
 - [Model.ListBreakdownValuesResponse](docs/ListBreakdownValuesResponse.md)
 - [Model.ListDeliveryUsageResponse](docs/ListDeliveryUsageResponse.md)
 - [Model.ListDimensionValuesResponse](docs/ListDimensionValuesResponse.md)
 - [Model.ListDimensionsResponse](docs/ListDimensionsResponse.md)
 - [Model.ListErrorsResponse](docs/ListErrorsResponse.md)
 - [Model.ListExportsResponse](docs/ListExportsResponse.md)
 - [Model.ListFilterValuesResponse](docs/ListFilterValuesResponse.md)
 - [Model.ListFiltersResponse](docs/ListFiltersResponse.md)
 - [Model.ListFiltersResponseData](docs/ListFiltersResponseData.md)
 - [Model.ListIncidentsResponse](docs/ListIncidentsResponse.md)
 - [Model.ListInsightsResponse](docs/ListInsightsResponse.md)
 - [Model.ListLiveStreamsResponse](docs/ListLiveStreamsResponse.md)
 - [Model.ListPlaybackRestrictionsResponse](docs/ListPlaybackRestrictionsResponse.md)
 - [Model.ListRealTimeDimensionsResponse](docs/ListRealTimeDimensionsResponse.md)
 - [Model.ListRealTimeDimensionsResponseData](docs/ListRealTimeDimensionsResponseData.md)
 - [Model.ListRealTimeMetricsResponse](docs/ListRealTimeMetricsResponse.md)
 - [Model.ListRelatedIncidentsResponse](docs/ListRelatedIncidentsResponse.md)
 - [Model.ListSigningKeysResponse](docs/ListSigningKeysResponse.md)
 - [Model.ListUploadsResponse](docs/ListUploadsResponse.md)
 - [Model.ListVideoViewExportsResponse](docs/ListVideoViewExportsResponse.md)
 - [Model.ListVideoViewsResponse](docs/ListVideoViewsResponse.md)
 - [Model.LiveStream](docs/LiveStream.md)
 - [Model.LiveStreamEmbeddedSubtitleSettings](docs/LiveStreamEmbeddedSubtitleSettings.md)
 - [Model.LiveStreamResponse](docs/LiveStreamResponse.md)
 - [Model.LiveStreamStatus](docs/LiveStreamStatus.md)
 - [Model.Metric](docs/Metric.md)
 - [Model.NotificationRule](docs/NotificationRule.md)
 - [Model.OverallValues](docs/OverallValues.md)
 - [Model.PlaybackID](docs/PlaybackID.md)
 - [Model.PlaybackPolicy](docs/PlaybackPolicy.md)
 - [Model.PlaybackRestriction](docs/PlaybackRestriction.md)
 - [Model.PlaybackRestrictionResponse](docs/PlaybackRestrictionResponse.md)
 - [Model.RealTimeBreakdownValue](docs/RealTimeBreakdownValue.md)
 - [Model.RealTimeHistogramTimeseriesBucket](docs/RealTimeHistogramTimeseriesBucket.md)
 - [Model.RealTimeHistogramTimeseriesBucketValues](docs/RealTimeHistogramTimeseriesBucketValues.md)
 - [Model.RealTimeHistogramTimeseriesDatapoint](docs/RealTimeHistogramTimeseriesDatapoint.md)
 - [Model.RealTimeTimeseriesDatapoint](docs/RealTimeTimeseriesDatapoint.md)
 - [Model.ReferrerDomainRestriction](docs/ReferrerDomainRestriction.md)
 - [Model.Score](docs/Score.md)
 - [Model.SignalLiveStreamCompleteResponse](docs/SignalLiveStreamCompleteResponse.md)
 - [Model.SigningKey](docs/SigningKey.md)
 - [Model.SigningKeyResponse](docs/SigningKeyResponse.md)
 - [Model.SimulcastTarget](docs/SimulcastTarget.md)
 - [Model.SimulcastTargetResponse](docs/SimulcastTargetResponse.md)
 - [Model.Track](docs/Track.md)
 - [Model.UpdateAssetMP4SupportRequest](docs/UpdateAssetMP4SupportRequest.md)
 - [Model.UpdateAssetMasterAccessRequest](docs/UpdateAssetMasterAccessRequest.md)
 - [Model.UpdateAssetRequest](docs/UpdateAssetRequest.md)
 - [Model.UpdateLiveStreamEmbeddedSubtitlesRequest](docs/UpdateLiveStreamEmbeddedSubtitlesRequest.md)
 - [Model.UpdateLiveStreamRequest](docs/UpdateLiveStreamRequest.md)
 - [Model.UpdateReferrerDomainRestrictionRequest](docs/UpdateReferrerDomainRestrictionRequest.md)
 - [Model.Upload](docs/Upload.md)
 - [Model.UploadError](docs/UploadError.md)
 - [Model.UploadResponse](docs/UploadResponse.md)
 - [Model.VideoView](docs/VideoView.md)
 - [Model.VideoViewEvent](docs/VideoViewEvent.md)
 - [Model.VideoViewResponse](docs/VideoViewResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="accessToken"></a>
### accessToken

- **Type**: HTTP basic authentication

