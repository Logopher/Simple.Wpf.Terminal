namespace Simple.Wpf.Terminal.Common;

public delegate void LineEnteredEventHandler(object o, LineEnteredEventArgs e);

public class LineEnteredEventArgs
{
    public string Line { get; }

    public LineEnteredEventArgs(string line)
    {
        Line = line;
    }
}