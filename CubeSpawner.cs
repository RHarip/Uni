using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spawnInterval = 2f;
    public Vector3 spawnRange = new Vector3(10f, 0f, 10f);

    private List<GameObject> spawnedCubes = new List<GameObject>();

    void Start()
    {
        InvokeRepeating(nameof(SpawnCube), 0f, spawnInterval);
    }

    void SpawnCube()
    {
        Vector3 randomPos = new Vector3(
            Random.Range(-spawnRange.x, spawnRange.x),
            spawnRange.y,
            Random.Range(-spawnRange.z, spawnRange.z)
        );

        GameObject cube = Instantiate(cubePrefab, randomPos, Quaternion.identity);
        spawnedCubes.Add(cube);
    }

    public void ClearCubes()
    {
        foreach (GameObject cube in spawnedCubes)
        {
            if (cube != null)
                Destroy(cube);
        }
        spawnedCubes.Clear();
        Debug.Log("All cubes destroyed.");
    }
}
