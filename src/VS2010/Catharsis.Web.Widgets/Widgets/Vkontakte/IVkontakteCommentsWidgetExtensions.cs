using System;
using System.Globalization;
using System.Linq;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IVkontakteCommentsWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IVkontakteCommentsWidget"/>
  public static class IVkontakteCommentsWidgetExtensions
  {
    /// <summary>
    ///   <para>Maximum number of comments to display.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="limit">Maximum number of comments.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommentsWidget.Limit(byte)"/>
    public static IVkontakteCommentsWidget Limit(this IVkontakteCommentsWidget widget, VkontakteCommentsLimit limit)
    {
      Assertion.NotNull(widget);

      return widget.Limit((byte)limit);
    }

    /// <summary>
    ///   <para>Collection of attachment types, which are allowed in comment posts.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="types">Allowed types of post attachments.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommentsWidget.Attach(string[])"/>
    public static IVkontakteCommentsWidget Attach(this IVkontakteCommentsWidget widget, params VkontakteCommentsAttach[] types)
    {
      Assertion.NotNull(widget);

      return widget.Attach(types.Select(item => item == VkontakteCommentsAttach.All ? "*" : item.ToString().ToLowerInvariant()).ToArray());
    }

    /// <summary>
    ///   <para>Horizontal width of comment area.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of comments widget.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteCommentsWidget.Width(string)"/>
    public static IVkontakteCommentsWidget Width(this IVkontakteCommentsWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }
  }
}