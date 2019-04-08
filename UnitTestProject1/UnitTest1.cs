using System;
using FlexLayoutTask.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var vm = new MainPageViewModel();

            vm.a = 4;
            vm.b = 3;

            var method = vm.Method(3, 4);

            Assert.IsTrue(method == 7, "EXCEPTION//////////////////////////////////");
        }
    }
}
