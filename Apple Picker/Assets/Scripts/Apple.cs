using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public float deletionBoundary;
    public ApplePicker applePicker;

	private void Start()
	{
        applePicker = Camera.main.GetComponent<ApplePicker>();
	}

	void Update()
    {
        if (transform.position.y < deletionBoundary)
        {
            Destroy(gameObject);
            applePicker.AppleMissed();
        }
    }
}
