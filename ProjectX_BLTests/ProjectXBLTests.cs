using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectX_BL;
using ProjectX_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX_BL.Tests
{
    [TestClass()]
    public class ProjectXBLTests
    {
        [TestMethod()]
        public void ParticipantInputValuesTest()
        {
            ParticipantDTO obj = new ParticipantDTO{ ParticipantID = 99004937, ParticipantName = "subham", ParticipantEmailID = "subham.panda@gmail.com" };
            ProjectXBL xblObj = new ProjectXBL();
            var expe = obj.ParticipantName;
            var actual = xblObj.ParticipantInputValues(99004937, "subham", "subham.panda@gmail.com").ParticipantName;
            Assert.AreEqual(expe, actual);
        }
    }
}