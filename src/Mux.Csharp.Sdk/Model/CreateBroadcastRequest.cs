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
    /// CreateBroadcastRequest
    /// </summary>
    [DataContract(Name = "CreateBroadcastRequest")]
    public partial class CreateBroadcastRequest : IEquatable<CreateBroadcastRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Layout
        /// </summary>
        [DataMember(Name = "layout", EmitDefaultValue = false)]
        public BroadcastLayout? Layout { get; set; }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name = "resolution", EmitDefaultValue = false)]
        public BroadcastResolution? Resolution { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBroadcastRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateBroadcastRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBroadcastRequest" /> class.
        /// </summary>
        /// <param name="passthrough">Arbitrary user-supplied metadata that will be included in the broadcast details and related webhooks. Max: 255 characters..</param>
        /// <param name="liveStreamId">The ID of the live stream that you want to broadcast to. (required).</param>
        /// <param name="layout">layout.</param>
        /// <param name="background">URL of an image to display as the background of the broadcast. Its dimensions should match the provided resolution..</param>
        /// <param name="resolution">resolution.</param>
        public CreateBroadcastRequest(string passthrough = default(string), string liveStreamId = default(string), BroadcastLayout? layout = default(BroadcastLayout?), string background = default(string), BroadcastResolution? resolution = default(BroadcastResolution?))
        {
            // to ensure "liveStreamId" is required (not null)
            if (liveStreamId == null) {
                throw new ArgumentNullException("liveStreamId is a required property for CreateBroadcastRequest and cannot be null");
            }
            this.LiveStreamId = liveStreamId;
            this.Passthrough = passthrough;
            this.Layout = layout;
            this.Background = background;
            this.Resolution = resolution;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Arbitrary user-supplied metadata that will be included in the broadcast details and related webhooks. Max: 255 characters.
        /// </summary>
        /// <value>Arbitrary user-supplied metadata that will be included in the broadcast details and related webhooks. Max: 255 characters.</value>
        [DataMember(Name = "passthrough", EmitDefaultValue = false)]
        public string Passthrough { get; set; }

        /// <summary>
        /// The ID of the live stream that you want to broadcast to.
        /// </summary>
        /// <value>The ID of the live stream that you want to broadcast to.</value>
        [DataMember(Name = "live_stream_id", IsRequired = true, EmitDefaultValue = false)]
        public string LiveStreamId { get; set; }

        /// <summary>
        /// URL of an image to display as the background of the broadcast. Its dimensions should match the provided resolution.
        /// </summary>
        /// <value>URL of an image to display as the background of the broadcast. Its dimensions should match the provided resolution.</value>
        [DataMember(Name = "background", EmitDefaultValue = false)]
        public string Background { get; set; }

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
            sb.Append("class CreateBroadcastRequest {\n");
            sb.Append("  Passthrough: ").Append(Passthrough).Append("\n");
            sb.Append("  LiveStreamId: ").Append(LiveStreamId).Append("\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  Background: ").Append(Background).Append("\n");
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
            return this.Equals(input as CreateBroadcastRequest);
        }

        /// <summary>
        /// Returns true if CreateBroadcastRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateBroadcastRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateBroadcastRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Passthrough == input.Passthrough ||
                    (this.Passthrough != null &&
                    this.Passthrough.Equals(input.Passthrough))
                ) && 
                (
                    this.LiveStreamId == input.LiveStreamId ||
                    (this.LiveStreamId != null &&
                    this.LiveStreamId.Equals(input.LiveStreamId))
                ) && 
                (
                    this.Layout == input.Layout ||
                    this.Layout.Equals(input.Layout)
                ) && 
                (
                    this.Background == input.Background ||
                    (this.Background != null &&
                    this.Background.Equals(input.Background))
                ) && 
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
                if (this.Passthrough != null)
                {
                    hashCode = (hashCode * 59) + this.Passthrough.GetHashCode();
                }
                if (this.LiveStreamId != null)
                {
                    hashCode = (hashCode * 59) + this.LiveStreamId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Layout.GetHashCode();
                if (this.Background != null)
                {
                    hashCode = (hashCode * 59) + this.Background.GetHashCode();
                }
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