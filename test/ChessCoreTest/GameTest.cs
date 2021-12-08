using ChessCore;
using Xunit;

namespace ChessCoreTest;

public class GameTest
{
    [Fact]
    public void CanCreateAGame()
    {
        Game game = new()
        {
            Info = new GameInformation
            {
                Black = "Bent Larsen",
                White = "Magnus Carlsen"
            }
        };

        GameInformation defaultGameInformation = new();

        Assert.NotNull(game);
        Assert.NotNull(game.Info);
        Assert.NotEqual(defaultGameInformation, game.Info);
    }
}