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
    /// PlaybackRestriction
    /// </summary>
    [DataContract(Name = "PlaybackRestriction")]
    public partial class PlaybackRestriction : IEquatable<PlaybackRestriction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaybackRestriction" /> class.
        /// </summary>
        /// <param name="id">Unique identifier for the Playback Restriction. Max 255 characters..</param>
        /// <param name="createdAt">Time the Playback Restriction was created, defined as a Unix timestamp (seconds since epoch)..</param>
        /// <param name="updatedAt">Time the Playback Restriction was last updated, defined as a Unix timestamp (seconds since epoch)..</param>
        /// <param name="referrer">referrer.</param>
        /// <param name="userAgent">userAgent.</param>
        public PlaybackRestriction(string id = default(string), string createdAt = default(string), string updatedAt = default(string), ReferrerDomainRestriction referrer = default(ReferrerDomainRestriction), UserAgentRestrictionSettings userAgent = default(UserAgentRestrictionSettings))
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Referrer = referrer;
            this.UserAgent = userAgent;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Unique identifier for the Playback Restriction. Max 255 characters.
        /// </summary>
        /// <value>Unique identifier for the Playback Restriction. Max 255 characters.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Time the Playback Restriction was created, defined as a Unix timestamp (seconds since epoch).
        /// </summary>
        /// <value>Time the Playback Restriction was created, defined as a Unix timestamp (seconds since epoch).</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Time the Playback Restriction was last updated, defined as a Unix timestamp (seconds since epoch).
        /// </summary>
        /// <value>Time the Playback Restriction was last updated, defined as a Unix timestamp (seconds since epoch).</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Referrer
        /// </summary>
        [DataMember(Name = "referrer", EmitDefaultValue = false)]
        public ReferrerDomainRestriction Referrer { get; set; }

        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>
        [DataMember(Name = "user_agent", EmitDefaultValue = false)]
        public UserAgentRestrictionSettings UserAgent { get; set; }

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
            sb.Append("class PlaybackRestriction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Referrer: ").Append(Referrer).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
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
            return this.Equals(input as PlaybackRestriction);
        }

        /// <summary>
        /// Returns true if PlaybackRestriction instances are equal
        /// </summary>
        /// <param name="input">Instance of PlaybackRestriction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlaybackRestriction input)
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Referrer == input.Referrer ||
                    (this.Referrer != null &&
                    this.Referrer.Equals(input.Referrer))
                ) && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Referrer != null)
                {
                    hashCode = (hashCode * 59) + this.Referrer.GetHashCode();
                }
                if (this.UserAgent != null)
                {
                    hashCode = (hashCode * 59) + this.UserAgent.GetHashCode();
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
