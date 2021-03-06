using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Mail.ru "Like" button on web page.</para>
  ///   <para>Requires MailRu scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://api.mail.ru/sites/plugins/share"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.MailRu(IWidgetsScriptsRenderer)"/>
  public class MailRuLikeButtonWidget : HtmlWidget, IMailRuLikeButtonWidget
  {
    private string type = "combo";
    private string size = "20";
    private byte layout = (byte) MailRuLikeButtonLayout.First;
    private bool text = true;
    private byte textType = (byte) MailRuLikeButtonTextType.First;
    private bool counter = true;
    private string counterPosition = MailRuLikeButtonCounterPosition.Right.ToString().ToLowerInvariant();

    /// <summary>
    ///   <para>Whether to render share counter next to a button. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show share counter, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IMailRuLikeButtonWidget Counter(bool show)
    {
      this.counter = show;
      return this;
    }

    /// <summary>
    ///   <para>Whether to render share counter next to a button. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show share counter, <c>false</c> to hide.</returns>
    public bool Counter()
    {
      return this.counter;
    }

    /// <summary>
    ///   <para>Position of a share counter.</para>
    /// </summary>
    /// <param name="position">Position of a counter.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="position"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="position"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuLikeButtonWidget CounterPosition(string position)
    {
      Assertion.NotEmpty(position);

      this.counterPosition = position;
      return this;
    }

    /// <summary>
    ///   <para>Position of a share counter.</para>
    /// </summary>
    /// <returns>Position of a counter.</returns>
    public string CounterPosition()
    {
      return this.counterPosition;
    }

    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <param name="layout">Visual layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuLikeButtonWidget Layout(byte layout)
    {
      this.layout = layout;
      return this;
    }

    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <returns>Visual layout of button.</returns>
    public byte Layout()
    {
      return this.layout;
    }

    /// <summary>
    ///   <para>Vertical size of button.</para>
    /// </summary>
    /// <param name="size">Vertical size of button.</param>
    /// <returns>Reference to the current widget.</returns>
    public IMailRuLikeButtonWidget Size(string size)
    {
      this.size = size;
      return this;
    }

    /// <summary>
    ///   <para>Vertical size of button.</para>
    /// </summary>
    /// <returns>Vertical size of button.</returns>
    public string Size()
    {
      return this.size;
    }

    /// <summary>
    ///   <para>Whether to show text label on button. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="text"><c>true</c> to show text label, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IMailRuLikeButtonWidget Text(bool text)
    {
      this.text = text;
      return this;
    }

    /// <summary>
    ///   <para>Whether to show text label on button. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show text label, <c>false</c> to hide.</returns>
    public bool Text()
    {
      return this.text;
    }

    /// <summary>
    ///   <para>Type of button.</para>
    /// </summary>
    /// <param name="type">Type of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="type"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="type"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuLikeButtonWidget Type(string type)
    {
      Assertion.NotEmpty(type);

      this.type = type;
      return this;
    }

    /// <summary>
    ///   <para>Type of button.</para>
    /// </summary>
    /// <returns>Type of button.</returns>
    public string Type()
    {
      return this.type;
    }

    /// <summary>
    ///   <para>Type of text label to show on button.</para>
    /// </summary>
    /// <param name="type">Type of text label.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="type"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="type"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuLikeButtonWidget TextType(byte type)
    {
      this.textType = type;
      return this;
    }

    /// <summary>
    ///   <para>Type of text label to show on button.</para>
    /// </summary>
    /// <returns>Type of text label.</returns>
    public byte TextType()
    {
      return this.textType;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      var config = new Dictionary<string, object>
      {
        { "sz", this.Size() },
        { "st", this.Layout() },
        { "tp", this.Type() }
      };

      if (!this.Counter())
      {
        config["nc"] = 1;
      }
      else if (this.CounterPosition() != null && string.Equals(this.CounterPosition(), MailRuLikeButtonCounterPosition.Upper.ToString(), StringComparison.InvariantCultureIgnoreCase))
      {
        config["vt"] = 1;
      }

      if (!this.Text())
      {
        config["nt"] = 1;
      }
      else
      {
        config["cm"] = this.TextType();
        config["ck"] = this.TextType();
      }

      return new TagBuilder("a")
        .Attribute("target", "_blank")
        .Attribute("href", "http://connect.mail.ru/share")
        .Attribute("data-mrc-config", config.Json())
        .CssClass("mrc__plugin_uber_like_button")
        .InnerHtml("��������")
        .ToString();
    }
  }
}