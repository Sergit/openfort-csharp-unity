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
    /// WithdrawalPolicyRequest
    /// </summary>
    [DataContract(Name = "WithdrawalPolicyRequest")]
    public partial class WithdrawalPolicyRequest : IEquatable<WithdrawalPolicyRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawalPolicyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WithdrawalPolicyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawalPolicyRequest" /> class.
        /// </summary>
        /// <param name="account">ID of the Dev Account this TransactionIntent will send the specified amount of tokens to (starts with &#x60;dac_&#x60;). (required).</param>
        /// <param name="amount">Amount in WEI to withdraw (i.e. factor 10^18).. (required).</param>
        public WithdrawalPolicyRequest(string account = default(string), string amount = default(string))
        {
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new ArgumentNullException("account is a required property for WithdrawalPolicyRequest and cannot be null");
            }
            this.Account = account;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for WithdrawalPolicyRequest and cannot be null");
            }
            this.Amount = amount;
        }

        /// <summary>
        /// ID of the Dev Account this TransactionIntent will send the specified amount of tokens to (starts with &#x60;dac_&#x60;).
        /// </summary>
        /// <value>ID of the Dev Account this TransactionIntent will send the specified amount of tokens to (starts with &#x60;dac_&#x60;).</value>
        /// <example>&quot;dac_e1b24353-1741-4a3d-9e91-2b0fd2942f60&quot;</example>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public string Account { get; set; }

        /// <summary>
        /// Amount in WEI to withdraw (i.e. factor 10^18)..
        /// </summary>
        /// <value>Amount in WEI to withdraw (i.e. factor 10^18)..</value>
        /// <example>&quot;300000&quot;</example>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WithdrawalPolicyRequest {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as WithdrawalPolicyRequest);
        }

        /// <summary>
        /// Returns true if WithdrawalPolicyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WithdrawalPolicyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WithdrawalPolicyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
