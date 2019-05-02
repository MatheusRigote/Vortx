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
                Destiny = "016",
                Origin = "011",
                Minute = DateTime.Now,
                PlanCode = 1,
                PricePerMinute = 16m
            };

            var automapper = Automapper.Bootstrap();
            IMapper mapper = automapper.CreateMapper();

            var _modelMapped = mapper.Map<TelephonyPlan>(planViewModel);
            Assert.IsNotNull(_modelMapped);
            Assert.IsInstanceOfType(_modelMapped, typeof(TelephonyPlan));
        }
    }
}
