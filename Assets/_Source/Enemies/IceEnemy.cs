using UnityEngine;

namespace Enemies
{
    public class IceEnemy : AEnemy
    {
        public override void Attack()
        {
            Debug.Log("IceEnemy attacking once");
        }

        public override void Idle()
        {
            Debug.Log("IceEnemy idling");
        }
    }
}