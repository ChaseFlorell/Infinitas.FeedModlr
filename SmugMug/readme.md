#[SmugMug Feed Examples][1]
##Global Feeds

 - Keyword feed:
   - http://api.smugmug.com/hack/feed.mg?Type=keyword&Data=[keyword]&format=rss
 - All-time Popular Photos feed:
   - http://api.smugmug.com/hack/feed.mg?Type=popular&Data=all&format=rss
 - Today's Popular Photos feed:
   - http://api.smugmug.com/hack/feed.mg?Type=popular&Data=today&format=rss
 - Category Popular Photos feed:
   - http://api.smugmug.com/hack/feed.mg?Type=popularCategory&Data=[category]&format=rss
 - Geotagged Photos feed:
   - http://api.smugmug.com/hack/feed.mg?Type=geoAll&format=rss
 - Geotagged Keyword feed:
   - http://api.smugmug.com/hack/feed.mg?Type=geoKeyword&Data=[keyword]&format=rss
 - Geotagged Search feed:
   - http://api.smugmug.com/hack/feed.mg?Type=geoSearch&Data=[search]&format=rss
 - Geotagged Community Photos feed:
   - http://api.smugmug.com/hack/feed.mg?Type=geoCommunity&Data=[community]&format=rss
 - OpenSearch Keyword feed:
   - http://api.smugmug.com/hack/feed.mg?Type=openSearchKeyword&Data=[keyword]&format=rss

#User Feeds

 - Keyword feed:
   - http://api.smugmug.com/hack/feed.mg?Type=userkeyword&NickName=[nickname]&Data=[keyword]&format=rss
 - Gallery feed:
   - http://api.smugmug.com/hack/feed.mg?Type=gallery&Data=[albumID]_[albumKey]&format=rss
 - Recent Galleries feed:
   - http://api.smugmug.com/hack/feed.mg?Type=nickname&Data=[nickname]&format=rss
 - Recent Photos feed:
   - http://api.smugmug.com/hack/feed.mg?Type=nicknameRecent&Data=[nickname]&format=rss
 - Popular Photos feed:
   - http://api.smugmug.com/hack/feed.mg?Type=nicknamePopular&Data=[nickname]&format=rss
 - Photo Comments feed:
   - http://api.smugmug.com/hack/feed.mg?Type=usercomments&Data=[nickname]&format=rss
 - Geotagged Photos feed:
   - http://api.smugmug.com/hack/feed.mg?Type=geoUser&Data=[nickname]&format=rss
 - Geotagged Album feed:
   - http://api.smugmug.com/hack/feed.mg?Type=geoAlbum&Data=[albumID]_[albumKey]&format=rss

##albumID and albumKey

Both must be included for the feed to work. They are connected by an underscore '_' as it is in any SmugMug gallery url like in this example:
cmac.smugmug.com/gallery/2504559_f3ta9

 - 2504559 is the albumID
 - f3ta9 is the albumKey (the key is case sensitive and you will encounter upper case characters in it)

[1]:http://help.smugmug.com/customer/portal/articles/84258-feed-examples