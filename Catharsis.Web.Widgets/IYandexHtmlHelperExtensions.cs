using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IYandexHtmlHelper"/>.</para>
  ///   <seealso cref="IYandexHtmlHelper"/>
  /// </summary>
  public static class IYandexHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new Yandex.Metrika analytics widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexHtmlHelper.Analytics()"/>
    public static string Analytics(this IYandexHtmlHelper html, Action<IYandexAnalyticsWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Analytics();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Yandex "Like" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexHtmlHelper.Like()"/>
    public static string Like(this IYandexHtmlHelper html, Action<IYandexLikeButtonWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Like();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Yandex "Share" button widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexHtmlHelper.Share()"/>
    public static string Share(this IYandexHtmlHelper html, Action<IYandexSharePanelWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Share();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Yandex embedded video widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexHtmlHelper.Video()"/>
    public static string Video(this IYandexHtmlHelper html, Action<IYandexVideoWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Video();
      builder(widget);
      return widget.ToHtmlString();
    }

    /// <summary>
    ///   <para>Creates new Yandex video hyperlink widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <seealso cref="IYandexHtmlHelper.VideoLink()"/>
    public static string VideoLink(this IYandexHtmlHelper html, Action<IYandexVideoLinkWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.VideoLink();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}