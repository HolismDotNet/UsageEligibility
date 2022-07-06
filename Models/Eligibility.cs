namespace UsageEligibility;

public class Eligibility : IEntity
{
    public Eligibility()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid UserGuid { get; set; }

    public dynamic RelatedItems { get; set; }
}
