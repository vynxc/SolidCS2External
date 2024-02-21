using SolidCS2External.Game.Entity;
using SolidCS2External.Interfaces;

namespace SolidCS2External.Game.Managers;

public class FeaturesManager(List<IFeature> renderables)
{
    public FeaturesManager() : this(new List<IFeature>())
    {
    }

    public void Render()
    {
        foreach (var feature in renderables.Where(x => x.Enabled))
            feature.Render();
        
        foreach (var entityPawn in Cs2Manager.GlobalManager.EntityList)
            entityPawn.GameSceneNode.ClearBonePositionCache();
    }

    public void Add(IFeature feature)
    {
        renderables.Add(feature);
    }

    public void Remove(string featureName)
    {
        var feature = renderables.FirstOrDefault(w => w.Name == featureName);
        if (feature == null) return;
        renderables.Remove(feature);
    }

    public void Remove(int featureIndex)
    {
        var feature = renderables.Where((_, w) => w == featureIndex).FirstOrDefault();
        if (feature == null) return;
        renderables.Remove(feature);
    }

    public List<IFeature> GetEnabled()
    {
        return renderables.Where(x => x.Enabled).ToList();
    }
}