using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPoint : MonoBehaviour
{
    [SerializeField] Point[] arrayPoint;
    [SerializeField] Transform AreaSpawn; // Objek atau area tempat spawn di mana-mana.

    bool spawn = true;
    float spawnDelay = 3f;
    int spawnedCount = 0; // Jumlah objek yang telah terspawn.

    private void Start()
    {
        StartCoroutine(spawning());
    }

    public void SetUpSpawningPoint()
    {
        StartCoroutine(spawningPart());
    }

    IEnumerator spawning()
    {
        while (spawn && spawnedCount < 5)
        {
            yield return new WaitForSeconds(1);
            SpawnPoint();
        }
    }

    IEnumerator spawningPart()
    {
        yield return new WaitForSeconds(spawnDelay);
        SpawnPoint();
    }

    void SpawnPoint()
    {
        int pointIndex = Random.Range(0, arrayPoint.Length);
        Spawn(arrayPoint[pointIndex]);
        spawnedCount++;
    }

    void Spawn(Point myPoint)
    {
        float randomX = Random.Range(-AreaSpawn.localScale.x / 2f, AreaSpawn.localScale.x / 2f);
        float randomY = Random.Range(-AreaSpawn.localScale.y / 2f, AreaSpawn.localScale.y / 2f);


        Vector3 randomPosition = new Vector3(randomX, randomY, 0f) + AreaSpawn.position;


        Point newPoint = Instantiate(myPoint, randomPosition, Quaternion.identity) as Point;
        newPoint.transform.parent = transform;
    }
}