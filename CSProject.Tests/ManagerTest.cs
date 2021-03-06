// <copyright file="ManagerTest.cs">Copyright ©  2017</copyright>

using System;
using CSProject;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSProject.Tests
{
    /// <summary>This class contains parameterized unit tests for Manager</summary>
    [TestClass]
    [PexClass(typeof(Manager))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ManagerTest
    {

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        internal string ToStringTest([PexAssumeUnderTest]Manager target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method ManagerTest.ToStringTest(Manager)
        }

        /// <summary>Test stub for CalculatePay()</summary>
        [PexMethod]
        internal void CalculatePayTest([PexAssumeUnderTest]Manager target)
        {
            target.CalculatePay();
            // TODO: add assertions to method ManagerTest.CalculatePayTest(Manager)
        }
    }
}
