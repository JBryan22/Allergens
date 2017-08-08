using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergens.Models;
using System.Collections.Generic;
using System;

namespace Allergens.Tests
{
  [TestClass]
  public class AllergyTest
  {
    [TestMethod]
    public void GetAllergies_GivenAllergyScoreReturnListOfAllergies_True()
    {
      //Arrange
      Allergy newAllergy = new Allergy(15);
      List<string> expectedResult = new List<string> {"eggs", "peanuts", "shellfish", "strawberries"};

      //Act
      List<string> actualResult = newAllergy.GetAllergies();

      //Assert
      CollectionAssert.AreEqual(expectedResult, actualResult);
    }
  }
}
