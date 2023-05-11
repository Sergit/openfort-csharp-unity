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
using OpenAPIDateConverter = OpenfortSdk.Client.OpenAPIDateConverter;

namespace OpenfortSdk.Model
{
    /// <summary>
    /// AllowFunctionResponse
    /// </summary>
    [DataContract(Name = "AllowFunctionResponse")]
    public partial class AllowFunctionResponse : IEquatable<AllowFunctionResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllowFunctionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AllowFunctionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllowFunctionResponse" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="functionName">functionName (required).</param>
        /// <param name="contract">contract (required).</param>
        /// <param name="_object">_object (required).</param>
        public AllowFunctionResponse(string id = default(string), DateTime createdAt = default(DateTime), string type = default(string), string functionName = default(string), ContractResponse contract = default(ContractResponse), string _object = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AllowFunctionResponse and cannot be null");
            }
            this.Id = id;
            this.CreatedAt = createdAt;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for AllowFunctionResponse and cannot be null");
            }
            this.Type = type;
            // to ensure "functionName" is required (not null)
            if (functionName == null)
            {
                throw new ArgumentNullException("functionName is a required property for AllowFunctionResponse and cannot be null");
            }
            this.FunctionName = functionName;
            // to ensure "contract" is required (not null)
            if (contract == null)
            {
                throw new ArgumentNullException("contract is a required property for AllowFunctionResponse and cannot be null");
            }
            this.Contract = contract;
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new ArgumentNullException("_object is a required property for AllowFunctionResponse and cannot be null");
            }
            this.Object = _object;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets FunctionName
        /// </summary>
        [DataMember(Name = "function_name", IsRequired = true, EmitDefaultValue = true)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Gets or Sets Contract
        /// </summary>
        [DataMember(Name = "contract", IsRequired = true, EmitDefaultValue = true)]
        public ContractResponse Contract { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string Object { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AllowFunctionResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FunctionName: ").Append(FunctionName).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
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
            return this.Equals(input as AllowFunctionResponse);
        }

        /// <summary>
        /// Returns true if AllowFunctionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AllowFunctionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllowFunctionResponse input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.FunctionName == input.FunctionName ||
                    (this.FunctionName != null &&
                    this.FunctionName.Equals(input.FunctionName))
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.FunctionName != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionName.GetHashCode();
                }
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}