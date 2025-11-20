using UnityEngine;

public class RaycastGun : GunBase
{
    public override void Fire()
    {
        Ray ray = new Ray();
        RaycastHit hit = new RaycastHit();

        ray.origin = this.transform.position;
        ray.direction = this.transform.forward;

        if(Physics.Raycast(ray, out hit, 100))
        {

        }
        base.Fire();
    }

    public override void Reload()
    {
        base.Reload();
    }
}
