# Mux.Csharp.Sdk.Model.UserAgentRestrictionRequest
Rules that control what user agents are allowed to play your videos. Please see [Using User-Agent HTTP header for validation](https://docs.mux.com/guides/secure-video-playback#using-user-agent-http-header-for-validation) for more details on this feature.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowNoUserAgent** | **bool** | Whether or not to allow views without a &#x60;User-Agent&#x60; HTTP request header. | [optional] [default to true]
**AllowHighRiskUserAgent** | **bool** | Whether or not to allow high risk user agents. The high risk user agents are defined by Mux. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

