using UnityEngine;

namespace Lecture4
{
    public class AbstractionExample : MonoBehaviour
    {
        private Vector3 pos;

        public Vector3 position
        {
            get;
            private set;
        }

        void Start()
        {
            Vector3 pos = position; //calling get 
            pos.x += 1f;
            position = pos;         //calling set 
        }
    }
}