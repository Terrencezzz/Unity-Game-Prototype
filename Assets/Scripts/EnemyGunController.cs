using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnBullet", 0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnBullet()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
