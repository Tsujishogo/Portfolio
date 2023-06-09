using UnityEngine;


public class BreakableOBJ : MonoBehaviour
{
    // 壊せるobjectのHP
    [SerializeField] int hp = 100;   
     

    void OnTriggerEnter(Collider other)
    {
        // 弾が当たったらHP減らす
        hp--;
        // HPがなくなったら爆発してobject消す
        if (hp <= 0)
        {
            ParticleManager.PlayParticle("Explosion", transform.position);
            Destroy(gameObject);
        }
    }
}
