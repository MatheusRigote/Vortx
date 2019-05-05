using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Vortx.Application.AutoMapper.Config;
using Vortx.Application.ViewModel;
using Vortx.Domain.Model;

namespace Vortx.Test.Model
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void Create_Customer_Model_Object()
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

            var automapper = Automapper.BootStrapper();
            IMapper mapper = automapper.CreateMapper();

            var _modelMapped = mapper.Map<Customer>(customerViewModel);
            var model = new Customer(_modelMapped);

            Assert.IsNotNull(model);
            Assert.IsTrue(model.GuiId != Guid.Empty);
            Assert.IsInstanceOfType(model, typeof(Customer));            
        }

        [TestMethod]
        public void Model_Is_Valid()
        {
            var customerViewModel = new CustomerViewModel()
            {
                BirthDate = new DateTime(1994,7,30),
                Cpf = "44398351809",
                RG = "438939098",
                DDD = "011",
                FullName = "Barbosa de Melo",
                Name = "Bruno",
                Number = "995283697",
                Type = 1
            };

            var automapper = Automapper.BootStrapper();
            IMapper mapper = automapper.CreateMapper();

            var _modelMapped = mapper.Map<Customer>(customerViewModel);
            var model = new Customer(_modelMapped);

            Assert.IsTrue(model.IsValid);
        }

        [TestMethod]
        public void Model_Is_NOT_Valid()
        {
            var customerViewModel = new CustomerViewModel()
            {
                BirthDate = DateTime.Now,
                Cpf = "1111111111",
                RG = "1111111111",
                DDD = "011",
                FullName = "Barbosa de Melo",
                Name = "Bruno",
                Number = "995283697",
                Type = 1
            };

            var automapper = Automapper.BootStrapper();
            IMapper mapper = automapper.CreateMapper();

            var _modelMapped = mapper.Map<Customer>(customerViewModel);
            var model = new Customer(_modelMapped);

            Assert.IsFalse(model.IsValid);
        }
    }
}
