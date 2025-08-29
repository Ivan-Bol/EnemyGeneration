using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private Vector3 _direction;

    private void Update()
    {
        transform.Translate(_direction * _movementSpeed * Time.deltaTime);
    }

    public void Initialize(Vector3 direction, Vector3 startPosition)
    {
        transform.position = startPosition;
        _direction = direction;
    }
