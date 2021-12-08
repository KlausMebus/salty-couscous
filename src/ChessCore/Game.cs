namespace ChessCore;

public class Game
{
    public GameInformation Info { get; init; } = new();
}

public record GameInformation
{
    public string Event { get; init; } = "";
    public string Site { get; init; } = "";
    public string Date { get; init; } = "????.??.??";
    public string Round { get; init; } = "";
    public string White { get; init; } = "";
    public string Black { get; init; } = "";
    public string Result { get; init; } = "*";
}
