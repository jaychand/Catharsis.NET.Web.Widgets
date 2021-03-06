using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Tumblr "Share" button.</para>
  ///   <para>Requires Tumblr scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://www.tumblr.com/buttons"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Tumblr(IWidgetsScriptsRenderer)"/>
  public interface ITumblrShareButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Visual color scheme of button.</para>
    /// </summary>
    /// <param name="scheme">Color scheme for button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="scheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="scheme"/> is <see cref="string.Empty"/> string.</exception>
    ITumblrShareButtonWidget ColorScheme(string scheme);

    /// <summary>
    ///   <para>Visual color scheme of button.</para>
    /// </summary>
    /// <returns>Color scheme for button.</returns>
    string ColorScheme();

    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <param name="type">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    ITumblrShareButtonWidget Type(byte type);

    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <returns>Layout of button.</returns>
    byte Type();
  }
}