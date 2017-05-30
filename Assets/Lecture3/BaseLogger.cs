using UnityEngine;

namespace Lecture3
{
    public abstract class BaseLogger : MonoBehaviour
    {
        public string message;

        public abstract void Log();

        public void LogError()
        {
            Debug.LogError(message);
        }
    }
}