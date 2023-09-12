using UnityEngine;

public class BoxMover : MonoBehaviour
{
    [SerializeField] private Vector3[] _points;
    [SerializeField] private float _speed = 1;

    private int _pointsCount;
    private int _currentPoint = 0;
    
    public Vector3 TargetPoint => _points[_currentPoint];

    private void Start()
    {
        _pointsCount = _points.Length;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, TargetPoint, _speed * Time.deltaTime);

        if (transform.position == TargetPoint)
            SetNextPoint();
    }

    private void SetNextPoint()
    {
        _currentPoint++;
        _currentPoint = _currentPoint == _pointsCount ? 0 : _currentPoint;
    }
}
