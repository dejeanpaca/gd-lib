using Godot;

namespace gdlib;

public static class Node3DExtensions
{
    public static void AbsoluteScale(this Node3D node, Vector3 scale)
    {
        var globalScale = node.GlobalBasis.Scale;

        var scaleDiff = new Vector3(globalScale.X / scale.X, globalScale.Y / scale.Y, globalScale.Z / scale.Z);
        node.ScaleObjectLocal(new Vector3(scale.X / scaleDiff.X, scale.Y / scaleDiff.Y, scale.Z / scaleDiff.Z));
    }
}
