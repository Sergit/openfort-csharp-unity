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
    /// Account
    /// </summary>
    [DataContract(Name = "Account")]
    public partial class Account : IEquatable<Account>
    {

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public EntityTypeACCOUNT Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Account() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="_object">_object (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="address">address (required).</param>
        /// <param name="ownerAddress">ownerAddress (required).</param>
        /// <param name="deployed">deployed (required).</param>
        /// <param name="custodial">custodial (required).</param>
        /// <param name="embeddedSigner">embeddedSigner (required).</param>
        /// <param name="chainId">The chain ID. (required).</param>
        /// <param name="accountType">accountType (required).</param>
        /// <param name="pendingOwnerAddress">pendingOwnerAddress.</param>
        /// <param name="transactionIntents">transactionIntents.</param>
        /// <param name="player">player (required).</param>
        public Account(string id = default(string), EntityTypeACCOUNT _object = default(EntityTypeACCOUNT), int createdAt = default(int), string address = default(string), string ownerAddress = default(string), bool deployed = default(bool), bool custodial = default(bool), bool embeddedSigner = default(bool), int chainId = default(int), string accountType = default(string), string pendingOwnerAddress = default(string), List<EntityIdResponse> transactionIntents = default(List<EntityIdResponse>), EntityIdResponse player = default(EntityIdResponse))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Account and cannot be null");
            }
            this.Id = id;
            this.Object = _object;
            this.CreatedAt = createdAt;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for Account and cannot be null");
            }
            this.Address = address;
            // to ensure "ownerAddress" is required (not null)
            if (ownerAddress == null)
            {
                throw new ArgumentNullException("ownerAddress is a required property for Account and cannot be null");
            }
            this.OwnerAddress = ownerAddress;
            this.Deployed = deployed;
            this.Custodial = custodial;
            this.EmbeddedSigner = embeddedSigner;
            this.ChainId = chainId;
            // to ensure "accountType" is required (not null)
            if (accountType == null)
            {
                throw new ArgumentNullException("accountType is a required property for Account and cannot be null");
            }
            this.AccountType = accountType;
            // to ensure "player" is required (not null)
            if (player == null)
            {
                throw new ArgumentNullException("player is a required property for Account and cannot be null");
            }
            this.Player = player;
            this.PendingOwnerAddress = pendingOwnerAddress;
            this.TransactionIntents = transactionIntents;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public int CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets OwnerAddress
        /// </summary>
        [DataMember(Name = "ownerAddress", IsRequired = true, EmitDefaultValue = true)]
        public string OwnerAddress { get; set; }

        /// <summary>
        /// Gets or Sets Deployed
        /// </summary>
        [DataMember(Name = "deployed", IsRequired = true, EmitDefaultValue = true)]
        public bool Deployed { get; set; }

        /// <summary>
        /// Gets or Sets Custodial
        /// </summary>
        [DataMember(Name = "custodial", IsRequired = true, EmitDefaultValue = true)]
        public bool Custodial { get; set; }

        /// <summary>
        /// Gets or Sets EmbeddedSigner
        /// </summary>
        [DataMember(Name = "embeddedSigner", IsRequired = true, EmitDefaultValue = true)]
        public bool EmbeddedSigner { get; set; }

        /// <summary>
        /// The chain ID.
        /// </summary>
        /// <value>The chain ID.</value>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public int ChainId { get; set; }

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name = "accountType", IsRequired = true, EmitDefaultValue = true)]
        public string AccountType { get; set; }

        /// <summary>
        /// Gets or Sets PendingOwnerAddress
        /// </summary>
        [DataMember(Name = "pendingOwnerAddress", EmitDefaultValue = false)]
        public string PendingOwnerAddress { get; set; }

        /// <summary>
        /// Gets or Sets TransactionIntents
        /// </summary>
        [DataMember(Name = "transactionIntents", EmitDefaultValue = false)]
        public List<EntityIdResponse> TransactionIntents { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", IsRequired = true, EmitDefaultValue = true)]
        public EntityIdResponse Player { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  OwnerAddress: ").Append(OwnerAddress).Append("\n");
            sb.Append("  Deployed: ").Append(Deployed).Append("\n");
            sb.Append("  Custodial: ").Append(Custodial).Append("\n");
            sb.Append("  EmbeddedSigner: ").Append(EmbeddedSigner).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  PendingOwnerAddress: ").Append(PendingOwnerAddress).Append("\n");
            sb.Append("  TransactionIntents: ").Append(TransactionIntents).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
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
                    this.Object == input.Object ||
                    this.Object.Equals(input.Object)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.OwnerAddress == input.OwnerAddress ||
                    (this.OwnerAddress != null &&
                    this.OwnerAddress.Equals(input.OwnerAddress))
                ) && 
                (
                    this.Deployed == input.Deployed ||
                    this.Deployed.Equals(input.Deployed)
                ) && 
                (
                    this.Custodial == input.Custodial ||
                    this.Custodial.Equals(input.Custodial)
                ) && 
                (
                    this.EmbeddedSigner == input.EmbeddedSigner ||
                    this.EmbeddedSigner.Equals(input.EmbeddedSigner)
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.PendingOwnerAddress == input.PendingOwnerAddress ||
                    (this.PendingOwnerAddress != null &&
                    this.PendingOwnerAddress.Equals(input.PendingOwnerAddress))
                ) && 
                (
                    this.TransactionIntents == input.TransactionIntents ||
                    this.TransactionIntents != null &&
                    input.TransactionIntents != null &&
                    this.TransactionIntents.SequenceEqual(input.TransactionIntents)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Object.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.OwnerAddress != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deployed.GetHashCode();
                hashCode = (hashCode * 59) + this.Custodial.GetHashCode();
                hashCode = (hashCode * 59) + this.EmbeddedSigner.GetHashCode();
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.AccountType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                }
                if (this.PendingOwnerAddress != null)
                {
                    hashCode = (hashCode * 59) + this.PendingOwnerAddress.GetHashCode();
                }
                if (this.TransactionIntents != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionIntents.GetHashCode();
                }
                if (this.Player != null)
                {
                    hashCode = (hashCode * 59) + this.Player.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
