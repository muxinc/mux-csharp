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
    /// TranscriptionVocabulary
    /// </summary>
    [DataContract(Name = "TranscriptionVocabulary")]
    public partial class TranscriptionVocabulary : IEquatable<TranscriptionVocabulary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionVocabulary" /> class.
        /// </summary>
        /// <param name="id">Unique identifier for the Transcription Vocabulary.</param>
        /// <param name="name">The user-supplied name of the Transcription Vocabulary..</param>
        /// <param name="phrases">Phrases, individual words, or proper names to include in the Transcription Vocabulary. When the Transcription Vocabulary is attached to a live stream&#39;s &#x60;generated_subtitles&#x60; configuration, the probability of successful speech recognition for these words or phrases is boosted..</param>
        /// <param name="passthrough">Arbitrary user-supplied metadata set for the Transcription Vocabulary. Max 255 characters..</param>
        /// <param name="createdAt">Time the Transcription Vocabulary was created, defined as a Unix timestamp (seconds since epoch)..</param>
        /// <param name="updatedAt">Time the Transcription Vocabulary was updated, defined as a Unix timestamp (seconds since epoch)..</param>
        public TranscriptionVocabulary(string id = default(string), string name = default(string), List<string> phrases = default(List<string>), string passthrough = default(string), string createdAt = default(string), string updatedAt = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Phrases = phrases;
            this.Passthrough = passthrough;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Unique identifier for the Transcription Vocabulary
        /// </summary>
        /// <value>Unique identifier for the Transcription Vocabulary</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The user-supplied name of the Transcription Vocabulary.
        /// </summary>
        /// <value>The user-supplied name of the Transcription Vocabulary.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Phrases, individual words, or proper names to include in the Transcription Vocabulary. When the Transcription Vocabulary is attached to a live stream&#39;s &#x60;generated_subtitles&#x60; configuration, the probability of successful speech recognition for these words or phrases is boosted.
        /// </summary>
        /// <value>Phrases, individual words, or proper names to include in the Transcription Vocabulary. When the Transcription Vocabulary is attached to a live stream&#39;s &#x60;generated_subtitles&#x60; configuration, the probability of successful speech recognition for these words or phrases is boosted.</value>
        [DataMember(Name = "phrases", EmitDefaultValue = false)]
        public List<string> Phrases { get; set; }

        /// <summary>
        /// Arbitrary user-supplied metadata set for the Transcription Vocabulary. Max 255 characters.
        /// </summary>
        /// <value>Arbitrary user-supplied metadata set for the Transcription Vocabulary. Max 255 characters.</value>
        [DataMember(Name = "passthrough", EmitDefaultValue = false)]
        public string Passthrough { get; set; }

        /// <summary>
        /// Time the Transcription Vocabulary was created, defined as a Unix timestamp (seconds since epoch).
        /// </summary>
        /// <value>Time the Transcription Vocabulary was created, defined as a Unix timestamp (seconds since epoch).</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Time the Transcription Vocabulary was updated, defined as a Unix timestamp (seconds since epoch).
        /// </summary>
        /// <value>Time the Transcription Vocabulary was updated, defined as a Unix timestamp (seconds since epoch).</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

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
            sb.Append("class TranscriptionVocabulary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phrases: ").Append(Phrases).Append("\n");
            sb.Append("  Passthrough: ").Append(Passthrough).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as TranscriptionVocabulary);
        }

        /// <summary>
        /// Returns true if TranscriptionVocabulary instances are equal
        /// </summary>
        /// <param name="input">Instance of TranscriptionVocabulary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptionVocabulary input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Phrases == input.Phrases ||
                    this.Phrases != null &&
                    input.Phrases != null &&
                    this.Phrases.SequenceEqual(input.Phrases)
                ) && 
                (
                    this.Passthrough == input.Passthrough ||
                    (this.Passthrough != null &&
                    this.Passthrough.Equals(input.Passthrough))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Phrases != null)
                {
                    hashCode = (hashCode * 59) + this.Phrases.GetHashCode();
                }
                if (this.Passthrough != null)
                {
                    hashCode = (hashCode * 59) + this.Passthrough.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
