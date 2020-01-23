using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Interview;
namespace EJTest
{
    [TestClass]
    public class EJTest
    {

        Repository<Storeable<int>, int> repository;
       [TestInitialize]
        public void TestInitialize()
        {
            repository= new Repository<Storeable<int>, int>();
        }

        [TestMethod]
        public void TestRepositorySave_ReturnStorable()
        {
            Storeable<int> storeable = new Storeable<int>() { Id=3 };
            repository = new Repository<Storeable<int>, int>();
            repository.Save(storeable);
            Assert.AreEqual(storeable,repository.Get(3));
        }

        [TestMethod]
        public void TestRepositoryGetAll_ReturnList()
        {
            Storeable<int> storeable1 = new Storeable<int>() { Id = 2 };
            Storeable<int> storeable2 = new Storeable<int>() { Id = 3 };
            Storeable<int> storeable3 = new Storeable<int>() { Id = 4 };
            repository = new Repository<Storeable<int>, int>();
            repository.Save(storeable1);
            repository.Save(storeable2);
            repository.Save(storeable3);
            var equatable = repository.GetAll().ToList();
            Assert.IsTrue(equatable.Count()==3);
        }

        [TestMethod]
        public void TestRepositoryDelete_ReturnList()
        {
            Storeable<int> storeable1 = new Storeable<int>() { Id = 2 };
            Storeable<int> storeable2 = new Storeable<int>() { Id = 3 };
            Storeable<int> storeable3 = new Storeable<int>() { Id = 4 };
            repository = new Repository<Storeable<int>, int>();
            repository.Save(storeable1);
            repository.Save(storeable2);
            repository.Save(storeable3);
            repository.Delete(4);
            var equatable = repository.GetAll().ToList();
            Assert.IsTrue(equatable.Count() == 2);
        }
    }
}
