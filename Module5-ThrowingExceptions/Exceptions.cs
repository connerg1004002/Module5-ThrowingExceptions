using System;

//Custom username exception
public class InvalidUsernameException : Exception {
  public InvalidUsernameException(string message) : base(message) { }
  public InvalidUsernameException(string message, Exception inner) : base(message, inner) { }
  public InvalidUsernameException() : base() { }
}


//Custom password exception
public class InvalidPasswordException : Exception {
  public InvalidPasswordException(string message) : base(message) { }
  public InvalidPasswordException(string message, Exception inner) : base(message, inner) { }
  public InvalidPasswordException() : base() { }
}

