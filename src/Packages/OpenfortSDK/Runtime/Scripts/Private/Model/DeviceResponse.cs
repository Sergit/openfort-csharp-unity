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
    /// DeviceResponse
    /// </summary>
    [DataContract(Name = "DeviceResponse")]
    public partial class DeviceResponse : IEquatable<DeviceResponse>
    {

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public EntityTypeDEVICE Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceResponse" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="_object">_object (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="account">account (required).</param>
        /// <param name="share">share (required).</param>
        /// <param name="isPrimary">isPrimary (required).</param>
        public DeviceResponse(string id = default(string), EntityTypeDEVICE _object = default(EntityTypeDEVICE), int createdAt = default(int), string account = default(string), string share = default(string), bool isPrimary = default(bool))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DeviceResponse and cannot be null");
            }
            this.Id = id;
            this.Object = _object;
            this.CreatedAt = createdAt;
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new ArgumentNullException("account is a required property for DeviceResponse and cannot be null");
            }
            this.Account = account;
            // to ensure "share" is required (not null)
            if (share == null)
            {
                throw new ArgumentNullException("share is a required property for DeviceResponse and cannot be null");
            }
            this.Share = share;
            this.IsPrimary = isPrimary;
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
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name = "share", IsRequired = true, EmitDefaultValue = true)]
        public string Share { get; set; }

        /// <summary>
        /// Gets or Sets IsPrimary
        /// </summary>
        [DataMember(Name = "isPrimary", IsRequired = true, EmitDefaultValue = true)]
        public bool IsPrimary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  IsPrimary: ").Append(IsPrimary).Append("\n");
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
            return this.Equals(input as DeviceResponse);
        }

        /// <summary>
        /// Returns true if DeviceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceResponse input)
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
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) &&
                (
                    this.Share == input.Share ||
                    (this.Share != null &&
                    this.Share.Equals(input.Share))
                ) &&
                (
                    this.IsPrimary == input.IsPrimary ||
                    this.IsPrimary.Equals(input.IsPrimary)
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
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.Share != null)
                {
                    hashCode = (hashCode * 59) + this.Share.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsPrimary.GetHashCode();
                return hashCode;
            }
        }

    }

}