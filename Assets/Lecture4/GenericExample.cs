using UnityEngine;

namespace Lecture4
{
    public class GenericExample : MonoBehaviour
    {

        void Start()
        {
            //casting example: primitive types
            float b = 5f;
            int a = (int)b;

            GenericPlay();
        }

        void GenericPlay()
        {
            //casting example: complex types
            AudioSource player = GetComponent<AudioSource>();
            player.Play();
        }

        void NonGenericPlay()
        {
            //casting example: complex types
            AudioSource player = (AudioSource)GetComponent("AudioSource");
            player.Play();
        }
    }
}