using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Vortx.Application.AutoMapper.Config;

namespace Vortx.Test.Application
{
    [TestClass]
    public class AutoMapper
    {
        [TestMethod]
        public void Bootstrap()
        {
            var automapper = Automapper.BootStrapper();
            Assert.IsNotNull(automapper);
            Assert.IsInstanceOfType(automapper, typeof(MapperConfiguration));            
        }

        [TestMethod]
        public void CreateInstanceAutomapper()
        {
            var automapper = Automapper.BootStrapper();
            IMapper mapper = automapper.CreateMapper();
            Assert.IsInstanceOfType(mapper, typeof(IMapper));
        }
    }
}
