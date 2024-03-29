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
    /// Describes the Asset or LiveStream object associated with the playback ID.
    /// </summary>
    [DataContract(Name = "GetAssetOrLiveStreamIdResponse_data_object")]
    public partial class GetAssetOrLiveStreamIdResponseDataObject : IEquatable<GetAssetOrLiveStreamIdResponseDataObject>, IValidatableObject
    {
        /// <summary>
        /// Identifies the object type associated with the playback ID.
        /// </summary>
        /// <value>Identifies the object type associated with the playback ID.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Asset for value: asset
            /// </summary>
            [EnumMember(Value = "asset")]
            Asset = 1,

            /// <summary>
            /// Enum LiveStream for value: live_stream
            /// </summary>
            [EnumMember(Value = "live_stream")]
            LiveStream = 2

        }


        /// <summary>
        /// Identifies the object type associated with the playback ID.
        /// </summary>
        /// <value>Identifies the object type associated with the playback ID.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetOrLiveStreamIdResponseDataObject" /> class.
        /// </summary>
        /// <param name="id">The identifier of the object..</param>
        /// <param name="type">Identifies the object type associated with the playback ID..</param>
        public GetAssetOrLiveStreamIdResponseDataObject(string id = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Type = type;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The identifier of the object.
        /// </summary>
        /// <value>The identifier of the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

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
            sb.Append("class GetAssetOrLiveStreamIdResponseDataObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GetAssetOrLiveStreamIdResponseDataObject);
        }

        /// <summary>
        /// Returns true if GetAssetOrLiveStreamIdResponseDataObject instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssetOrLiveStreamIdResponseDataObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssetOrLiveStreamIdResponseDataObject input)
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
