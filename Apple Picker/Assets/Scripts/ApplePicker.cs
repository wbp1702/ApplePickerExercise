using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;

    public int basketCount = 3;

    public float basketSpacing = 2.0f;

    public float basketInitialY = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject basket = Instantiate(basketPrefab);
            basket.transform.position = new Vector3(0.0f, basketInitialY + i * basketSpacing, 0.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
