using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YandexSharePanelWidget"/>.</para>
  /// </summary>
  public sealed class YandexSharePanelWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="YandexSharePanelWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new YandexSharePanelWidget();
      Assert.Null(widget.Language());
      Assert.Equal(YandexSharePanelLayout.Button.ToString().ToLowerInvariant(), widget.Layout());
      Assert.True(widget.Services().SequenceEqual(new [] { "yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird" }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexSharePanelWidget.Language(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexSharePanelWidget().Language(null));
      Assert.Throws<ArgumentException>(() => new YandexSharePanelWidget().Language(string.Empty));

      var widget = new YandexSharePanelWidget();
      Assert.Null(widget.Language());
      Assert.True(ReferenceEquals(widget.Language("language"), widget));
      Assert.Equal("language", widget.Language());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexSharePanelWidget.Services(IEnumerable{string})"/> method.</para>
    /// </summary>
    [Fact]
    public void Services_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexSharePanelWidget().Services(null));

      var widget = new YandexSharePanelWidget();
      Assert.True(widget.Services().SequenceEqual(new[] { "yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird" }));
      Assert.True(ReferenceEquals(widget.Services(new[] { "first", "second" }), widget));
      Assert.True(widget.Services().SequenceEqual(new[] { "first", "second" }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexSharePanelWidget.Layout(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexSharePanelWidget().Layout(null));
      Assert.Throws<ArgumentException>(() => new YandexSharePanelWidget().Layout(string.Empty));

      var widget = new YandexSharePanelWidget();
      Assert.Equal(YandexSharePanelLayout.Button.ToString().ToLowerInvariant(), widget.Layout());
      Assert.True(ReferenceEquals(widget.Layout("layout"), widget));
      Assert.Equal("layout", widget.Layout());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexSharePanelWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<div class=""yashare-auto-init"" data-yashareL10n=""{0}"" data-yashareQuickServices=""yaru,vkontakte,facebook,twitter,odnoklassniki,moimir,lj,friendfeed,moikrug,gplus,pinterest,surfingbird"" data-yashareType=""button""></div>".FormatSelf(Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName), new YandexSharePanelWidget().ToString());
      Assert.Equal(@"<div class=""yashare-auto-init"" data-yashareL10n=""ru"" data-yashareQuickServices=""yaru"" data-yashareType=""link""></div>", new YandexSharePanelWidget().Services("yaru").Layout(YandexSharePanelLayout.Link).Language("ru").ToString());
    }
  }
}