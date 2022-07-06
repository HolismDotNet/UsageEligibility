namespace UsageEligibility;

public class UsageEligibilityContext : DatabaseContext
{
    public override string ConnectionStringName => "UsageEligibility";

    public DbSet<UsageEligibility.Eligibility> Eligibilities { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
