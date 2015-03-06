using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DBModel;
using BLL.Implementations;
using BLL.Interfaces;
using DAL;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Initialize()
        {
        }

        [TestMethod]
        public void TestGroup()
        {
            Group group = new Group();
            Assert.IsNotNull(group);
            GroupManager groupMan = new GroupManager(new UnitOfWork());
            Assert.IsNotNull(groupMan);
        }

        [TestMethod]
        public void TestGetGroups()
        {
            GroupManager groupMan = new GroupManager(new UnitOfWork());
            Assert.IsNotNull(groupMan);
            var groups = groupMan.GetGroups();
            Assert.IsNotNull(groups);
        }

        [TestMethod]
        public void TestAddGroup()
        {
            GroupManager groupMan = new GroupManager(new UnitOfWork());
            Assert.IsNotNull(groupMan);
            var newGroup = groupMan.AddGroup(new Group { Name = "Shkola" });
            Assert.IsNotNull(newGroup);
        }

        [TestMethod]
        public void TestGetGroupById()
        {
            GroupManager groupMan = new GroupManager(new UnitOfWork());
            Assert.IsNotNull(groupMan);
            Group group = groupMan.GetGroups().Last();
            Assert.IsNotNull(group);
            groupMan.DeleteGroup(group);
            Group gt = groupMan.GetGroups().Last();
            Assert.AreNotEqual(group, gt);
        }

        [TestMethod]
        public void TestEditGroup()
        {
            GroupManager groupMan = new GroupManager(new UnitOfWork());
            Assert.IsNotNull(groupMan);
            Group group = groupMan.GetGroups().Last();
            Assert.IsNotNull(group);
            groupMan.EditGroup(group);
            Group gt = groupMan.GetGroups().Last();
            Assert.AreEqual(group.Id, gt.Id);
        }


        [TestCleanup]
        public void CleanUp()
        {
        }
    }
}
