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
    /// PolicyRuleUpdateRequest
    /// </summary>
    [DataContract(Name = "PolicyRuleUpdateRequest")]
    public partial class PolicyRuleUpdateRequest : IEquatable<PolicyRuleUpdateRequest>
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public PolicySchema? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyRuleUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PolicyRuleUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyRuleUpdateRequest" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="functionName">functionName (required).</param>
        /// <param name="policy">policy.</param>
        /// <param name="project">project.</param>
        /// <param name="contract">contract (required).</param>
        public PolicyRuleUpdateRequest(PolicySchema? type = default(PolicySchema?), string functionName = default(string), string policy = default(string), string project = default(string), string contract = default(string))
        {
            // to ensure "functionName" is required (not null)
            if (functionName == null)
            {
                throw new ArgumentNullException("functionName is a required property for PolicyRuleUpdateRequest and cannot be null");
            }
            this.FunctionName = functionName;
            // to ensure "contract" is required (not null)
            if (contract == null)
            {
                throw new ArgumentNullException("contract is a required property for PolicyRuleUpdateRequest and cannot be null");
            }
            this.Contract = contract;
            this.Type = type;
            this.Policy = policy;
            this.Project = project;
        }

        /// <summary>
        /// Gets or Sets FunctionName
        /// </summary>
        [DataMember(Name = "function_name", IsRequired = true, EmitDefaultValue = true)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public string Policy { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", EmitDefaultValue = false)]
        public string Project { get; set; }

        /// <summary>
        /// Gets or Sets Contract
        /// </summary>
        [DataMember(Name = "contract", IsRequired = true, EmitDefaultValue = true)]
        public string Contract { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PolicyRuleUpdateRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FunctionName: ").Append(FunctionName).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
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
            return this.Equals(input as PolicyRuleUpdateRequest);
        }

        /// <summary>
        /// Returns true if PolicyRuleUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyRuleUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyRuleUpdateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.FunctionName == input.FunctionName ||
                    (this.FunctionName != null &&
                    this.FunctionName.Equals(input.FunctionName))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.FunctionName != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionName.GetHashCode();
                }
                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
                }
                if (this.Project != null)
                {
                    hashCode = (hashCode * 59) + this.Project.GetHashCode();
                }
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}