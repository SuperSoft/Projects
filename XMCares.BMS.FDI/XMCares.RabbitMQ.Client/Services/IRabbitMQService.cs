using System;
using System.Collections.Generic;
using System.Linq;
using EasyNetQ.Topology;
using EasyNetQ;
using XMCares.RabbitMQ.Client.Events;

namespace XMCares.RabbitMQ.Client.Services
{
    /// <summary>
    /// 定义连接状态事件委托
    /// </summary>
    /// <param name="isConnected">True/False</param>
    public delegate void RabbitMQConnected(bool isConnected);
    /// <summary>
    /// 定义接收消息事件委托
    /// </summary>
    /// <param name="e">消息对象</param>
    public delegate void RabbitMQMessage(MessageEventArgs e);

    /// <summary>
    /// RabbitMQ客户端服务封装接口
    /// </summary>
    public interface IRabbitMQService
    {
        /// <summary>
        /// 连接状态事件
        /// </summary>
        event RabbitMQConnected OnRabbitMQConnected;
        /// <summary>
        /// 接收消息事件
        /// </summary>
        event RabbitMQMessage OnRabbitMQMessage;
        /// <summary>
        /// 创建RabbitBus新实例
        /// </summary>
        /// <param name="connectionString">
        /// The EasyNetQ connection string. Example:
        /// host=192.168.1.1;port=5672;virtualHost=MyVirtualHost;username=MyUsername;password=MyPassword;requestedHeartbeat=10
        /// 
        /// The following default values will be used if not specified:
        /// host=localhost;port=5672;virtualHost=/;username=guest;password=guest;requestedHeartbeat=0
        /// </param>
        void CreateBus(string connectionString);
        /// <summary>
        /// 注销RabbitMQ Bus
        /// </summary>
        void LogoutBus();
        /// <summary>
        /// 发布消息（泛型消息类型）
        /// </summary>
        /// <typeparam name="T">泛型消息类型</typeparam>
        /// <param name="exchangeName">消息路由</param>
        /// <param name="routingKey">关键字</param>
        /// <param name="message">消息内容</param>
        bool Publish<T>(string exchangeName, string routingKey, IMessage<T> message);
        /// <summary>
        /// 发布消息（字节流）
        /// </summary>
        /// <param name="exchangeName">消息路由</param>
        /// <param name="routingKey">关键字</param>
        /// <param name="properties">消息属性</param>
        /// <param name="messageBody">消息内容</param>
        /// <returns></returns>
        bool Publish(string exchangeName, string routingKey, MessageProperties properties, string messageBody);
        /// <summary>
        /// 订阅队列消息（泛型消息类型）
        /// </summary>
        /// <typeparam name="T">泛型消息类型</typeparam>
        /// <param name="queueName">队列名称</param>
        void Subscribe<T>(string queueName);
        /// <summary>
        /// 订阅队列消息（字节流）
        /// </summary>
        /// <param name="queueName">队列名称</param>
        void Subscribe(string queueName);
        /// <summary>
        /// 获取RabbitMQ连接状态
        /// </summary>
        /// <returns></returns>
        bool IsRabbitMQConnected();
    }
}
