namespace Azure.DevOps.Notificator.Types;

public class Event
{
	public Guid? Id { get; set; }

	public string EventType { get; set; }

	public string PublisherId { get; set; }

	public string Scope { get; set; }

	public Message Message { get; set; }

	public Message DetailedMessage { get; set; }

	public Resource Resource { get; set; }

	public string ResourceVersion { get; set; }

	public ResourceDistribution ResourceContainers { get; set; }

	public DateTimeOffset? CreatedDate { get; set; }
}