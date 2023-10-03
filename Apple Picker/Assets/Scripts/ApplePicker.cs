using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;

    public GameObject restartButton;

    public int basketCount = 3;

    public float basketSpacing = 2.0f;

    public float basketInitialY = -15.0f;

    private List<GameObject> baskets = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject basket = Instantiate(basketPrefab);
            basket.transform.position = new Vector3(0.0f, basketInitialY + i * basketSpacing, 0.0f);
            baskets.Add(basket);
        }
    }

    public void AppleMissed()
	{
        var found = GameObject.FindGameObjectsWithTag("Apple");
        foreach (var item in found) Destroy(item);

        Destroy(baskets[baskets.Count - 1]);
        baskets.RemoveAt(baskets.Count - 1);

        if (baskets.Count == 0)
        {
            Time.timeScale = 0.0f;
            restartButton.SetActive(true);
        }
	}

    public void ResetLevel()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("_Scene_0");
    }
}
