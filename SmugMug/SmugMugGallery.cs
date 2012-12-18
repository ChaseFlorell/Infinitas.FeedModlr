// ***********************************************************************
// Assembly         : Infinitas.FeedModlr
// Author           : Chase
// Created          : 12-14-2012
//
// Last Modified By : Chase
// Last Modified On : 12-18-2012
// ***********************************************************************
// <copyright file="SmugMugGallery.cs" company="Infinitas Advantage">
//     Copyright (c) Infinitas Advantage. All rights reserved.
// </copyright>
// <summary>http://opensource.org/licenses/MIT</summary>
// ***********************************************************************
// This class is a more natural feeling model object for the SmugMug Gallery.
namespace Infinitas.FeedModlr.SmugMug
{
    using System.Collections.Generic;
    public class SmugMugGallery
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Category { get; set; }
        public string PubDate { get; set; }
        public string LastBuildDate { get; set; }
        public string Generator { get; set; }
        public string Copyright { get; set; }
        public _GalleryImage GalleryImage { get; set; }
        public class _GalleryImage
        {
            public string Url { get; set; }
            public string Title { get; set; }
            public string Link { get; set; }
        }
        public _AtomLinks AtomLinks { get; set; }
        public class _AtomLinks
        {
            public string Rel { get; set; }
            public string Type { get; set; }
            public string Href { get; set; }
        }
        public List<Image> Images { get; set; }
        public class Image
        {
            public string Title { get; set; }
            public string Link { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public string PubDate { get; set; }
            public string Author { get; set; }
            public _Guid Guid { get; set; }
            public class _Guid
            {
                public string value { get; set; }
                public override string ToString()
                {
                    return value.ToString();
                }
                public bool isPermaLink { get; set; }
            }
            public string DateTimeOriginal { get; set; }
            public _Img TinyImage { get; set; }
            public _Img ThumbnailImage { get; set; }
            public _Img SmallImage { get; set; }
            public _Img MediumImage { get; set; }
            public _Img LargeImage { get; set; }
            public _Img ExtraLargeImage { get; set; }
            public _Img TwoExtraLargeImage { get; set; }
            public _Img ThreeExtraLargeImage { get; set; }
            public _Img OriginalImage { get; set; }
            public class _Img
            {
                public string Url { get; set; }
                public string FileSize { get; set; }
                public string Type { get; set; }
                public string Medium { get; set; }
                public string Width { get; set; }
                public string Height { get; set; }
                public string Hash { get; set; }
            }
            public string HtmlTitle { get; set; }
            public string Text { get; set; }
            public _Thumbnail Thumbnail { get; set; }
            public class _Thumbnail
            {
                public string Url { get; set; }
                public string Width { get; set; }
                public string Height { get; set; }
            }
            public string Keywords { get; set; }
            public _Copyright Copyright { get; set; }
            public class _Copyright
            {
                public string value { get; set; }
                public override string ToString()
                {
                    return value.ToString();
                }
                public string Url { get; set; }
            }
            public _Credit Credit { get; set; }
            public class _Credit
            {
                public string value { get; set; }
                public override string ToString()
                {
                    return value.ToString();
                }
                public string Role { get; set; }
            }
        }
    }
}