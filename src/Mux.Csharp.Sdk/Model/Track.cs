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
    /// Track
    /// </summary>
    [DataContract(Name = "Track")]
    public partial class Track : IEquatable<Track>, IValidatableObject
    {
        /// <summary>
        /// The type of track
        /// </summary>
        /// <value>The type of track</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Video for value: video
            /// </summary>
            [EnumMember(Value = "video")]
            Video = 1,

            /// <summary>
            /// Enum Audio for value: audio
            /// </summary>
            [EnumMember(Value = "audio")]
            Audio = 2,

            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 3

        }


        /// <summary>
        /// The type of track
        /// </summary>
        /// <value>The type of track</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// This parameter is only set for &#x60;text&#x60; type tracks.
        /// </summary>
        /// <value>This parameter is only set for &#x60;text&#x60; type tracks.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextTypeEnum
        {
            /// <summary>
            /// Enum Subtitles for value: subtitles
            /// </summary>
            [EnumMember(Value = "subtitles")]
            Subtitles = 1

        }


        /// <summary>
        /// This parameter is only set for &#x60;text&#x60; type tracks.
        /// </summary>
        /// <value>This parameter is only set for &#x60;text&#x60; type tracks.</value>
        [DataMember(Name = "text_type", EmitDefaultValue = false)]
        public TextTypeEnum? TextType { get; set; }
        /// <summary>
        /// The source of the text contained in a Track of type &#x60;text&#x60;. Valid &#x60;text_source&#x60; values are listed below. * &#x60;uploaded&#x60;: Tracks uploaded to Mux as caption or subtitle files using the Create Asset Track API. * &#x60;embedded&#x60;: Tracks extracted from an embedded stream of CEA-608 closed captions. * &#x60;generated_live&#x60;: Tracks generated by automatic speech recognition on a live stream configured with &#x60;generated_subtitles&#x60;. If an Asset has both &#x60;generated_live&#x60; and &#x60;generated_live_final&#x60; tracks that are &#x60;ready&#x60;, then only the &#x60;generated_live_final&#x60; track will be included during playback. * &#x60;generated_live_final&#x60;: Tracks generated by automatic speech recognition on a live stream using &#x60;generated_subtitles&#x60;. The accuracy, timing, and formatting of these subtitles is improved compared to the corresponding &#x60;generated_live&#x60; tracks. However, &#x60;generated_live_final&#x60; tracks will not be available in &#x60;ready&#x60; status until the live stream ends. If an Asset has both &#x60;generated_live&#x60; and &#x60;generated_live_final&#x60; tracks that are &#x60;ready&#x60;, then only the &#x60;generated_live_final&#x60; track will be included during playback. 
        /// </summary>
        /// <value>The source of the text contained in a Track of type &#x60;text&#x60;. Valid &#x60;text_source&#x60; values are listed below. * &#x60;uploaded&#x60;: Tracks uploaded to Mux as caption or subtitle files using the Create Asset Track API. * &#x60;embedded&#x60;: Tracks extracted from an embedded stream of CEA-608 closed captions. * &#x60;generated_live&#x60;: Tracks generated by automatic speech recognition on a live stream configured with &#x60;generated_subtitles&#x60;. If an Asset has both &#x60;generated_live&#x60; and &#x60;generated_live_final&#x60; tracks that are &#x60;ready&#x60;, then only the &#x60;generated_live_final&#x60; track will be included during playback. * &#x60;generated_live_final&#x60;: Tracks generated by automatic speech recognition on a live stream using &#x60;generated_subtitles&#x60;. The accuracy, timing, and formatting of these subtitles is improved compared to the corresponding &#x60;generated_live&#x60; tracks. However, &#x60;generated_live_final&#x60; tracks will not be available in &#x60;ready&#x60; status until the live stream ends. If an Asset has both &#x60;generated_live&#x60; and &#x60;generated_live_final&#x60; tracks that are &#x60;ready&#x60;, then only the &#x60;generated_live_final&#x60; track will be included during playback. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextSourceEnum
        {
            /// <summary>
            /// Enum Uploaded for value: uploaded
            /// </summary>
            [EnumMember(Value = "uploaded")]
            Uploaded = 1,

            /// <summary>
            /// Enum Embedded for value: embedded
            /// </summary>
            [EnumMember(Value = "embedded")]
            Embedded = 2,

            /// <summary>
            /// Enum GeneratedLive for value: generated_live
            /// </summary>
            [EnumMember(Value = "generated_live")]
            GeneratedLive = 3,

            /// <summary>
            /// Enum GeneratedLiveFinal for value: generated_live_final
            /// </summary>
            [EnumMember(Value = "generated_live_final")]
            GeneratedLiveFinal = 4

        }


        /// <summary>
        /// The source of the text contained in a Track of type &#x60;text&#x60;. Valid &#x60;text_source&#x60; values are listed below. * &#x60;uploaded&#x60;: Tracks uploaded to Mux as caption or subtitle files using the Create Asset Track API. * &#x60;embedded&#x60;: Tracks extracted from an embedded stream of CEA-608 closed captions. * &#x60;generated_live&#x60;: Tracks generated by automatic speech recognition on a live stream configured with &#x60;generated_subtitles&#x60;. If an Asset has both &#x60;generated_live&#x60; and &#x60;generated_live_final&#x60; tracks that are &#x60;ready&#x60;, then only the &#x60;generated_live_final&#x60; track will be included during playback. * &#x60;generated_live_final&#x60;: Tracks generated by automatic speech recognition on a live stream using &#x60;generated_subtitles&#x60;. The accuracy, timing, and formatting of these subtitles is improved compared to the corresponding &#x60;generated_live&#x60; tracks. However, &#x60;generated_live_final&#x60; tracks will not be available in &#x60;ready&#x60; status until the live stream ends. If an Asset has both &#x60;generated_live&#x60; and &#x60;generated_live_final&#x60; tracks that are &#x60;ready&#x60;, then only the &#x60;generated_live_final&#x60; track will be included during playback. 
        /// </summary>
        /// <value>The source of the text contained in a Track of type &#x60;text&#x60;. Valid &#x60;text_source&#x60; values are listed below. * &#x60;uploaded&#x60;: Tracks uploaded to Mux as caption or subtitle files using the Create Asset Track API. * &#x60;embedded&#x60;: Tracks extracted from an embedded stream of CEA-608 closed captions. * &#x60;generated_live&#x60;: Tracks generated by automatic speech recognition on a live stream configured with &#x60;generated_subtitles&#x60;. If an Asset has both &#x60;generated_live&#x60; and &#x60;generated_live_final&#x60; tracks that are &#x60;ready&#x60;, then only the &#x60;generated_live_final&#x60; track will be included during playback. * &#x60;generated_live_final&#x60;: Tracks generated by automatic speech recognition on a live stream using &#x60;generated_subtitles&#x60;. The accuracy, timing, and formatting of these subtitles is improved compared to the corresponding &#x60;generated_live&#x60; tracks. However, &#x60;generated_live_final&#x60; tracks will not be available in &#x60;ready&#x60; status until the live stream ends. If an Asset has both &#x60;generated_live&#x60; and &#x60;generated_live_final&#x60; tracks that are &#x60;ready&#x60;, then only the &#x60;generated_live_final&#x60; track will be included during playback. </value>
        [DataMember(Name = "text_source", EmitDefaultValue = false)]
        public TextSourceEnum? TextSource { get; set; }
        /// <summary>
        /// The status of the track. This parameter is only set for &#x60;text&#x60; type tracks.
        /// </summary>
        /// <value>The status of the track. This parameter is only set for &#x60;text&#x60; type tracks.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Preparing for value: preparing
            /// </summary>
            [EnumMember(Value = "preparing")]
            Preparing = 1,

            /// <summary>
            /// Enum Ready for value: ready
            /// </summary>
            [EnumMember(Value = "ready")]
            Ready = 2,

            /// <summary>
            /// Enum Errored for value: errored
            /// </summary>
            [EnumMember(Value = "errored")]
            Errored = 3,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 4

        }


        /// <summary>
        /// The status of the track. This parameter is only set for &#x60;text&#x60; type tracks.
        /// </summary>
        /// <value>The status of the track. This parameter is only set for &#x60;text&#x60; type tracks.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Track" /> class.
        /// </summary>
        /// <param name="id">Unique identifier for the Track.</param>
        /// <param name="type">The type of track.</param>
        /// <param name="duration">The duration in seconds of the track media. This parameter is not set for &#x60;text&#x60; type tracks. This field is optional and may not be set. The top level &#x60;duration&#x60; field of an asset will always be set..</param>
        /// <param name="maxWidth">The maximum width in pixels available for the track. Only set for the &#x60;video&#x60; type track..</param>
        /// <param name="maxHeight">The maximum height in pixels available for the track. Only set for the &#x60;video&#x60; type track..</param>
        /// <param name="maxFrameRate">The maximum frame rate available for the track. Only set for the &#x60;video&#x60; type track. This field may return &#x60;-1&#x60; if the frame rate of the input cannot be reliably determined..</param>
        /// <param name="maxChannels">The maximum number of audio channels the track supports. Only set for the &#x60;audio&#x60; type track..</param>
        /// <param name="maxChannelLayout">Only set for the &#x60;audio&#x60; type track..</param>
        /// <param name="textType">This parameter is only set for &#x60;text&#x60; type tracks..</param>
        /// <param name="textSource">The source of the text contained in a Track of type &#x60;text&#x60;. Valid &#x60;text_source&#x60; values are listed below. * &#x60;uploaded&#x60;: Tracks uploaded to Mux as caption or subtitle files using the Create Asset Track API. * &#x60;embedded&#x60;: Tracks extracted from an embedded stream of CEA-608 closed captions. * &#x60;generated_live&#x60;: Tracks generated by automatic speech recognition on a live stream configured with &#x60;generated_subtitles&#x60;. If an Asset has both &#x60;generated_live&#x60; and &#x60;generated_live_final&#x60; tracks that are &#x60;ready&#x60;, then only the &#x60;generated_live_final&#x60; track will be included during playback. * &#x60;generated_live_final&#x60;: Tracks generated by automatic speech recognition on a live stream using &#x60;generated_subtitles&#x60;. The accuracy, timing, and formatting of these subtitles is improved compared to the corresponding &#x60;generated_live&#x60; tracks. However, &#x60;generated_live_final&#x60; tracks will not be available in &#x60;ready&#x60; status until the live stream ends. If an Asset has both &#x60;generated_live&#x60; and &#x60;generated_live_final&#x60; tracks that are &#x60;ready&#x60;, then only the &#x60;generated_live_final&#x60; track will be included during playback. .</param>
        /// <param name="languageCode">The language code value represents [BCP 47](https://tools.ietf.org/html/bcp47) specification compliant value. For example, &#x60;en&#x60; for English or &#x60;en-US&#x60; for the US version of English. This parameter is only set for &#x60;text&#x60; type and &#x60;subtitles&#x60; text type tracks..</param>
        /// <param name="name">The name of the track containing a human-readable description. The hls manifest will associate a subtitle text track with this value. For example, the value is \&quot;English\&quot; for subtitles text track for the &#x60;language_code&#x60; value of &#x60;en-US&#x60;. This parameter is only set for &#x60;text&#x60; type and &#x60;subtitles&#x60; text type tracks..</param>
        /// <param name="closedCaptions">Indicates the track provides Subtitles for the Deaf or Hard-of-hearing (SDH). This parameter is only set for &#x60;text&#x60; type and &#x60;subtitles&#x60; text type tracks..</param>
        /// <param name="passthrough">Arbitrary user-supplied metadata set for the track either when creating the asset or track. This parameter is only set for &#x60;text&#x60; type tracks. Max 255 characters..</param>
        /// <param name="status">The status of the track. This parameter is only set for &#x60;text&#x60; type tracks..</param>
        public Track(string id = default(string), TypeEnum? type = default(TypeEnum?), double duration = default(double), long maxWidth = default(long), long maxHeight = default(long), double maxFrameRate = default(double), long maxChannels = default(long), string maxChannelLayout = default(string), TextTypeEnum? textType = default(TextTypeEnum?), TextSourceEnum? textSource = default(TextSourceEnum?), string languageCode = default(string), string name = default(string), bool closedCaptions = default(bool), string passthrough = default(string), StatusEnum? status = default(StatusEnum?))
        {
            this.Id = id;
            this.Type = type;
            this.Duration = duration;
            this.MaxWidth = maxWidth;
            this.MaxHeight = maxHeight;
            this.MaxFrameRate = maxFrameRate;
            this.MaxChannels = maxChannels;
            this.MaxChannelLayout = maxChannelLayout;
            this.TextType = textType;
            this.TextSource = textSource;
            this.LanguageCode = languageCode;
            this.Name = name;
            this.ClosedCaptions = closedCaptions;
            this.Passthrough = passthrough;
            this.Status = status;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Unique identifier for the Track
        /// </summary>
        /// <value>Unique identifier for the Track</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The duration in seconds of the track media. This parameter is not set for &#x60;text&#x60; type tracks. This field is optional and may not be set. The top level &#x60;duration&#x60; field of an asset will always be set.
        /// </summary>
        /// <value>The duration in seconds of the track media. This parameter is not set for &#x60;text&#x60; type tracks. This field is optional and may not be set. The top level &#x60;duration&#x60; field of an asset will always be set.</value>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public double Duration { get; set; }

        /// <summary>
        /// The maximum width in pixels available for the track. Only set for the &#x60;video&#x60; type track.
        /// </summary>
        /// <value>The maximum width in pixels available for the track. Only set for the &#x60;video&#x60; type track.</value>
        [DataMember(Name = "max_width", EmitDefaultValue = false)]
        public long MaxWidth { get; set; }

        /// <summary>
        /// The maximum height in pixels available for the track. Only set for the &#x60;video&#x60; type track.
        /// </summary>
        /// <value>The maximum height in pixels available for the track. Only set for the &#x60;video&#x60; type track.</value>
        [DataMember(Name = "max_height", EmitDefaultValue = false)]
        public long MaxHeight { get; set; }

        /// <summary>
        /// The maximum frame rate available for the track. Only set for the &#x60;video&#x60; type track. This field may return &#x60;-1&#x60; if the frame rate of the input cannot be reliably determined.
        /// </summary>
        /// <value>The maximum frame rate available for the track. Only set for the &#x60;video&#x60; type track. This field may return &#x60;-1&#x60; if the frame rate of the input cannot be reliably determined.</value>
        [DataMember(Name = "max_frame_rate", EmitDefaultValue = false)]
        public double MaxFrameRate { get; set; }

        /// <summary>
        /// The maximum number of audio channels the track supports. Only set for the &#x60;audio&#x60; type track.
        /// </summary>
        /// <value>The maximum number of audio channels the track supports. Only set for the &#x60;audio&#x60; type track.</value>
        [DataMember(Name = "max_channels", EmitDefaultValue = false)]
        public long MaxChannels { get; set; }

        /// <summary>
        /// Only set for the &#x60;audio&#x60; type track.
        /// </summary>
        /// <value>Only set for the &#x60;audio&#x60; type track.</value>
        [DataMember(Name = "max_channel_layout", EmitDefaultValue = false)]
        public string MaxChannelLayout { get; set; }

        /// <summary>
        /// The language code value represents [BCP 47](https://tools.ietf.org/html/bcp47) specification compliant value. For example, &#x60;en&#x60; for English or &#x60;en-US&#x60; for the US version of English. This parameter is only set for &#x60;text&#x60; type and &#x60;subtitles&#x60; text type tracks.
        /// </summary>
        /// <value>The language code value represents [BCP 47](https://tools.ietf.org/html/bcp47) specification compliant value. For example, &#x60;en&#x60; for English or &#x60;en-US&#x60; for the US version of English. This parameter is only set for &#x60;text&#x60; type and &#x60;subtitles&#x60; text type tracks.</value>
        [DataMember(Name = "language_code", EmitDefaultValue = false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// The name of the track containing a human-readable description. The hls manifest will associate a subtitle text track with this value. For example, the value is \&quot;English\&quot; for subtitles text track for the &#x60;language_code&#x60; value of &#x60;en-US&#x60;. This parameter is only set for &#x60;text&#x60; type and &#x60;subtitles&#x60; text type tracks.
        /// </summary>
        /// <value>The name of the track containing a human-readable description. The hls manifest will associate a subtitle text track with this value. For example, the value is \&quot;English\&quot; for subtitles text track for the &#x60;language_code&#x60; value of &#x60;en-US&#x60;. This parameter is only set for &#x60;text&#x60; type and &#x60;subtitles&#x60; text type tracks.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates the track provides Subtitles for the Deaf or Hard-of-hearing (SDH). This parameter is only set for &#x60;text&#x60; type and &#x60;subtitles&#x60; text type tracks.
        /// </summary>
        /// <value>Indicates the track provides Subtitles for the Deaf or Hard-of-hearing (SDH). This parameter is only set for &#x60;text&#x60; type and &#x60;subtitles&#x60; text type tracks.</value>
        [DataMember(Name = "closed_captions", EmitDefaultValue = true)]
        public bool ClosedCaptions { get; set; }

        /// <summary>
        /// Arbitrary user-supplied metadata set for the track either when creating the asset or track. This parameter is only set for &#x60;text&#x60; type tracks. Max 255 characters.
        /// </summary>
        /// <value>Arbitrary user-supplied metadata set for the track either when creating the asset or track. This parameter is only set for &#x60;text&#x60; type tracks. Max 255 characters.</value>
        [DataMember(Name = "passthrough", EmitDefaultValue = false)]
        public string Passthrough { get; set; }

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
            sb.Append("class Track {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  MaxWidth: ").Append(MaxWidth).Append("\n");
            sb.Append("  MaxHeight: ").Append(MaxHeight).Append("\n");
            sb.Append("  MaxFrameRate: ").Append(MaxFrameRate).Append("\n");
            sb.Append("  MaxChannels: ").Append(MaxChannels).Append("\n");
            sb.Append("  MaxChannelLayout: ").Append(MaxChannelLayout).Append("\n");
            sb.Append("  TextType: ").Append(TextType).Append("\n");
            sb.Append("  TextSource: ").Append(TextSource).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ClosedCaptions: ").Append(ClosedCaptions).Append("\n");
            sb.Append("  Passthrough: ").Append(Passthrough).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as Track);
        }

        /// <summary>
        /// Returns true if Track instances are equal
        /// </summary>
        /// <param name="input">Instance of Track to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Track input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.MaxWidth == input.MaxWidth ||
                    this.MaxWidth.Equals(input.MaxWidth)
                ) && 
                (
                    this.MaxHeight == input.MaxHeight ||
                    this.MaxHeight.Equals(input.MaxHeight)
                ) && 
                (
                    this.MaxFrameRate == input.MaxFrameRate ||
                    this.MaxFrameRate.Equals(input.MaxFrameRate)
                ) && 
                (
                    this.MaxChannels == input.MaxChannels ||
                    this.MaxChannels.Equals(input.MaxChannels)
                ) && 
                (
                    this.MaxChannelLayout == input.MaxChannelLayout ||
                    (this.MaxChannelLayout != null &&
                    this.MaxChannelLayout.Equals(input.MaxChannelLayout))
                ) && 
                (
                    this.TextType == input.TextType ||
                    this.TextType.Equals(input.TextType)
                ) && 
                (
                    this.TextSource == input.TextSource ||
                    this.TextSource.Equals(input.TextSource)
                ) && 
                (
                    this.LanguageCode == input.LanguageCode ||
                    (this.LanguageCode != null &&
                    this.LanguageCode.Equals(input.LanguageCode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ClosedCaptions == input.ClosedCaptions ||
                    this.ClosedCaptions.Equals(input.ClosedCaptions)
                ) && 
                (
                    this.Passthrough == input.Passthrough ||
                    (this.Passthrough != null &&
                    this.Passthrough.Equals(input.Passthrough))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxWidth.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxHeight.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxFrameRate.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxChannels.GetHashCode();
                if (this.MaxChannelLayout != null)
                {
                    hashCode = (hashCode * 59) + this.MaxChannelLayout.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TextType.GetHashCode();
                hashCode = (hashCode * 59) + this.TextSource.GetHashCode();
                if (this.LanguageCode != null)
                {
                    hashCode = (hashCode * 59) + this.LanguageCode.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ClosedCaptions.GetHashCode();
                if (this.Passthrough != null)
                {
                    hashCode = (hashCode * 59) + this.Passthrough.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
            yield break;
        }
    }

}
