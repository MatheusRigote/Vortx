using System;
using System.Collections.Generic;
using Vortx.Domain.Contract;
using Vortx.Domain.Core.Enumerators;
using Vortx.Domain.Core.Notification;
using System.Linq;
using Vortx.Domain.Helper;
using Vortx.Domain.Model;
using System.Globalization;

namespace Vortx.Domain.Service
{
    public class PlanService: IPlan
    {
        private readonly Notification notification;

        public PlanService(Notification _notification)
        {
            notification = _notification;
        }

        public IEnumerable<object> GetTheOriginalRegions()
        {
            return (from EDDD data in Enum.GetValues(typeof(EDDD))
                    select new
                    {
                        AreaCode = (int)data,
                        Region = EnumerationHelper.GetDescriptionName(data)

                    }).AsEnumerable().ToList();                                                     
        }

        public string GetCallPrice(Plan plan)
        {            
            var model = new Plan(plan);

            if (!model.IsValid)
            {
                notification.AddNotifications(model.ErrorMessages);
                return string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:N}", default(decimal));
            }

            return string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:N}", model.CalculateCall());
        }

        public string GetCallPrice(EPlan planCode, EDDD origin, EDDD destiny, int minute)
        {
            var model = new Plan(planCode, origin, destiny);

            if (!model.IsValid)
            {
                notification.AddNotifications(model.ErrorMessages);
                return string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:N}", default(decimal));
            }

            return string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:N}", model.CalculateCall(minute));
        }
    }
}
