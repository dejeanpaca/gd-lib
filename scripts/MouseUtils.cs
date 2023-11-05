using Godot;

namespace glib;

public class MouseUtils
{
    public static void CenterPointer(Viewport viewport) {
        var viewportSize = viewport.GetVisibleRect().Size;

        Input.WarpMouse(new Vector2(viewportSize[0] / 2, viewportSize[1] / 2));
    }
    
    /// <summary>
     /// Returns a normalized mouse position (-1.0 .. 1.0) within a viewport
     /// </summary>
     /// <param name="viewport"></param>
     /// <param name="eventMouseMotion"></param>
     /// <returns></returns>
    public static Vector2 NormalizedConfinedPosition(Viewport viewport, InputEventMouseMotion eventMouseMotion) {
        var viewportSize = viewport.GetVisibleRect().Size;

        // Mouse in viewport coordinates.
        float x = 1 / viewportSize.X * eventMouseMotion.Position.X - 0.5f;
        float y = 1 / viewportSize.Y * eventMouseMotion.Position.Y - 0.5f;

        x = x * 2;
        y = y * 2;

        if(x < -1) x = -1;
        if(x > 1) x = 1;
        if(y < -1) y = -1;
        if(y > 1) y = 1;

        return new Vector2(x, y);
    }

    public static Vector2 GetPositionForControl(Viewport viewport, Control control) {
        var position = viewport.GetMousePosition() - control.GlobalPosition;

        return new Vector2(position[1], -position[0]);
    }
}
