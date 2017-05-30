using UnityEngine;

namespace Lecture3
{
    public class ChildLogger : BaseLogger
    {
        public override void Log()
        {
            Debug.LogWarning(message);
        }
    }
}
