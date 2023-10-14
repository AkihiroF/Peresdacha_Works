using UnityEngine;

namespace Enemies
{
    public class LightEnemy : AEnemy
    {
        public override void Attack()
        {
            Debug.Log("LightEnemy attacking once");
        }

        public override void Idle()
        {
            Debug.Log("LightEnemy idling");
        }
    }
}