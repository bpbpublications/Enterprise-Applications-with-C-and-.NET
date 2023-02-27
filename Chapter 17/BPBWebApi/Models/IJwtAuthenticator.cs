namespace BPBWebApi.Models
{
    public interface IJwtAuthenticator
    {
        Token Authenticate(User user);
    }
}



