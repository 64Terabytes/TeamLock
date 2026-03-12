using TerrariaApi.Server;
using Terraria;
using TShockAPI;

namespace TeamLock;

/// <summary>
/// The main plugin class should always be decorated with an ApiVersion attribute. The current API Version is 2.1
/// </summary>
[ApiVersion(2, 1)]
public class TeamLock : TerrariaPlugin
{
    /// <summary>
    /// The name of the plugin.
    /// </summary>
    public override string Name => "Team Lock";

    /// <summary>
    /// The version of the plugin in its current state.
    /// </summary>
    public override Version Version => new Version(1, 0, 0);

    /// <summary>
    /// The author(s) of the plugin.
    /// </summary>
    public override string Author => "64Terabytes";

    /// <summary>
    /// A short, one-line, description of the plugin's purpose.
    /// </summary>
    public override string Description => "A simple, senseless, plugin used to demonstrate the code structure of a TShock and TS-API plugin.";

    /// <summary>
    /// The plugin's constructor
    /// Set your plugin's order (optional) and any other constructor logic here
    /// </summary>
    public TeamLock(Main game) : base(game)
    {
        
    }

    /// <summary>
    /// Performs plugin initialization logic.
    /// Add your hooks, config file read/writes, etc here
    /// </summary>
    public override void Initialize()
    {
        
    }
        
    /// <summary>
    /// Performs plugin cleanup logic
    /// Remove your hooks and perform general cleanup here
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            //unhook
            //dispose child objects
            //set large objects to null
        }
        base.Dispose(disposing);
    }
}
