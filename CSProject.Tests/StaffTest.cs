// <copyright file="StaffTest.cs">Copyright ©  2017</copyright>

using System;
using CSProject;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSProject.Tests
{
    /// <summary>This class contains parameterized unit tests for Staff</summary>
    [TestClass]
    [PexClass(typeof(Staff))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StaffTest
    {

        /// <summary>Test stub for .ctor(String, Single)</summary>
        [PexMethod]
        internal Staff ConstructorTest(string name, float rate)
        {
            Staff target = new Staff(name, rate);
            return target;
            // TODO: add assertions to method StaffTest.ConstructorTest(String, Single)
        }

    }
}
