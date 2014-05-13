﻿using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook comments widget.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/comments"/>
  public interface IFacebookCommentsWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>The color scheme used by the widget.</para>
    /// </summary>
    /// <param name="colorScheme">Color scheme of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="colorScheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="colorScheme"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookCommentsWidget ColorScheme(string colorScheme);

    /// <summary>
    ///   <para>The color scheme used by the widget.</para>
    /// </summary>
    /// <returns>Color scheme of widget.</returns>
    string ColorScheme();

    /// <summary>
    ///   <para>A boolean value that specifies whether to show the mobile-optimized version or not. If not specified, auto-detection is used.</para>
    /// </summary>
    /// <param name="mobile"><c>true</c> to use mobile-optimized version, <c>false</c> otherwise.</param>
    /// <returns>Reference to the current widget.</returns>
    IFacebookCommentsWidget Mobile(bool mobile);

    /// <summary>
    ///   <para>A boolean value that specifies whether to show the mobile-optimized version or not. If not specified, auto-detection is used.</para>
    /// </summary>
    /// <returns><c>true</c> to use mobile-optimized version, <c>false</c> otherwise.</returns>
    bool? Mobile();

    /// <summary>
    ///   <para>The order to use when displaying comments.</para>
    /// </summary>
    /// <param name="order">Order of comments.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="order"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="order"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookCommentsWidget Order(string order);

    /// <summary>
    ///   <para>The order to use when displaying comments.</para>
    /// </summary>
    /// <returns>Order of comments.</returns>
    string Order();

    /// <summary>
    ///   <para>The number of comments to show by default. The minimum value is 1. Default is 10.</para>
    /// </summary>
    /// <param name="posts">Number of comments to show.</param>
    /// <returns>Reference to the current widget.</returns>
    IFacebookCommentsWidget Posts(byte posts);

    /// <summary>
    ///   <para>The number of comments to show by default. The minimum value is 1. Default is 10.</para>
    /// </summary>
    /// <returns>Number of comments to show.</returns>
    byte? Posts();

    /// <summary>
    ///   <para>The absolute URL that comments posted in the widget will be permanently associated with. Stories on Facebook about comments posted in the plugin will link to this URL. Default is current page URL.</para>
    /// </summary>
    /// <param name="url">URL of the page for comments.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookCommentsWidget Url(string url);

    /// <summary>
    ///   <para>The absolute URL that comments posted in the widget will be permanently associated with. Stories on Facebook about comments posted in the plugin will link to this URL. Default is current page URL.</para>
    /// </summary>
    /// <returns>URL of the page for comments.</returns>
    string Url();

    /// <summary>
    ///   <para>The width of the widget. The mobile version of the Comments widget ignores the width parameter, and instead has a fluid width of 100%.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookCommentsWidget Width(string width);

    /// <summary>
    ///   <para>The width of the widget. The mobile version of the Comments widget ignores the width parameter, and instead has a fluid width of 100%.</para>
    /// </summary>
    /// <returns>Width of widget.</returns>
    string Width();
  }
}