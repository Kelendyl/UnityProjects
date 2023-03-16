using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] spawnItems;

    private BoxCollider2D boxCollider;
    float spawnMin;
    float spawnMax;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();

        spawnMin = transform.position.x - boxCollider.size.x / 2;
        spawnMax = transform.position.x + boxCollider.size.x / 2;

        StartCoroutine(SpawnItem(2f));
    }

    IEnumerator SpawnItem(float time)
    {
        yield return new WaitForSeconds(time);

        Vector2 startPosition = transform.position;
        startPosition.x = Random.Range(spawnMin, spawnMax);

        Instantiate(spawnItems[Random.Range(0, spawnItems.Length)], startPosition, Quaternion.identity);

        StartCoroutine(SpawnItem(Random.Range(0.5f, 2f)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
