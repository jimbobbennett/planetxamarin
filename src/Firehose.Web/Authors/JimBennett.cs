﻿using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
   public class JimBennett : IAmAMicrosoftMVP, IAmAXamarinMVP
   {
      public string FirstName => "Jim";
      public string LastName => "Bennett";
      public string Title => "Mobile developer at EROAD";
      public string StateOrRegion => "Auckland, New Zealand";
      public string EmailAddress => "jim@jimbobbennett.io";
      public string TwitterHandle => "jimbobbennett";

      public Uri WebSite => new Uri("https://jimbobbennett.io/");
      public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.jimbobbennett.io/rss"); } }

      public DateTime FirstAwarded => new DateTime(2016, 1, 1);
   }
}
