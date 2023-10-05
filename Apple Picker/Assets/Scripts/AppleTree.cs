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
        InvokeRepeating("DropApple", appleDropDelay, appleDropDelay);
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

        transform.position = pos;
    }

    private void FixedUpdate()
    {
        if (Random.value < changeRate) velocity *= -1;
    }

    void DropApple()
    {
        Instantiate<GameObject>(applePrefab, transform.position, new());
    }

    /*
     Labrinth with invisible walls that show shadows, walls moved / controled by player
     Symbols displayed on palnels indicates the traversable direction of the maze
     
     */

    /*
        Genres
        - Platformer (puzzle adventure, 2D spatial), mark of the ninja, castlevania, mega man, mario
        - Jigsaw (Orthographic 2D spatial), baba is you
        - Block-fitting (Patten Matching), tetris, candy-crush,
        - Escape (deduction), portal
        - Trivia (internal: logic-pizzles, deductions, memory), (external: knowledge)
        - Tactics (), rube goldburg machine
    */

    /*
        Noneuclidean puzzle game in labrinth with windows showing coridors for some familiarity, like out of bounds stanley parrable 
    */
}
