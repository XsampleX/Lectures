using UnityEngine;

namespace Lecture2_Homework
{
    public class Parent : MonoBehaviour
    {

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                DoAction();
            }
        }

        public virtual void DoAction()
        {
            Debug.Log("error");
        }
    }
}