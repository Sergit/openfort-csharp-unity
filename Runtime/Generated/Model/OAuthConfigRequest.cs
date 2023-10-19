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
using OpenAPIDateConverter = Openfort.Client.OpenAPIDateConverter;

namespace Openfort.Model
{
    /// <summary>
    /// OAuthConfigRequest
    /// </summary>
    [DataContract(Name = "OAuthConfigRequest")]
    public partial class OAuthConfigRequest : IEquatable<OAuthConfigRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthConfigRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OAuthConfigRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthConfigRequest" /> class.
        /// </summary>
        /// <param name="config">config (required).</param>
        public OAuthConfigRequest(AccelbyteOauthConfig config = default(AccelbyteOauthConfig))
        {
            // to ensure "config" is required (not null)
            if (config == null)
            {
                throw new ArgumentNullException("config is a required property for OAuthConfigRequest and cannot be null");
            }
            this.Config = config;
        }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", IsRequired = true, EmitDefaultValue = true)]
        public AccelbyteOauthConfig Config { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuthConfigRequest {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
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
            return this.Equals(input as OAuthConfigRequest);
        }

        /// <summary>
        /// Returns true if OAuthConfigRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuthConfigRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthConfigRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
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
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
