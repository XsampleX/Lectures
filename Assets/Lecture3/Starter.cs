using UnityEngine;

namespace Lecture3
{
    public class Starter : MonoBehaviour
    {
        public BaseLogger myLogger;

        void Start()
        {
            myLogger.Log();

            float rootOf10 = MathUtils.Root(10f);

            //Unity's example static classes:
            //Input
            //Random
            //Mathf
            //Debug

        }
    }
}