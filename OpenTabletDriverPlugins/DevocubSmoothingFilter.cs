using System;
using TabletDriverPlugin;
using TabletDriverPlugin.Attributes;
using TabletDriverPlugin.Tablet;

namespace OpenTabletDriverPlugins
{
    [PluginName("Devocub Smoothing Filter")]
    class DevocubSmoothingFilter : Notifier, IFilter
    {
        public virtual Point Filter(Point point)
        {
            return point;
        }
        public FilterStage FilterStage => FilterStage.PostTranspose;
    }
}
