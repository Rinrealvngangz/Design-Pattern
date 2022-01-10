using ProxyPattern.ProtectedProxy;
using Xunit;

namespace ProxyPattern.Test;

public class AuthorReviewDocument
{
    public void ThrowsUnauthorizedExceptionAndDoesNotSetDateReviewed()
    {
        var author = new User { Role = Roles.Author };
        var document = Document.CreateDocument(TestConstants.TEST_DOCUMENT_NAME, TestConstants.TEST_DOCUMENT_CONTENT);

        Assert.Throws<UnauthorizedAccessException>(() => document.CompleteReview(author));
        Assert.Null(document.DateReviewed);
    }
}