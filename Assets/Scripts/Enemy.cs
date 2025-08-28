using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    private void Update()
    {
        transform.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);
    }
}