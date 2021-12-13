namespace BossRC3Editor;

public class BossRC3
{
    private readonly DirectoryInfo _roland;
    private readonly DirectoryInfo _wave;
    private readonly DirectoryInfo _data;

    public BossRC3(DirectoryInfo directory)
    {
        _roland = directory.GetDirectories("ROLAND").First();
        _wave = _roland.GetDirectories("WAVE").First();
        _data = _roland.GetDirectories("DATA").First();
    }

    public DirectoryInfo Loop(string name)
    {
        return _wave.GetDirectories(name).First();
    }

    public void CopyLoop(string source, string destination)
    {
        var loop = Loop(source);
        var dest = Loop(destination);

        dest.GetFiles().ToList().ForEach(f => f.Delete());

        var files = loop.GetFiles();

        files.Single();

        for (int i = 0; i < files.Length; i++)
        {
            files[i].CopyTo($"{dest.FullName}\\{destination}.WAV");
        }
    }

    public double GetTempo(string v)
    {
        var lines = File.ReadAllLines(_data.GetFiles("MEMORY.RC3").Single().FullName);

        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);

            if (lines[i].Contains(v))
            {
                Console.WriteLine(lines[i]);
            }
        }

        return 0.0;
    }
}