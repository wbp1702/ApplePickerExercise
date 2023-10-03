using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public ScoreCounter scoreCounter;

	private void Start()
	{
        scoreCounter = GameObject.Find("Score Counter").GetComponent<ScoreCounter>();
	}

	// Update is called once per frame
	void Update()
    {
        var pos = Input.mousePosition;
        pos.z = -Camera.main.transform.position.z;
        pos = Camera.main.ScreenToWorldPoint(pos);

        transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);
    }

	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.layer == LayerMask.NameToLayer("Apple"))
		{
            Destroy(collision.gameObject);
            scoreCounter.score += 100;
            HighScore.TrySetHighScore(scoreCounter.score);
        }
	}
}
