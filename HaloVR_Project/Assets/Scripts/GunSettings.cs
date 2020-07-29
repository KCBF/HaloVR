using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSettings : ScriptableObject
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

}
