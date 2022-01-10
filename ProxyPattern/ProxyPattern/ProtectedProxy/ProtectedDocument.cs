namespace ProxyPattern.ProtectedProxy;

 class ProtectedDocument : Document
{
 public ProtectedDocument(string name, string content) : base(name, content)
 {
 }
 
 internal override void UpdateName(string newName, User user)
 {
  if(user.Role != Roles.Author)
  {
   Console.WriteLine("No authorized");
   throw new UnauthorizedAccessException("Cannot update name unless in Author role.");
  }
  Console.WriteLine("Update success");
  base.UpdateName(newName, user);
 }

 internal override void CompleteReview(User editor)
 {
  if (editor.Role != Roles.Editor)
  {
   Console.WriteLine("No authorized");
   throw new UnauthorizedAccessException("Cannot review documents unless you are an Editor.");
  }
  Console.WriteLine("Review success");
  base.CompleteReview(editor);
 }
}