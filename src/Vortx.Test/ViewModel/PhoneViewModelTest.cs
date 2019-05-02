using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vortx.Application.AutoMapper.Config;
using Vortx.Application.ViewModel;
using Vortx.Domain.Model;

namespace Vortx.Test.ViewModel
{
    [TestClass]
    public class PhoneViewModelTest
    {
        [TestMethod]
        public void Create_Domain_Object()
        {
            var phone = new PhoneViewModel
            {
                DDD = "011",
                Number = "995283697",
                Type = 1                           
            };

            var automapper = Automapper.Bootstrap();
            IMapper mapper = automapper.CreateMapper();

            var _model = mapper.Map<TelephoneLine>(phone);

            Assert.IsNotNull(_model);
            Assert.IsInstanceOfType(_model, typeof(TelephoneLine));
        }
    }
}
