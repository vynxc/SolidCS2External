using SolidCS2External.Game;

namespace SolidCS2External.Interfaces;

public interface IFeature
{
    Cs2Manager Manager { get; }
    bool Enabled { get; set; }
    string Name { get; }
    void Initialize();
    void Render();
}