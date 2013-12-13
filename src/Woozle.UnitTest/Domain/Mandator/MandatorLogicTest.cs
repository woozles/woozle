﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using Woozle.Domain.MandatorManagement;
using Woozle.Model;
using Woozle.Model.SessionHandling;
using Woozle.Persistence;

namespace Woozle.UnitTest.Domain.Mandator
{
    [TestClass]
    public class MandatorLogicTest
    {
        private MandatorLogic mandatorLogic;
        private Mock<IRepository<Model.Mandator>> mandatorRepository;
        private Mock<IUnitOfWork> unitOfWorkMock;

        [TestInitialize]
        public void Initialize()
        {
            this.mandatorRepository = new Mock<IRepository<Model.Mandator>>();
            this.unitOfWorkMock = new Mock<IUnitOfWork>();
            this.mandatorLogic = new MandatorLogic(mandatorRepository.Object);
        }

        [TestMethod]
        public void LoadMandatorTest()
        {

            var expectedMandator = new Model.Mandator
                                     {
                                         Id = 2,
                                         Name = "Test Mandant 2",
                                         Street = "Teststrasse 12",
                                         CityId = 75
                                     };

            this.mandatorRepository.Setup(n => n.CreateQueryable(It.IsAny<Session>()))
                                .Returns(new List<Model.Mandator>
                                             {
                                                 new Model.Mandator
                                                     {
                                                         Id = 1,
                                                         Name = "Test Mandant 1",
                                                         Street = "Teststrasse 10",
                                                         CityId = 123
                                                     },
                                                 expectedMandator
                                             }.AsQueryable());

            var mandator = new Model.Mandator
                               {
                                   Id = 2
                               };

            var session = new Session(Guid.NewGuid(), new SessionData(new User(), mandator), DateTime.Now);

            var result = this.mandatorLogic.LoadMandator(session);
            Assert.AreEqual(expectedMandator, result);
        }

        [TestMethod]
        public void SaveTest()
        {
            var saveMandator = new Model.Mandator
                                   {
                                       Id = 1,
                                       Name = "Test Mandant"
                                   };

            this.mandatorRepository.Setup(n => n.Synchronize(saveMandator, It.IsAny<Session>()))
                                    .Returns(saveMandator);

            this.mandatorRepository.Setup(n => n.UnitOfWork)
                                    .Returns(this.unitOfWorkMock.Object);

            var result = this.mandatorLogic.Save(saveMandator,
                                    new Session(Guid.NewGuid(), new SessionData(new User(), new Model.Mandator()),
                                                DateTime.Now));

            Assert.AreEqual(saveMandator, result.TargetObject);
            Assert.IsFalse(result.HasSystemErrors);

            mandatorRepository.Verify(n => n.Synchronize(saveMandator, It.IsAny<Session>()), Times.Once());
        }

    }
}
