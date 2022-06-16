using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenKey : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.gameObject.GetComponent<Player>().IsGreenKey = true;

            Destroy(this.gameObject);
        }
    }
}
