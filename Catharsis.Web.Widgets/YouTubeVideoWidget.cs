﻿using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders embedded YouTube video on web page.</para>
  /// </summary>
  public sealed class YouTubeVideoWidget : HtmlWidgetBase<IYouTubeVideoWidget>, IYouTubeVideoWidget
  {
    private string id;
    private string width;
    private string height;
    private bool @private;
    private bool secure;

    /// <summary>
    ///   <para>Identifier of video.</para>
    /// </summary>
    /// <param name="id">Identifier of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYouTubeVideoWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    /// <summary>
    ///   <para>Width of video control.</para>
    /// </summary>
    /// <param name="width">Width of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYouTubeVideoWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Height of video control.</para>
    /// </summary>
    /// <param name="height">Height of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYouTubeVideoWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>Whether to keep track of user cookies or not (default is <c>false)</c>.</para>
    /// </summary>
    /// <param name="private"><c>true</c> to set cookies, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYouTubeVideoWidget Private(bool @private = true)
    {
      this.@private = @private;
      return this;
    }

    /// <summary>
    ///   <para>Whether to access video through secure HTTPS protocol or unsecure HTTP (default is <c>false</c>).</para>
    /// </summary>
    /// <param name="isSecure"><c>true</c> to use HTTPS protocol, <c>false</c> to use HTTP.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYouTubeVideoWidget Secure(bool isSecure = true)
    {
      this.secure = isSecure;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.id.IsEmpty() || this.width.IsEmpty() || this.height.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("iframe", tag => tag
        .Attribute("src", "{2}://{1}/embed/{0}".FormatSelf(this.id, this.@private ? "www.youtube-nocookie.com" : "www.youtube.com", this.secure ? "https" : "http"))
        .Attribute("width", this.width)
        .Attribute("height", this.height)
        .Attribute("frameborder", 0)
        .Attribute("allowfullscreen", true)
        .Attribute("webkitallowfullscreen", true)
        .Attribute("mozallowfullscreen", true)));
    }
  }
}