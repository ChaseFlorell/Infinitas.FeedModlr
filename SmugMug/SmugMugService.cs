// ***********************************************************************
// Assembly         : Infinitas.FeedModlr
// Author           : Chase
// Created          : 12-14-2012
//
// Last Modified By : Chase
// Last Modified On : 12-18-2012
// ***********************************************************************
// <copyright file="SmugMugService.cs" company="Infinitas Advantage">
//     Copyright (c) Infinitas Advantage. All rights reserved.
// </copyright>
// <summary>http://opensource.org/licenses/MIT</summary>
// ***********************************************************************
namespace Infinitas.FeedModlr.SmugMug
{
    using Infinitas.FeedModlr.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class SmugMugService
    /// </summary>
    public class SmugMugService
    {
        // SmugMug specific information
        /// <summary>
        /// The smugmug feed URL
        /// </summary>
        private const string SmugmugFeedUrl = "http://{0}.smugmug.com/hack/feed.mg?Type=gallery&Data={1}_{2}&format=rss";
        /// <summary>
        /// The _smugmug nickname
        /// </summary>
        private readonly string _smugmugNickname = ConfigurationManager.AppSettings["smugMugNickname"];
        /// <summary>
        /// Initializes a new instance of the <see cref="SmugMugService" /> class.
        /// </summary>
        public SmugMugService() { }


        /// <summary>
        /// Gets the smug mug gallery.
        /// </summary>
        /// <param name="smugMugAlbumId">The smug mug album id.</param>
        /// <param name="smugMugAlbumKey">The smug mug album key.</param>
        /// <param name="returnSmugMugOriginalGallery">if set to <c>true</c> [return smug mug original gallery].</param>
        /// <returns>Object.</returns>
        public Object GetSmugMugGallery(string smugMugAlbumId, string smugMugAlbumKey, bool returnSmugMugOriginalGallery)
        {
            // request the RSS Feed
            var url = string.Format(
                SmugmugFeedUrl,
                this._smugmugNickname,
                smugMugAlbumId,
                smugMugAlbumKey);

            // Deserialize the RSS feed into the appropriate model
            var originalGallery = XmlRssReader.Deserialize<OriginalSmugMugGallery>(url);


            if (returnSmugMugOriginalGallery)
            {
                return originalGallery;
            }
            return MapSmugMugGalleries(originalGallery);
        }

        /// <summary>
        /// Gets the smug mug gallery.
        /// </summary>
        /// <param name="albumID">The album ID.</param>
        /// <param name="albumKey">The album key.</param>
        /// <returns>Object.</returns>
        public Object GetSmugMugGallery(string albumID, string albumKey)
        {
            return GetSmugMugGallery(albumID, albumKey, false);
        }

        /// <summary>
        /// Maps the smug mug galleries.
        /// </summary>
        /// <param name="originalSmugMugGallery">The original smug mug gallery.</param>
        /// <returns>SmugMugGallery.</returns>
        private SmugMugGallery MapSmugMugGalleries(OriginalSmugMugGallery originalSmugMugGallery)
        {
            var gallery = new SmugMugGallery();

            // Map the original model to the new one
            gallery.Title = originalSmugMugGallery.Channel.Title;
            gallery.Link = originalSmugMugGallery.Channel.Link;
            gallery.Description = originalSmugMugGallery.Channel.Description;
            gallery.Icon = originalSmugMugGallery.Channel.Icon;
            gallery.Category = originalSmugMugGallery.Channel.Category;
            gallery.PubDate = originalSmugMugGallery.Channel.PubDate;
            gallery.LastBuildDate = originalSmugMugGallery.Channel.LastBuildDate;
            gallery.Generator = originalSmugMugGallery.Channel.Generator;
            gallery.Copyright = originalSmugMugGallery.Channel.Copyright;
            gallery.GalleryImage = new SmugMugGallery._GalleryImage();
            gallery.GalleryImage.Url = originalSmugMugGallery.Channel.Image.Url;
            gallery.GalleryImage.Title = originalSmugMugGallery.Channel.Image.Title;
            gallery.GalleryImage.Link = originalSmugMugGallery.Channel.Image.Link;
            gallery.AtomLinks = new SmugMugGallery._AtomLinks();
            gallery.AtomLinks.Rel = originalSmugMugGallery.Channel.AtomLink.Rel;
            gallery.AtomLinks.Href = originalSmugMugGallery.Channel.AtomLink.Href;
            gallery.AtomLinks.Type = originalSmugMugGallery.Channel.AtomLink.Type;
            gallery.Images = new List<SmugMugGallery.Image>();
            foreach (var img in originalSmugMugGallery.Channel.Items)
            {
                var galleryImage = new SmugMugGallery.Image();
                galleryImage.Title = img.Title;
                galleryImage.Link = img.Link;
                galleryImage.Description = img.Description;
                galleryImage.Category = img.Category;
                galleryImage.PubDate = img.PubDate;
                galleryImage.Author = img.Author;
                galleryImage.Guid = new SmugMugGallery.Image._Guid();
                galleryImage.Guid.value = img.Guid.ToString();
                galleryImage.Guid.isPermaLink = img.Guid.isPermaLink;
                galleryImage.DateTimeOriginal = img.DateTimeOriginal;

                var imgType = new[] {
                    galleryImage.TinyImage = new SmugMugGallery.Image._Img(),
                    galleryImage.ThumbnailImage = new SmugMugGallery.Image._Img(),
                    galleryImage.SmallImage = new SmugMugGallery.Image._Img(),
                    galleryImage.MediumImage = new SmugMugGallery.Image._Img(),
                    galleryImage.LargeImage = new SmugMugGallery.Image._Img(),
                    galleryImage.ExtraLargeImage = new SmugMugGallery.Image._Img(),
                    galleryImage.TwoExtraLargeImage = new SmugMugGallery.Image._Img(),
                    galleryImage.ThreeExtraLargeImage = new SmugMugGallery.Image._Img(),
                    galleryImage.OriginalImage = new SmugMugGallery.Image._Img(),
                };

                var count = 0;
                foreach (var i in img.Group.Contents)
                {
                    imgType[count].Url = i.Url;
                    imgType[count].FileSize = i.FileSize;
                    imgType[count].Type = i.Type;
                    imgType[count].Medium = i.Medium;
                    imgType[count].Width = i.Width;
                    imgType[count].Height = i.Height;
                    imgType[count].Hash = i.Hash;
                    count++;
                }
                {
                    galleryImage.Thumbnail = new SmugMugGallery.Image._Thumbnail();
                    galleryImage.Thumbnail.Url = img.Thumbnail.Url;
                    galleryImage.Thumbnail.Width = img.Thumbnail.Width;
                    galleryImage.Thumbnail.Height = img.Thumbnail.Height;
                }
                {
                    galleryImage.Copyright = new SmugMugGallery.Image._Copyright();
                    galleryImage.Copyright.value = img.Copyright.ToString();
                    galleryImage.Copyright.Url = img.Copyright.Url;
                }
                {
                    galleryImage.Credit = new SmugMugGallery.Image._Credit();
                    galleryImage.Credit.value = img.Credit.ToString();
                    galleryImage.Credit.Role = img.Credit.Role;
                }

                galleryImage.HtmlTitle = img.HtmlTitle;
                galleryImage.Text = img.Text;
                galleryImage.Keywords = img.Keywords;
                gallery.Images.Add(galleryImage);

            }

            return gallery;

        }
    }
}
