using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject food1Prefab;
    public float spawnTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(foodLoop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnFood1()
    {
    GameObject a = Instantiate(food1Prefab) as GameObject;
    a.transform.position = new Vector2(Random.Range(-7, 7), 7);
    }

    IEnumerator foodLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnFood1();

        }
        
    }
}
