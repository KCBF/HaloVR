using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("Properties")]
    public float speed = 40;
    public float fireRate = 0.5f;
    public float spreadFactor = 0.1f;
    public float nextFire = 0.0f;
    public bool isBurst = false;
    public bool isChargeable = false;
    public bool isLoaded;


    [Header("Setup")]
    public GameObject bullet;
    public ParticleSystem muzzleFlash;
    public Transform barrel;
    public Transform magazine;
    public Transform magazineAttachPoint;

    [Header("Sound Effects")]
    public AudioSource audioSource;
    public AudioClip audioClip;

    //public GunSettings settings;


    public void WeaponSettings()
    {
        //controls weapon functionality inherited from scriptable object variant settings
        
        //Burst Fire
        /*
        if(settings.isBurst == true && Time.time > settings.nextFire)
        {
            for (int i = 1; i <= 3; i++)
            {

            }
        }
        */
    }


    public void Fire()
    {

        Vector3 shootDirection = barrel.forward;
        shootDirection.x += Random.Range(-spreadFactor, spreadFactor);
        shootDirection.y += Random.Range(-spreadFactor, spreadFactor);
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
            spawnedBullet.GetComponent<Rigidbody>().velocity = speed * shootDirection;
            //muzzleFlash.Play();
            //MuzzleFlash();
            //audioSource.PlayOneShot(audioClip);
            Destroy(spawnedBullet, 2f);
        }
    }
    /*
    private void MuzzleFlash()
    {
        GameObject currentMuzzle = Instantiate(muzzleFlash, barrel.position, barrel.rotation);
        currentMuzzle.transform.parent = barrel;
    }
    */
}
