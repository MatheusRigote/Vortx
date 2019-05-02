using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Vortx.Application.AutoMapper.Config;
using Vortx.Application.ViewModel;
using Vortx.Domain.Model;

namespace Vortx.Test.ViewModel
{
    [TestClass]
    public class CustomerViewModelTest
    {

       [TestMethod]
        public void Create_Domain_Object()
        {
            var customerViewModel = new CustomerViewModel()
            {
                BirthDate = DateTime.Now,
                Cpf = "44398351809",
                RG = "438939098",
                DDD = "011",
                FullName = "Barbosa de Melo",
                Name = "Bruno",
                Number = "995283697",
                Type = 1
            };

            var automapper = Automapper.Bootstrap();
            IMapper mapper = automapper.CreateMapper();

            var _modelMapped = mapper.Map<Customer>(customerViewModel);
            Assert.IsNotNull(_modelMapped);
            Assert.IsInstanceOfType(_modelMapped, typeof(Customer));
        }

    }
}
