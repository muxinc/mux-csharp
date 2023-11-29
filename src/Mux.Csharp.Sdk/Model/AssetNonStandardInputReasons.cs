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
    /// An object containing one or more reasons the input file is non-standard. See [the guide on minimizing processing time](https://docs.mux.com/guides/minimize-processing-time) for more information on what a standard input is defined as. This object only exists on on-demand assets that have non-standard inputs, so if missing you can assume the input qualifies as standard.
    /// </summary>
    [DataContract(Name = "Asset_non_standard_input_reasons")]
    public partial class AssetNonStandardInputReasons : IEquatable<AssetNonStandardInputReasons>, IValidatableObject
    {
        /// <summary>
        /// The video key frame Interval (also called as Group of Picture or GOP) of the input file is &#x60;high&#x60;. This parameter is present when the gop is greater than 20 seconds.
        /// </summary>
        /// <value>The video key frame Interval (also called as Group of Picture or GOP) of the input file is &#x60;high&#x60;. This parameter is present when the gop is greater than 20 seconds.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VideoGopSizeEnum
        {
            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 1

        }


        /// <summary>
        /// The video key frame Interval (also called as Group of Picture or GOP) of the input file is &#x60;high&#x60;. This parameter is present when the gop is greater than 20 seconds.
        /// </summary>
        /// <value>The video key frame Interval (also called as Group of Picture or GOP) of the input file is &#x60;high&#x60;. This parameter is present when the gop is greater than 20 seconds.</value>
        [DataMember(Name = "video_gop_size", EmitDefaultValue = false)]
        public VideoGopSizeEnum? VideoGopSize { get; set; }
        /// <summary>
        /// The video bitrate of the input file is &#x60;high&#x60;. This parameter is present when the average bitrate of any key frame interval (also known as Group of Pictures or GOP) is higher than what&#39;s considered standard which typically is 16 Mbps.
        /// </summary>
        /// <value>The video bitrate of the input file is &#x60;high&#x60;. This parameter is present when the average bitrate of any key frame interval (also known as Group of Pictures or GOP) is higher than what&#39;s considered standard which typically is 16 Mbps.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VideoBitrateEnum
        {
            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 1

        }


        /// <summary>
        /// The video bitrate of the input file is &#x60;high&#x60;. This parameter is present when the average bitrate of any key frame interval (also known as Group of Pictures or GOP) is higher than what&#39;s considered standard which typically is 16 Mbps.
        /// </summary>
        /// <value>The video bitrate of the input file is &#x60;high&#x60;. This parameter is present when the average bitrate of any key frame interval (also known as Group of Pictures or GOP) is higher than what&#39;s considered standard which typically is 16 Mbps.</value>
        [DataMember(Name = "video_bitrate", EmitDefaultValue = false)]
        public VideoBitrateEnum? VideoBitrate { get; set; }
        /// <summary>
        /// Video Edit List reason indicates that the input file&#39;s video track contains a complex Edit Decision List.
        /// </summary>
        /// <value>Video Edit List reason indicates that the input file&#39;s video track contains a complex Edit Decision List.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VideoEditListEnum
        {
            /// <summary>
            /// Enum NonStandard for value: non-standard
            /// </summary>
            [EnumMember(Value = "non-standard")]
            NonStandard = 1

        }


        /// <summary>
        /// Video Edit List reason indicates that the input file&#39;s video track contains a complex Edit Decision List.
        /// </summary>
        /// <value>Video Edit List reason indicates that the input file&#39;s video track contains a complex Edit Decision List.</value>
        [DataMember(Name = "video_edit_list", EmitDefaultValue = false)]
        public VideoEditListEnum? VideoEditList { get; set; }
        /// <summary>
        /// Audio Edit List reason indicates that the input file&#39;s audio track contains a complex Edit Decision List.
        /// </summary>
        /// <value>Audio Edit List reason indicates that the input file&#39;s audio track contains a complex Edit Decision List.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AudioEditListEnum
        {
            /// <summary>
            /// Enum NonStandard for value: non-standard
            /// </summary>
            [EnumMember(Value = "non-standard")]
            NonStandard = 1

        }


        /// <summary>
        /// Audio Edit List reason indicates that the input file&#39;s audio track contains a complex Edit Decision List.
        /// </summary>
        /// <value>Audio Edit List reason indicates that the input file&#39;s audio track contains a complex Edit Decision List.</value>
        [DataMember(Name = "audio_edit_list", EmitDefaultValue = false)]
        public AudioEditListEnum? AudioEditList { get; set; }
        /// <summary>
        /// A catch-all reason when the input file in created with non-standard encoding parameters.
        /// </summary>
        /// <value>A catch-all reason when the input file in created with non-standard encoding parameters.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnexpectedMediaFileParametersEnum
        {
            /// <summary>
            /// Enum NonStandard for value: non-standard
            /// </summary>
            [EnumMember(Value = "non-standard")]
            NonStandard = 1

        }


        /// <summary>
        /// A catch-all reason when the input file in created with non-standard encoding parameters.
        /// </summary>
        /// <value>A catch-all reason when the input file in created with non-standard encoding parameters.</value>
        [DataMember(Name = "unexpected_media_file_parameters", EmitDefaultValue = false)]
        public UnexpectedMediaFileParametersEnum? UnexpectedMediaFileParameters { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetNonStandardInputReasons" /> class.
        /// </summary>
        /// <param name="videoCodec">The video codec used on the input file. For example, the input file encoded with &#x60;hevc&#x60; video codec is non-standard and the value of this parameter is &#x60;hevc&#x60;..</param>
        /// <param name="audioCodec">The audio codec used on the input file. Non-AAC audio codecs are non-standard..</param>
        /// <param name="videoGopSize">The video key frame Interval (also called as Group of Picture or GOP) of the input file is &#x60;high&#x60;. This parameter is present when the gop is greater than 20 seconds..</param>
        /// <param name="videoFrameRate">The video frame rate of the input file. Video with average frames per second (fps) less than 5 or greater than 120 is non-standard. A &#x60;-1&#x60; frame rate value indicates Mux could not determine the frame rate of the video track..</param>
        /// <param name="videoResolution">The video resolution of the input file. Video resolution higher than 2048 pixels on any one dimension (height or width) is considered non-standard, The resolution value is presented as &#x60;width&#x60; x &#x60;height&#x60; in pixels..</param>
        /// <param name="videoBitrate">The video bitrate of the input file is &#x60;high&#x60;. This parameter is present when the average bitrate of any key frame interval (also known as Group of Pictures or GOP) is higher than what&#39;s considered standard which typically is 16 Mbps..</param>
        /// <param name="pixelAspectRatio">The video pixel aspect ratio of the input file..</param>
        /// <param name="videoEditList">Video Edit List reason indicates that the input file&#39;s video track contains a complex Edit Decision List..</param>
        /// <param name="audioEditList">Audio Edit List reason indicates that the input file&#39;s audio track contains a complex Edit Decision List..</param>
        /// <param name="unexpectedMediaFileParameters">A catch-all reason when the input file in created with non-standard encoding parameters..</param>
        /// <param name="unsupportedPixelFormat">The video pixel format, as a string, returned by libav. Considered non-standard if not one of yuv420p or yuvj420p..</param>
        public AssetNonStandardInputReasons(string videoCodec = default(string), string audioCodec = default(string), VideoGopSizeEnum? videoGopSize = default(VideoGopSizeEnum?), string videoFrameRate = default(string), string videoResolution = default(string), VideoBitrateEnum? videoBitrate = default(VideoBitrateEnum?), string pixelAspectRatio = default(string), VideoEditListEnum? videoEditList = default(VideoEditListEnum?), AudioEditListEnum? audioEditList = default(AudioEditListEnum?), UnexpectedMediaFileParametersEnum? unexpectedMediaFileParameters = default(UnexpectedMediaFileParametersEnum?), string unsupportedPixelFormat = default(string))
        {
            this.VideoCodec = videoCodec;
            this.AudioCodec = audioCodec;
            this.VideoGopSize = videoGopSize;
            this.VideoFrameRate = videoFrameRate;
            this.VideoResolution = videoResolution;
            this.VideoBitrate = videoBitrate;
            this.PixelAspectRatio = pixelAspectRatio;
            this.VideoEditList = videoEditList;
            this.AudioEditList = audioEditList;
            this.UnexpectedMediaFileParameters = unexpectedMediaFileParameters;
            this.UnsupportedPixelFormat = unsupportedPixelFormat;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The video codec used on the input file. For example, the input file encoded with &#x60;hevc&#x60; video codec is non-standard and the value of this parameter is &#x60;hevc&#x60;.
        /// </summary>
        /// <value>The video codec used on the input file. For example, the input file encoded with &#x60;hevc&#x60; video codec is non-standard and the value of this parameter is &#x60;hevc&#x60;.</value>
        [DataMember(Name = "video_codec", EmitDefaultValue = false)]
        public string VideoCodec { get; set; }

        /// <summary>
        /// The audio codec used on the input file. Non-AAC audio codecs are non-standard.
        /// </summary>
        /// <value>The audio codec used on the input file. Non-AAC audio codecs are non-standard.</value>
        [DataMember(Name = "audio_codec", EmitDefaultValue = false)]
        public string AudioCodec { get; set; }

        /// <summary>
        /// The video frame rate of the input file. Video with average frames per second (fps) less than 5 or greater than 120 is non-standard. A &#x60;-1&#x60; frame rate value indicates Mux could not determine the frame rate of the video track.
        /// </summary>
        /// <value>The video frame rate of the input file. Video with average frames per second (fps) less than 5 or greater than 120 is non-standard. A &#x60;-1&#x60; frame rate value indicates Mux could not determine the frame rate of the video track.</value>
        [DataMember(Name = "video_frame_rate", EmitDefaultValue = false)]
        public string VideoFrameRate { get; set; }

        /// <summary>
        /// The video resolution of the input file. Video resolution higher than 2048 pixels on any one dimension (height or width) is considered non-standard, The resolution value is presented as &#x60;width&#x60; x &#x60;height&#x60; in pixels.
        /// </summary>
        /// <value>The video resolution of the input file. Video resolution higher than 2048 pixels on any one dimension (height or width) is considered non-standard, The resolution value is presented as &#x60;width&#x60; x &#x60;height&#x60; in pixels.</value>
        [DataMember(Name = "video_resolution", EmitDefaultValue = false)]
        public string VideoResolution { get; set; }

        /// <summary>
        /// The video pixel aspect ratio of the input file.
        /// </summary>
        /// <value>The video pixel aspect ratio of the input file.</value>
        [DataMember(Name = "pixel_aspect_ratio", EmitDefaultValue = false)]
        public string PixelAspectRatio { get; set; }

        /// <summary>
        /// The video pixel format, as a string, returned by libav. Considered non-standard if not one of yuv420p or yuvj420p.
        /// </summary>
        /// <value>The video pixel format, as a string, returned by libav. Considered non-standard if not one of yuv420p or yuvj420p.</value>
        [DataMember(Name = "unsupported_pixel_format", EmitDefaultValue = false)]
        public string UnsupportedPixelFormat { get; set; }

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
            sb.Append("class AssetNonStandardInputReasons {\n");
            sb.Append("  VideoCodec: ").Append(VideoCodec).Append("\n");
            sb.Append("  AudioCodec: ").Append(AudioCodec).Append("\n");
            sb.Append("  VideoGopSize: ").Append(VideoGopSize).Append("\n");
            sb.Append("  VideoFrameRate: ").Append(VideoFrameRate).Append("\n");
            sb.Append("  VideoResolution: ").Append(VideoResolution).Append("\n");
            sb.Append("  VideoBitrate: ").Append(VideoBitrate).Append("\n");
            sb.Append("  PixelAspectRatio: ").Append(PixelAspectRatio).Append("\n");
            sb.Append("  VideoEditList: ").Append(VideoEditList).Append("\n");
            sb.Append("  AudioEditList: ").Append(AudioEditList).Append("\n");
            sb.Append("  UnexpectedMediaFileParameters: ").Append(UnexpectedMediaFileParameters).Append("\n");
            sb.Append("  UnsupportedPixelFormat: ").Append(UnsupportedPixelFormat).Append("\n");
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
            return this.Equals(input as AssetNonStandardInputReasons);
        }

        /// <summary>
        /// Returns true if AssetNonStandardInputReasons instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetNonStandardInputReasons to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetNonStandardInputReasons input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VideoCodec == input.VideoCodec ||
                    (this.VideoCodec != null &&
                    this.VideoCodec.Equals(input.VideoCodec))
                ) && 
                (
                    this.AudioCodec == input.AudioCodec ||
                    (this.AudioCodec != null &&
                    this.AudioCodec.Equals(input.AudioCodec))
                ) && 
                (
                    this.VideoGopSize == input.VideoGopSize ||
                    this.VideoGopSize.Equals(input.VideoGopSize)
                ) && 
                (
                    this.VideoFrameRate == input.VideoFrameRate ||
                    (this.VideoFrameRate != null &&
                    this.VideoFrameRate.Equals(input.VideoFrameRate))
                ) && 
                (
                    this.VideoResolution == input.VideoResolution ||
                    (this.VideoResolution != null &&
                    this.VideoResolution.Equals(input.VideoResolution))
                ) && 
                (
                    this.VideoBitrate == input.VideoBitrate ||
                    this.VideoBitrate.Equals(input.VideoBitrate)
                ) && 
                (
                    this.PixelAspectRatio == input.PixelAspectRatio ||
                    (this.PixelAspectRatio != null &&
                    this.PixelAspectRatio.Equals(input.PixelAspectRatio))
                ) && 
                (
                    this.VideoEditList == input.VideoEditList ||
                    this.VideoEditList.Equals(input.VideoEditList)
                ) && 
                (
                    this.AudioEditList == input.AudioEditList ||
                    this.AudioEditList.Equals(input.AudioEditList)
                ) && 
                (
                    this.UnexpectedMediaFileParameters == input.UnexpectedMediaFileParameters ||
                    this.UnexpectedMediaFileParameters.Equals(input.UnexpectedMediaFileParameters)
                ) && 
                (
                    this.UnsupportedPixelFormat == input.UnsupportedPixelFormat ||
                    (this.UnsupportedPixelFormat != null &&
                    this.UnsupportedPixelFormat.Equals(input.UnsupportedPixelFormat))
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
                if (this.VideoCodec != null)
                {
                    hashCode = (hashCode * 59) + this.VideoCodec.GetHashCode();
                }
                if (this.AudioCodec != null)
                {
                    hashCode = (hashCode * 59) + this.AudioCodec.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VideoGopSize.GetHashCode();
                if (this.VideoFrameRate != null)
                {
                    hashCode = (hashCode * 59) + this.VideoFrameRate.GetHashCode();
                }
                if (this.VideoResolution != null)
                {
                    hashCode = (hashCode * 59) + this.VideoResolution.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VideoBitrate.GetHashCode();
                if (this.PixelAspectRatio != null)
                {
                    hashCode = (hashCode * 59) + this.PixelAspectRatio.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VideoEditList.GetHashCode();
                hashCode = (hashCode * 59) + this.AudioEditList.GetHashCode();
                hashCode = (hashCode * 59) + this.UnexpectedMediaFileParameters.GetHashCode();
                if (this.UnsupportedPixelFormat != null)
                {
                    hashCode = (hashCode * 59) + this.UnsupportedPixelFormat.GetHashCode();
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
