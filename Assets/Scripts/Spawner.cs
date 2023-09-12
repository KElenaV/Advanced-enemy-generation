using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _target;

    private void Start()
    {
       _enemy.Init(_target);
        Instantiate(_enemy, transform.position, transform.rotation);
    }
}
