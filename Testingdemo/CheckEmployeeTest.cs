using BlogDAL;
using BlogDAL.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testingdemo
{
    [TestFixture]
    public class CheckEmployeeTest
    {
        [Test]
        public void checkEmployeeExist()
        {
            var obj = new EmpRepository(new BlogDbContext());
            var res = obj.GetEmpInfoByEmialId("user2@example.com");
            Assert.That(res, Is.Not.Null);
        }

    }
}
