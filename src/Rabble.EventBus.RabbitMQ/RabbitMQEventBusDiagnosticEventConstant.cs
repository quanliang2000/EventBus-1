﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rabble.EventBus.RabbitMQ
{
    /// <summary>
    /// RabbitMQ事件总线的可遥测静态常量
    /// </summary>
    public class RabbitMQEventBusDiagnosticEventConstant
    {
        /// <summary>
        /// 发布事件前
        /// </summary>
        public const string BEFORE_PUBLISH = "Rabble.EventBus.RabbitMQ.PublishEvent.Begin";
        /// <summary>
        /// 发布事件后
        /// </summary>
        public const string AFTER_PUBLISH = "Rabble.EventBus.RabbitMQ.PublishEvent.End";
        /// <summary>
        /// 发布事件失败，开始重试中
        /// </summary>
        public const string PUBLISH_RETRY = "Rabble.EventBus.RabbitMQ.PublishEvent.Retrying";
        /// <summary>
        /// 发布事件失败，超过重试次数后依然未发布成功
        /// </summary>
        public const string PUBLISH_RETRY_FAIL = "Rabble.EventBus.RabbitMQ.PublishEvent.RetryFail";
        /// <summary>
        /// 发布事件失败，出现了其他异常
        /// </summary>
        public const string PUBLISH_FAIL = "Rabble.EventBus.RabbitMQ.PublishEvent.Fail";
        /// <summary>
        /// 开始接受到事件消息
        /// </summary>
        public const string BEFORE_HANDLE_MESSAGE = "Rabble.EventBus.RabbitMQ.HandleEvent.Begin";
        /// <summary>
        /// 已处理完事件消息
        /// </summary>
        public const string AFTER_HANDLE_MESSAGE = "Rabble.EventBus.RabbitMQ.HandleEvent.End";
    }
}
