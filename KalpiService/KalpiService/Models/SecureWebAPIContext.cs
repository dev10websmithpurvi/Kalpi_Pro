using System.Data.Entity;

namespace KalpiService.Models
{
    public class SecureWebAPIContext : DbContext
    {
        public SecureWebAPIContext() : base("SecureWebAPIContext")
        {
        }
    }
}