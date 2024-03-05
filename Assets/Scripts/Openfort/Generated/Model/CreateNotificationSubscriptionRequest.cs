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
    /// CreateNotificationSubscriptionRequest
    /// </summary>
    [DataContract(Name = "CreateNotificationSubscriptionRequest")]
    public partial class CreateNotificationSubscriptionRequest : IEquatable<CreateNotificationSubscriptionRequest>
    {

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public SubscriptionType Method { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNotificationSubscriptionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateNotificationSubscriptionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNotificationSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="notification">The notification ID (starts with not_). (required).</param>
        /// <param name="method">method (required).</param>
        /// <param name="target">The receiver of notifications. (required).</param>
        public CreateNotificationSubscriptionRequest(string notification = default(string), SubscriptionType method = default(SubscriptionType), string target = default(string))
        {
            // to ensure "notification" is required (not null)
            if (notification == null)
            {
                throw new ArgumentNullException("notification is a required property for CreateNotificationSubscriptionRequest and cannot be null");
            }
            this.Notification = notification;
            this.Method = method;
            // to ensure "target" is required (not null)
            if (target == null)
            {
                throw new ArgumentNullException("target is a required property for CreateNotificationSubscriptionRequest and cannot be null");
            }
            this.Target = target;
        }

        /// <summary>
        /// The notification ID (starts with not_).
        /// </summary>
        /// <value>The notification ID (starts with not_).</value>
        /// <example>&quot;not_e0b84653-1741-4a3d-9e91-2b0fd2942f60&quot;</example>
        [DataMember(Name = "notification", IsRequired = true, EmitDefaultValue = true)]
        public string Notification { get; set; }

        /// <summary>
        /// The receiver of notifications.
        /// </summary>
        /// <value>The receiver of notifications.</value>
        /// <example>&quot;jaume@openfort.xyz&quot;</example>
        [DataMember(Name = "target", IsRequired = true, EmitDefaultValue = true)]
        public string Target { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateNotificationSubscriptionRequest {\n");
            sb.Append("  Notification: ").Append(Notification).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(input as CreateNotificationSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if CreateNotificationSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateNotificationSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateNotificationSubscriptionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Notification == input.Notification ||
                    (this.Notification != null &&
                    this.Notification.Equals(input.Notification))
                ) && 
                (
                    this.Method == input.Method ||
                    this.Method.Equals(input.Method)
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
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
                if (this.Notification != null)
                {
                    hashCode = (hashCode * 59) + this.Notification.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Method.GetHashCode();
                if (this.Target != null)
                {
                    hashCode = (hashCode * 59) + this.Target.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
