using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;

    public void SpawnEnemy(Vector3 rotation)
    {
        Enemy enemy = Instantiate(_enemyPrefab); ;
        enemy.transform.position = transform.position;
        enemy.transform.eulerAngles = rotation;
    }
}