using Verse;
using RimWorld;
using System.Reflection;

namespace musicPauseOut
{
    [StaticConstructorOnStartup]
    static class musicPauseOut
    {
        static musicPauseOut()
        {
            typeof(MusicManagerPlay).GetField("SongIntervalTension", BindingFlags.NonPublic | BindingFlags.Static).SetValue(null, FloatRange.Zero);
            typeof(MusicManagerPlay).GetField("SongIntervalRelax", BindingFlags.NonPublic | BindingFlags.Static).SetValue(null, FloatRange.Zero);
        }
    }
}