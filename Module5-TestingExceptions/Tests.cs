using System;

[TestClass]
public class Tests {
  
  //Username should throw error
  [TestMethod]
  public void CheckIfValidateThrowsErrorOnBadUsername() {
    Assert.ThrowsException<InvalidUsernameException>
      (() => Validate.ValidateCredentials("f", "Password123!"));
  }

  //Password should throw error
  [TestMethod]
  public void CheckIfValidateThrowsErrorOnBadPassword() {
    Assert.ThrowsException<InvalidPasswordException>
      (() => Validate.ValidateCredentials("Username", "j"));
  }

  //No errors should be thrown
  [TestMethod]
  public void CheckIfValidateThrowsNoErrorOnCorrectInput() {
    try {
      Validate.ValidateCredentials("Username", "Password123!");
    } catch(Exception) {
      Assert.Fail("Threw Exception");
    }
  }
}