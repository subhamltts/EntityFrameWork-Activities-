using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectX_DTO;
using ProjextX_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjextX_DAL.Tests
{
    [TestClass()]
    public class ProjectXDALTests
    {
        ProjectXDAL dalObj = new ProjectXDAL();
        
        [TestMethod()]
        public void UpdateParticipantNameTest()
        {
            ParticipantDTO obj = new ParticipantDTO { ParticipantID = 99004937, ParticipantName = "Subham", ParticipantEmailID = "subham.panda@gmail.com",};
            int expected = 0;
            int actual = dalObj.UpdateParticipantName(obj);
            Assert.AreEqual(expected, actual);
        }
    }
}