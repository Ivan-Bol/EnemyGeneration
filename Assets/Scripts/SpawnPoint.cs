using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;

    public void SpawnEnemy(Vector3 direction)
    {
        Enemy enemy = Instantiate(_enemyPrefab);
        enemy.Initialize(direction, transform.position);
    }
}
