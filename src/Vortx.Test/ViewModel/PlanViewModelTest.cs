using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Vortx.Application.AutoMapper.Config;
using Vortx.Application.ViewModel;
using Vortx.Domain.Model;

namespace Vortx.Test.ViewModel
{
    [TestClass]
    public class PlanViewModelTest
    {
        [TestMethod]
        public void Create_Domain_Object()
        {
            var planViewModel = new PlanViewModel
            {
                //Destiny = 1,
                Origin = Domain.Core.Enumerators.EDDD.SaoPaulo11,
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                Destiny = Domain.Core.Enumerators.EDDD.SaoPaulo16,
                PlanCode = Domain.Core.Enumerators.EPlan.Default,                
            };

            var automapper = Automapper.BootStrapper();
            IMapper mapper = automapper.CreateMapper();

            var _modelMapped = mapper.Map<Plan>(planViewModel);
            Assert.IsNotNull(_modelMapped);
            Assert.IsInstanceOfType(_modelMapped, typeof(Plan));
        }
    }
}
