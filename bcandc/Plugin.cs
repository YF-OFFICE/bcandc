using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcandc
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "bcandc";
        public override string Author { get; } = "BigFish";
        public override Version Version { get; } = new Version(1, 1, 0);
		public static Plugin Ins { get; set; }
		public override void OnEnabled()
		{
			Ins = this;
			Log.Debug("bcandc 插件加载成功");
			base.OnEnabled();
		}

		public override void OnDisabled()
		{
			Ins = null;
			Log.Debug("bcandc插件关闭");
			base.OnDisabled();
		}
	}
}
