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
    /// StaticRendition
    /// </summary>
    [DataContract(Name = "StaticRendition")]
    public partial class StaticRendition : IEquatable<StaticRendition>, IValidatableObject
    {
        /// <summary>
        /// Name of the static rendition file
        /// </summary>
        /// <value>Name of the static rendition file</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Enum LowMp4 for value: low.mp4
            /// </summary>
            [EnumMember(Value = "low.mp4")]
            LowMp4 = 1,

            /// <summary>
            /// Enum MediumMp4 for value: medium.mp4
            /// </summary>
            [EnumMember(Value = "medium.mp4")]
            MediumMp4 = 2,

            /// <summary>
            /// Enum HighMp4 for value: high.mp4
            /// </summary>
            [EnumMember(Value = "high.mp4")]
            HighMp4 = 3,

            /// <summary>
            /// Enum HighestMp4 for value: highest.mp4
            /// </summary>
            [EnumMember(Value = "highest.mp4")]
            HighestMp4 = 4,

            /// <summary>
            /// Enum AudioM4a for value: audio.m4a
            /// </summary>
            [EnumMember(Value = "audio.m4a")]
            AudioM4a = 5,

            /// <summary>
            /// Enum Capped1080pMp4 for value: capped-1080p.mp4
            /// </summary>
            [EnumMember(Value = "capped-1080p.mp4")]
            Capped1080pMp4 = 6,

            /// <summary>
            /// Enum _2160pMp4 for value: 2160p.mp4
            /// </summary>
            [EnumMember(Value = "2160p.mp4")]
            _2160pMp4 = 7,

            /// <summary>
            /// Enum _1440pMp4 for value: 1440p.mp4
            /// </summary>
            [EnumMember(Value = "1440p.mp4")]
            _1440pMp4 = 8,

            /// <summary>
            /// Enum _1080pMp4 for value: 1080p.mp4
            /// </summary>
            [EnumMember(Value = "1080p.mp4")]
            _1080pMp4 = 9,

            /// <summary>
            /// Enum _720pMp4 for value: 720p.mp4
            /// </summary>
            [EnumMember(Value = "720p.mp4")]
            _720pMp4 = 10,

            /// <summary>
            /// Enum _540pMp4 for value: 540p.mp4
            /// </summary>
            [EnumMember(Value = "540p.mp4")]
            _540pMp4 = 11,

            /// <summary>
            /// Enum _480pMp4 for value: 480p.mp4
            /// </summary>
            [EnumMember(Value = "480p.mp4")]
            _480pMp4 = 12,

            /// <summary>
            /// Enum _360pMp4 for value: 360p.mp4
            /// </summary>
            [EnumMember(Value = "360p.mp4")]
            _360pMp4 = 13,

            /// <summary>
            /// Enum _270pMp4 for value: 270p.mp4
            /// </summary>
            [EnumMember(Value = "270p.mp4")]
            _270pMp4 = 14

        }


        /// <summary>
        /// Name of the static rendition file
        /// </summary>
        /// <value>Name of the static rendition file</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Extension of the static rendition file
        /// </summary>
        /// <value>Extension of the static rendition file</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExtEnum
        {
            /// <summary>
            /// Enum Mp4 for value: mp4
            /// </summary>
            [EnumMember(Value = "mp4")]
            Mp4 = 1,

            /// <summary>
            /// Enum M4a for value: m4a
            /// </summary>
            [EnumMember(Value = "m4a")]
            M4a = 2

        }


        /// <summary>
        /// Extension of the static rendition file
        /// </summary>
        /// <value>Extension of the static rendition file</value>
        [DataMember(Name = "ext", EmitDefaultValue = false)]
        public ExtEnum? Ext { get; set; }
        /// <summary>
        /// Indicates the static rendition type of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.
        /// </summary>
        /// <value>Indicates the static rendition type of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 1,

            /// <summary>
            /// Enum Advanced for value: advanced
            /// </summary>
            [EnumMember(Value = "advanced")]
            Advanced = 2

        }


        /// <summary>
        /// Indicates the static rendition type of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.
        /// </summary>
        /// <value>Indicates the static rendition type of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Indicates the status of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;. * &#x60;ready&#x60; indicates the MP4 has been generated and is ready for download * &#x60;preparing&#x60; indicates the asset has not been ingested or the static rendition is still being generated after an asset is ready * &#x60;skipped&#x60; indicates the static rendition will not be generated because the requested resolution conflicts with the asset attributes after the asset has been ingested * &#x60;errored&#x60; indicates the static rendition cannot be generated. For example, an asset could not be ingested 
        /// </summary>
        /// <value>Indicates the status of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;. * &#x60;ready&#x60; indicates the MP4 has been generated and is ready for download * &#x60;preparing&#x60; indicates the asset has not been ingested or the static rendition is still being generated after an asset is ready * &#x60;skipped&#x60; indicates the static rendition will not be generated because the requested resolution conflicts with the asset attributes after the asset has been ingested * &#x60;errored&#x60; indicates the static rendition cannot be generated. For example, an asset could not be ingested </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Ready for value: ready
            /// </summary>
            [EnumMember(Value = "ready")]
            Ready = 1,

            /// <summary>
            /// Enum Preparing for value: preparing
            /// </summary>
            [EnumMember(Value = "preparing")]
            Preparing = 2,

            /// <summary>
            /// Enum Skipped for value: skipped
            /// </summary>
            [EnumMember(Value = "skipped")]
            Skipped = 3,

            /// <summary>
            /// Enum Errored for value: errored
            /// </summary>
            [EnumMember(Value = "errored")]
            Errored = 4

        }


        /// <summary>
        /// Indicates the status of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;. * &#x60;ready&#x60; indicates the MP4 has been generated and is ready for download * &#x60;preparing&#x60; indicates the asset has not been ingested or the static rendition is still being generated after an asset is ready * &#x60;skipped&#x60; indicates the static rendition will not be generated because the requested resolution conflicts with the asset attributes after the asset has been ingested * &#x60;errored&#x60; indicates the static rendition cannot be generated. For example, an asset could not be ingested 
        /// </summary>
        /// <value>Indicates the status of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;. * &#x60;ready&#x60; indicates the MP4 has been generated and is ready for download * &#x60;preparing&#x60; indicates the asset has not been ingested or the static rendition is still being generated after an asset is ready * &#x60;skipped&#x60; indicates the static rendition will not be generated because the requested resolution conflicts with the asset attributes after the asset has been ingested * &#x60;errored&#x60; indicates the static rendition cannot be generated. For example, an asset could not be ingested </value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Indicates the resolution tier of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.
        /// </summary>
        /// <value>Indicates the resolution tier of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResolutionTierEnum
        {
            /// <summary>
            /// Enum _2160p for value: 2160p
            /// </summary>
            [EnumMember(Value = "2160p")]
            _2160p = 1,

            /// <summary>
            /// Enum _1440p for value: 1440p
            /// </summary>
            [EnumMember(Value = "1440p")]
            _1440p = 2,

            /// <summary>
            /// Enum _1080p for value: 1080p
            /// </summary>
            [EnumMember(Value = "1080p")]
            _1080p = 3,

            /// <summary>
            /// Enum _720p for value: 720p
            /// </summary>
            [EnumMember(Value = "720p")]
            _720p = 4

        }


        /// <summary>
        /// Indicates the resolution tier of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.
        /// </summary>
        /// <value>Indicates the resolution tier of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.</value>
        [DataMember(Name = "resolution_tier", EmitDefaultValue = false)]
        public ResolutionTierEnum? ResolutionTier { get; set; }
        /// <summary>
        /// Indicates the resolution of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.
        /// </summary>
        /// <value>Indicates the resolution of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResolutionEnum
        {
            /// <summary>
            /// Enum Highest for value: highest
            /// </summary>
            [EnumMember(Value = "highest")]
            Highest = 1,

            /// <summary>
            /// Enum AudioOnly for value: audio-only
            /// </summary>
            [EnumMember(Value = "audio-only")]
            AudioOnly = 2,

            /// <summary>
            /// Enum _2160p for value: 2160p
            /// </summary>
            [EnumMember(Value = "2160p")]
            _2160p = 3,

            /// <summary>
            /// Enum _1440p for value: 1440p
            /// </summary>
            [EnumMember(Value = "1440p")]
            _1440p = 4,

            /// <summary>
            /// Enum _1080p for value: 1080p
            /// </summary>
            [EnumMember(Value = "1080p")]
            _1080p = 5,

            /// <summary>
            /// Enum _720p for value: 720p
            /// </summary>
            [EnumMember(Value = "720p")]
            _720p = 6,

            /// <summary>
            /// Enum _540p for value: 540p
            /// </summary>
            [EnumMember(Value = "540p")]
            _540p = 7,

            /// <summary>
            /// Enum _480p for value: 480p
            /// </summary>
            [EnumMember(Value = "480p")]
            _480p = 8,

            /// <summary>
            /// Enum _360p for value: 360p
            /// </summary>
            [EnumMember(Value = "360p")]
            _360p = 9,

            /// <summary>
            /// Enum _270p for value: 270p
            /// </summary>
            [EnumMember(Value = "270p")]
            _270p = 10

        }


        /// <summary>
        /// Indicates the resolution of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.
        /// </summary>
        /// <value>Indicates the resolution of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.</value>
        [DataMember(Name = "resolution", EmitDefaultValue = false)]
        public ResolutionEnum? Resolution { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaticRendition" /> class.
        /// </summary>
        /// <param name="name">Name of the static rendition file.</param>
        /// <param name="ext">Extension of the static rendition file.</param>
        /// <param name="height">The height of the static rendition&#39;s file in pixels.</param>
        /// <param name="width">The width of the static rendition&#39;s file in pixels.</param>
        /// <param name="bitrate">The bitrate in bits per second.</param>
        /// <param name="filesize">The file size in bytes.</param>
        /// <param name="type">Indicates the static rendition type of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;..</param>
        /// <param name="status">Indicates the status of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;. * &#x60;ready&#x60; indicates the MP4 has been generated and is ready for download * &#x60;preparing&#x60; indicates the asset has not been ingested or the static rendition is still being generated after an asset is ready * &#x60;skipped&#x60; indicates the static rendition will not be generated because the requested resolution conflicts with the asset attributes after the asset has been ingested * &#x60;errored&#x60; indicates the static rendition cannot be generated. For example, an asset could not be ingested .</param>
        /// <param name="resolutionTier">Indicates the resolution tier of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;..</param>
        /// <param name="resolution">Indicates the resolution of this specific MP4 version of this asset. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;..</param>
        /// <param name="id">The ID of this static rendition, used in managing this static rendition. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;..</param>
        /// <param name="passthrough">Arbitrary user-supplied metadata set for the static rendition. Max 255 characters..</param>
        public StaticRendition(NameEnum? name = default(NameEnum?), ExtEnum? ext = default(ExtEnum?), int height = default(int), int width = default(int), long bitrate = default(long), string filesize = default(string), TypeEnum? type = default(TypeEnum?), StatusEnum? status = default(StatusEnum?), ResolutionTierEnum? resolutionTier = default(ResolutionTierEnum?), ResolutionEnum? resolution = default(ResolutionEnum?), string id = default(string), string passthrough = default(string))
        {
            this.Name = name;
            this.Ext = ext;
            this.Height = height;
            this.Width = width;
            this.Bitrate = bitrate;
            this.Filesize = filesize;
            this.Type = type;
            this.Status = status;
            this.ResolutionTier = resolutionTier;
            this.Resolution = resolution;
            this.Id = id;
            this.Passthrough = passthrough;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The height of the static rendition&#39;s file in pixels
        /// </summary>
        /// <value>The height of the static rendition&#39;s file in pixels</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// The width of the static rendition&#39;s file in pixels
        /// </summary>
        /// <value>The width of the static rendition&#39;s file in pixels</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// The bitrate in bits per second
        /// </summary>
        /// <value>The bitrate in bits per second</value>
        [DataMember(Name = "bitrate", EmitDefaultValue = false)]
        public long Bitrate { get; set; }

        /// <summary>
        /// The file size in bytes
        /// </summary>
        /// <value>The file size in bytes</value>
        [DataMember(Name = "filesize", EmitDefaultValue = false)]
        public string Filesize { get; set; }

        /// <summary>
        /// The ID of this static rendition, used in managing this static rendition. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.
        /// </summary>
        /// <value>The ID of this static rendition, used in managing this static rendition. This field is only valid for &#x60;static_renditions&#x60;, not for &#x60;mp4_support&#x60;.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Arbitrary user-supplied metadata set for the static rendition. Max 255 characters.
        /// </summary>
        /// <value>Arbitrary user-supplied metadata set for the static rendition. Max 255 characters.</value>
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
            sb.Append("class StaticRendition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  Filesize: ").Append(Filesize).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ResolutionTier: ").Append(ResolutionTier).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Passthrough: ").Append(Passthrough).Append("\n");
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
            return this.Equals(input as StaticRendition);
        }

        /// <summary>
        /// Returns true if StaticRendition instances are equal
        /// </summary>
        /// <param name="input">Instance of StaticRendition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaticRendition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    this.Name.Equals(input.Name)
                ) && 
                (
                    this.Ext == input.Ext ||
                    this.Ext.Equals(input.Ext)
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
                ) && 
                (
                    this.Bitrate == input.Bitrate ||
                    this.Bitrate.Equals(input.Bitrate)
                ) && 
                (
                    this.Filesize == input.Filesize ||
                    (this.Filesize != null &&
                    this.Filesize.Equals(input.Filesize))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.ResolutionTier == input.ResolutionTier ||
                    this.ResolutionTier.Equals(input.ResolutionTier)
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    this.Resolution.Equals(input.Resolution)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Passthrough == input.Passthrough ||
                    (this.Passthrough != null &&
                    this.Passthrough.Equals(input.Passthrough))
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
                hashCode = (hashCode * 59) + this.Name.GetHashCode();
                hashCode = (hashCode * 59) + this.Ext.GetHashCode();
                hashCode = (hashCode * 59) + this.Height.GetHashCode();
                hashCode = (hashCode * 59) + this.Width.GetHashCode();
                hashCode = (hashCode * 59) + this.Bitrate.GetHashCode();
                if (this.Filesize != null)
                {
                    hashCode = (hashCode * 59) + this.Filesize.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.ResolutionTier.GetHashCode();
                hashCode = (hashCode * 59) + this.Resolution.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Passthrough != null)
                {
                    hashCode = (hashCode * 59) + this.Passthrough.GetHashCode();
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
