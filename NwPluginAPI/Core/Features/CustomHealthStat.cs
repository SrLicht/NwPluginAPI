using PlayerStatsSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginAPI.Core.Features
{
	/// <summary>
	/// A custom version of <see cref="HealthStat"/> which allows the player's max amount of health to be changed.
	/// </summary>
	public class CustomHealthStat : HealthStat
	{
		/// <inheritdoc/>
		public override float MaxValue => CustomMaxValue == default ? base.MaxValue : CustomMaxValue;

		/// <summary>
		/// Gets or sets the maximum amount of health the player will have.
		/// </summary>
		public float CustomMaxValue { get; set; }
	}
}
