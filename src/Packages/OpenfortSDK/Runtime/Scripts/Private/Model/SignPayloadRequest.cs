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
    /// SignPayloadRequest
    /// </summary>
    [DataContract(Name = "SignPayloadRequest")]
    public partial class SignPayloadRequest : IEquatable<SignPayloadRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignPayloadRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignPayloadRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignPayloadRequest" /> class.
        /// </summary>
        /// <param name="domain">domain (required).</param>
        /// <param name="types">types (required).</param>
        /// <param name="primaryType">primaryType (required).</param>
        /// <param name="value">value (required).</param>
        /// <param name="hash">Hash to verify and that will be signed (required).</param>
        public SignPayloadRequest(DomainData domain = default(DomainData), Dictionary<string, List<TypedDataField>> types = default(Dictionary<string, List<TypedDataField>>), string primaryType = default(string), Dictionary<string, Object> value = default(Dictionary<string, Object>), string hash = default(string))
        {
            // to ensure "domain" is required (not null)
            if (domain == null)
            {
                throw new ArgumentNullException("domain is a required property for SignPayloadRequest and cannot be null");
            }
            this.Domain = domain;
            // to ensure "types" is required (not null)
            if (types == null)
            {
                throw new ArgumentNullException("types is a required property for SignPayloadRequest and cannot be null");
            }
            this.Types = types;
            // to ensure "primaryType" is required (not null)
            if (primaryType == null)
            {
                throw new ArgumentNullException("primaryType is a required property for SignPayloadRequest and cannot be null");
            }
            this.PrimaryType = primaryType;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for SignPayloadRequest and cannot be null");
            }
            this.Value = value;
            // to ensure "hash" is required (not null)
            if (hash == null)
            {
                throw new ArgumentNullException("hash is a required property for SignPayloadRequest and cannot be null");
            }
            this.Hash = hash;
        }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name = "domain", IsRequired = true, EmitDefaultValue = true)]
        public DomainData Domain { get; set; }

        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name = "types", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, List<TypedDataField>> Types { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryType
        /// </summary>
        /// <example>&quot;Mail&quot;</example>
        [DataMember(Name = "primaryType", IsRequired = true, EmitDefaultValue = true)]
        public string PrimaryType { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Value { get; set; }

        /// <summary>
        /// Hash to verify and that will be signed
        /// </summary>
        /// <value>Hash to verify and that will be signed</value>
        /// <example>&quot;0x3d8c6cab96bc24c87162c529bed5ba88b4617a7ea8bef66489a541d043ac6e8b&quot;</example>
        [DataMember(Name = "hash", IsRequired = true, EmitDefaultValue = true)]
        public string Hash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignPayloadRequest {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  PrimaryType: ").Append(PrimaryType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
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
            return this.Equals(input as SignPayloadRequest);
        }

        /// <summary>
        /// Returns true if SignPayloadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SignPayloadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignPayloadRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) &&
                (
                    this.Types == input.Types ||
                    this.Types != null &&
                    input.Types != null &&
                    this.Types.SequenceEqual(input.Types)
                ) &&
                (
                    this.PrimaryType == input.PrimaryType ||
                    (this.PrimaryType != null &&
                    this.PrimaryType.Equals(input.PrimaryType))
                ) &&
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
                ) &&
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
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
                if (this.Domain != null)
                {
                    hashCode = (hashCode * 59) + this.Domain.GetHashCode();
                }
                if (this.Types != null)
                {
                    hashCode = (hashCode * 59) + this.Types.GetHashCode();
                }
                if (this.PrimaryType != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryType.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}