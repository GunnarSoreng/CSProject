// <copyright file="AdminTest.cs">Copyright ©  2017</copyright>

using System;
using CSProject;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSProject.Tests
{
    /// <summary>This class contains parameterized unit tests for Admin</summary>
    [TestClass]
    [PexClass(typeof(Admin))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AdminTest
    {

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        internal string ToStringTest([PexAssumeUnderTest]Admin target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method AdminTest.ToStringTest(Admin)
        }

        /// <summary>Test stub for CalculatePay()</summary>
        [PexMethod]
        internal void CalculatePayTest([PexAssumeUnderTest]Admin target)
        {
            target.CalculatePay();
            // TODO: add assertions to method AdminTest.CalculatePayTest(Admin)
        }
    }
}
