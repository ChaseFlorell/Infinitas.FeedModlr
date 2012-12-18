#Infinitas.FeedModlr#

This simple `C#` project is designed to help model public feed into usable Model Objects for your projects.

##Current Support:  
- [SmugMug][1]
   - Gallery Feed

##Usage:  
Using the modlr is quite simple. If you'd like to get a gallery, simply do the following.

#####SmugMug Examples:

    // setup the service
    var smugMugService = new SmugMugService();

    // get's an easy to use SmugMug Model Object From the specified Gallery
    var smGallery = smugMugService.GetSmugMugGallery("[smugMugGalleryID]", "[smugMugGalleryKey]");

    // get's the original SmugMug Model Object from the specified Gallery
    var smOriginalGallery = smugMugService.GetSmugMugGallery("[smugMugGalleryID]", "[smugMugGalleryKey]", true);


---
<p>Copyright (c) 2012 Chase Florell</p>

<p>Permission is hereby granted, free of charge, to any person obtaining
    a copy of this software and associated documentation files (the
    "Software"), to deal in the Software without restriction, including
    without limitation the rights to use, copy, modify, merge, publish,
    distribute, sublicense, and/or sell copies of the Software, and to
    permit persons to whom the Software is furnished to do so, subject to
    the following conditions:</p>

<p>The above copyright notice and this permission notice shall be
    included in all copies or substantial portions of the Software.</p>

<p>THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
    MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
    LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
    OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
    WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.</p>

<!-- Links-->

<!-- SmugMug RSS Help -->
[1]: http://help.smugmug.com/customer/portal/articles/84258-feed-examples