// <copyright file="PaySlipTest.cs">Copyright ©  2017</copyright>
using System;
using System.Collections.Generic;
using CSProject;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSProject.Tests
{
    /// <summary>This class contains parameterized unit tests for PaySlip</summary>
    [PexClass(typeof(PaySlip))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class PaySlipTest
    {
        /// <summary>Test stub for GeneratePaySlip(List`1&lt;Staff&gt;)</summary>
        [PexMethod]
        internal void GeneratePaySlipTest([PexAssumeUnderTest]PaySlip target, List<Staff> myStaff)
        {
            target.GeneratePaySlip(myStaff);
            // TODO: add assertions to method PaySlipTest.GeneratePaySlipTest(PaySlip, List`1<Staff>)

        }

        /// <summary>Test stub for GenerateSummary(List`1&lt;Staff&gt;)</summary>
        [PexMethod]
        internal void GenerateSummaryTest([PexAssumeUnderTest]PaySlip target, List<Staff> myStaff)
        {
            target.GenerateSummary(myStaff);
            // TODO: add assertions to method PaySlipTest.GenerateSummaryTest(PaySlip, List`1<Staff>)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        internal string ToStringTest([PexAssumeUnderTest]PaySlip target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method PaySlipTest.ToStringTest(PaySlip)
        }

        /// <summary>Test stub for .ctor(Int32, Int32)</summary>
        [PexMethod]
        internal PaySlip ConstructorTest(int payMonth, int payYear)
        {
            PaySlip target = new PaySlip(payMonth, payYear);
            return target;
            // TODO: add assertions to method PaySlipTest.ConstructorTest(Int32, Int32)
        }
    }
}
