using Verse;
using RimWorld;
using System.Reflection;

namespace musicPauseOut
{
    [StaticConstructorOnStartup]
    static class MusicPauseOut
    {
        static MusicPauseOut()
        {
            typeof(MusicManagerPlay).GetField("SongIntervalTension", BindingFlags.NonPublic | BindingFlags.Static).SetValue(null, FloatRange.Zero);
            typeof(MusicManagerPlay).GetField("SongIntervalRelax", BindingFlags.NonPublic | BindingFlags.Static).SetValue(null, FloatRange.Zero);
        }
    }
}