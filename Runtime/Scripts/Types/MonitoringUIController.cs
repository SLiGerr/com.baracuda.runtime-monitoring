// Copyright (c) 2022 Jonathan Lang

using System;

namespace Baracuda.Monitoring
{
    [Obsolete("Inherit from MonitoringUI instead! This class will be removed in 4.0.0")]
    public abstract class MonitoringUIController : MonitoringUI
    {
        /// <summary>
        /// The visible state of the UI.
        /// </summary>
        public override bool Visible
        {
            get => IsVisible();
            set
            {
                if (value)
                {
                    ShowMonitoringUI();
                }
                else
                {
                    HideMonitoringUI();
                }
            }
        }

        /// <summary>
        /// Use to add UI elements for the passed unit.
        /// </summary>
        protected override void OnMonitorUnitCreated(IMonitorHandle handle)
        {
            OnUnitCreated(handle);
        }

        /// <summary>
        /// Use to remove UI elements for the passed unit.
        /// </summary>
        protected override void OnMonitorUnitDisposed(IMonitorHandle handle)
        {
            OnUnitDisposed(handle);
        }

        [Obsolete("Use MonitoringUI.Visible instead! This class will be removed in 4.0.0")]
        public abstract bool IsVisible();

        [Obsolete("Use MonitoringUI.Visible instead! This class will be removed in 4.0.0")]
        public abstract void ShowMonitoringUI();

        [Obsolete("Use MonitoringUI.Visible instead! This class will be removed in 4.0.0")]
        public abstract void HideMonitoringUI();

        [Obsolete("Use MonitoringUI.OnMonitorUnitDisposed instead! This class will be removed in 4.0.0")]
        public abstract void OnUnitDisposed(IMonitorHandle handle);

        [Obsolete("Use MonitoringUI.OnMonitorUnitCreated instead! This class will be removed in 4.0.0")]
        public abstract void OnUnitCreated(IMonitorHandle handle);
    }
}