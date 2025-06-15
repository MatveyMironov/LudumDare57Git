using PerceptionSystem;
using System.Collections.Generic;

namespace MonsterPerseptionSystem
{
    public class MonsterPerception
    {
        public HashSet<AMBPercievedObject> PercievedObjects { get; } = new();
    }
}
