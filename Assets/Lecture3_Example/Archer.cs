using UnityEngine;

namespace Lecture3_Example
{
    public class Archer : Soldier
    {
        public int arrowCount = 100;

        public override void Attack()
        {
            //draw one arrow and shoot!
            if (arrowCount > 0)
            {
                arrowCount--;
                target.GetDamage(damage);
            }
        }
    }
}