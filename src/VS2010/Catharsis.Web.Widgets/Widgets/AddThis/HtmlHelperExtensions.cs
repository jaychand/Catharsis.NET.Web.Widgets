﻿using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for class <see cref="HtmlHelper"/>.</para>
  /// </summary>
  /// <seealso cref="HtmlHelper"/>
  public static partial class HtmlHelperExtensions
  {
    private static IAddThisHtmlHelper addthis;

    /// <summary>
    ///   <para>Initializes HTML helper object for rendering of AddThis widgets.</para>
    /// </summary>
    /// <param name="html">Helper object to call method on.</param>
    /// <returns>Widgets factory helper.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
    public static IAddThisHtmlHelper AddThis(this HtmlHelper html)
    {
      Assertion.NotNull(html);

      return addthis ?? (addthis = new AddThisHtmlHelper());
    }
  }
}