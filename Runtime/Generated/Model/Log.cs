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
    /// Log
    /// </summary>
    [DataContract(Name = "Log")]
    public partial class Log : IEquatable<Log>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Log" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Log() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Log" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="projectId">projectId (required).</param>
        /// <param name="_event">_event (required).</param>
        /// <param name="requestBody">requestBody (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="responseTime">responseTime (required).</param>
        /// <param name="responseData">responseData (required).</param>
        public Log(string id = default(string), string timestamp = default(string), string projectId = default(string), string _event = default(string), Object requestBody = default(Object), double status = default(double), double responseTime = default(double), Object responseData = default(Object))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Log and cannot be null");
            }
            this.Id = id;
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new ArgumentNullException("timestamp is a required property for Log and cannot be null");
            }
            this.Timestamp = timestamp;
            // to ensure "projectId" is required (not null)
            if (projectId == null)
            {
                throw new ArgumentNullException("projectId is a required property for Log and cannot be null");
            }
            this.ProjectId = projectId;
            // to ensure "_event" is required (not null)
            if (_event == null)
            {
                throw new ArgumentNullException("_event is a required property for Log and cannot be null");
            }
            this.Event = _event;
            // to ensure "requestBody" is required (not null)
            if (requestBody == null)
            {
                throw new ArgumentNullException("requestBody is a required property for Log and cannot be null");
            }
            this.RequestBody = requestBody;
            this.Status = status;
            this.ResponseTime = responseTime;
            // to ensure "responseData" is required (not null)
            if (responseData == null)
            {
                throw new ArgumentNullException("responseData is a required property for Log and cannot be null");
            }
            this.ResponseData = responseData;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name = "project_id", IsRequired = true, EmitDefaultValue = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name = "event", IsRequired = true, EmitDefaultValue = true)]
        public string Event { get; set; }

        /// <summary>
        /// Gets or Sets RequestBody
        /// </summary>
        [DataMember(Name = "requestBody", IsRequired = true, EmitDefaultValue = true)]
        public Object RequestBody { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public double Status { get; set; }

        /// <summary>
        /// Gets or Sets ResponseTime
        /// </summary>
        [DataMember(Name = "responseTime", IsRequired = true, EmitDefaultValue = true)]
        public double ResponseTime { get; set; }

        /// <summary>
        /// Gets or Sets ResponseData
        /// </summary>
        [DataMember(Name = "responseData", IsRequired = true, EmitDefaultValue = true)]
        public Object ResponseData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Log {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  RequestBody: ").Append(RequestBody).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ResponseTime: ").Append(ResponseTime).Append("\n");
            sb.Append("  ResponseData: ").Append(ResponseData).Append("\n");
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
            return this.Equals(input as Log);
        }

        /// <summary>
        /// Returns true if Log instances are equal
        /// </summary>
        /// <param name="input">Instance of Log to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Log input)
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
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.RequestBody == input.RequestBody ||
                    (this.RequestBody != null &&
                    this.RequestBody.Equals(input.RequestBody))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.ResponseTime == input.ResponseTime ||
                    this.ResponseTime.Equals(input.ResponseTime)
                ) && 
                (
                    this.ResponseData == input.ResponseData ||
                    (this.ResponseData != null &&
                    this.ResponseData.Equals(input.ResponseData))
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
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.Event != null)
                {
                    hashCode = (hashCode * 59) + this.Event.GetHashCode();
                }
                if (this.RequestBody != null)
                {
                    hashCode = (hashCode * 59) + this.RequestBody.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.ResponseTime.GetHashCode();
                if (this.ResponseData != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseData.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
