/*
 * Openfort API
 *
 * Complete Openfort API references and guides can be found at: https://openfort.xyz/docs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: founders@openfort.xyz
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


namespace Openfort.OpenfortSDK.Model
{
    /// <summary>
    /// Response for the OAuth config list method.
    /// </summary>
    [DataContract(Name = "OAuthConfigListResponse")]
    public partial class OAuthConfigListResponse : IEquatable<OAuthConfigListResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthConfigListResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OAuthConfigListResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthConfigListResponse" /> class.
        /// </summary>
        /// <param name="data">List of the OAuth providers configurations (required).</param>
        public OAuthConfigListResponse(List<OAuthConfig> data = default(List<OAuthConfig>))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for OAuthConfigListResponse and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// List of the OAuth providers configurations
        /// </summary>
        /// <value>List of the OAuth providers configurations</value>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public List<OAuthConfig> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuthConfigListResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as OAuthConfigListResponse);
        }

        /// <summary>
        /// Returns true if OAuthConfigListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuthConfigListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthConfigListResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                );
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}