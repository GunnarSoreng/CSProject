using System.Collections.Generic;
// <copyright file="FileReaderTest.cs">Copyright ©  2017</copyright>

using System;
using CSProject;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSProject.Tests
{
    /// <summary>This class contains parameterized unit tests for FileReader</summary>
    [TestClass]
    [PexClass(typeof(FileReader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FileReaderTest
    {

        /// <summary>Test stub for ReadFile()</summary>
        [PexMethod]
        internal List<Staff> ReadFileTest([PexAssumeUnderTest]FileReader target)
        {
            List<Staff> result = target.ReadFile();
            return result;
            // TODO: add assertions to method FileReaderTest.ReadFileTest(FileReader)
        }

    }
}
