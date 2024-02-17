using SolidCS2External.Game.Entity;

namespace SolidCS2External.Game;

public class Cs2Manager
{
    public EntityManager EntityManager = new();
    public Memory.Memory Memory = new("cs2");
}