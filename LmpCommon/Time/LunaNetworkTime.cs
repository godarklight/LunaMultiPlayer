using System;
using System.Threading;

namespace LmpCommon.Time
{
    /// <summary>
    /// Use this class to retrieve exact times. All players and the server must have the same exact time so we adjust
    /// this class to geit their internal clock errors against a NTP server
    /// </summary>
    public class LunaNetworkTime
    {
        /// <summary>
        /// Get correctly sync local time from internet
        /// </summary>
        public static DateTime Now => UtcNow.ToLocalTime();
        public static TimeSpan TimeDifference { get; set; } = TimeSpan.Zero;
        public static float SimulatedMsTimeOffset { get; set; } = 0;

        /// <summary>
        /// We sync time with time provider every 30 seconds. This limits the number of clients/servers in the same machine to 6
        /// as the max queries a NTP server accept are 1 every 5 seconds
        /// </summary>
        public const int TimeSyncIntervalMs = 30 * 1000;

        /// <summary>
        /// Get correctly sync UTC time from internet
        /// </summary>
        public static DateTime UtcNow => LunaComputerTime.UtcNow + TimeDifference.Negate() + TimeSpan.FromMilliseconds(SimulatedMsTimeOffset);
    }
}
