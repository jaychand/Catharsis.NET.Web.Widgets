﻿using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IRuTubeHtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="IRuTubeHtmlHelper"/>
  public static class IRuTubeHtmlHelperExtensions
  {
    /// <summary>
    ///   <para>Creates new RuTube embedded video widget.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <param name="builder">Delegate that performs configuration of the widget.</param>
    /// <returns>HTML contents of configured and rendered widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IRuTubeHtmlHelper.Video()"/>
    public static string Video(this IRuTubeHtmlHelper html, Action<IRuTubeVideoWidget> builder)
    {
      Assertion.NotNull(html);
      Assertion.NotNull(builder);

      var widget = html.Video();
      builder(widget);
      return widget.ToHtmlString();
    }
  }
}