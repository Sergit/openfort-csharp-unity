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
    /// Fragment
    /// </summary>
    [DataContract(Name = "Fragment")]
    public partial class Fragment : IEquatable<Fragment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fragment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Fragment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Fragment" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="inputs">inputs (required).</param>
        /// <param name="isFragment">isFragment (required).</param>
        public Fragment(string type = default(string), string name = default(string), List<ParamType> inputs = default(List<ParamType>), bool isFragment = default(bool))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for Fragment and cannot be null");
            }
            this.Type = type;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Fragment and cannot be null");
            }
            this.Name = name;
            // to ensure "inputs" is required (not null)
            if (inputs == null)
            {
                throw new ArgumentNullException("inputs is a required property for Fragment and cannot be null");
            }
            this.Inputs = inputs;
            this.IsFragment = isFragment;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name = "inputs", IsRequired = true, EmitDefaultValue = true)]
        public List<ParamType> Inputs { get; set; }

        /// <summary>
        /// Gets or Sets IsFragment
        /// </summary>
        [DataMember(Name = "_isFragment", IsRequired = true, EmitDefaultValue = true)]
        public bool IsFragment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Fragment {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  IsFragment: ").Append(IsFragment).Append("\n");
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
            return this.Equals(input as Fragment);
        }

        /// <summary>
        /// Returns true if Fragment instances are equal
        /// </summary>
        /// <param name="input">Instance of Fragment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Fragment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.IsFragment == input.IsFragment ||
                    this.IsFragment.Equals(input.IsFragment)
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Inputs != null)
                {
                    hashCode = (hashCode * 59) + this.Inputs.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsFragment.GetHashCode();
                return hashCode;
            }
        }

    }

}