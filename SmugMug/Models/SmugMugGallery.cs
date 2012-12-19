// ***********************************************************************
// Assembly         : Infinitas.FeedModlr
// Author           : Chase Florell
// Created          : 12-14-2012
//
// Last Modified By : Chase Florell
// Last Modified On : 12-18-2012
// ***********************************************************************
// <copyright file="SmugMugGallery.cs" company="Infinitas Advantage">
//     Copyright (c) Infinitas Advantage. All rights reserved.
// </copyright>
// <summary>
// This code file is licensed under the MIT License.
// http://opensource.org/licenses/MIT
// </summary>
// ***********************************************************************
namespace Infinitas.FeedModlr.SmugMug.Models
{
    using System.Collections.Generic;
    /// <summary>
    /// Class SmugMugGallery
    /// </summary>
    /// <remarks>This class is a more natural feeling model object for the SmugMug Gallery.</remarks>
    public class SmugMugGallery
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        /// <value>The link.</value>
        public string Link { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>The icon.</value>
        public string Icon { get; set; }
        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
        public string Category { get; set; }
        /// <summary>
        /// Gets or sets the pub date.
        /// </summary>
        /// <value>The pub date.</value>
        public string PubDate { get; set; }
        /// <summary>
        /// Gets or sets the last build date.
        /// </summary>
        /// <value>The last build date.</value>
        public string LastBuildDate { get; set; }
        /// <summary>
        /// Gets or sets the generator.
        /// </summary>
        /// <value>The generator.</value>
        public string Generator { get; set; }
        /// <summary>
        /// Gets or sets the copyright.
        /// </summary>
        /// <value>The copyright.</value>
        public string Copyright { get; set; }
        /// <summary>
        /// Gets or sets the gallery image.
        /// </summary>
        /// <value>The gallery image.</value>
        public _GalleryImage GalleryImage { get; set; }
        /// <summary>
        /// Class _GalleryImage
        /// </summary>
        public class _GalleryImage
        {
            /// <summary>
            /// Gets or sets the URL.
            /// </summary>
            /// <value>The URL.</value>
            public string Url { get; set; }
            /// <summary>
            /// Gets or sets the title.
            /// </summary>
            /// <value>The title.</value>
            public string Title { get; set; }
            /// <summary>
            /// Gets or sets the link.
            /// </summary>
            /// <value>The link.</value>
            public string Link { get; set; }
        }
        /// <summary>
        /// Gets or sets the atom links.
        /// </summary>
        /// <value>The atom links.</value>
        public _AtomLinks AtomLinks { get; set; }
        /// <summary>
        /// Class _AtomLinks
        /// </summary>
        public class _AtomLinks
        {
            /// <summary>
            /// Gets or sets the rel.
            /// </summary>
            /// <value>The rel.</value>
            public string Rel { get; set; }
            /// <summary>
            /// Gets or sets the type.
            /// </summary>
            /// <value>The type.</value>
            public string Type { get; set; }
            /// <summary>
            /// Gets or sets the href.
            /// </summary>
            /// <value>The href.</value>
            public string Href { get; set; }
        }
        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>The images.</value>
        public List<Image> Images { get; set; }
        /// <summary>
        /// Class Image
        /// </summary>
        public class Image
        {
            /// <summary>
            /// Gets or sets the title.
            /// </summary>
            /// <value>The title.</value>
            public string Title { get; set; }
            /// <summary>
            /// Gets or sets the link.
            /// </summary>
            /// <value>The link.</value>
            public string Link { get; set; }
            /// <summary>
            /// Gets or sets the description.
            /// </summary>
            /// <value>The description.</value>
            public string Description { get; set; }
            /// <summary>
            /// Gets or sets the category.
            /// </summary>
            /// <value>The category.</value>
            public string Category { get; set; }
            /// <summary>
            /// Gets or sets the pub date.
            /// </summary>
            /// <value>The pub date.</value>
            public string PubDate { get; set; }
            /// <summary>
            /// Gets or sets the author.
            /// </summary>
            /// <value>The author.</value>
            public string Author { get; set; }
            /// <summary>
            /// Gets or sets the GUID.
            /// </summary>
            /// <value>The GUID.</value>
            public _Guid Guid { get; set; }
            /// <summary>
            /// Class _Guid
            /// </summary>
            public class _Guid
            {
                /// <summary>
                /// Gets or sets the value.
                /// </summary>
                /// <value>The value.</value>
                public string value { get; set; }
                /// <summary>
                /// Returns a <see cref="System.String" /> that represents this instance.
                /// </summary>
                /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
                public override string ToString()
                {
                    return value.ToString();
                }
                /// <summary>
                /// Gets or sets a value indicating whether this instance is perma link.
                /// </summary>
                /// <value><c>true</c> if this instance is perma link; otherwise, <c>false</c>.</value>
                public bool isPermaLink { get; set; }
            }
            /// <summary>
            /// Gets or sets the date time original.
            /// </summary>
            /// <value>The date time original.</value>
            public string DateTimeOriginal { get; set; }
            /// <summary>
            /// Gets or sets the tiny image.
            /// </summary>
            /// <value>The tiny image.</value>
            public _Img TinyImage { get; set; }
            /// <summary>
            /// Gets or sets the thumbnail image.
            /// </summary>
            /// <value>The thumbnail image.</value>
            public _Img ThumbnailImage { get; set; }
            /// <summary>
            /// Gets or sets the small image.
            /// </summary>
            /// <value>The small image.</value>
            public _Img SmallImage { get; set; }
            /// <summary>
            /// Gets or sets the medium image.
            /// </summary>
            /// <value>The medium image.</value>
            public _Img MediumImage { get; set; }
            /// <summary>
            /// Gets or sets the large image.
            /// </summary>
            /// <value>The large image.</value>
            public _Img LargeImage { get; set; }
            /// <summary>
            /// Gets or sets the extra large image.
            /// </summary>
            /// <value>The extra large image.</value>
            public _Img ExtraLargeImage { get; set; }
            /// <summary>
            /// Gets or sets the two extra large image.
            /// </summary>
            /// <value>The two extra large image.</value>
            public _Img TwoExtraLargeImage { get; set; }
            /// <summary>
            /// Gets or sets the three extra large image.
            /// </summary>
            /// <value>The three extra large image.</value>
            public _Img ThreeExtraLargeImage { get; set; }
            /// <summary>
            /// Gets or sets the original image.
            /// </summary>
            /// <value>The original image.</value>
            public _Img OriginalImage { get; set; }
            /// <summary>
            /// Class _Img
            /// </summary>
            public class _Img
            {
                /// <summary>
                /// Gets or sets the URL.
                /// </summary>
                /// <value>The URL.</value>
                public string Url { get; set; }
                /// <summary>
                /// Gets or sets the size of the file.
                /// </summary>
                /// <value>The size of the file.</value>
                public string FileSize { get; set; }
                /// <summary>
                /// Gets or sets the type.
                /// </summary>
                /// <value>The type.</value>
                public string Type { get; set; }
                /// <summary>
                /// Gets or sets the medium.
                /// </summary>
                /// <value>The medium.</value>
                public string Medium { get; set; }
                /// <summary>
                /// Gets or sets the width.
                /// </summary>
                /// <value>The width.</value>
                public string Width { get; set; }
                /// <summary>
                /// Gets or sets the height.
                /// </summary>
                /// <value>The height.</value>
                public string Height { get; set; }
                /// <summary>
                /// Gets or sets the hash.
                /// </summary>
                /// <value>The hash.</value>
                public string Hash { get; set; }
            }
            /// <summary>
            /// Gets or sets the HTML title.
            /// </summary>
            /// <value>The HTML title.</value>
            public string HtmlTitle { get; set; }
            /// <summary>
            /// Gets or sets the text.
            /// </summary>
            /// <value>The text.</value>
            public string Text { get; set; }
            /// <summary>
            /// Gets or sets the thumbnail.
            /// </summary>
            /// <value>The thumbnail.</value>
            public _Thumbnail Thumbnail { get; set; }
            /// <summary>
            /// Class _Thumbnail
            /// </summary>
            public class _Thumbnail
            {
                /// <summary>
                /// Gets or sets the URL.
                /// </summary>
                /// <value>The URL.</value>
                public string Url { get; set; }
                /// <summary>
                /// Gets or sets the width.
                /// </summary>
                /// <value>The width.</value>
                public string Width { get; set; }
                /// <summary>
                /// Gets or sets the height.
                /// </summary>
                /// <value>The height.</value>
                public string Height { get; set; }
            }
            /// <summary>
            /// Gets or sets the keywords.
            /// </summary>
            /// <value>The keywords.</value>
            public string Keywords { get; set; }
            /// <summary>
            /// Gets or sets the copyright.
            /// </summary>
            /// <value>The copyright.</value>
            public _Copyright Copyright { get; set; }
            /// <summary>
            /// Class _Copyright
            /// </summary>
            public class _Copyright
            {
                /// <summary>
                /// Gets or sets the value.
                /// </summary>
                /// <value>The value.</value>
                public string value { get; set; }
                /// <summary>
                /// Returns a <see cref="System.String" /> that represents this instance.
                /// </summary>
                /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
                public override string ToString()
                {
                    return value.ToString();
                }
                /// <summary>
                /// Gets or sets the URL.
                /// </summary>
                /// <value>The URL.</value>
                public string Url { get; set; }
            }
            /// <summary>
            /// Gets or sets the credit.
            /// </summary>
            /// <value>The credit.</value>
            public _Credit Credit { get; set; }
            /// <summary>
            /// Class _Credit
            /// </summary>
            public class _Credit
            {
                /// <summary>
                /// Gets or sets the value.
                /// </summary>
                /// <value>The value.</value>
                public string value { get; set; }
                /// <summary>
                /// Returns a <see cref="System.String" /> that represents this instance.
                /// </summary>
                /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
                public override string ToString()
                {
                    return value.ToString();
                }
                /// <summary>
                /// Gets or sets the role.
                /// </summary>
                /// <value>The role.</value>
                public string Role { get; set; }
            }
        }
    }
}