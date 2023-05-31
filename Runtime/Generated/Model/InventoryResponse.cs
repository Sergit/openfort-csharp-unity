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
    /// InventoryResponse
    /// </summary>
    [DataContract(Name = "InventoryResponse")]
    public partial class InventoryResponse : IEquatable<InventoryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InventoryResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryResponse" /> class.
        /// </summary>
        /// <param name="_object">_object (required).</param>
        /// <param name="nftAssets">nftAssets.</param>
        /// <param name="nativeAsset">nativeAsset.</param>
        /// <param name="tokenAssets">tokenAssets.</param>
        public InventoryResponse(string _object = default(string), List<AssetInventory> nftAssets = default(List<AssetInventory>), AssetInventory nativeAsset = default(AssetInventory), List<AssetInventory> tokenAssets = default(List<AssetInventory>))
        {
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new ArgumentNullException("_object is a required property for InventoryResponse and cannot be null");
            }
            this.Object = _object;
            this.NftAssets = nftAssets;
            this.NativeAsset = nativeAsset;
            this.TokenAssets = tokenAssets;
        }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets NftAssets
        /// </summary>
        [DataMember(Name = "nft_assets", EmitDefaultValue = false)]
        public List<AssetInventory> NftAssets { get; set; }

        /// <summary>
        /// Gets or Sets NativeAsset
        /// </summary>
        [DataMember(Name = "native_asset", EmitDefaultValue = false)]
        public AssetInventory NativeAsset { get; set; }

        /// <summary>
        /// Gets or Sets TokenAssets
        /// </summary>
        [DataMember(Name = "token_assets", EmitDefaultValue = false)]
        public List<AssetInventory> TokenAssets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InventoryResponse {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  NftAssets: ").Append(NftAssets).Append("\n");
            sb.Append("  NativeAsset: ").Append(NativeAsset).Append("\n");
            sb.Append("  TokenAssets: ").Append(TokenAssets).Append("\n");
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
            return this.Equals(input as InventoryResponse);
        }

        /// <summary>
        /// Returns true if InventoryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.NftAssets == input.NftAssets ||
                    this.NftAssets != null &&
                    input.NftAssets != null &&
                    this.NftAssets.SequenceEqual(input.NftAssets)
                ) && 
                (
                    this.NativeAsset == input.NativeAsset ||
                    (this.NativeAsset != null &&
                    this.NativeAsset.Equals(input.NativeAsset))
                ) && 
                (
                    this.TokenAssets == input.TokenAssets ||
                    this.TokenAssets != null &&
                    input.TokenAssets != null &&
                    this.TokenAssets.SequenceEqual(input.TokenAssets)
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
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                if (this.NftAssets != null)
                {
                    hashCode = (hashCode * 59) + this.NftAssets.GetHashCode();
                }
                if (this.NativeAsset != null)
                {
                    hashCode = (hashCode * 59) + this.NativeAsset.GetHashCode();
                }
                if (this.TokenAssets != null)
                {
                    hashCode = (hashCode * 59) + this.TokenAssets.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
