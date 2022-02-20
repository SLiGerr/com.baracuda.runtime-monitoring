﻿using System.Reflection;
using Baracuda.Monitoring.Management;

namespace Baracuda.Monitoring.Internal.Utils
{
    /// <summary>
    /// Struct acts as a wrapper for additional arguments that need to be passed when constructing a unit profile.
    /// </summary>
    public readonly struct MonitorProfileCtorArgs
    {
        public readonly BindingFlags ReflectedMemberFlags;
        public readonly MonitoringSettings Settings;

        public MonitorProfileCtorArgs(BindingFlags reflectedMemberFlags, MonitoringSettings settings)
        {
            ReflectedMemberFlags = reflectedMemberFlags;
            Settings = settings;
        }
    }
}