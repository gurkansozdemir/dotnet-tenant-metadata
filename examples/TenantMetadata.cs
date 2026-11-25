public readonly record struct DemoTenantId(Guid Value);
public sealed record TenantSummary(DemoTenantId Id, string DisplayName);

public interface ITenantDirectory
{
    Task<TenantSummary?> FindAsync(DemoTenantId id, CancellationToken cancellationToken);
}
