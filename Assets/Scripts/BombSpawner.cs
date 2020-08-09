using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BombSpawner : MonoBehaviour
{

    public GameObject Prefab;

    private float minX = -2.55f;
    private float maxX = 2.55f;

    void Start()
    {
        StartCoroutine(SpawnBomb());
    }

    private IEnumerator SpawnBomb()
    {
        yield return new WaitForSeconds(Random.Range(0f, 1f));
        Instantiate(Prefab, new Vector2(Random.Range(minX, maxX), transform.position.y), Quaternion.identity);
        StartCoroutine(SpawnBomb());
    }

}
