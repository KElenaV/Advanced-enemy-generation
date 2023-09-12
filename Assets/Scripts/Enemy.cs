using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    private Transform _target;
    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
    }

    private void Update()
    {
        _agent.SetDestination(_target.position);
    }
    
    public void Init(Transform target) => _target = target;
}
