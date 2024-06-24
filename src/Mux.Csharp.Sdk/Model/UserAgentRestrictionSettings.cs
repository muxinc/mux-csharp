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
    /// Rules that control what user agents are allowed to play your videos. Please see [Using User-Agent HTTP header for validation](https://docs.mux.com/guides/secure-video-playback#using-user-agent-http-header-for-validation) for more details on this feature.
    /// </summary>
    [DataContract(Name = "UserAgentRestrictionSettings")]
    public partial class UserAgentRestrictionSettings : IEquatable<UserAgentRestrictionSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAgentRestrictionSettings" /> class.
        /// </summary>
        /// <param name="allowNoUserAgent">Whether or not to allow views without a &#x60;User-Agent&#x60; HTTP request header. (default to true).</param>
        /// <param name="allowHighRiskUserAgent">Whether or not to allow high risk user agents. The high risk user agents are defined by Mux. (default to true).</param>
        public UserAgentRestrictionSettings(bool allowNoUserAgent = true, bool allowHighRiskUserAgent = true)
        {
            this.AllowNoUserAgent = allowNoUserAgent;
            this.AllowHighRiskUserAgent = allowHighRiskUserAgent;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Whether or not to allow views without a &#x60;User-Agent&#x60; HTTP request header.
        /// </summary>
        /// <value>Whether or not to allow views without a &#x60;User-Agent&#x60; HTTP request header.</value>
        [DataMember(Name = "allow_no_user_agent", EmitDefaultValue = true)]
        public bool AllowNoUserAgent { get; set; }

        /// <summary>
        /// Whether or not to allow high risk user agents. The high risk user agents are defined by Mux.
        /// </summary>
        /// <value>Whether or not to allow high risk user agents. The high risk user agents are defined by Mux.</value>
        [DataMember(Name = "allow_high_risk_user_agent", EmitDefaultValue = true)]
        public bool AllowHighRiskUserAgent { get; set; }

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
            sb.Append("class UserAgentRestrictionSettings {\n");
            sb.Append("  AllowNoUserAgent: ").Append(AllowNoUserAgent).Append("\n");
            sb.Append("  AllowHighRiskUserAgent: ").Append(AllowHighRiskUserAgent).Append("\n");
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
            return this.Equals(input as UserAgentRestrictionSettings);
        }

        /// <summary>
        /// Returns true if UserAgentRestrictionSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAgentRestrictionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAgentRestrictionSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowNoUserAgent == input.AllowNoUserAgent ||
                    this.AllowNoUserAgent.Equals(input.AllowNoUserAgent)
                ) && 
                (
                    this.AllowHighRiskUserAgent == input.AllowHighRiskUserAgent ||
                    this.AllowHighRiskUserAgent.Equals(input.AllowHighRiskUserAgent)
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
                hashCode = (hashCode * 59) + this.AllowNoUserAgent.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowHighRiskUserAgent.GetHashCode();
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