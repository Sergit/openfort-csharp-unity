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
    /// RevokeSessionRequest
    /// </summary>
    [DataContract(Name = "RevokeSessionRequest")]
    public partial class RevokeSessionRequest : IEquatable<RevokeSessionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeSessionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RevokeSessionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeSessionRequest" /> class.
        /// </summary>
        /// <param name="address">The address of the session key to revoke. (required).</param>
        /// <param name="policy">ID of the Policy that defines the gas sponsorship strategy (starts with &#x60;pol_&#x60;). If no Policy is provided, the own Account native token funds will be used to pay for gas..</param>
        /// <param name="optimistic">Whether the transactionIntent is optimistic (resolve before it arrives on chain) or not..</param>
        /// <param name="chainId">The chain ID. Must be a [supported chain](/chains). (required).</param>
        /// <param name="player">The player ID (starts with pla_). (required).</param>
        public RevokeSessionRequest(string address = default(string), string policy = default(string), bool optimistic = default(bool), int chainId = default(int), string player = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for RevokeSessionRequest and cannot be null");
            }
            this.Address = address;
            this.ChainId = chainId;
            // to ensure "player" is required (not null)
            if (player == null)
            {
                throw new ArgumentNullException("player is a required property for RevokeSessionRequest and cannot be null");
            }
            this.Player = player;
            this.Policy = policy;
            this.Optimistic = optimistic;
        }

        /// <summary>
        /// The address of the session key to revoke.
        /// </summary>
        /// <value>The address of the session key to revoke.</value>
        /// <example>&quot;0x1234567890abcdef1234567890abcdef12345678&quot;</example>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// ID of the Policy that defines the gas sponsorship strategy (starts with &#x60;pol_&#x60;). If no Policy is provided, the own Account native token funds will be used to pay for gas.
        /// </summary>
        /// <value>ID of the Policy that defines the gas sponsorship strategy (starts with &#x60;pol_&#x60;). If no Policy is provided, the own Account native token funds will be used to pay for gas.</value>
        /// <example>&quot;pol_7e07ae30-2a4d-48fa-803f-361da94905dd&quot;</example>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public string Policy { get; set; }

        /// <summary>
        /// Whether the transactionIntent is optimistic (resolve before it arrives on chain) or not.
        /// </summary>
        /// <value>Whether the transactionIntent is optimistic (resolve before it arrives on chain) or not.</value>
        /// <example>true</example>
        [DataMember(Name = "optimistic", EmitDefaultValue = true)]
        public bool Optimistic { get; set; }

        /// <summary>
        /// The chain ID. Must be a [supported chain](/chains).
        /// </summary>
        /// <value>The chain ID. Must be a [supported chain](/chains).</value>
        /// <example>80002</example>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public int ChainId { get; set; }

        /// <summary>
        /// The player ID (starts with pla_).
        /// </summary>
        /// <value>The player ID (starts with pla_).</value>
        /// <example>&quot;pla_e0b84653-1741-4a3d-9e91-2b0fd2942f60&quot;</example>
        [DataMember(Name = "player", IsRequired = true, EmitDefaultValue = true)]
        public string Player { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RevokeSessionRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
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
            return this.Equals(input as RevokeSessionRequest);
        }

        /// <summary>
        /// Returns true if RevokeSessionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RevokeSessionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RevokeSessionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) &&
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) &&
                (
                    this.Optimistic == input.Optimistic ||
                    this.Optimistic.Equals(input.Optimistic)
                ) &&
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) &&
                (
                    this.Player == input.Player ||
                    (this.Player != null &&
                    this.Player.Equals(input.Player))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Optimistic.GetHashCode();
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.Player != null)
                {
                    hashCode = (hashCode * 59) + this.Player.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}