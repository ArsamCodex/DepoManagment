using DepoManagment.Server.Models;
using DepoManagment.Shared;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DepoManagment.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<ExtractBoxDepartment> extractBoxDepartments { get; set; } = default;
        public DbSet<Parts> parts { get; set; } = default;
        public DbSet<ReceiveBoxPoint> receiveBoxPoints { get; set; } = default;
    }
}