using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vortx.Domain.Core.Notification
{
    public sealed class Notification
    {
        private readonly List<NotificationBase> _notifications;
        public IReadOnlyCollection<NotificationBase> Notifications { get { return _notifications; } }
        public bool HasNotifications { get { return _notifications.Any(); } }

        public Notification()
        {
            _notifications = new List<NotificationBase>();
        }

        public void AddNotification(string key, string message)
        {
            _notifications.Add(new NotificationBase(key, message));
        }

        public void AddNotification(NotificationBase notification)
        {
            _notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<NotificationBase> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(IReadOnlyCollection<NotificationBase> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(IList<NotificationBase> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(ICollection<NotificationBase> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                AddNotification(error.ErrorCode, error.ErrorMessage);
            }
        }
    }


    public class NotificationBase
    {
        public string Key { get; }
        public string Message { get; }

        public NotificationBase(string key, string message)
        {
            Key = key;
            Message = message;
        }
    }
}
