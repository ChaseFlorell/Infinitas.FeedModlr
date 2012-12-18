// ***********************************************************************
// Assembly         : Infinitas.FeedModlr
// Author           : Chase
// Created          : 12-14-2012
//
// Last Modified By : Chase
// Last Modified On : 12-18-2012
// ***********************************************************************
// <copyright file="OriginalSmugMugGallery.cs" company="Infinitas Advantage">
//     Copyright (c) Infinitas Advantage. All rights reserved.
// </copyright>
// <summary>http://opensource.org/licenses/MIT</summary>
// ***********************************************************************
namespace Infinitas.FeedModlr.SmugMug
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Class OriginalSmugMugGallery
    /// </summary>
    /// <remarks>This class is used by the XML Serializer, to map the RSS feed to this Class Model</remarks>
    [XmlRoot("rss")]
    public class OriginalSmugMugGallery
    {
        /// <summary>
        /// Gets or sets the channel.
        /// </summary>
        /// <value>The channel.</value>
        [XmlElement("channel")]
        public Channels Channel { get; set; }
        /// <summary>
        /// Class Channels
        /// </summary>
        public class Channels
        {
            /// <summary>
            /// Gets or sets the title.
            /// </summary>
            /// <value>The title.</value>
            [XmlElement("title")]
            public string Title { get; set; }

            /// <summary>
            /// Gets or sets the link.
            /// </summary>
            /// <value>The link.</value>
            [XmlElement("link")]
            public string Link { get; set; }

            /// <summary>
            /// Gets or sets the description.
            /// </summary>
            /// <value>The description.</value>
            [XmlElement("description")]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets the icon.
            /// </summary>
            /// <value>The icon.</value>
            [XmlElement("icon", Namespace = "http://www.w3.org/2005/Atom")]
            public string Icon { get; set; }

            /// <summary>
            /// Gets or sets the category.
            /// </summary>
            /// <value>The category.</value>
            [XmlElement("category")]
            public string Category { get; set; }

            /// <summary>
            /// Gets or sets the pub date.
            /// </summary>
            /// <value>The pub date.</value>
            [XmlElement("pubDate")]
            public string PubDate { get; set; }

            /// <summary>
            /// Gets or sets the last build date.
            /// </summary>
            /// <value>The last build date.</value>
            [XmlElement("lastBuildDate")]
            public string LastBuildDate { get; set; }

            /// <summary>
            /// Gets or sets the generator.
            /// </summary>
            /// <value>The generator.</value>
            [XmlElement("generator")]
            public string Generator { get; set; }

            /// <summary>
            /// Gets or sets the copyright.
            /// </summary>
            /// <value>The copyright.</value>
            [XmlElement("copyright")]
            public string Copyright { get; set; }

            /// <summary>
            /// Gets or sets the image.
            /// </summary>
            /// <value>The image.</value>
            [XmlElement("image")]
            public _Image Image { get; set; }
            /// <summary>
            /// Class _Image
            /// </summary>
            public class _Image
            {
                /// <summary>
                /// Gets or sets the URL.
                /// </summary>
                /// <value>The URL.</value>
                [XmlElement("url")]
                public string Url { get; set; }

                /// <summary>
                /// Gets or sets the title.
                /// </summary>
                /// <value>The title.</value>
                [XmlElement("title")]
                public string Title { get; set; }

                /// <summary>
                /// Gets or sets the link.
                /// </summary>
                /// <value>The link.</value>
                [XmlElement("link")]
                public string Link { get; set; }
            }

            /// <summary>
            /// Gets or sets the atom link.
            /// </summary>
            /// <value>The atom link.</value>
            [XmlElement("link", Namespace = "http://www.w3.org/2005/Atom")]
            public _AtomLinks AtomLink { get; set; }
            /// <summary>
            /// Class _AtomLinks
            /// </summary>
            public class _AtomLinks
            {

                /// <summary>
                /// Gets or sets the rel.
                /// </summary>
                /// <value>The rel.</value>
                [XmlAttribute("rel")]
                public string Rel { get; set; }

                /// <summary>
                /// Gets or sets the type.
                /// </summary>
                /// <value>The type.</value>
                [XmlAttribute("type")]
                public string Type { get; set; }

                /// <summary>
                /// Gets or sets the href.
                /// </summary>
                /// <value>The href.</value>
                [XmlAttribute("href")]
                public string Href { get; set; }
            }

            /// <summary>
            /// Gets or sets the items.
            /// </summary>
            /// <value>The items.</value>
            [XmlElement("item")]
            public List<Item> Items { get; set; }
            /// <summary>
            /// Class Item
            /// </summary>
            public class Item
            {
                /// <summary>
                /// Gets or sets the title.
                /// </summary>
                /// <value>The title.</value>
                [XmlElement("title")]
                public string Title { get; set; }

                /// <summary>
                /// Gets or sets the link.
                /// </summary>
                /// <value>The link.</value>
                [XmlElement("link")]
                public string Link { get; set; }

                /// <summary>
                /// Gets or sets the description.
                /// </summary>
                /// <value>The description.</value>
                [XmlElement("description")]
                public string Description { get; set; }

                /// <summary>
                /// Gets or sets the category.
                /// </summary>
                /// <value>The category.</value>
                [XmlElement("category")]
                public string Category { get; set; }

                /// <summary>
                /// Gets or sets the pub date.
                /// </summary>
                /// <value>The pub date.</value>
                [XmlElement("pubDate")]
                public string PubDate { get; set; }

                /// <summary>
                /// Gets or sets the author.
                /// </summary>
                /// <value>The author.</value>
                [XmlElement("author")]
                public string Author { get; set; }

                /// <summary>
                /// Gets or sets the GUID.
                /// </summary>
                /// <value>The GUID.</value>
                [XmlElement("guid")]
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
                    [XmlTextAttribute]
                   public string value { get; set; }

                    /// <summary>
                    /// Returns a <see cref="System.String" /> that represents this instance.
                    /// </summary>
                    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
                    public override string ToString()
                    {  return value.ToString(); }

                    /// <summary>
                    /// Gets or sets a value indicating whether this instance is perma link.
                    /// </summary>
                    /// <value><c>true</c> if this instance is perma link; otherwise, <c>false</c>.</value>
                    [XmlAttribute("isPermaLink")]
                    public bool isPermaLink { get; set; }
                }

                /// <summary>
                /// Gets or sets the date time original.
                /// </summary>
                /// <value>The date time original.</value>
                [XmlElement("DateTimeOriginal", Namespace = "http://www.exif.org/specifications.html")]
                public string DateTimeOriginal { get; set; }

                /// <summary>
                /// Gets or sets the group.
                /// </summary>
                /// <value>The group.</value>
                [XmlElement("group", Namespace = "http://search.yahoo.com/mrss/")]
                public _Group Group { get; set; }
                /// <summary>
                /// Class _Group
                /// </summary>
                public class _Group
                {
                    /// <summary>
                    /// Gets or sets the contents.
                    /// </summary>
                    /// <value>The contents.</value>
                    [XmlElement("content", Namespace = "http://search.yahoo.com/mrss/")]
                    public List<Content> Contents { get; set; }
                    /// <summary>
                    /// Class Content
                    /// </summary>
                    public class Content
                    {
                        /// <summary>
                        /// Gets or sets the URL.
                        /// </summary>
                        /// <value>The URL.</value>
                        [XmlAttribute("url")]
                        public string Url { get; set; }

                        /// <summary>
                        /// Gets or sets the size of the file.
                        /// </summary>
                        /// <value>The size of the file.</value>
                        [XmlAttribute("fileSize")]
                        public string FileSize { get; set; }

                        /// <summary>
                        /// Gets or sets the type.
                        /// </summary>
                        /// <value>The type.</value>
                        [XmlAttribute("type")]
                        public string Type { get; set; }

                        /// <summary>
                        /// Gets or sets the medium.
                        /// </summary>
                        /// <value>The medium.</value>
                        [XmlAttribute("medium")]
                        public string Medium { get; set; }

                        /// <summary>
                        /// Gets or sets the width.
                        /// </summary>
                        /// <value>The width.</value>
                        [XmlAttribute("width")]
                        public string Width { get; set; }

                        /// <summary>
                        /// Gets or sets the height.
                        /// </summary>
                        /// <value>The height.</value>
                        [XmlAttribute("height")]
                        public string Height { get; set; }

                        /// <summary>
                        /// Gets or sets the hash.
                        /// </summary>
                        /// <value>The hash.</value>
                        [XmlElement("hash", Namespace = "http://search.yahoo.com/mrss/")]
                        public string Hash { get; set; }
                    }
                }

                /// <summary>
                /// Gets or sets the HTML title.
                /// </summary>
                /// <value>The HTML title.</value>
                [XmlElement("title", Namespace = "http://search.yahoo.com/mrss/")]
                public string HtmlTitle { get; set; }

                /// <summary>
                /// Gets or sets the text.
                /// </summary>
                /// <value>The text.</value>
                [XmlElement("text", Namespace = "http://search.yahoo.com/mrss/")]
                public string Text { get; set; }

                /// <summary>
                /// Gets or sets the thumbnail.
                /// </summary>
                /// <value>The thumbnail.</value>
                [XmlElement("thumbnail", Namespace = "http://search.yahoo.com/mrss/")]
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
                    [XmlAttribute("url")]
                    public string Url { get; set; }

                    /// <summary>
                    /// Gets or sets the width.
                    /// </summary>
                    /// <value>The width.</value>
                    [XmlAttribute("width")]
                    public string Width { get; set; }

                    /// <summary>
                    /// Gets or sets the height.
                    /// </summary>
                    /// <value>The height.</value>
                    [XmlAttribute("height")]
                    public string Height { get; set; }
                }

                /// <summary>
                /// Gets or sets the keywords.
                /// </summary>
                /// <value>The keywords.</value>
                [XmlElement("keywords", Namespace = "http://search.yahoo.com/mrss/")]
                public string Keywords { get; set; }


                /// <summary>
                /// Gets or sets the copyright.
                /// </summary>
                /// <value>The copyright.</value>
                [XmlElement("copyright", Namespace = "http://search.yahoo.com/mrss/")]
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
                    [XmlTextAttribute]
                   public string value { get; set; }
                    /// <summary>
                    /// Returns a <see cref="System.String" /> that represents this instance.
                    /// </summary>
                    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
                    public override string ToString()
                    { return value.ToString(); }

                    /// <summary>
                    /// Gets or sets the URL.
                    /// </summary>
                    /// <value>The URL.</value>
                    [XmlAttribute("url")]
                    public string Url { get; set; }
                }

                /// <summary>
                /// Gets or sets the credit.
                /// </summary>
                /// <value>The credit.</value>
                [XmlElement("credit", Namespace = "http://search.yahoo.com/mrss/")]
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
                    [XmlTextAttribute]
                   public string value { get; set; }
                    /// <summary>
                    /// Returns a <see cref="System.String" /> that represents this instance.
                    /// </summary>
                    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
                    public override string ToString()
                    { return value.ToString(); }

                    /// <summary>
                    /// Gets or sets the role.
                    /// </summary>
                    /// <value>The role.</value>
                    [XmlAttribute("role")]
                    public string Role { get; set; }
                }
            }
        }
    }
}
