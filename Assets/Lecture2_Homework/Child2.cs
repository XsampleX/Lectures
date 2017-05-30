using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture2_Homework
{
    public class Child2 : Parent
    {
        public Material mat;

        public override void DoAction()
        {
            mat.color = Random.ColorHSV();
        }
    }
}
