﻿using Abp.Grpc.Common.Configuration;
using Consul;

namespace Abp.Grpc.Common.Infrastructure
{
    /// <summary>
    /// Consul Client 工厂
    /// </summary>
    public interface IConsulClientFactory
    {
        /// <summary>
        /// 获得一个新的 Consul Discovery 客户端
        /// </summary>
        /// <param name="config">Consul 注册配置项</param>
        IConsulClient Get(ConsulRegistryConfiguration config);
    }
}