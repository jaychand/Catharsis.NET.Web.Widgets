﻿using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IPinterestBoardWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IPinterestBoardWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Height(IPinterestBoardWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestBoardWidgetExtensions.Height(null, 0));

      new PinterestBoardWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Height(1), widget));
        Assert.Equal("1", widget.Height());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Width(IPinterestBoardWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestBoardWidgetExtensions.Width(null, 0));

      new PinterestBoardWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Width(1), widget));
        Assert.Equal("1", widget.Width());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Header(IPinterestBoardWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Header_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestBoardWidgetExtensions.Header(null));

      new PinterestBoardWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Header(), widget));
        Assert.Equal("115", widget.Image());
        Assert.Equal("120", widget.Height());
        Assert.Equal("900", widget.Width());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Image(IPinterestBoardWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Image_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestBoardWidgetExtensions.Image(null, 0));

      new PinterestBoardWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Image(1), widget));
        Assert.Equal("1", widget.Image());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Sidebar(IPinterestBoardWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Sidebar_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestBoardWidgetExtensions.Sidebar(null));

      new PinterestBoardWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Sidebar(), widget));
        Assert.Equal("60", widget.Image());
        Assert.Equal("800", widget.Height());
        Assert.Equal("150", widget.Width());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestBoardWidgetExtensions.Square(IPinterestBoardWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Square_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestBoardWidgetExtensions.Square(null));

      new PinterestBoardWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Square(), widget));
        Assert.Equal("80", widget.Image());
        Assert.Equal("320", widget.Height());
        Assert.Equal("400", widget.Width());
      });
    }
  }
}