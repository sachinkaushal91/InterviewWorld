using InterviewWorld.Controllers;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InterviewWorld.Test.Controllers
{
    public class SubjectControllerTest
    {
        

        [Fact]
        public void SubjectController_GetStringData_ValidResult()
        {
            //AAA
            //Avarage
           
            string expectedResult = "Sachin";

            //Act
            string result = controller.GetStringData();

            //Assert
            Assert.Equal(expectedResult, result);
        }

        public void SubjectController_GetStringData_InValidResult()
        {
            //AAA
            //Avarage
            SubjectController controller = new SubjectController();
            string expectedResult = "Sachin";

            //Act
            string result = controller.GetStringData();

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
