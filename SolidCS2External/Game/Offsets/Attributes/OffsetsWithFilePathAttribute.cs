using System.Reflection;

namespace SolidCS2External.Game.Offsets.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class OffsetsWithFilePath(string filePath) : Attribute
{
    private string FilePath { get; } = filePath;

    public static void FillOffsets()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var types = assembly.GetTypes()
            .Where(t => t.GetCustomAttributes(typeof(OffsetsWithFilePath), true).Any())
            .ToList();

        foreach (var type in types)
        {
            var className = type.Name;
            var filePath = ((OffsetsWithFilePath)type.GetCustomAttributes(typeof(OffsetsWithFilePath), false).First())
                .FilePath;
            var properties = type.GetFields();
            foreach (var fieldInfo in properties)
            {
                var offset = (nint)OffsetsReader.ReadOffset(filePath, className, fieldInfo.Name);
                fieldInfo.SetValue(null, offset);
            }
        }
    }
}