using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private int _spawmTime;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private void Spawn()
    {
        if (_spawnPoints.Count > 0)
        {
            int number = Random.Range(0, _spawnPoints.Count);
            _spawnPoints[number].SpawnEnemy(GenerateDirection());
        }
    }

    private Vector3 GenerateDirection()
    {
        List<Vector3> directions = new List<Vector3>
        {Vector3.forward, Vector3.down, Vector3.back, Vector3.up, Vector3.left, Vector3.right};
        int number = Random.Range(0, directions.Count);

        return directions[number];
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
