using System.Collections.Generic;
using System.Reflection;
using FlexLayoutTask.Models;
using FlexLayoutTask.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class MathUnitTest
    {
        [TestMethod]
        public void AddTest()
        {
            var vm = new FlexLayoutTask.ViewModel.MainPageViewModel();

            /*var model = new Model();
            model.Text = "";*/

            vm.ValueA = 4;
            vm.ValueB = 6;

            vm.AddCommandHandler();

            Assert.IsTrue(vm.Result == 10, "vm.Result != 10 !");
        }
    }
}