using SolidCS2External.Game;
using SolidCS2External.Game.Entity;

namespace SolidCS2External.Interfaces;

public interface IFeature
{
    Cs2Manager Manager { get; }
    bool Enabled { get; set; }
    string Name { get; }
    void Initialize();
    void Run(EntityList entityList);
    void EntityLoop(EntityPawn pawn);
}