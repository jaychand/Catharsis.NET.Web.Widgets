﻿using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IVkontakteSubscriptionWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IVkontakteSubscriptionWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteSubscriptionWidgetExtensions.Layout(IVkontakteSubscriptionWidget, VkontakteSubscribeButtonLayout)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteSubscriptionWidgetExtensions.Layout(null, VkontakteSubscribeButtonLayout.First));

      new VkontakteSubscriptionWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Layout(VkontakteSubscribeButtonLayout.First), widget));
        Assert.True(widget.Field("layout").To<byte>() == 1);
      });
      new VkontakteSubscriptionWidget().With(widget => Assert.True(widget.Layout(VkontakteSubscribeButtonLayout.Second).Field("layout").To<byte>() == 2));
    }
  }
}