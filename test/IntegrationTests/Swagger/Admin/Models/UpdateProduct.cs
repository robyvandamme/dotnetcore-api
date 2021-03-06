// <auto-generated>

namespace Swagger.Admin.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using Swagger.Admin;
    using System.Linq;

    public partial class UpdateProduct
    {
        /// <summary>
        /// Initializes a new instance of the UpdateProduct class.
        /// </summary>
        public UpdateProduct()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateProduct class.
        /// </summary>
        public UpdateProduct(string name, double listPrice, string productNumber, double standardCost, System.DateTime sellStartDate, System.Guid? id = default(System.Guid?), string color = default(string), string size = default(string), double? weight = default(double?), int? productCategoryId = default(int?), int? productModelId = default(int?), byte[] thumbNailPhoto = default(byte[]), string thumbnailPhotoFileName = default(string), System.DateTime? sellEndDate = default(System.DateTime?), System.DateTime? discontinuedDate = default(System.DateTime?), System.DateTime? modifiedDate = default(System.DateTime?))
        {
            Id = id;
            Name = name;
            Color = color;
            ListPrice = listPrice;
            ProductNumber = productNumber;
            Size = size;
            Weight = weight;
            ProductCategoryId = productCategoryId;
            ProductModelId = productModelId;
            ThumbNailPhoto = thumbNailPhoto;
            ThumbnailPhotoFileName = thumbnailPhotoFileName;
            StandardCost = standardCost;
            SellStartDate = sellStartDate;
            SellEndDate = sellEndDate;
            DiscontinuedDate = discontinuedDate;
            ModifiedDate = modifiedDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listPrice")]
        public double ListPrice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productNumber")]
        public string ProductNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productCategoryId")]
        public int? ProductCategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productModelId")]
        public int? ProductModelId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumbNailPhoto")]
        public byte[] ThumbNailPhoto { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumbnailPhotoFileName")]
        public string ThumbnailPhotoFileName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardCost")]
        public double StandardCost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sellStartDate")]
        public System.DateTime SellStartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sellEndDate")]
        public System.DateTime? SellEndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discontinuedDate")]
        public System.DateTime? DiscontinuedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedDate")]
        public System.DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (ProductNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProductNumber");
            }
            if (Name != null)
            {
                if (Name.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 50);
                }
            }
            if (Color != null)
            {
                if (Color.Length > 15)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Color", 15);
                }
            }
            if (ProductNumber != null)
            {
                if (ProductNumber.Length > 25)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ProductNumber", 25);
                }
            }
            if (Size != null)
            {
                if (Size.Length > 5)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Size", 5);
                }
            }
            if (ThumbnailPhotoFileName != null)
            {
                if (ThumbnailPhotoFileName.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ThumbnailPhotoFileName", 50);
                }
            }
        }
    }
}
