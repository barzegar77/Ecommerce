﻿namespace Ecommerce.Models.Media
{
    public partial class PictureBinary 
    {
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the picture binary
        /// </summary>
        public byte[] BinaryData { get; set; }

        /// <summary>
        /// Gets or sets the picture identifier
        /// </summary>
        public int PictureId { get; set; }
    }
}
