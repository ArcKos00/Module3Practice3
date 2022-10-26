using ConsoleApp1;

var message = new MessageBox();
var tss = new TaskCompletionSource();
message.WindowClose += (State state) =>
{
    if (state == State.Close)
    {
        Console.WriteLine("Операцiя вiдхилена");
    }
    else
    {
        Console.WriteLine("Операцiя погоджена");
    }

    tss.SetResult();
};

message.Open();
await Task.WhenAll(tss.Task);