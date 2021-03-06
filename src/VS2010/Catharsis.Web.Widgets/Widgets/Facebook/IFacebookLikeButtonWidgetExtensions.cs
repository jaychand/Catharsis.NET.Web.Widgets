using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IFacebookLikeButtonWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IFacebookLikeButtonWidget"/>
  public static class IFacebookLikeButtonWidgetExtensions
  {
    /// <summary>
    ///   <para>Selects one of the different layouts that are available for the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="layout">Button layout.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookLikeButtonWidget.Layout(string)"/>
    public static IFacebookLikeButtonWidget Layout(this IFacebookLikeButtonWidget widget, FacebookButtonLayout layout)
    {
      Assertion.NotNull(widget);

      switch (layout)
      {
        case FacebookButtonLayout.BoxCount :
          return widget.Layout("box_count");

        case FacebookButtonLayout.ButtonCount :
          return widget.Layout("button_count");

        default:
          return widget.Layout("standard");
      }
    }

    /// <summary>
    ///   <para>The width of the button. The layout you choose affects the minimum and default widths you can use.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookLikeButtonWidget.Width(string)"/>
    public static IFacebookLikeButtonWidget Width(this IFacebookLikeButtonWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>The verb to display on the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="verb">Verb on the button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookLikeButtonWidget.Verb(string)"/>
    public static IFacebookLikeButtonWidget Verb(this IFacebookLikeButtonWidget widget, FacebookLikeButtonVerb verb)
    {
      Assertion.NotNull(widget);

      return widget.Verb(verb.ToString().ToLowerInvariant());
    }

    /// <summary>
    ///   <para>Color scheme used by the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="scheme">The color scheme for the button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookLikeButtonWidget.ColorScheme(string)"/>
    public static IFacebookLikeButtonWidget ColorScheme(this IFacebookLikeButtonWidget widget, FacebookColorScheme scheme)
    {
      Assertion.NotNull(widget);

      return widget.ColorScheme(scheme.ToString().ToLowerInvariant());
    }
  }
}