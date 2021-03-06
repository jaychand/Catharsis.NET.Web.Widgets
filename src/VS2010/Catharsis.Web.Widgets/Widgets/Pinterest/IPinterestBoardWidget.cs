﻿using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Pinterest Board widget with board's latest pins.</para>
  ///   <para>Requires Pinterest scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://business.pinterest.com/widget-builder/#do_embed_board"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Pinterest(IWidgetsScriptsRenderer)"/>
  public interface IPinterestBoardWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Pinterest user account.</para>
    /// </summary>
    /// <param name="account">Account name.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IPinterestBoardWidget Account(string account);

    /// <summary>
    ///   <para>Pinterest user account.</para>
    /// </summary>
    /// <returns>Account name.</returns>
    string Account();

    /// <summary>
    ///   <para>Total height of board in pixels.</para>
    /// </summary>
    /// <param name="height">Board's height.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>Min: 60; leave blank for 175.</remarks>
    IPinterestBoardWidget Height(string height);

    /// <summary>
    ///   <para>Total height of board in pixels.</para>
    /// </summary>
    /// <returns>>Board's height.</returns>
    string Height();

    /// <summary>
    ///   <para>Total width of board in pixels.</para>
    /// </summary>
    /// <param name="width">Board's width.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>Min: 130; leave blank for auto.</remarks>
    IPinterestBoardWidget Width(string width);

    /// <summary>
    ///   <para>Total width of board in pixels.</para>
    /// </summary>
    /// <returns>Board's width.</returns>
    string Width();

    /// <summary>
    ///   <para>Identifier of account's board.</para>
    /// </summary>
    /// <param name="id">Board's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IPinterestBoardWidget Id(string id);

    /// <summary>
    ///   <para>Identifier of account's board.</para>
    /// </summary>
    /// <returns>Board's identifier.</returns>
    string Id();

    /// <summary>
    ///   <para>Width of board's image in pixels.</para>
    /// </summary>
    /// <param name="width">Board's image width.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>Min: 60; leave blank for 92.</remarks>
    IPinterestBoardWidget Image(string width);

    /// <summary>
    ///   <para>Width of board's image in pixels.</para>
    /// </summary>
    /// <returns>Board's image width.</returns>
    string Image();
  }
}