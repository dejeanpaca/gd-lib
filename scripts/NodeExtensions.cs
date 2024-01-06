using Godot;

namespace gdlib;

public static class NodeExtensions
{
    public static T FindChildOfType<T>(this Node node) where T : Node
    {
        T child = default(T);

        foreach (var current in node.GetChildren())
        {
            if (current is T) return (T)current;
        }

        return child;
    }
}
