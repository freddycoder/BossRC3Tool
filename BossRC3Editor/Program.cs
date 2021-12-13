namespace BossRC3Editor;

class Program
{
    public static void Main(string[] args)
    {
        var boss = new BossRC3(new DirectoryInfo(@"F:\"));

        var getTempo = boss.GetTempo("060_1");
    }
}