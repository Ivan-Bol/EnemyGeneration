using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private int _spawmTime;
    [SerializeField] private int _minDegree;
    [SerializeField] private int _maxDegree;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private void Spawn()
    {
        if (_spawnPoints.Count > 0)
        {
            int number = Random.Range(0, _spawnPoints.Count);
            _spawnPoints[number].SpawnEnemy(GenerateRotation());
        }
    }

    private Vector3 GenerateRotation()
    {
        Vector3 rotation = new Vector3();
        rotation.y = Random.Range(_minDegree, _maxDegree + 1);

        return rotation;
    }

    private IEnumerator SpawnEnemies()
    {
        var wait = new WaitForSeconds(_spawmTime);
        bool isWork = true;

        while (isWork)
        {
            yield return wait;

            Spawn();
        }
    }
}