using Godot;

namespace gdlib;

public static class NodeExtensions
{
    public static T FindChildOfType<T>(this Node node) where T : Node
    {
        foreach (var current in node.GetChildren())
        {
            if (current is T) return (T)current;
        }

        return default;
    }

    public static T RecursiveFindChildOfType<T>(this Node node) where T : Node
    {
        foreach (var current in node.GetChildren())
        {
            if (current is T) return (T)current;

        }

        foreach (var current in node.GetChildren())
        {
            T child = RecursiveFindChildOfType<T>(current);

            if (child != default(T)) return child;

        }

        return default;
    }
}
