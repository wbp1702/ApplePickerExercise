using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public float deletionBoundary;

    void Update()
    {
        if (transform.position.y < deletionBoundary)
        {

            Destroy(this.gameObject);
        }
    }
}
