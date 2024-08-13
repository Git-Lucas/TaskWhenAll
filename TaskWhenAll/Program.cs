using TaskWhenAll;

Service service = new();

Console.WriteLine(DateTime.UtcNow);

Result result1 = await service.ExecuteAsync();
Result result2 = await service.ExecuteAsync();

Console.WriteLine(DateTime.UtcNow);