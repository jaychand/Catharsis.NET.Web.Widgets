﻿using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IFacebookPostWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IFacebookPostWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookPostWidgetExtensions.Width(IFacebookPostWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookPostWidgetExtensions.Width(null, 0));

      Assert.Equal("1", new FacebookPostWidget().Width(1).Width());
    }
  }
}