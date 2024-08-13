namespace TaskWhenAll;
public class Service
{
    public async Task<Result> ExecuteAsync()
    {
        await Task.Delay(2000);

        return new Result(true);
    }
}
