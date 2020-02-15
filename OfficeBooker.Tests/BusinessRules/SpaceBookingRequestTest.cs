using OfficeBooker.BusinessRules.Models;
using System;
using Xunit;

namespace OfficeBooker.BusinessRules
{
    public class SpaceBookingRequestTest
    {
        [Fact]
        public void ShouldReturnSpaceResultWithRequestValues()
        {
            //Arrange
            var userRequest = new SpaceBookingRequest
            {
                FirstName = "Jose",
                LastName = "Cruz",
                Email = "jose.cruz@gmail.com",
                DateRequested = new DateTime(2020, 01, 05)
            };
            var executor = new SpaceBookingRequestExecution();

            //Act
            SpaceBookingResult result =  executor.BookSpace(userRequest);


            //Assert
            Assert.NotNull(result);
            Assert.Equal(userRequest.FirstName, result.FirstName);
            Assert.Equal(userRequest.LastName, result.LastName);
            Assert.Equal(userRequest.Email, result.Email);
            Assert.Equal(userRequest.DateRequested, result.DateRequested);
        }

        [Fact]
        public void ShouldThrowExceptionIfNullRequest()
        {
            //Arrange
            var executor = new SpaceBookingRequestExecution();

            //Act
            var exception = Assert.Throws<ArgumentNullException>(() => executor.BookSpace(null));

            //Assert
            Assert.Equal("userRequest", exception.ParamName);
        }


    }
}
