using TaskWhenAll;

Service service = new();

Console.WriteLine(DateTime.UtcNow);

await service.ExecuteAsync();
await service.ExecuteAsync();

Console.WriteLine(DateTime.UtcNow);