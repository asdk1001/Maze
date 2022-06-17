using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public PopUp PopUp;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PopUp.transform.gameObject.SetActive(true);
        }
    }

}
