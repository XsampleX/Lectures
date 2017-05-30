using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture2_Homework
{
    public class Child1 : Parent
    {
        public override void DoAction()
        {
            Instantiate(gameObject);
        }
    }
}
