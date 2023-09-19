using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;

    public float velocity = 1f;

    public float boundary = 10f;

    public float changeRate = 0.01f;

    public float appleDropDelay = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += velocity * Time.deltaTime;

        if (Mathf.Abs(pos.x + velocity * Time.deltaTime) >= boundary)
        {
            pos.x = pos.x < 0 ? -boundary : boundary;
            velocity *= -1;
        }
        else if (Random.value < changeRate) velocity *= -1;

        transform.position = pos;


    }

    /*
     Labrinth with invisible walls that show shadows, walls moved / controled by player
     Symbols displayed on palnels indicates the traversable direction of the maze
     
     */
}
