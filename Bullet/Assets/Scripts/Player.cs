using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletobj;

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            //Bullet bullet = Instantiate(bulletobj).GetComponent<Bullet>();
            Bullet bullet = ObjectPool.GetObject();            
            bullet.Shoot();
        }
    }
}
