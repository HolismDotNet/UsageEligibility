namespace UsageEligibility;

public class Repository
{
    public static Write<UsageEligibility.Eligibility> Eligibility
    {
        get
        {
            return new Write<UsageEligibility.Eligibility>(new UsageEligibilityContext());
        }
    }
}
