public class Validate {
  public static void Main() {
    try {
      string username;
      string password;

      //Ask for username and password
      Console.Write("Enter username\n>>");
      username = Console.ReadLine() ?? "";

      Console.Write("Enter password\n>>");
      password = Console.ReadLine() ?? "";


      //Validate
      ValidateCredentials(username, password);
    } catch (InvalidUsernameException ex) {
      Console.WriteLine($"Username exception : {ex.Message}");
    } catch (InvalidPasswordException ex) {
      Console.WriteLine($"Password exception : {ex.Message}");
    } catch (Exception ex) {
      Console.WriteLine($"Exception : {ex.Message}");
    }
  }


  public static void ValidateCredentials(string username, string password) {
    //Make sure username is at least 5 characters and contains a capital letter
    if (username.ToLower() == username)
      throw new InvalidUsernameException("Username needs at least one capital letter");

    if (username.Length < 5)
      throw new InvalidUsernameException("Username needs at least five characters");



    //Make sure password has a special character and is at least 8 characters
    if (!ContainsSpecialCharacter(password))
      throw new InvalidPasswordException("Password needs at least one special character");

    if (password.Length < 8)
      throw new InvalidPasswordException("Password needs at least eight characters");
  }

  //Returns if string contains any special characters
  public static bool ContainsSpecialCharacter(string str) {
    return str.Any(ch => !char.IsLetterOrDigit(ch));
  }
}
