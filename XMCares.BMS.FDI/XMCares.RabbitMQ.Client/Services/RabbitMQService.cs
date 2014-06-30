using System;
using System.Collections.Generic;
using System.Linq;
using EasyNetQ;
using System.Threading;
using System.Threading.Tasks;
using EasyNetQ.Topology;
using XMCares.RabbitMQ.Client.Events;
using System.Text;

namespace XMCares.RabbitMQ.Client.Services
{
    /// <summary>
    /// RabbitMQ客户端服务封装实现类
    /// </summary>
    public class RabbitMQService : IRabbitMQService
    {
        #region 成员变量

        private IAdvancedBus _advBus;
        private CancellationTokenSource _ctokenSourceBus;
        private CancellationToken _ctokenBus;
        private static string _connString = string.Empty;

        #endregion

        #region IRMQService 成员

        public event RabbitMQConnected OnRabbitMQConnected;

        public event RabbitMQMessage OnRabbitMQMessage;

        /// <summary>
        /// Creates a new instance of RabbitBus.
        /// </summary>
        /// <param name="connectionString">
        /// The EasyNetQ connection string. Example:
        /// host=192.168.1.1;port=5672;virtualHost=MyVirtualHost;username=MyUsername;password=MyPassword;requestedHeartbeat=10
        /// 
        /// The following default values will be used if not specified:
        /// host=localhost;port=5672;virtualHost=/;username=guest;password=guest;requestedHeartbeat=0
        /// </param>
        public void CreateBus(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new NotImplementedException("RabbitMQ连接字符串为空！");
            }
            //RabbitMQ连接字符串
            _connString = connectionString;
            //创建RabbitMQ连接状态检测机制
            RunRabbitMQConnectedStatusTask();
        }

        /// <summary>
        /// 注销RabbitMQ Bus
        /// </summary>
        public void LogoutBus()
        {
            if (_advBus != null)
            {
                _ctokenSourceBus.Cancel();
                _advBus.Dispose();
                _advBus = null;
                _advBus_Disconnected();
            }
        }

        /// <summary>
        /// 创建RabbitMQ连接状态检测机制
        /// </summary>
        private void RunRabbitMQConnectedStatusTask()
        {
            _ctokenSourceBus = new CancellationTokenSource();
            _ctokenBus = _ctokenSourceBus.Token;
            var task = new Task(() =>
            {
                while (!_ctokenBus.IsCancellationRequested)
                {
                    try
                    {
                        if (_advBus == null)
                        {
                            _advBus = RabbitHutch.CreateBus(_connString).Advanced;
                            _advBus.Connected += _advBus_Connected;
                            _advBus.Disconnected += _advBus_Disconnected;
                        }
                    }
                    catch
                    {
                    }
                    finally
                    {
                        if (_advBus != null
                            && OnRabbitMQConnected != null)
                        {
                            //响应RabbitMQ连接状态
                            OnRabbitMQConnected(_advBus.IsConnected);
                        }
                        Thread.Sleep(3000);
                    }
                }
            }, _ctokenBus);
            task.Start();
        }

        /// <summary>
        /// 响应RabbitMQ连接断开事件
        /// </summary>
        void _advBus_Disconnected()
        {
            if (OnRabbitMQConnected != null)
                OnRabbitMQConnected(false);
        }

        /// <summary>
        /// 响应RabbitMQ连接事件
        /// </summary>
        void _advBus_Connected()
        {
            if (OnRabbitMQConnected != null)
                OnRabbitMQConnected(true);
        }

        /// <summary>
        /// 发布消息（泛型消息类型）
        /// </summary>
        /// <typeparam name="T">泛型消息类型</typeparam>
        /// <param name="exchangeName">消息路由名称</param>
        /// <param name="routingKey">关键字</param>
        /// <param name="message">消息内容</param>
        public bool Publish<T>(string exchangeName, string routingKey, IMessage<T> message)
        {
            //To...add...

            /// <summary>
            /// Publish a message.
            /// </summary>
            /// <typeparam name="T">The message type</typeparam>
            /// <param name="exchange">The exchange to publish to</param>
            /// <param name="routingKey">The routing key</param>
            /// <param name="message">The message to publish</param>
            //void Publish<T>(IExchange exchange, string routingKey, IMessage<T> message);

            return false;
        }

        /// <summary>
        /// 发布消息（字节流）
        /// </summary>
        /// <param name="exchangeName">消息路由名称</param>
        /// <param name="routingKey">关键字</param>
        /// <param name="properties">消息属性</param>
        /// <param name="messageBody">消息内容</param>
        /// <returns></returns>
        public bool Publish(string exchangeName, string routingKey, MessageProperties properties, string messageBody)
        {
            if (!string.IsNullOrEmpty(exchangeName))
            {
                try
                {
                    if (IsRabbitMQConnected() == true)
                    {
                        var exchange = Exchange.DeclareTopic(exchangeName);
                        if (string.IsNullOrEmpty(messageBody))
                            messageBody = "";
                        var byteArray = Encoding.UTF8.GetBytes(messageBody);
                        using (var channel = _advBus.OpenPublishChannel())
                        {
                            properties.DeliveryMode = 2;
                            channel.Publish(exchange, routingKey, properties, byteArray);
                        }
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new NotImplementedException("RabbitMQ消息路由名称不能为空值！");
            }
            return false;
        }


        /// <summary>
        /// 订阅队列消息（泛型实体对象）
        /// </summary>
        /// <typeparam name="T">泛型实体对象消息</typeparam>
        /// <param name="queueName">队列名称</param>
        public void Subscribe<T>(string queueName)
        {
            //To...add...

            /// <summary>
            /// Subscribe to a stream of messages
            /// </summary>
            /// <typeparam name="T">The message type</typeparam>
            /// <param name="queue">The queue to take messages from</param>
            /// <param name="onMessage">The message handler</param>
            //void Subscribe<T>(IQueue queue, Func<IMessage<T>, MessageReceivedInfo, Task> onMessage);
        }

        /// <summary>
        /// 订阅队列消息
        /// </summary>
        /// <param name="queueName">队列名称</param>
        public void Subscribe(string queueName)
        {
            if (_advBus != null && !string.IsNullOrEmpty(queueName))
            {
                var ctokenSourceSub = new CancellationTokenSource();
                var ctokenSub = ctokenSourceSub.Token;
                /// <summary>
                /// Subscribe to raw bytes from the queue.
                /// </summary>
                /// <param name="queue">The queue to subscribe to</param>
                /// <param name="onMessage">
                /// The message handler. Takes the message body, message properties and some information about the 
                /// receive context. Returns a Task.
                /// </param>
                _advBus.Subscribe(Queue.DeclareDurable(queueName), (bytemsg, properties, receivedinfo) => Task.Factory.StartNew(() =>
                {
                    var args = new MessageEventArgs
                                         {
                                             Bytemessage = bytemsg,
                                             Messagepoperties = properties,
                                             Messagereceivedinfo = receivedinfo
                                         };
                    if (bytemsg != null)
                        OnRabbitMQMessage(args);
                }, ctokenSub));
                
            }
        }

        /// <summary>
        /// 获取RabbitMQ连接状态
        /// </summary>
        /// <returns></returns>
        public bool IsRabbitMQConnected()
        {
            if (_advBus != null)
            {
                return _advBus.IsConnected;
            }
            return false;
        }

        #endregion
    }
}
