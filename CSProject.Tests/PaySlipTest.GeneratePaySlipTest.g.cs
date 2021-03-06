using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CSProject;
// <copyright file="PaySlipTest.GeneratePaySlipTest.g.cs">Copyright ©  2017</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace CSProject.Tests
{
    public partial class PaySlipTest
    {

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void GeneratePaySlipTestThrowsNullReferenceException711()
{
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, (List<Staff>)null);
}

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
public void GeneratePaySlipTest139()
{
    List<Staff> list;
    Staff[] staffs = new Staff[0];
    list = new List<Staff>((IEnumerable<Staff>)staffs);
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, list);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void GeneratePaySlipTestThrowsNullReferenceException290()
{
    List<Staff> list;
    Staff[] staffs = new Staff[1];
    list = new List<Staff>((IEnumerable<Staff>)staffs);
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, list);
}

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
public void GeneratePaySlipTest859()
{
    Staff staff;
    List<Staff> list;
    staff = new Staff((string)null, (float)0);
    staff.HoursWorked = 0;
    staff.CalculatePay();
    Staff[] staffs = new Staff[1];
    staffs[0] = staff;
    list = new List<Staff>((IEnumerable<Staff>)staffs);
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, list);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
public void GeneratePaySlipTest85901()
{
    Staff staff;
    List<Staff> list;
    staff = new Staff("", (float)0);
    staff.HoursWorked = 0;
    staff.CalculatePay();
    Staff[] staffs = new Staff[1];
    staffs[0] = staff;
    list = new List<Staff>((IEnumerable<Staff>)staffs);
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, list);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void GeneratePaySlipTestThrowsNullReferenceException304()
{
    Staff staff;
    List<Staff> list;
    staff = new Staff((string)null, (float)0);
    staff.HoursWorked = 0;
    staff.CalculatePay();
    Staff[] staffs = new Staff[2];
    staffs[0] = staff;
    list = new List<Staff>((IEnumerable<Staff>)staffs);
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, list);
}

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
public void GeneratePaySlipTest143()
{
    Staff staff;
    List<Staff> list;
    staff = new Staff((string)null, (float)0);
    staff.HoursWorked = 0;
    staff.CalculatePay();
    Staff[] staffs = new Staff[2];
    staffs[0] = staff;
    staffs[1] = staff;
    list = new List<Staff>((IEnumerable<Staff>)staffs);
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, list);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
public void GeneratePaySlipTest96()
{
    Staff staff;
    Manager manager;
    List<Staff> list;
    staff = new Staff((string)null, (float)0);
    staff.HoursWorked = 0;
    staff.CalculatePay();
    manager = new Manager((string)null);
    ((Staff)manager).HoursWorked = 0;
    manager.CalculatePay();
    Staff[] staffs = new Staff[2];
    staffs[0] = staff;
    staffs[1] = (Staff)manager;
    list = new List<Staff>((IEnumerable<Staff>)staffs);
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, list);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void GeneratePaySlipTestThrowsNullReferenceException555()
{
    Staff staff;
    Manager manager;
    List<Staff> list;
    staff = new Staff((string)null, (float)0);
    staff.HoursWorked = 0;
    staff.CalculatePay();
    manager = new Manager("");
    ((Staff)manager).HoursWorked = 161;
    manager.CalculatePay();
    Staff[] staffs = new Staff[3];
    staffs[0] = staff;
    staffs[1] = (Staff)manager;
    list = new List<Staff>((IEnumerable<Staff>)staffs);
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, list);
}

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
public void GeneratePaySlipTest16()
{
    Staff staff;
    Manager manager;
    List<Staff> list;
    staff = new Staff((string)null, (float)0);
    staff.HoursWorked = 0;
    staff.CalculatePay();
    manager = new Manager("");
    ((Staff)manager).HoursWorked = 161;
    manager.CalculatePay();
    Staff[] staffs = new Staff[3];
    staffs[0] = staff;
    staffs[1] = (Staff)manager;
    staffs[2] = (Staff)manager;
    list = new List<Staff>((IEnumerable<Staff>)staffs);
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, list);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
public void GeneratePaySlipTest269()
{
    Staff staff;
    Manager manager;
    Admin admin;
    List<Staff> list;
    staff = new Staff((string)null, (float)0);
    staff.HoursWorked = 0;
    staff.CalculatePay();
    manager = new Manager("");
    ((Staff)manager).HoursWorked = 161;
    manager.CalculatePay();
    admin = new Admin((string)null);
    ((Staff)admin).HoursWorked = 0;
    admin.CalculatePay();
    Staff[] staffs = new Staff[3];
    staffs[0] = staff;
    staffs[1] = (Staff)manager;
    staffs[2] = (Staff)admin;
    list = new List<Staff>((IEnumerable<Staff>)staffs);
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, list);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
public void GeneratePaySlipTest26901()
{
    Staff staff;
    Manager manager;
    Admin admin;
    List<Staff> list;
    staff = new Staff((string)null, (float)0);
    staff.HoursWorked = 0;
    staff.CalculatePay();
    manager = new Manager("");
    ((Staff)manager).HoursWorked = 161;
    manager.CalculatePay();
    admin = new Admin((string)null);
    ((Staff)admin).HoursWorked = 161;
    admin.CalculatePay();
    Staff[] staffs = new Staff[3];
    staffs[0] = staff;
    staffs[1] = (Staff)manager;
    staffs[2] = (Staff)admin;
    list = new List<Staff>((IEnumerable<Staff>)staffs);
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, list);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void GeneratePaySlipTestThrowsNullReferenceException55501()
{
    Staff staff;
    Manager manager;
    List<Staff> list;
    staff = new Staff((string)null, (float)0);
    staff.HoursWorked = 0;
    staff.CalculatePay();
    manager = new Manager((string)null);
    ((Staff)manager).HoursWorked = 32;
    manager.CalculatePay();
    Staff[] staffs = new Staff[3];
    staffs[0] = staff;
    staffs[1] = (Staff)manager;
    list = new List<Staff>((IEnumerable<Staff>)staffs);
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, list);
}

[TestMethod]
[PexGeneratedBy(typeof(PaySlipTest))]
public void GeneratePaySlipTest398()
{
    Staff staff;
    Manager manager;
    Admin admin;
    Admin admin1;
    List<Staff> list;
    staff = new Staff((string)null, (float)0);
    staff.HoursWorked = 0;
    staff.CalculatePay();
    manager = new Manager("");
    ((Staff)manager).HoursWorked = 161;
    manager.CalculatePay();
    admin = new Admin((string)null);
    ((Staff)admin).HoursWorked = 1;
    admin.CalculatePay();
    admin1 = new Admin((string)null);
    ((Staff)admin1).HoursWorked = 0;
    admin1.CalculatePay();
    Staff[] staffs = new Staff[4];
    staffs[0] = staff;
    staffs[1] = (Staff)manager;
    staffs[2] = (Staff)admin;
    staffs[3] = (Staff)admin1;
    list = new List<Staff>((IEnumerable<Staff>)staffs);
    PaySlip s0 = new PaySlip(0, 0);
    this.GeneratePaySlipTest(s0, list);
    Assert.IsNotNull((object)s0);
}
    }
}
