using Homeworktasks.Handlers;
using System.Diagnostics.Tracing;
using System.Net;


public class Program
{
    public static async Task Main(string[] args)
    {
        var server = new ServerHandler();
        await server.Start();
    }
}