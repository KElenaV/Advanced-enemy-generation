using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _target;

    private void Start()
    {
        _enemy = Instantiate(_enemy, transform.position, transform.rotation);
        _enemy.Init(_target);
    }
}
