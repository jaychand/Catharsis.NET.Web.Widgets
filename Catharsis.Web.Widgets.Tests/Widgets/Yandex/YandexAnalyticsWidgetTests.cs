﻿using System;
using System.Threading;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YandexAnalyticsWidget"/>.</para>
  /// </summary>
  public sealed class YandexAnalyticsWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="YandexAnalyticsWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(widget.Field("webVisor").To<bool>());
      Assert.True(widget.Field("clickMap").To<bool>());
      Assert.True(widget.Field("trackLinks").To<bool>());
      Assert.True(widget.Field("trackHash").To<bool>());
      Assert.True(widget.Field("accurate").To<bool>());
      Assert.False(widget.Field("noIndex").To<bool>());
      Assert.Null(widget.Field("language"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexAnalyticsWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new YandexAnalyticsWidget().Account(string.Empty));

      var widget = new YandexAnalyticsWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.WebVisor(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void WebVisor_Method()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.True(widget.Field("webVisor").To<bool>());
      Assert.True(ReferenceEquals(widget.WebVisor(false), widget));
      Assert.False(widget.Field("webVisor").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.ClickMap(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void ClickMap_Method()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.True(widget.Field("clickMap").To<bool>());
      Assert.True(ReferenceEquals(widget.ClickMap(false), widget));
      Assert.False(widget.Field("clickMap").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.TrackLinks(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void TrackLinks_Method()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.True(widget.Field("trackLinks").To<bool>());
      Assert.True(ReferenceEquals(widget.TrackLinks(false), widget));
      Assert.False(widget.Field("trackLinks").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.TrackHash(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void TrackHash_Method()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.True(widget.Field("trackHash").To<bool>());
      Assert.True(ReferenceEquals(widget.TrackHash(false), widget));
      Assert.False(widget.Field("trackHash").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.Accurate(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Accurate_Method()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.True(widget.Field("accurate").To<bool>());
      Assert.True(ReferenceEquals(widget.Accurate(false), widget));
      Assert.False(widget.Field("accurate").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.NoIndex(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void NoIndex_Method()
    {
      var widget = new YandexAnalyticsWidget();
      Assert.False(widget.Field("noIndex").To<bool>());
      Assert.True(ReferenceEquals(widget.NoIndex(), widget));
      Assert.True(widget.Field("noIndex").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.Language(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexAnalyticsWidget().Language(null));
      Assert.Throws<ArgumentException>(() => new YandexAnalyticsWidget().Language(string.Empty));

      var widget = new YandexAnalyticsWidget();
      Assert.Null(widget.Field("language"));
      Assert.True(ReferenceEquals(widget.Language("language"), widget));
      Assert.Equal("language", widget.Field("language").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexAnalyticsWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new YandexAnalyticsWidget().ToString());
      
      var html = new YandexAnalyticsWidget().Account("account").ToString();
      Assert.True(html.Contains("Ya.Metrika.informer({{i: this, id: account, lang: '{0}'}})".FormatSelf(Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)));
      Assert.True(html.Contains("yaCounteraccount"));
      Assert.True(html.Contains(@"""webvisor"":true"));
      Assert.True(html.Contains(@"""clickmap"":true"));
      Assert.True(html.Contains(@"""trackLinks"":true"));
      Assert.True(html.Contains(@"""accurateTrackBounce"":true"));
      Assert.True(html.Contains(@"""trackHash"":true"));
      Assert.False(html.Contains(@"""ut"":""noindex"""));

      html = new YandexAnalyticsWidget().Account("account").Language("language").WebVisor(false).ClickMap(false).TrackLinks(false).Accurate(false).TrackHash(false).NoIndex().ToString();
      Assert.True(html.Contains("Ya.Metrika.informer({i: this, id: account, lang: 'language'})"));
      Assert.True(html.Contains("yaCounteraccount"));
      Assert.True(html.Contains(@"""webvisor"":false"));
      Assert.True(html.Contains(@"""clickmap"":false"));
      Assert.True(html.Contains(@"""trackLinks"":false"));
      Assert.True(html.Contains(@"""accurateTrackBounce"":false"));
      Assert.True(html.Contains(@"""trackHash"":false"));
      Assert.True(html.Contains(@"""ut"":""noindex"""));
    }
  }
}