// ***********************************************************************
// Assembly         : Infinitas.FeedModlr
// Author           : Chase Florell
// Created          : 12-14-2012
//
// Last Modified By : Chase Florell
// Last Modified On : 12-18-2012
// ***********************************************************************
// <copyright file="SmugMugService.cs" company="Infinitas Advantage">
//     Copyright (c) Infinitas Advantage. All rights reserved.
// </copyright>
// <summary>
// This code file is licensed under the MIT License.
// http://opensource.org/licenses/MIT
// </summary>
// ***********************************************************************
namespace Infinitas.FeedModlr.SmugMug.Services
{
    using Infinitas.FeedModlr.SmugMug.Models;
    using Infinitas.FeedModlr.Utilities;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class SmugMugService
    /// </summary>
    public class SmugMugGalleryService
    {
        // SmugMug specific information
        /// <summary>
        /// The smugmug feed URL
        /// </summary>
        /// <remarks>Even though the feed examples on the smugmug website state
        /// that you can use "Atom", "KML", and "Open Search RSS", We're using
        /// the standard RSS feed since it delivers the most amount of useful
        /// information.</remarks>
        private const string SmugmugFeedUrl = "http://api.smugmug.com/hack/feed.mg?Type=gallery&Data={0}_{1}&format=rss";

        /// <summary>
        /// Initializes a new instance of the <see cref="SmugMugService" /> class.
        /// </summary>
        public SmugMugGalleryService() { }

        /// <summary>
        /// Gets the smug mug gallery.
        /// </summary>
        /// <param name="smugMugAlbumId">The smug mug album id.</param>
        /// <param name="smugMugAlbumKey">The smug mug album key.</param>
        /// <returns>Either a <see cref="SmugMugGallery" or a <see cref="OriginalSmugMugGallery"/>/>.</returns>
        /// <remarks>The albumID and albumKey can be located by looking in your gallery's url string.  `&Data=[albumID]_[albumKey]`</remarks>
        /// <exception cref="System.Exception">Invalid Type specified, nothing to return.</exception>
        public T GetSmugMugGallery<T>(string smugMugAlbumId, string smugMugAlbumKey)
        {
            // Format the SmugmugFeedUrl with the appropriate input information
            var url = string.Format(
                SmugmugFeedUrl,
                smugMugAlbumId,
                smugMugAlbumKey);

            // Deserialize the RSS feed into an OriginalSmugMugGallery Model
            var originalGallery = XmlRssReader.Deserialize<OriginalSmugMugGallery>(url);

            // returns an OriginalSmugMugGallery if requested
            if (typeof(T) == typeof(OriginalSmugMugGallery)) {
                return (T)(object)originalGallery;
            }

            // Returns a SmugMugGallery if requested
            if (typeof(T) == typeof(SmugMugGallery))  {
                return (T)(object)MapSmugMugGalleries(originalGallery);
            }

            // If the request was anything but the above Types, throw an error.
            throw new Exception("Invalid Type specified, nothing to return.");
        }

        /// <summary>
        /// Gets the smug mug image by GUID.
        /// </summary>
        /// <param name="smugMugAlbumId">The smug mug album id.</param>
        /// <param name="smugMugAlbumKey">The smug mug album key.</param>
        /// <param name="smugMugImageGuid">The smug mug image GUID.</param>
        /// <returns><see cref="SmugMugGallery.Image"/>.</returns>
        /// <exception cref="System.Exception">Unable to find an image associated with the specified Guid within the specified SmugMug Gallery.</exception>
        public SmugMugGallery.Image GetSmugMugImageByGuid(string smugMugAlbumId, string smugMugAlbumKey, string smugMugImageGuid){

            // Grab all Images from the specified gallery
            var smGalleryImages = GetSmugMugGallery<SmugMugGallery>(smugMugAlbumId, smugMugAlbumKey).Images;
            SmugMugGallery.Image imageToReturn = null;

            // Loop through the images to find the one specified by the smugMugImageGuid
            foreach (var image in smGalleryImages)
            {
                if (smugMugImageGuid == image.Guid.ToString())
                {
                    imageToReturn = image;
                }
            }

            // Throw an error if an invalid image was specified
            if (imageToReturn == null)
            {
                throw new Exception("Unable to find an image associated with the specified Guid within the specified SmugMug Gallery.");
            }

            // Return the image if no error was thrown.
            return imageToReturn;
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
