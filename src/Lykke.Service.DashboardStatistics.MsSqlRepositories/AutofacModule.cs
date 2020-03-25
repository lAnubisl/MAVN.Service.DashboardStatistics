﻿using Autofac;
using Lykke.Common.MsSql;
using Lykke.Service.DashboardStatistics.Domain.Repositories;
using Lykke.Service.DashboardStatistics.MsSqlRepositories.Repositories;

namespace Lykke.Service.DashboardStatistics.MsSqlRepositories
{
    public class AutofacModule : Module
    {
        private readonly string _connectionString;

        public AutofacModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterMsSql(_connectionString,
                connectionString => new DashboardStatisticsContext(connectionString, false),
                dbConnection => new DashboardStatisticsContext(dbConnection));

            builder.RegisterType<CustomerActivityRepository>()
                .As<ICustomerActivityRepository>()
                .SingleInstance();

            builder.RegisterType<CustomerStatisticRepository>()
                .As<ICustomerRegistrationRepository>()
                .SingleInstance();

            builder.RegisterType<LeadStatisticRepository>()
                .As<ILeadStatisticRepository>()
                .SingleInstance();
        }
    }
}
