using UnityEngine;

public abstract class GunBase : MonoBehaviour
{
    public int maxAmmo;
    public int ammo;
    public float fireRate;
    public float damage;

    public virtual void Fire()
    {
        ammo--;
        ammo = Mathf.Clamp(ammo, 0, maxAmmo);
    }
    public virtual void Reload()
    {
        ammo = maxAmmo;
    }
}
