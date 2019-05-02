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
            var automapper = Automapper.Bootstrap();
            Assert.IsNotNull(automapper);
            Assert.IsInstanceOfType(automapper, typeof(MapperConfiguration));            
        }

        [TestMethod]
        public void CreateInstanceAutomapper()
        {
            var automapper = Automapper.Bootstrap();
            IMapper mapper = automapper.CreateMapper();
            Assert.IsInstanceOfType(mapper, typeof(IMapper));
        }
    }
}
