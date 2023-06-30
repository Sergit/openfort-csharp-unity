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
    /// AccountRequest
    /// </summary>
    [DataContract(Name = "AccountRequest")]
    public partial class AccountRequest : IEquatable<AccountRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRequest" /> class.
        /// </summary>
        /// <param name="project">The project ID.</param>
        /// <param name="chainId">The chain_id (required).</param>
        /// <param name="player">The player ID (required).</param>
        /// <param name="externalOwnerAddress">The address of the external owner.</param>
        public AccountRequest(string project = default(string), double chainId = default(double), string player = default(string), string externalOwnerAddress = default(string))
        {
            this.ChainId = chainId;
            // to ensure "player" is required (not null)
            if (player == null)
            {
                throw new ArgumentNullException("player is a required property for AccountRequest and cannot be null");
            }
            this.Player = player;
            this.Project = project;
            this.ExternalOwnerAddress = externalOwnerAddress;
        }

        /// <summary>
        /// The project ID
        /// </summary>
        /// <value>The project ID</value>
        [DataMember(Name = "project", EmitDefaultValue = false)]
        public string Project { get; set; }

        /// <summary>
        /// The chain_id
        /// </summary>
        /// <value>The chain_id</value>
        [DataMember(Name = "chain_id", IsRequired = true, EmitDefaultValue = true)]
        public double ChainId { get; set; }

        /// <summary>
        /// The player ID
        /// </summary>
        /// <value>The player ID</value>
        [DataMember(Name = "player", IsRequired = true, EmitDefaultValue = true)]
        public string Player { get; set; }

        /// <summary>
        /// The address of the external owner
        /// </summary>
        /// <value>The address of the external owner</value>
        [DataMember(Name = "external_owner_address", EmitDefaultValue = false)]
        public string ExternalOwnerAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountRequest {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  ExternalOwnerAddress: ").Append(ExternalOwnerAddress).Append("\n");
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
            return this.Equals(input as AccountRequest);
        }

        /// <summary>
        /// Returns true if AccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.Player == input.Player ||
                    (this.Player != null &&
                    this.Player.Equals(input.Player))
                ) && 
                (
                    this.ExternalOwnerAddress == input.ExternalOwnerAddress ||
                    (this.ExternalOwnerAddress != null &&
                    this.ExternalOwnerAddress.Equals(input.ExternalOwnerAddress))
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
                if (this.Project != null)
                {
                    hashCode = (hashCode * 59) + this.Project.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.Player != null)
                {
                    hashCode = (hashCode * 59) + this.Player.GetHashCode();
                }
                if (this.ExternalOwnerAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalOwnerAddress.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}