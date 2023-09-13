using UnityEngine;

public class BoxMover : MonoBehaviour
{
    [SerializeField] private Vector3[] _points;
    [SerializeField] private float _speed = 1;

    private int _currentPoint = 0;
    private Vector3 _targetPoint;

    private void Start()
    {
        _targetPoint = _points[_currentPoint];
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPoint, _speed * Time.deltaTime);

        if (transform.position == _targetPoint)
            SetNextPoint();
    }

    private void SetNextPoint()
    {
        _currentPoint++;
        _currentPoint = _currentPoint == _points.Length ? 0 : _currentPoint;
        _targetPoint = _points[_currentPoint];
    }
}
