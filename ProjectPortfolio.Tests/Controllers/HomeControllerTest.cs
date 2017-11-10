using NUnit.Framework;
using System;
using System.Web.Mvc;
using ProjectPortfolio.Models;
using ProjectPortfolio.Controllers;

namespace ProjectPortfolio.Tests.Controllers
{
    //Controller Tests
    /**
     * Test 1 - test connectivity with the framework by the Home Controller. 
     */
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            var homeController = new HomeController();

            // Act
            var result = (ViewResult)homeController.Index();

            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            var expectedVersion = mvcName.Version.Major + "." + mvcName.Version.Minor;
            var expectedRuntime = isMono ? "Mono" : ".NET";

            // Assert
            Assert.AreEqual(expectedVersion, result.ViewData["Version"]);
            Assert.AreEqual(expectedRuntime, result.ViewData["Runtime"]);
        }
        /**
         * Test 2 - test connectivity with the framework by the About Controller. 
         */
        [Test]
        public void TestAboutController() 
        {

            var aboutController = new AboutController();

            var result = (ViewResult)aboutController.Index();

            Assert.NotNull(result);
        }

        /**
         * Test 3 - test connectivity with the framework by the IrishTechNews Controller. 
         */
        [Test]
        public void TestIrishTechNewsController() 
        {
            var irishTechNewsController = new IrishTechNewsController();

            var result = (ViewResult)irishTechNewsController.Index();

            Assert.NotNull(result);
        }
        /**
         * Test 4 - test connectivity with the framework by the Resume Controller. 
         */
        [Test]
        public void TestResumeController()
        {
            var resumeController = new ResumeController();

            var result = (ActionResult)resumeController.Index();

            Assert.NotNull(result);
        }
        /**
         * Test 5 - test connectivity with the framework by the Contact Controller. 
         */
        [Test]
        public void TestContactController()
        {
            var contactController = new ContactController();

            var result = (ActionResult)contactController.Index();

            Assert.NotNull(result);
        }

        //ContactModel - Data Model Tests
        /**
         * Test 6 - test Contact DataModel Enum fields for correct user defined enum datatype 
         */
        [Test]
        public void TestContactModelEnums()
        {
            var contactModelEnums = new ContactModel();

            var resultContactType = contactModelEnums.ContactReason.GetType();
            var resultContactCountry = contactModelEnums.Country.GetType();

            Assert.True(resultContactType == typeof(ContactType));
            Assert.True(resultContactCountry == typeof(CountryList));
        }
        /**
         * Test 7 - test Contact String Fields on online contact form
         */ 
        [Test]
        public void TestContactModelStringFields()
        {
            var contactModelStrings = new ContactModel();
            contactModelStrings.FirstName = "John";
            contactModelStrings.LastName = "Mulhall";
            contactModelStrings.PhoneNumber = "9999";
            contactModelStrings.Email = "john@gmail.com";
            contactModelStrings.CompanyName = "Jedi Ltd";
            contactModelStrings.City = "Dublin";
            contactModelStrings.Message = "Test Data";

            var resultFirstNameDataType = contactModelStrings.FirstName.GetType();
            var resultLastNameDataType = contactModelStrings.LastName.GetType();
            var resultPhoneNumberDataType = contactModelStrings.PhoneNumber.GetType();
            var resultEmailDataType = contactModelStrings.Email.GetType();
            var resultCompanyNameDataType = contactModelStrings.CompanyName.GetType();
            var resultCityDataType = contactModelStrings.City.GetType();
            var resultMessageDataType = contactModelStrings.Message.GetType();

            Assert.True(resultFirstNameDataType == typeof(string));
            Assert.True(resultLastNameDataType == typeof(string));
            Assert.True(resultPhoneNumberDataType == typeof(string));
            Assert.True(resultEmailDataType == typeof(string));
            Assert.True(resultCompanyNameDataType == typeof(string));
            Assert.True(resultCityDataType == typeof(string));
            Assert.True(resultMessageDataType == typeof(string));
        }
        /**
         * Test 8 - test Controller and Model Validation on the dataModel for "Required" fields
         */
        [Test]
        public void TestContactValidationRequiredFields()
        {
            ContactController testValidation = new ContactController();
            var contactRequiredFieldValidation = new ContactModel();
            contactRequiredFieldValidation.LastName = "Mulhall";
            contactRequiredFieldValidation.Email = "john@gmail.com";
            contactRequiredFieldValidation.Message = "Test Data";

            var validationResult = testValidation.SubmitEntry(contactRequiredFieldValidation);

            Assert.IsNotNull(validationResult); //return obj not empty
            Assert.IsInstanceOf<ViewResult>(validationResult); //datatype return correct
            Assert.True(testValidation.ModelState.IsValid == true); //confirmations data valiation via modelstate
        }
        /**
         * Test 9 - test ContactProcessor class for posting of XML entry to Native XML DB 
         */
        [Test]
        public void TestPostXMLEntryToDB() 
        {
            ContactController contactController = new ContactController();
            var contactXMLPosting = new ContactModel();
            contactXMLPosting.FirstName = "John";
            contactXMLPosting.LastName = "Mulhall";
            contactXMLPosting.PhoneNumber = "08632434233";
            contactXMLPosting.Email = "john@gmail.com";
            contactXMLPosting.CompanyName = "Test Inc";
            contactXMLPosting.City = "Dublin";
            contactXMLPosting.Message = "Test Data to See if message posts to XML DB";
            contactXMLPosting.Country = CountryList.Ireland;
            contactXMLPosting.ContactReason = ContactType.EmploymentOpportunity; 

            var postingResult = contactController.SubmitEntry(contactXMLPosting); 

            Assert.NotNull(postingResult);
        }
    }
}
