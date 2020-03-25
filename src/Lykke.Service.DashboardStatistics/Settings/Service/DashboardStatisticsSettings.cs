﻿using JetBrains.Annotations;
using Lykke.Service.DashboardStatistics.Settings.Service.Db;
using Lykke.Service.DashboardStatistics.Settings.Service.Rabbit;

namespace Lykke.Service.DashboardStatistics.Settings.Service
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class DashboardStatisticsSettings
    {
        public DbSettings Db { get; set; }

        public RabbitMqSettings RabbitMq { get; set; }
    }
}
