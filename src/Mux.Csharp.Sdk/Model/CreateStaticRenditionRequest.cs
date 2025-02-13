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
    /// CreateStaticRenditionRequest
    /// </summary>
    [DataContract(Name = "CreateStaticRenditionRequest")]
    public partial class CreateStaticRenditionRequest : IEquatable<CreateStaticRenditionRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Resolution
        /// </summary>
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
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name = "resolution", EmitDefaultValue = false)]
        public ResolutionEnum? Resolution { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStaticRenditionRequest" /> class.
        /// </summary>
        /// <param name="resolution">resolution.</param>
        public CreateStaticRenditionRequest(ResolutionEnum? resolution = default(ResolutionEnum?))
        {
            this.Resolution = resolution;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

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
            sb.Append("class CreateStaticRenditionRequest {\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
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
            return this.Equals(input as CreateStaticRenditionRequest);
        }

        /// <summary>
        /// Returns true if CreateStaticRenditionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateStaticRenditionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateStaticRenditionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Resolution == input.Resolution ||
                    this.Resolution.Equals(input.Resolution)
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
                hashCode = (hashCode * 59) + this.Resolution.GetHashCode();
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
