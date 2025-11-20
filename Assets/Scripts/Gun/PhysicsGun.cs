using UnityEngine;

public class PhysicsGun : GunBase
{
    [SerializeField]
    private GameObject bulletToSpawn;

    public override void Fire()
    {
        GameObject spawnedBullet = Instantiate(bulletToSpawn);
        spawnedBullet.transform.position = this.transform.position;
        base.Fire();

    }
}
