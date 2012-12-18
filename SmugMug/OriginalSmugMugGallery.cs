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
// <summary></summary>
// ***********************************************************************
// This class is used by the XML Serializer, to map the RSS feed to this Class Model
namespace Infinitas.FeedModlr.SmugMug
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot("rss")]
    public class OriginalSmugMugGallery
    {
        [XmlElement("channel")]
        public Channels Channel { get; set; }
        public class Channels
        {
            [XmlElement("title")]
            public string Title { get; set; }

            [XmlElement("link")]
            public string Link { get; set; }

            [XmlElement("description")]
            public string Description { get; set; }

            [XmlElement("icon", Namespace = "http://www.w3.org/2005/Atom")]
            public string Icon { get; set; }

            [XmlElement("category")]
            public string Category { get; set; }

            [XmlElement("pubDate")]
            public string PubDate { get; set; }

            [XmlElement("lastBuildDate")]
            public string LastBuildDate { get; set; }

            [XmlElement("generator")]
            public string Generator { get; set; }

            [XmlElement("copyright")]
            public string Copyright { get; set; }

            [XmlElement("image")]
            public m_Image Image { get; set; }
            public class m_Image
            {
                [XmlElement("url")]
                public string Url { get; set; }

                [XmlElement("title")]
                public string Title { get; set; }

                [XmlElement("link")]
                public string Link { get; set; }
            }

            [XmlElement("link", Namespace = "http://www.w3.org/2005/Atom")]
            public m_AtomLinks AtomLink { get; set; }
            public class m_AtomLinks
            {

                [XmlAttribute("rel")]
                public string Rel { get; set; }

                [XmlAttribute("type")]
                public string Type { get; set; }

                [XmlAttribute("href")]
                public string Href { get; set; }
            }

            [XmlElement("item")]
            public List<Item> Items { get; set; }
            public class Item
            {
                [XmlElement("title")]
                public string Title { get; set; }

                [XmlElement("link")]
                public string Link { get; set; }

                [XmlElement("description")]
                public string Description { get; set; }

                [XmlElement("category")]
                public string Category { get; set; }

                [XmlElement("pubDate")]
                public string PubDate { get; set; }

                [XmlElement("author")]
                public string Author { get; set; }

                [XmlElement("guid")]
                public m_Guid Guid { get; set; }
                public class m_Guid
                {
                    [XmlTextAttribute]
                   public string value { get; set; }

                    public override string ToString()
                    {  return value.ToString(); }

                    [XmlAttribute("isPermaLink")]
                    public bool isPermaLink { get; set; }
                }

                [XmlElement("DateTimeOriginal", Namespace = "http://www.exif.org/specifications.html")]
                public string DateTimeOriginal { get; set; }

                [XmlElement("group", Namespace = "http://search.yahoo.com/mrss/")]
                public m_Group Group { get; set; }
                public class m_Group
                {
                    [XmlElement("content", Namespace = "http://search.yahoo.com/mrss/")]
                    public List<Content> Contents { get; set; }
                    public class Content
                    {
                        [XmlAttribute("url")]
                        public string Url { get; set; }

                        [XmlAttribute("fileSize")]
                        public string FileSize { get; set; }

                        [XmlAttribute("type")]
                        public string Type { get; set; }

                        [XmlAttribute("medium")]
                        public string Medium { get; set; }

                        [XmlAttribute("width")]
                        public string Width { get; set; }

                        [XmlAttribute("height")]
                        public string Height { get; set; }

                        [XmlElement("hash", Namespace = "http://search.yahoo.com/mrss/")]
                        public string Hash { get; set; }
                    }
                }

                [XmlElement("title", Namespace = "http://search.yahoo.com/mrss/")]
                public string HtmlTitle { get; set; }

                [XmlElement("text", Namespace = "http://search.yahoo.com/mrss/")]
                public string Text { get; set; }

                [XmlElement("thumbnail", Namespace = "http://search.yahoo.com/mrss/")]
                public m_Thumbnail Thumbnail { get; set; }
                public class m_Thumbnail
                {
                    [XmlAttribute("url")]
                    public string Url { get; set; }

                    [XmlAttribute("width")]
                    public string Width { get; set; }

                    [XmlAttribute("height")]
                    public string Height { get; set; }
                }

                [XmlElement("keywords", Namespace = "http://search.yahoo.com/mrss/")]
                public string Keywords { get; set; }


                [XmlElement("copyright", Namespace = "http://search.yahoo.com/mrss/")]
                public m_Copyright Copyright { get; set; }
                public class m_Copyright
                {
                    [XmlTextAttribute]
                   public string value { get; set; }
                    public override string ToString()
                    { return value.ToString(); }

                    [XmlAttribute("url")]
                    public string Url { get; set; }
                }

                [XmlElement("credit", Namespace = "http://search.yahoo.com/mrss/")]
                public m_Credit Credit { get; set; }
                public class m_Credit
                {
                    [XmlTextAttribute]
                   public string value { get; set; }
                    public override string ToString()
                    { return value.ToString(); }

                    [XmlAttribute("role")]
                    public string Role { get; set; }
                }
            }
        }
    }
}
