/*
 * Mux API
 *
 * Mux is how developers build online video. This API encompasses both Mux Video and Mux Data functionality to help you build your video-related projects better and faster than ever before.
 *
 * The version of the OpenAPI document: v1
 * Contact: devex@mux.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Mux.Csharp.Sdk.Client.OpenAPIDateConverter;

namespace Mux.Csharp.Sdk.Model
{
    /// <summary>
    /// CreateLiveStreamRequest
    /// </summary>
    [DataContract(Name = "CreateLiveStreamRequest")]
    public partial class CreateLiveStreamRequest : IEquatable<CreateLiveStreamRequest>, IValidatableObject
    {
        /// <summary>
        /// Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Set this as an alternative to setting low latency or reduced latency flags.
        /// </summary>
        /// <value>Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Set this as an alternative to setting low latency or reduced latency flags.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LatencyModeEnum
        {
            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 1,

            /// <summary>
            /// Enum Reduced for value: reduced
            /// </summary>
            [EnumMember(Value = "reduced")]
            Reduced = 2,

            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 3

        }


        /// <summary>
        /// Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Set this as an alternative to setting low latency or reduced latency flags.
        /// </summary>
        /// <value>Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Set this as an alternative to setting low latency or reduced latency flags.</value>
        [DataMember(Name = "latency_mode", EmitDefaultValue = false)]
        public LatencyModeEnum? LatencyMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLiveStreamRequest" /> class.
        /// </summary>
        /// <param name="playbackPolicy">Deprecated. Use &#x60;playback_policies&#x60; instead, which accepts an identical type..</param>
        /// <param name="playbackPolicies">An array of playback policy names that you want applied to this live stream and available through &#x60;playback_ids&#x60;. Options include:  * &#x60;\&quot;public\&quot;&#x60; (anyone with the playback URL can stream the live stream). * &#x60;\&quot;signed\&quot;&#x60; (an additional access token is required to play the live stream).  If no &#x60;playback_policies&#x60; is set, the live stream will have no playback IDs and will therefore not be playable. For simplicity, a single string name can be used in place of the array in the case of only one playback policy. .</param>
        /// <param name="advancedPlaybackPolicies">An array of playback policy objects that you want applied on this live stream and available through &#x60;playback_ids&#x60;. &#x60;advanced_playback_policies&#x60; must be used instead of &#x60;playback_policies&#x60; when creating a DRM playback ID. .</param>
        /// <param name="newAssetSettings">newAssetSettings.</param>
        /// <param name="reconnectWindow">When live streaming software disconnects from Mux, either intentionally or due to a drop in the network, the Reconnect Window is the time in seconds that Mux should wait for the streaming software to reconnect before considering the live stream finished and completing the recorded asset. Defaults to 60 seconds on the API if not specified.  If not specified directly, Standard Latency streams have a Reconnect Window of 60 seconds; Reduced and Low Latency streams have a default of 0 seconds, or no Reconnect Window. For that reason, we suggest specifying a value other than zero for Reduced and Low Latency streams.  Reduced and Low Latency streams with a Reconnect Window greater than zero will insert slate media into the recorded asset while waiting for the streaming software to reconnect or when there are brief interruptions in the live stream media. When using a Reconnect Window setting higher than 60 seconds with a Standard Latency stream, we highly recommend enabling slate with the &#x60;use_slate_for_standard_latency&#x60; option.  (default to 60F).</param>
        /// <param name="useSlateForStandardLatency">By default, Standard Latency live streams do not have slate media inserted while waiting for live streaming software to reconnect to Mux. Setting this to true enables slate insertion on a Standard Latency stream. (default to false).</param>
        /// <param name="reconnectSlateUrl">The URL of the image file that Mux should download and use as slate media during interruptions of the live stream media. This file will be downloaded each time a new recorded asset is created from the live stream. If this is not set, the default slate media will be used..</param>
        /// <param name="passthrough">passthrough.</param>
        /// <param name="audioOnly">Force the live stream to only process the audio track when the value is set to true. Mux drops the video track if broadcasted..</param>
        /// <param name="embeddedSubtitles">Describe the embedded closed caption contents of the incoming live stream..</param>
        /// <param name="generatedSubtitles">Configure the incoming live stream to include subtitles created with automatic speech recognition. Each Asset created from a live stream with &#x60;generated_subtitles&#x60; configured will automatically receive two text tracks. The first of these will have a &#x60;text_source&#x60; value of &#x60;generated_live&#x60;, and will be available with &#x60;ready&#x60; status as soon as the stream is live. The second text track will have a &#x60;text_source&#x60; value of &#x60;generated_live_final&#x60; and will contain subtitles with improved accuracy, timing, and formatting. However, &#x60;generated_live_final&#x60; tracks will not be available in &#x60;ready&#x60; status until the live stream ends. If an Asset has both &#x60;generated_live&#x60; and &#x60;generated_live_final&#x60; tracks that are &#x60;ready&#x60;, then only the &#x60;generated_live_final&#x60; track will be included during playback..</param>
        /// <param name="reducedLatency">This field is deprecated. Please use &#x60;latency_mode&#x60; instead. Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Set this if you want lower latency for your live stream. Read more here: https://mux.com/blog/reduced-latency-for-mux-live-streaming-now-available/.</param>
        /// <param name="lowLatency">This field is deprecated. Please use &#x60;latency_mode&#x60; instead. Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Setting this option will enable compatibility with the LL-HLS specification for low-latency streaming. This typically has lower latency than Reduced Latency streams, and cannot be combined with Reduced Latency..</param>
        /// <param name="latencyMode">Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Set this as an alternative to setting low latency or reduced latency flags..</param>
        /// <param name="test">Marks the live stream as a test live stream when the value is set to true. A test live stream can help evaluate the Mux Video APIs without incurring any cost. There is no limit on number of test live streams created. Test live streams are watermarked with the Mux logo and limited to 5 minutes. The test live stream is disabled after the stream is active for 5 mins and the recorded asset also deleted after 24 hours..</param>
        /// <param name="simulcastTargets">simulcastTargets.</param>
        /// <param name="maxContinuousDuration">The time in seconds a live stream may be continuously active before being disconnected. Defaults to 12 hours. (default to 43200).</param>
        public CreateLiveStreamRequest(List<PlaybackPolicy> playbackPolicy = default(List<PlaybackPolicy>), List<PlaybackPolicy> playbackPolicies = default(List<PlaybackPolicy>), List<CreatePlaybackIDRequest> advancedPlaybackPolicies = default(List<CreatePlaybackIDRequest>), CreateAssetRequest newAssetSettings = default(CreateAssetRequest), float reconnectWindow = 60F, bool useSlateForStandardLatency = false, string reconnectSlateUrl = default(string), string passthrough = default(string), bool audioOnly = default(bool), List<LiveStreamEmbeddedSubtitleSettings> embeddedSubtitles = default(List<LiveStreamEmbeddedSubtitleSettings>), List<LiveStreamGeneratedSubtitleSettings> generatedSubtitles = default(List<LiveStreamGeneratedSubtitleSettings>), bool reducedLatency = default(bool), bool lowLatency = default(bool), LatencyModeEnum? latencyMode = default(LatencyModeEnum?), bool test = default(bool), List<CreateSimulcastTargetRequest> simulcastTargets = default(List<CreateSimulcastTargetRequest>), int maxContinuousDuration = 43200)
        {
            this.PlaybackPolicy = playbackPolicy;
            this.PlaybackPolicies = playbackPolicies;
            this.AdvancedPlaybackPolicies = advancedPlaybackPolicies;
            this.NewAssetSettings = newAssetSettings;
            this.ReconnectWindow = reconnectWindow;
            this.UseSlateForStandardLatency = useSlateForStandardLatency;
            this.ReconnectSlateUrl = reconnectSlateUrl;
            this.Passthrough = passthrough;
            this.AudioOnly = audioOnly;
            this.EmbeddedSubtitles = embeddedSubtitles;
            this.GeneratedSubtitles = generatedSubtitles;
            this.ReducedLatency = reducedLatency;
            this.LowLatency = lowLatency;
            this.LatencyMode = latencyMode;
            this.Test = test;
            this.SimulcastTargets = simulcastTargets;
            this.MaxContinuousDuration = maxContinuousDuration;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Deprecated. Use &#x60;playback_policies&#x60; instead, which accepts an identical type.
        /// </summary>
        /// <value>Deprecated. Use &#x60;playback_policies&#x60; instead, which accepts an identical type.</value>
        [DataMember(Name = "playback_policy", EmitDefaultValue = false)]
        [Obsolete]
        public List<PlaybackPolicy> PlaybackPolicy { get; set; }

        /// <summary>
        /// An array of playback policy names that you want applied to this live stream and available through &#x60;playback_ids&#x60;. Options include:  * &#x60;\&quot;public\&quot;&#x60; (anyone with the playback URL can stream the live stream). * &#x60;\&quot;signed\&quot;&#x60; (an additional access token is required to play the live stream).  If no &#x60;playback_policies&#x60; is set, the live stream will have no playback IDs and will therefore not be playable. For simplicity, a single string name can be used in place of the array in the case of only one playback policy. 
        /// </summary>
        /// <value>An array of playback policy names that you want applied to this live stream and available through &#x60;playback_ids&#x60;. Options include:  * &#x60;\&quot;public\&quot;&#x60; (anyone with the playback URL can stream the live stream). * &#x60;\&quot;signed\&quot;&#x60; (an additional access token is required to play the live stream).  If no &#x60;playback_policies&#x60; is set, the live stream will have no playback IDs and will therefore not be playable. For simplicity, a single string name can be used in place of the array in the case of only one playback policy. </value>
        [DataMember(Name = "playback_policies", EmitDefaultValue = false)]
        [Obsolete]
        public List<PlaybackPolicy> PlaybackPolicies { get; set; }

        /// <summary>
        /// An array of playback policy objects that you want applied on this live stream and available through &#x60;playback_ids&#x60;. &#x60;advanced_playback_policies&#x60; must be used instead of &#x60;playback_policies&#x60; when creating a DRM playback ID. 
        /// </summary>
        /// <value>An array of playback policy objects that you want applied on this live stream and available through &#x60;playback_ids&#x60;. &#x60;advanced_playback_policies&#x60; must be used instead of &#x60;playback_policies&#x60; when creating a DRM playback ID. </value>
        [DataMember(Name = "advanced_playback_policies", EmitDefaultValue = false)]
        public List<CreatePlaybackIDRequest> AdvancedPlaybackPolicies { get; set; }

        /// <summary>
        /// Gets or Sets NewAssetSettings
        /// </summary>
        [DataMember(Name = "new_asset_settings", EmitDefaultValue = false)]
        public CreateAssetRequest NewAssetSettings { get; set; }

        /// <summary>
        /// When live streaming software disconnects from Mux, either intentionally or due to a drop in the network, the Reconnect Window is the time in seconds that Mux should wait for the streaming software to reconnect before considering the live stream finished and completing the recorded asset. Defaults to 60 seconds on the API if not specified.  If not specified directly, Standard Latency streams have a Reconnect Window of 60 seconds; Reduced and Low Latency streams have a default of 0 seconds, or no Reconnect Window. For that reason, we suggest specifying a value other than zero for Reduced and Low Latency streams.  Reduced and Low Latency streams with a Reconnect Window greater than zero will insert slate media into the recorded asset while waiting for the streaming software to reconnect or when there are brief interruptions in the live stream media. When using a Reconnect Window setting higher than 60 seconds with a Standard Latency stream, we highly recommend enabling slate with the &#x60;use_slate_for_standard_latency&#x60; option. 
        /// </summary>
        /// <value>When live streaming software disconnects from Mux, either intentionally or due to a drop in the network, the Reconnect Window is the time in seconds that Mux should wait for the streaming software to reconnect before considering the live stream finished and completing the recorded asset. Defaults to 60 seconds on the API if not specified.  If not specified directly, Standard Latency streams have a Reconnect Window of 60 seconds; Reduced and Low Latency streams have a default of 0 seconds, or no Reconnect Window. For that reason, we suggest specifying a value other than zero for Reduced and Low Latency streams.  Reduced and Low Latency streams with a Reconnect Window greater than zero will insert slate media into the recorded asset while waiting for the streaming software to reconnect or when there are brief interruptions in the live stream media. When using a Reconnect Window setting higher than 60 seconds with a Standard Latency stream, we highly recommend enabling slate with the &#x60;use_slate_for_standard_latency&#x60; option. </value>
        [DataMember(Name = "reconnect_window", EmitDefaultValue = false)]
        public float ReconnectWindow { get; set; }

        /// <summary>
        /// By default, Standard Latency live streams do not have slate media inserted while waiting for live streaming software to reconnect to Mux. Setting this to true enables slate insertion on a Standard Latency stream.
        /// </summary>
        /// <value>By default, Standard Latency live streams do not have slate media inserted while waiting for live streaming software to reconnect to Mux. Setting this to true enables slate insertion on a Standard Latency stream.</value>
        [DataMember(Name = "use_slate_for_standard_latency", EmitDefaultValue = true)]
        public bool UseSlateForStandardLatency { get; set; }

        /// <summary>
        /// The URL of the image file that Mux should download and use as slate media during interruptions of the live stream media. This file will be downloaded each time a new recorded asset is created from the live stream. If this is not set, the default slate media will be used.
        /// </summary>
        /// <value>The URL of the image file that Mux should download and use as slate media during interruptions of the live stream media. This file will be downloaded each time a new recorded asset is created from the live stream. If this is not set, the default slate media will be used.</value>
        [DataMember(Name = "reconnect_slate_url", EmitDefaultValue = false)]
        public string ReconnectSlateUrl { get; set; }

        /// <summary>
        /// Gets or Sets Passthrough
        /// </summary>
        [DataMember(Name = "passthrough", EmitDefaultValue = false)]
        public string Passthrough { get; set; }

        /// <summary>
        /// Force the live stream to only process the audio track when the value is set to true. Mux drops the video track if broadcasted.
        /// </summary>
        /// <value>Force the live stream to only process the audio track when the value is set to true. Mux drops the video track if broadcasted.</value>
        [DataMember(Name = "audio_only", EmitDefaultValue = true)]
        public bool AudioOnly { get; set; }

        /// <summary>
        /// Describe the embedded closed caption contents of the incoming live stream.
        /// </summary>
        /// <value>Describe the embedded closed caption contents of the incoming live stream.</value>
        [DataMember(Name = "embedded_subtitles", EmitDefaultValue = false)]
        public List<LiveStreamEmbeddedSubtitleSettings> EmbeddedSubtitles { get; set; }

        /// <summary>
        /// Configure the incoming live stream to include subtitles created with automatic speech recognition. Each Asset created from a live stream with &#x60;generated_subtitles&#x60; configured will automatically receive two text tracks. The first of these will have a &#x60;text_source&#x60; value of &#x60;generated_live&#x60;, and will be available with &#x60;ready&#x60; status as soon as the stream is live. The second text track will have a &#x60;text_source&#x60; value of &#x60;generated_live_final&#x60; and will contain subtitles with improved accuracy, timing, and formatting. However, &#x60;generated_live_final&#x60; tracks will not be available in &#x60;ready&#x60; status until the live stream ends. If an Asset has both &#x60;generated_live&#x60; and &#x60;generated_live_final&#x60; tracks that are &#x60;ready&#x60;, then only the &#x60;generated_live_final&#x60; track will be included during playback.
        /// </summary>
        /// <value>Configure the incoming live stream to include subtitles created with automatic speech recognition. Each Asset created from a live stream with &#x60;generated_subtitles&#x60; configured will automatically receive two text tracks. The first of these will have a &#x60;text_source&#x60; value of &#x60;generated_live&#x60;, and will be available with &#x60;ready&#x60; status as soon as the stream is live. The second text track will have a &#x60;text_source&#x60; value of &#x60;generated_live_final&#x60; and will contain subtitles with improved accuracy, timing, and formatting. However, &#x60;generated_live_final&#x60; tracks will not be available in &#x60;ready&#x60; status until the live stream ends. If an Asset has both &#x60;generated_live&#x60; and &#x60;generated_live_final&#x60; tracks that are &#x60;ready&#x60;, then only the &#x60;generated_live_final&#x60; track will be included during playback.</value>
        [DataMember(Name = "generated_subtitles", EmitDefaultValue = false)]
        public List<LiveStreamGeneratedSubtitleSettings> GeneratedSubtitles { get; set; }

        /// <summary>
        /// This field is deprecated. Please use &#x60;latency_mode&#x60; instead. Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Set this if you want lower latency for your live stream. Read more here: https://mux.com/blog/reduced-latency-for-mux-live-streaming-now-available/
        /// </summary>
        /// <value>This field is deprecated. Please use &#x60;latency_mode&#x60; instead. Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Set this if you want lower latency for your live stream. Read more here: https://mux.com/blog/reduced-latency-for-mux-live-streaming-now-available/</value>
        [DataMember(Name = "reduced_latency", EmitDefaultValue = true)]
        [Obsolete]
        public bool ReducedLatency { get; set; }

        /// <summary>
        /// This field is deprecated. Please use &#x60;latency_mode&#x60; instead. Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Setting this option will enable compatibility with the LL-HLS specification for low-latency streaming. This typically has lower latency than Reduced Latency streams, and cannot be combined with Reduced Latency.
        /// </summary>
        /// <value>This field is deprecated. Please use &#x60;latency_mode&#x60; instead. Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Setting this option will enable compatibility with the LL-HLS specification for low-latency streaming. This typically has lower latency than Reduced Latency streams, and cannot be combined with Reduced Latency.</value>
        [DataMember(Name = "low_latency", EmitDefaultValue = true)]
        [Obsolete]
        public bool LowLatency { get; set; }

        /// <summary>
        /// Marks the live stream as a test live stream when the value is set to true. A test live stream can help evaluate the Mux Video APIs without incurring any cost. There is no limit on number of test live streams created. Test live streams are watermarked with the Mux logo and limited to 5 minutes. The test live stream is disabled after the stream is active for 5 mins and the recorded asset also deleted after 24 hours.
        /// </summary>
        /// <value>Marks the live stream as a test live stream when the value is set to true. A test live stream can help evaluate the Mux Video APIs without incurring any cost. There is no limit on number of test live streams created. Test live streams are watermarked with the Mux logo and limited to 5 minutes. The test live stream is disabled after the stream is active for 5 mins and the recorded asset also deleted after 24 hours.</value>
        [DataMember(Name = "test", EmitDefaultValue = true)]
        public bool Test { get; set; }

        /// <summary>
        /// Gets or Sets SimulcastTargets
        /// </summary>
        [DataMember(Name = "simulcast_targets", EmitDefaultValue = false)]
        public List<CreateSimulcastTargetRequest> SimulcastTargets { get; set; }

        /// <summary>
        /// The time in seconds a live stream may be continuously active before being disconnected. Defaults to 12 hours.
        /// </summary>
        /// <value>The time in seconds a live stream may be continuously active before being disconnected. Defaults to 12 hours.</value>
        [DataMember(Name = "max_continuous_duration", EmitDefaultValue = false)]
        public int MaxContinuousDuration { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateLiveStreamRequest {\n");
            sb.Append("  PlaybackPolicy: ").Append(PlaybackPolicy).Append("\n");
            sb.Append("  PlaybackPolicies: ").Append(PlaybackPolicies).Append("\n");
            sb.Append("  AdvancedPlaybackPolicies: ").Append(AdvancedPlaybackPolicies).Append("\n");
            sb.Append("  NewAssetSettings: ").Append(NewAssetSettings).Append("\n");
            sb.Append("  ReconnectWindow: ").Append(ReconnectWindow).Append("\n");
            sb.Append("  UseSlateForStandardLatency: ").Append(UseSlateForStandardLatency).Append("\n");
            sb.Append("  ReconnectSlateUrl: ").Append(ReconnectSlateUrl).Append("\n");
            sb.Append("  Passthrough: ").Append(Passthrough).Append("\n");
            sb.Append("  AudioOnly: ").Append(AudioOnly).Append("\n");
            sb.Append("  EmbeddedSubtitles: ").Append(EmbeddedSubtitles).Append("\n");
            sb.Append("  GeneratedSubtitles: ").Append(GeneratedSubtitles).Append("\n");
            sb.Append("  ReducedLatency: ").Append(ReducedLatency).Append("\n");
            sb.Append("  LowLatency: ").Append(LowLatency).Append("\n");
            sb.Append("  LatencyMode: ").Append(LatencyMode).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
            sb.Append("  SimulcastTargets: ").Append(SimulcastTargets).Append("\n");
            sb.Append("  MaxContinuousDuration: ").Append(MaxContinuousDuration).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLiveStreamRequest);
        }

        /// <summary>
        /// Returns true if CreateLiveStreamRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateLiveStreamRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateLiveStreamRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PlaybackPolicy == input.PlaybackPolicy ||
                    this.PlaybackPolicy != null &&
                    input.PlaybackPolicy != null &&
                    this.PlaybackPolicy.SequenceEqual(input.PlaybackPolicy)
                ) && 
                (
                    this.PlaybackPolicies == input.PlaybackPolicies ||
                    this.PlaybackPolicies != null &&
                    input.PlaybackPolicies != null &&
                    this.PlaybackPolicies.SequenceEqual(input.PlaybackPolicies)
                ) && 
                (
                    this.AdvancedPlaybackPolicies == input.AdvancedPlaybackPolicies ||
                    this.AdvancedPlaybackPolicies != null &&
                    input.AdvancedPlaybackPolicies != null &&
                    this.AdvancedPlaybackPolicies.SequenceEqual(input.AdvancedPlaybackPolicies)
                ) && 
                (
                    this.NewAssetSettings == input.NewAssetSettings ||
                    (this.NewAssetSettings != null &&
                    this.NewAssetSettings.Equals(input.NewAssetSettings))
                ) && 
                (
                    this.ReconnectWindow == input.ReconnectWindow ||
                    this.ReconnectWindow.Equals(input.ReconnectWindow)
                ) && 
                (
                    this.UseSlateForStandardLatency == input.UseSlateForStandardLatency ||
                    this.UseSlateForStandardLatency.Equals(input.UseSlateForStandardLatency)
                ) && 
                (
                    this.ReconnectSlateUrl == input.ReconnectSlateUrl ||
                    (this.ReconnectSlateUrl != null &&
                    this.ReconnectSlateUrl.Equals(input.ReconnectSlateUrl))
                ) && 
                (
                    this.Passthrough == input.Passthrough ||
                    (this.Passthrough != null &&
                    this.Passthrough.Equals(input.Passthrough))
                ) && 
                (
                    this.AudioOnly == input.AudioOnly ||
                    this.AudioOnly.Equals(input.AudioOnly)
                ) && 
                (
                    this.EmbeddedSubtitles == input.EmbeddedSubtitles ||
                    this.EmbeddedSubtitles != null &&
                    input.EmbeddedSubtitles != null &&
                    this.EmbeddedSubtitles.SequenceEqual(input.EmbeddedSubtitles)
                ) && 
                (
                    this.GeneratedSubtitles == input.GeneratedSubtitles ||
                    this.GeneratedSubtitles != null &&
                    input.GeneratedSubtitles != null &&
                    this.GeneratedSubtitles.SequenceEqual(input.GeneratedSubtitles)
                ) && 
                (
                    this.ReducedLatency == input.ReducedLatency ||
                    this.ReducedLatency.Equals(input.ReducedLatency)
                ) && 
                (
                    this.LowLatency == input.LowLatency ||
                    this.LowLatency.Equals(input.LowLatency)
                ) && 
                (
                    this.LatencyMode == input.LatencyMode ||
                    this.LatencyMode.Equals(input.LatencyMode)
                ) && 
                (
                    this.Test == input.Test ||
                    this.Test.Equals(input.Test)
                ) && 
                (
                    this.SimulcastTargets == input.SimulcastTargets ||
                    this.SimulcastTargets != null &&
                    input.SimulcastTargets != null &&
                    this.SimulcastTargets.SequenceEqual(input.SimulcastTargets)
                ) && 
                (
                    this.MaxContinuousDuration == input.MaxContinuousDuration ||
                    this.MaxContinuousDuration.Equals(input.MaxContinuousDuration)
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PlaybackPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.PlaybackPolicy.GetHashCode();
                }
                if (this.PlaybackPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.PlaybackPolicies.GetHashCode();
                }
                if (this.AdvancedPlaybackPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.AdvancedPlaybackPolicies.GetHashCode();
                }
                if (this.NewAssetSettings != null)
                {
                    hashCode = (hashCode * 59) + this.NewAssetSettings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReconnectWindow.GetHashCode();
                hashCode = (hashCode * 59) + this.UseSlateForStandardLatency.GetHashCode();
                if (this.ReconnectSlateUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ReconnectSlateUrl.GetHashCode();
                }
                if (this.Passthrough != null)
                {
                    hashCode = (hashCode * 59) + this.Passthrough.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AudioOnly.GetHashCode();
                if (this.EmbeddedSubtitles != null)
                {
                    hashCode = (hashCode * 59) + this.EmbeddedSubtitles.GetHashCode();
                }
                if (this.GeneratedSubtitles != null)
                {
                    hashCode = (hashCode * 59) + this.GeneratedSubtitles.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReducedLatency.GetHashCode();
                hashCode = (hashCode * 59) + this.LowLatency.GetHashCode();
                hashCode = (hashCode * 59) + this.LatencyMode.GetHashCode();
                hashCode = (hashCode * 59) + this.Test.GetHashCode();
                if (this.SimulcastTargets != null)
                {
                    hashCode = (hashCode * 59) + this.SimulcastTargets.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxContinuousDuration.GetHashCode();
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // ReconnectWindow (float) maximum
            if (this.ReconnectWindow > (float)1800)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReconnectWindow, must be a value less than or equal to 1800.", new [] { "ReconnectWindow" });
            }

            // ReconnectWindow (float) minimum
            if (this.ReconnectWindow < (float)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReconnectWindow, must be a value greater than or equal to 0.", new [] { "ReconnectWindow" });
            }

            // MaxContinuousDuration (int) maximum
            if (this.MaxContinuousDuration > (int)43200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxContinuousDuration, must be a value less than or equal to 43200.", new [] { "MaxContinuousDuration" });
            }

            // MaxContinuousDuration (int) minimum
            if (this.MaxContinuousDuration < (int)60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxContinuousDuration, must be a value greater than or equal to 60.", new [] { "MaxContinuousDuration" });
            }

            yield break;
        }
    }

}
