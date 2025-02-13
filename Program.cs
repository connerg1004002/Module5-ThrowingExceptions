class Program {
  static void Main() {
    try {
      string username;
      string password;

      Console.Write("Enter username\n>>");
      username = Console.ReadLine() ?? "";

      Console.Write("Enter password\n>>");
      password = Console.ReadLine() ?? "";


      if (username.ToLower() == username)
        throw new InvalidUsernameException("Username needs at least one capital letter");

      if (username.Length < 5)
        throw new InvalidUsernameException("Username needs at least five characters");


      if (!ContainsSpecialLetter(password))
        throw new InvalidPasswordException("Password needs at least one special character");

      if (password.Length < 8)
        throw new InvalidPasswordException("Password needs at least eight characters");


    } catch (InvalidUsernameException ex) {
      Console.WriteLine($"Username exception : {ex.Message}");
    } catch (InvalidPasswordException ex) {
      Console.WriteLine($"Password exception : {ex.Message}");
    } catch (Exception ex) {
      Console.WriteLine($"Exception : {ex.Message}");
    }
  }

  static bool ContainsSpecialLetter(string str) {
    return str.Any(ch => !char.IsLetterOrDigit(ch));
  }
}
