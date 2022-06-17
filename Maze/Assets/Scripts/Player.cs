using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isGreenKey;

    public bool IsGreenKey { get => isGreenKey; set => isGreenKey = value; }

    void Start()
    {
        IsGreenKey = false;
    }

    void Update()
    {
        float moveZ = 0f;

        float moveX = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveZ += 2f;
        }


        if (Input.GetKey(KeyCode.S))
        {
            moveZ -= 2f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveX -= 2f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX += 2f;
        }

        transform.Translate(new Vector3(moveX, 0f, moveZ) * 0.02f);
    }
}
