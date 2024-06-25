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
    /// RefreshTokenRequest
    /// </summary>
    [DataContract(Name = "RefreshTokenRequest")]
    public partial class RefreshTokenRequest : IEquatable<RefreshTokenRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefreshTokenRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenRequest" /> class.
        /// </summary>
        /// <param name="refreshToken">Specifies the session refresh token. (required).</param>
        /// <param name="forceRefresh">Specifies whether to force refresh the session..</param>
        public RefreshTokenRequest(string refreshToken = default(string), bool forceRefresh = default(bool))
        {
            // to ensure "refreshToken" is required (not null)
            if (refreshToken == null)
            {
                throw new ArgumentNullException("refreshToken is a required property for RefreshTokenRequest and cannot be null");
            }
            this.RefreshToken = refreshToken;
            this.ForceRefresh = forceRefresh;
        }

        /// <summary>
        /// Specifies the session refresh token.
        /// </summary>
        /// <value>Specifies the session refresh token.</value>
        /// <example>&quot;eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9&quot;</example>
        [DataMember(Name = "refreshToken", IsRequired = true, EmitDefaultValue = true)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Specifies whether to force refresh the session.
        /// </summary>
        /// <value>Specifies whether to force refresh the session.</value>
        /// <example>false</example>
        [DataMember(Name = "forceRefresh", EmitDefaultValue = true)]
        public bool ForceRefresh { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RefreshTokenRequest {\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  ForceRefresh: ").Append(ForceRefresh).Append("\n");
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
            return this.Equals(input as RefreshTokenRequest);
        }

        /// <summary>
        /// Returns true if RefreshTokenRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RefreshTokenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefreshTokenRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) &&
                (
                    this.ForceRefresh == input.ForceRefresh ||
                    this.ForceRefresh.Equals(input.ForceRefresh)
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
                if (this.RefreshToken != null)
                {
                    hashCode = (hashCode * 59) + this.RefreshToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ForceRefresh.GetHashCode();
                return hashCode;
            }
        }

    }

}