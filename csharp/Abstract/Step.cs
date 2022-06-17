using System.Diagnostics;

namespace Udemy;

public static class Step{

    public static void Track(Action function, ref Stopwatch timer) {
        timer.Restart();
        function();
        timer.Stop();
    }

}
