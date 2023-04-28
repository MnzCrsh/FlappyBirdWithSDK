using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public GameObject obstacles;
    public float timeToSpawn;

    private void Start()
    {
        if (DifficultySelect.easy)
        {
            timeToSpawn = 2f;
        }

        if (DifficultySelect.medium)
        {
            timeToSpawn = 1f;
        }
        if (DifficultySelect.hard)
        {
            timeToSpawn = 0.5f;
        }

        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            float randomYPos = Random.Range(-6, 6);

            yield return new WaitForSeconds(timeToSpawn);

            GameObject clonedObstacles = Instantiate(obstacles, new Vector3(15, randomYPos, 0), Quaternion.identity);
            Destroy(clonedObstacles, 20);
        }
    }
}
