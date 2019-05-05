using System;
using Vortx.Domain.Core.EntityBase;
using Vortx.Domain.Core.Enumerators;
using Vortx.Domain.Validation;

namespace Vortx.Domain.Model
{
    public class Plan : EntityWeak
    {                
        public EPlan EPlanCode { get; protected set; }
        public EDDD EOrigin { get; protected set; }    
        public EDDD EDestiny { get; protected set; }
        public DateTime StartTime { get; protected set; }
        public DateTime EndTime { get; protected set; }
        private decimal PricePerMinute { get; set; }
        private decimal PriceTotal { get; set; }

        protected Plan() { }

        public Plan(Plan plan)
        {
            EPlanCode = plan.EPlanCode;
            EOrigin = plan.EOrigin;
            EDestiny = plan.EDestiny;
            StartTime = plan.StartTime;
            EndTime = plan.EndTime;
            
            Validate(this, new PlanValidator());           
        }    

        public Plan(EPlan planCode, EDDD origin, EDDD destiny)
        {
            EPlanCode = planCode;
            EOrigin = origin;
            EDestiny = destiny;
            StartTime = DateTime.Now;
            EndTime = DateTime.Now;

            Validate(this, new PlanValidator());
        }
        
        public virtual decimal CalculateCall()
        {            
            return GetCalculateValue((int)EndTime.Subtract(StartTime).TotalMinutes);
        }

        public decimal CalculateCall(int callTime)
        {
            return GetCalculateValue(callTime);
        }

        private decimal GetCalculateValue(int callTime)
        {
            if (EPlanCode == EPlan.Default)
            {
                if (EOrigin == EDDD.SaoPaulo11 && EDestiny == EDDD.SaoPaulo16)
                    PricePerMinute = 1.90M;
                else if (EOrigin == EDDD.SaoPaulo16 && EDestiny == EDDD.SaoPaulo11)
                    PricePerMinute = 2.90M;
                else if (EOrigin == EDDD.SaoPaulo11 && EDestiny == EDDD.SaoPaulo17)
                    PricePerMinute = 1.70M;
                else if (EOrigin == EDDD.SaoPaulo17 && EDestiny == EDDD.SaoPaulo11)
                    PricePerMinute = 2.70M;
                else if (EOrigin == EDDD.SaoPaulo11 && EDestiny == EDDD.SaoPaulo18)
                    PricePerMinute = 0.90M;
                else if (EOrigin == EDDD.SaoPaulo18 && EDestiny == EDDD.SaoPaulo11)
                    PricePerMinute = 1.90M;
            }
            else if (EPlanCode == EPlan.SpeakMore30)
            {
                if (EOrigin == EDDD.SaoPaulo11 && EDestiny == EDDD.SaoPaulo16)
                    PricePerMinute = callTime <= 30 ? default(decimal) : (1.90M * 10) / 100 + 1.90M;
                else if (EOrigin == EDDD.SaoPaulo16 && EDestiny == EDDD.SaoPaulo11)
                    PricePerMinute = callTime <= 30 ? default(decimal) : (2.90M * 10) / 100 + 2.90M;
                else if (EOrigin == EDDD.SaoPaulo11 && EDestiny == EDDD.SaoPaulo17)
                    PricePerMinute = callTime <= 30 ? default(decimal) : (1.70M * 10) / 100 + 1.70M;
                else if (EOrigin == EDDD.SaoPaulo17 && EDestiny == EDDD.SaoPaulo11)
                    PricePerMinute = callTime <= 30 ? default(decimal) : (2.70M * 10) / 100 + 2.70M;
                else if (EOrigin == EDDD.SaoPaulo11 && EDestiny == EDDD.SaoPaulo18)
                    PricePerMinute = callTime <= 30 ? default(decimal) : (0.90M * 10) / 100 + 0.90M;
                else if (EOrigin == EDDD.SaoPaulo18 && EDestiny == EDDD.SaoPaulo11)
                    PricePerMinute = callTime <= 30 ? default(decimal) : (1.90M * 10) / 100 + 1.90M;
            }
            else if (EPlanCode == EPlan.SpeakMore60)
            {
                if (EOrigin == EDDD.SaoPaulo11 && EDestiny == EDDD.SaoPaulo16)
                    PricePerMinute = callTime <= 60 ? default(decimal) : (1.90M * 10) / 100 + 1.90M;
                else if (EOrigin == EDDD.SaoPaulo16 && EDestiny == EDDD.SaoPaulo11)
                    PricePerMinute = callTime <= 60 ? default(decimal) : (2.90M * 10) / 100 + 2.90M;
                else if (EOrigin == EDDD.SaoPaulo11 && EDestiny == EDDD.SaoPaulo17)
                    PricePerMinute = callTime <= 60 ? default(decimal) : (1.70M * 10) / 100 + 1.70M;
                else if (EOrigin == EDDD.SaoPaulo17 && EDestiny == EDDD.SaoPaulo11)
                    PricePerMinute = callTime <= 60 ? default(decimal) : (2.70M * 10) / 100 + 2.70M;
                else if (EOrigin == EDDD.SaoPaulo11 && EDestiny == EDDD.SaoPaulo18)
                    PricePerMinute = callTime <= 60 ? default(decimal) : (0.90M * 10) / 100 + 0.90M;
                else if (EOrigin == EDDD.SaoPaulo18 && EDestiny == EDDD.SaoPaulo11)
                    PricePerMinute = callTime <= 60 ? default(decimal) : (1.90M * 10) / 100 + 1.90M;
            }
            else if (EPlanCode == EPlan.SpeakMore120)
            {
                if (EOrigin == EDDD.SaoPaulo11 && EDestiny == EDDD.SaoPaulo16)
                    PricePerMinute = callTime <= 120 ? default(decimal) : (1.90M * 10) / 100 + 1.90M;
                else if (EOrigin == EDDD.SaoPaulo16 && EDestiny == EDDD.SaoPaulo11)
                    PricePerMinute = callTime <= 120 ? default(decimal) : (2.90M * 10) / 100 + 2.90M;
                else if (EOrigin == EDDD.SaoPaulo11 && EDestiny == EDDD.SaoPaulo17)
                    PricePerMinute = callTime <= 120 ? default(decimal) : (1.70M * 10) / 100 + 1.70M;
                else if (EOrigin == EDDD.SaoPaulo17 && EDestiny == EDDD.SaoPaulo11)
                    PricePerMinute = callTime <= 120 ? default(decimal) : (2.70M * 10) / 100 + 2.70M;
                else if (EOrigin == EDDD.SaoPaulo11 && EDestiny == EDDD.SaoPaulo18)
                    PricePerMinute = callTime <= 120 ? default(decimal) : (0.90M * 10) / 100 + 0.90M;
                else if (EOrigin == EDDD.SaoPaulo18 && EDestiny == EDDD.SaoPaulo11)
                    PricePerMinute = callTime <= 120 ? default(decimal) : (1.90M * 10) / 100 + 1.90M;
            }

            return callTime * PricePerMinute;
        }
    }
}
