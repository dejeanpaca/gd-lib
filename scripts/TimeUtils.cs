using Godot;

namespace gdlib;

public static class TimeUtils
{
    public static double UsecNowInSeconds()
    {
        return Time.GetTicksUsec() / (1000.0 * 1000.0);
    }
}
