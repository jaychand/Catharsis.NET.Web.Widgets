﻿using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="MailRuVideoLinkWidget"/>.</para>
  /// </summary>
  public sealed class MailRuVideoLinkWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="MailRuVideoLinkWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new MailRuVideoLinkWidget();
      Assert.Null(widget.Field("id"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuVideoLinkWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuVideoLinkWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new MailRuVideoLinkWidget().Id(string.Empty));

      var widget = new MailRuVideoLinkWidget();
      Assert.Null(widget.Field("id"));
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.Equal("id", widget.Field("id").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuVideoLinkWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuVideoLinkWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new MailRuVideoLinkWidget().Write(writer)).ToString().IsEmpty());
      Assert.Equal(@"<a href=""http://my.mail.ru/video/mail/id""></a>", new StringWriter().With(writer => new MailRuVideoLinkWidget().Id("id").Write(writer)).ToString());
    }
  }
}