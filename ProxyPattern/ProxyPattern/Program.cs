using ProxyPattern.ProtectedProxy;

namespace ProxyPattern;

public class Program
{
   static void Main(string[] args)
   {
      var author = new AuthorUpdateDocumentName();
           author.UpdatesNameGivenUserInAuthorRole();
         //  author.ThrowsUnauthorizedExceptionGivenUserNotInAuthorRole();
      Console.ReadLine();
   }
}