# Mux.Csharp.Sdk.Model.DeliveryReportDeliveredSecondsByResolution
Seconds delivered broken into resolution tiers. Each tier will only be displayed if there was content delivered in the tier.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tier1080p** | **double** | Total number of delivered seconds during this time window that had a resolution larger than the 720p tier (over 921,600 pixels total). | [optional] 
**Tier720p** | **double** | Total number of delivered seconds during this time window that had a resolution within the 720p tier (up to 921,600 pixels total, based on typical 1280x720). | [optional] 
**TierAudioOnly** | **double** | Total number of delivered seconds during this time window that had a resolution of audio only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

