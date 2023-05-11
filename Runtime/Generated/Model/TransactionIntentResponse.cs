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
    /// TransactionIntentResponse
    /// </summary>
    [DataContract(Name = "TransactionIntentResponse")]
    public partial class TransactionIntentResponse : IEquatable<TransactionIntentResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionIntentResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionIntentResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionIntentResponse" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="chainId">chainId (required).</param>
        /// <param name="userOperationHash">userOperationHash (required).</param>
        /// <param name="userOperation">userOperation.</param>
        /// <param name="policy">policy (required).</param>
        /// <param name="player">player (required).</param>
        /// <param name="account">account.</param>
        /// <param name="transactions">transactions (required).</param>
        /// <param name="response">response (required).</param>
        /// <param name="_object">_object (required).</param>
        public TransactionIntentResponse(string id = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), double chainId = default(double), string userOperationHash = default(string), UserOpResult userOperation = default(UserOpResult), string policy = default(string), string player = default(string), string account = default(string), List<Interaction> transactions = default(List<Interaction>), ResponseResponse response = default(ResponseResponse), string _object = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TransactionIntentResponse and cannot be null");
            }
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ChainId = chainId;
            // to ensure "userOperationHash" is required (not null)
            if (userOperationHash == null)
            {
                throw new ArgumentNullException("userOperationHash is a required property for TransactionIntentResponse and cannot be null");
            }
            this.UserOperationHash = userOperationHash;
            // to ensure "policy" is required (not null)
            if (policy == null)
            {
                throw new ArgumentNullException("policy is a required property for TransactionIntentResponse and cannot be null");
            }
            this.Policy = policy;
            // to ensure "player" is required (not null)
            if (player == null)
            {
                throw new ArgumentNullException("player is a required property for TransactionIntentResponse and cannot be null");
            }
            this.Player = player;
            // to ensure "transactions" is required (not null)
            if (transactions == null)
            {
                throw new ArgumentNullException("transactions is a required property for TransactionIntentResponse and cannot be null");
            }
            this.Transactions = transactions;
            // to ensure "response" is required (not null)
            if (response == null)
            {
                throw new ArgumentNullException("response is a required property for TransactionIntentResponse and cannot be null");
            }
            this.Response = response;
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new ArgumentNullException("_object is a required property for TransactionIntentResponse and cannot be null");
            }
            this.Object = _object;
            this.UserOperation = userOperation;
            this.Account = account;
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
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chain_id", IsRequired = true, EmitDefaultValue = true)]
        public double ChainId { get; set; }

        /// <summary>
        /// Gets or Sets UserOperationHash
        /// </summary>
        [DataMember(Name = "user_operation_hash", IsRequired = true, EmitDefaultValue = true)]
        public string UserOperationHash { get; set; }

        /// <summary>
        /// Gets or Sets UserOperation
        /// </summary>
        [DataMember(Name = "user_operation", EmitDefaultValue = false)]
        public UserOpResult UserOperation { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name = "policy", IsRequired = true, EmitDefaultValue = true)]
        public string Policy { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", IsRequired = true, EmitDefaultValue = true)]
        public string Player { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", IsRequired = true, EmitDefaultValue = true)]
        public List<Interaction> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name = "response", IsRequired = true, EmitDefaultValue = true)]
        public ResponseResponse Response { get; set; }

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
            sb.Append("class TransactionIntentResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  UserOperationHash: ").Append(UserOperationHash).Append("\n");
            sb.Append("  UserOperation: ").Append(UserOperation).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
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
            return this.Equals(input as TransactionIntentResponse);
        }

        /// <summary>
        /// Returns true if TransactionIntentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionIntentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionIntentResponse input)
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
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.UserOperationHash == input.UserOperationHash ||
                    (this.UserOperationHash != null &&
                    this.UserOperationHash.Equals(input.UserOperationHash))
                ) && 
                (
                    this.UserOperation == input.UserOperation ||
                    (this.UserOperation != null &&
                    this.UserOperation.Equals(input.UserOperation))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.Player == input.Player ||
                    (this.Player != null &&
                    this.Player.Equals(input.Player))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
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
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.UserOperationHash != null)
                {
                    hashCode = (hashCode * 59) + this.UserOperationHash.GetHashCode();
                }
                if (this.UserOperation != null)
                {
                    hashCode = (hashCode * 59) + this.UserOperation.GetHashCode();
                }
                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
                }
                if (this.Player != null)
                {
                    hashCode = (hashCode * 59) + this.Player.GetHashCode();
                }
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.Transactions != null)
                {
                    hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
                }
                if (this.Response != null)
                {
                    hashCode = (hashCode * 59) + this.Response.GetHashCode();
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