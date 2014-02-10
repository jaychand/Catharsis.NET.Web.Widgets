﻿using System;
using System.IO;
using System.Threading;
using System.Web;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="TwitterFollowButtonWidget"/>.</para>
  /// </summary>
  public sealed class TwitterFollowButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="TwitterFollowButtonWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new TwitterFollowButtonWidget();
      Assert.True(widget.Field("account") == null);
      Assert.True(widget.Field("language") == null);
      Assert.True(widget.Field("size") == null);
      Assert.True(widget.Field("alignment") == null);
      Assert.True(widget.Field("showCount") == null);
      Assert.True(widget.Field("showScreenName") == null);
      Assert.True(widget.Field("optOut") == null);
      Assert.True(widget.Field("width") == null);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterFollowButtonWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new TwitterFollowButtonWidget().Account(string.Empty));

      var widget = new TwitterFollowButtonWidget();
      Assert.True(widget.Field("account") == null);
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.True(widget.Field("account").To<string>() == "account");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Language(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterFollowButtonWidget().Language(null));
      Assert.Throws<ArgumentException>(() => new TwitterFollowButtonWidget().Language(string.Empty));

      var widget = new TwitterFollowButtonWidget();
      Assert.True(widget.Field("language") == null);
      Assert.True(ReferenceEquals(widget.Language("language"), widget));
      Assert.True(widget.Field("language").To<string>() == "language");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Size(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterFollowButtonWidget().Size(null));
      Assert.Throws<ArgumentException>(() => new TwitterFollowButtonWidget().Size(string.Empty));

      var widget = new TwitterFollowButtonWidget();
      Assert.True(widget.Field("size") == null);
      Assert.True(ReferenceEquals(widget.Size("size"), widget));
      Assert.True(widget.Field("size").To<string>() == "size");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Alignment(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Alignment_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterFollowButtonWidget().Alignment(null));
      Assert.Throws<ArgumentException>(() => new TwitterFollowButtonWidget().Alignment(string.Empty));

      var widget = new TwitterFollowButtonWidget();
      Assert.True(widget.Field("alignment") == null);
      Assert.True(ReferenceEquals(widget.Alignment("alignment"), widget));
      Assert.True(widget.Field("alignment").To<string>() == "alignment");
    }
    
    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.ShowCount(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void ShowCount_Method()
    {
      var widget = new TwitterFollowButtonWidget();
      Assert.True(widget.Field("showCount") == null);
      Assert.True(ReferenceEquals(widget.ShowCount(), widget));
      Assert.True(widget.Field("showCount").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.ShowScreenName(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void ShowScreenName_Method()
    {
      var widget = new TwitterFollowButtonWidget();
      Assert.True(widget.Field("showScreenName") == null);
      Assert.True(ReferenceEquals(widget.ShowScreenName(), widget));
      Assert.True(widget.Field("showScreenName").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.OptOut(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void OptOut_Method()
    {
      var widget = new TwitterFollowButtonWidget();
      Assert.True(widget.Field("optOut") == null);
      Assert.True(ReferenceEquals(widget.OptOut(), widget));
      Assert.True(widget.Field("optOut").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterFollowButtonWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new TwitterFollowButtonWidget().Account("account").Write(writer)).ToString() == @"<a class=""twitter-follow-button"" data-lang=""{0}"" href=""https://twitter.com/account""></a>".FormatValue(HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName));
      Assert.True(new StringWriter().With(writer => new TwitterFollowButtonWidget().Account("account").Language("en").ShowCount().Size("size").Width("width").Alignment("align").ShowScreenName().OptOut().Write(writer)).ToString() == @"<a class=""twitter-follow-button"" data-align=""align"" data-dnt=""true"" data-lang=""en"" data-show-count=""true"" data-show-screen-name=""true"" data-size=""size"" data-width=""width"" href=""https://twitter.com/account""></a>");
    }
  }
}