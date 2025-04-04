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
    /// Updates the new asset settings to use to generate a new asset for this live stream. Only the &#x60;mp4_support&#x60;, &#x60;master_access&#x60;, and &#x60;video_quality&#x60; settings may be updated. 
    /// </summary>
    [DataContract(Name = "UpdateLiveStreamNewAssetSettings")]
    public partial class UpdateLiveStreamNewAssetSettings : IEquatable<UpdateLiveStreamNewAssetSettings>, IValidatableObject
    {
        /// <summary>
        /// Deprecated. See the [Static Renditions API](https://www.mux.com/docs/guides/enable-static-mp4-renditions#during-live-stream-creation) for the updated API. Specify what level of support for mp4 playback should be added to new assets generated from this live stream. * The &#x60;none&#x60; option disables MP4 support for new assets. MP4 files will not be produced for an asset generated from this live stream. * The &#x60;capped-1080p&#x60; option produces a single MP4 file, called &#x60;capped-1080p.mp4&#x60;, with the video resolution capped at 1080p. This option produces an &#x60;audio.m4a&#x60; file for an audio-only asset. * The &#x60;audio-only&#x60; option produces a single M4A file, called &#x60;audio.m4a&#x60; for a video or an audio-only asset. MP4 generation will error when this option is specified for a video-only asset. * The &#x60;audio-only,capped-1080p&#x60; option produces both the &#x60;audio.m4a&#x60; and &#x60;capped-1080p.mp4&#x60; files. Only the &#x60;capped-1080p.mp4&#x60; file is produced for a video-only asset, while only the &#x60;audio.m4a&#x60; file is produced for an audio-only asset. * The &#x60;standard&#x60;(deprecated) option produces up to three MP4 files with different levels of resolution (&#x60;high.mp4&#x60;, &#x60;medium.mp4&#x60;, &#x60;low.mp4&#x60;, or &#x60;audio.m4a&#x60; for an audio-only asset). 
        /// </summary>
        /// <value>Deprecated. See the [Static Renditions API](https://www.mux.com/docs/guides/enable-static-mp4-renditions#during-live-stream-creation) for the updated API. Specify what level of support for mp4 playback should be added to new assets generated from this live stream. * The &#x60;none&#x60; option disables MP4 support for new assets. MP4 files will not be produced for an asset generated from this live stream. * The &#x60;capped-1080p&#x60; option produces a single MP4 file, called &#x60;capped-1080p.mp4&#x60;, with the video resolution capped at 1080p. This option produces an &#x60;audio.m4a&#x60; file for an audio-only asset. * The &#x60;audio-only&#x60; option produces a single M4A file, called &#x60;audio.m4a&#x60; for a video or an audio-only asset. MP4 generation will error when this option is specified for a video-only asset. * The &#x60;audio-only,capped-1080p&#x60; option produces both the &#x60;audio.m4a&#x60; and &#x60;capped-1080p.mp4&#x60; files. Only the &#x60;capped-1080p.mp4&#x60; file is produced for a video-only asset, while only the &#x60;audio.m4a&#x60; file is produced for an audio-only asset. * The &#x60;standard&#x60;(deprecated) option produces up to three MP4 files with different levels of resolution (&#x60;high.mp4&#x60;, &#x60;medium.mp4&#x60;, &#x60;low.mp4&#x60;, or &#x60;audio.m4a&#x60; for an audio-only asset). </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Mp4SupportEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 2,

            /// <summary>
            /// Enum Capped1080p for value: capped-1080p
            /// </summary>
            [EnumMember(Value = "capped-1080p")]
            Capped1080p = 3,

            /// <summary>
            /// Enum AudioOnly for value: audio-only
            /// </summary>
            [EnumMember(Value = "audio-only")]
            AudioOnly = 4,

            /// <summary>
            /// Enum AudioOnlycapped1080p for value: audio-only,capped-1080p
            /// </summary>
            [EnumMember(Value = "audio-only,capped-1080p")]
            AudioOnlycapped1080p = 5

        }


        /// <summary>
        /// Deprecated. See the [Static Renditions API](https://www.mux.com/docs/guides/enable-static-mp4-renditions#during-live-stream-creation) for the updated API. Specify what level of support for mp4 playback should be added to new assets generated from this live stream. * The &#x60;none&#x60; option disables MP4 support for new assets. MP4 files will not be produced for an asset generated from this live stream. * The &#x60;capped-1080p&#x60; option produces a single MP4 file, called &#x60;capped-1080p.mp4&#x60;, with the video resolution capped at 1080p. This option produces an &#x60;audio.m4a&#x60; file for an audio-only asset. * The &#x60;audio-only&#x60; option produces a single M4A file, called &#x60;audio.m4a&#x60; for a video or an audio-only asset. MP4 generation will error when this option is specified for a video-only asset. * The &#x60;audio-only,capped-1080p&#x60; option produces both the &#x60;audio.m4a&#x60; and &#x60;capped-1080p.mp4&#x60; files. Only the &#x60;capped-1080p.mp4&#x60; file is produced for a video-only asset, while only the &#x60;audio.m4a&#x60; file is produced for an audio-only asset. * The &#x60;standard&#x60;(deprecated) option produces up to three MP4 files with different levels of resolution (&#x60;high.mp4&#x60;, &#x60;medium.mp4&#x60;, &#x60;low.mp4&#x60;, or &#x60;audio.m4a&#x60; for an audio-only asset). 
        /// </summary>
        /// <value>Deprecated. See the [Static Renditions API](https://www.mux.com/docs/guides/enable-static-mp4-renditions#during-live-stream-creation) for the updated API. Specify what level of support for mp4 playback should be added to new assets generated from this live stream. * The &#x60;none&#x60; option disables MP4 support for new assets. MP4 files will not be produced for an asset generated from this live stream. * The &#x60;capped-1080p&#x60; option produces a single MP4 file, called &#x60;capped-1080p.mp4&#x60;, with the video resolution capped at 1080p. This option produces an &#x60;audio.m4a&#x60; file for an audio-only asset. * The &#x60;audio-only&#x60; option produces a single M4A file, called &#x60;audio.m4a&#x60; for a video or an audio-only asset. MP4 generation will error when this option is specified for a video-only asset. * The &#x60;audio-only,capped-1080p&#x60; option produces both the &#x60;audio.m4a&#x60; and &#x60;capped-1080p.mp4&#x60; files. Only the &#x60;capped-1080p.mp4&#x60; file is produced for a video-only asset, while only the &#x60;audio.m4a&#x60; file is produced for an audio-only asset. * The &#x60;standard&#x60;(deprecated) option produces up to three MP4 files with different levels of resolution (&#x60;high.mp4&#x60;, &#x60;medium.mp4&#x60;, &#x60;low.mp4&#x60;, or &#x60;audio.m4a&#x60; for an audio-only asset). </value>
        [DataMember(Name = "mp4_support", EmitDefaultValue = false)]
        [Obsolete]
        public Mp4SupportEnum? Mp4Support { get; set; }
        /// <summary>
        /// Add or remove access to the master version of the video.
        /// </summary>
        /// <value>Add or remove access to the master version of the video.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MasterAccessEnum
        {
            /// <summary>
            /// Enum Temporary for value: temporary
            /// </summary>
            [EnumMember(Value = "temporary")]
            Temporary = 1,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 2

        }


        /// <summary>
        /// Add or remove access to the master version of the video.
        /// </summary>
        /// <value>Add or remove access to the master version of the video.</value>
        [DataMember(Name = "master_access", EmitDefaultValue = false)]
        public MasterAccessEnum? MasterAccess { get; set; }
        /// <summary>
        /// The video quality controls the cost, quality, and available platform features for the asset. [See the video quality guide for more details.](https://docs.mux.com/guides/use-video-quality-levels)
        /// </summary>
        /// <value>The video quality controls the cost, quality, and available platform features for the asset. [See the video quality guide for more details.](https://docs.mux.com/guides/use-video-quality-levels)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VideoQualityEnum
        {
            /// <summary>
            /// Enum Plus for value: plus
            /// </summary>
            [EnumMember(Value = "plus")]
            Plus = 1,

            /// <summary>
            /// Enum Premium for value: premium
            /// </summary>
            [EnumMember(Value = "premium")]
            Premium = 2

        }


        /// <summary>
        /// The video quality controls the cost, quality, and available platform features for the asset. [See the video quality guide for more details.](https://docs.mux.com/guides/use-video-quality-levels)
        /// </summary>
        /// <value>The video quality controls the cost, quality, and available platform features for the asset. [See the video quality guide for more details.](https://docs.mux.com/guides/use-video-quality-levels)</value>
        [DataMember(Name = "video_quality", EmitDefaultValue = false)]
        public VideoQualityEnum? VideoQuality { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLiveStreamNewAssetSettings" /> class.
        /// </summary>
        /// <param name="mp4Support">Deprecated. See the [Static Renditions API](https://www.mux.com/docs/guides/enable-static-mp4-renditions#during-live-stream-creation) for the updated API. Specify what level of support for mp4 playback should be added to new assets generated from this live stream. * The &#x60;none&#x60; option disables MP4 support for new assets. MP4 files will not be produced for an asset generated from this live stream. * The &#x60;capped-1080p&#x60; option produces a single MP4 file, called &#x60;capped-1080p.mp4&#x60;, with the video resolution capped at 1080p. This option produces an &#x60;audio.m4a&#x60; file for an audio-only asset. * The &#x60;audio-only&#x60; option produces a single M4A file, called &#x60;audio.m4a&#x60; for a video or an audio-only asset. MP4 generation will error when this option is specified for a video-only asset. * The &#x60;audio-only,capped-1080p&#x60; option produces both the &#x60;audio.m4a&#x60; and &#x60;capped-1080p.mp4&#x60; files. Only the &#x60;capped-1080p.mp4&#x60; file is produced for a video-only asset, while only the &#x60;audio.m4a&#x60; file is produced for an audio-only asset. * The &#x60;standard&#x60;(deprecated) option produces up to three MP4 files with different levels of resolution (&#x60;high.mp4&#x60;, &#x60;medium.mp4&#x60;, &#x60;low.mp4&#x60;, or &#x60;audio.m4a&#x60; for an audio-only asset). .</param>
        /// <param name="masterAccess">Add or remove access to the master version of the video..</param>
        /// <param name="videoQuality">The video quality controls the cost, quality, and available platform features for the asset. [See the video quality guide for more details.](https://docs.mux.com/guides/use-video-quality-levels).</param>
        /// <param name="meta">meta.</param>
        public UpdateLiveStreamNewAssetSettings(Mp4SupportEnum? mp4Support = default(Mp4SupportEnum?), MasterAccessEnum? masterAccess = default(MasterAccessEnum?), VideoQualityEnum? videoQuality = default(VideoQualityEnum?), AssetMetadata meta = default(AssetMetadata))
        {
            this.Mp4Support = mp4Support;
            this.MasterAccess = masterAccess;
            this.VideoQuality = videoQuality;
            this.Meta = meta;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public AssetMetadata Meta { get; set; }

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
            sb.Append("class UpdateLiveStreamNewAssetSettings {\n");
            sb.Append("  Mp4Support: ").Append(Mp4Support).Append("\n");
            sb.Append("  MasterAccess: ").Append(MasterAccess).Append("\n");
            sb.Append("  VideoQuality: ").Append(VideoQuality).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as UpdateLiveStreamNewAssetSettings);
        }

        /// <summary>
        /// Returns true if UpdateLiveStreamNewAssetSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateLiveStreamNewAssetSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateLiveStreamNewAssetSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Mp4Support == input.Mp4Support ||
                    this.Mp4Support.Equals(input.Mp4Support)
                ) && 
                (
                    this.MasterAccess == input.MasterAccess ||
                    this.MasterAccess.Equals(input.MasterAccess)
                ) && 
                (
                    this.VideoQuality == input.VideoQuality ||
                    this.VideoQuality.Equals(input.VideoQuality)
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
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
                hashCode = (hashCode * 59) + this.Mp4Support.GetHashCode();
                hashCode = (hashCode * 59) + this.MasterAccess.GetHashCode();
                hashCode = (hashCode * 59) + this.VideoQuality.GetHashCode();
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
                }
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
