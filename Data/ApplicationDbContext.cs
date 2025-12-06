using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore;
using AbsherSecure1.Models;

namespace AbsherSecure1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<IssueRequest> issueRequests { get; set; }
        public DbSet<NewIDRequest> newIDRequests { get; set; }
        public DbSet<PassportRequest> passportRequests { get; set; }
        public DbSet<RenewalRequest> renewalRequests { get; set; }
        public DbSet<ReportModel> reportModels { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserIdentity> userIdentities { get; set; }
        public DbSet<VisaRequest> visaRequests { get; set; }

    }
}
