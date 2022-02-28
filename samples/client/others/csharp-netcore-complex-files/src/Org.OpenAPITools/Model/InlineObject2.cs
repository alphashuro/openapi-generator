/*
 * MultipartFile test
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// InlineObject2
    /// </summary>
    [DataContract(Name = "inline_object_2")]
    public partial class InlineObject2 : IEquatable<InlineObject2>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        // public MultipartMixedStatus Status { get; set; }
        public MultipartMixedStatus Status { get; set; } // a
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject2" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="marker">marker.</param>
        /// <param name="file">a file (required).</param>
        // public InlineObject2(MultipartMixedStatus status = default(MultipartMixedStatus), MultipartMixedMarker marker = default(MultipartMixedMarker), System.IO.Stream file = default(System.IO.Stream))
        public InlineObject2(MultipartMixedStatus status, MultipartMixedMarker marker = default, System.IO.Stream file)
        {
            this.Status = status;
            // to ensure "file" is required (not null)
            if (file == null) {
                throw new ArgumentNullException("file is a required property for InlineObject2 and cannot be null");
            }
            this.File = file;
            this.Marker = marker;
        }

        /// <summary>
        /// Gets or Sets Marker
        /// </summary>
        [DataMember(Name = "marker", EmitDefaultValue = false)]
        // public MultipartMixedMarker Marker { get; set; }
        public MultipartMixedMarker Marker { get; set; } // c

        /// <summary>
        /// a file
        /// </summary>
        /// <value>a file</value>
        [DataMember(Name = "file", IsRequired = true, EmitDefaultValue = false)]
        // public System.IO.Stream File { get; set; }
        public System.IO.Stream File { get; set; } // c

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlineObject2 {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Marker: ").Append(Marker).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as InlineObject2).AreEqual;
        }

        /// <summary>
        /// Returns true if InlineObject2 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject2 input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Marker != null)
                {
                    hashCode = (hashCode * 59) + this.Marker.GetHashCode();
                }
                if (this.File != null)
                {
                    hashCode = (hashCode * 59) + this.File.GetHashCode();
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
