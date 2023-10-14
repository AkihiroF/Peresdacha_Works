using UnityEngine;

namespace Enemies
{
    public class FireEnemy : AEnemy
    {
        public override void Attack()
        {
            Debug.Log("FireEnemy attacking once");
        }

        public override void Idle()
        {
            Debug.Log("FireEnemy idling");
        }
    }
}