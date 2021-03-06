// Copyright (c) Stride contributors (https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using Stride.Core;
using Stride.Core.Collections;

namespace Stride.UI
{
    /// <summary>
    /// A collection of UIElements.
    /// </summary>
    [DataContract(nameof(UIElementCollection))]
    public class UIElementCollection : TrackingCollection<UIElement>
    {
    }
}
