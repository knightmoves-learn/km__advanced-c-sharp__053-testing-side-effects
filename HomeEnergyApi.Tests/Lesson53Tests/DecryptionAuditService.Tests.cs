using HomeEnergyApi.Services;

public class DecryptionAuditServiceTest
{
    private StubLogger<DecryptionAuditService> stubLogger;
    private DecryptionAuditService service;

    public DecryptionAuditServiceTest()
    {
        stubLogger = new StubLogger<DecryptionAuditService>();
        service = new DecryptionAuditService(stubLogger);
    }

    [Fact]
    public void ShouldLog_WhenValueDecrypted()
    {
        string testCipher = "testCipher";
        string plainText = "testText";

        service.OnValueDecrypted(testCipher, plainText);
        
        Assert.Single(stubLogger.LoggedInfoMessages);
    }
}