using TaskWhenAll;

Service service = new();

Console.WriteLine(DateTime.UtcNow);

Result[] result = await Task.WhenAll(
    service.ExecuteAsync(),
    service.ExecuteAsync());

Console.WriteLine(DateTime.UtcNow);