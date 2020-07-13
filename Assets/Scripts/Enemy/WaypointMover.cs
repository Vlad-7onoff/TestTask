using UnityEngine;

public class WaypointMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Transform _path;
    [SerializeField] private int _currentPoint;

    private Transform[] _points;

    private void Start()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
            _points[i] = _path.GetChild(i);
    }

    public void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _moveSpeed * Time.deltaTime);

        if (transform.position == target.position)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Length)
                _currentPoint = 0;
        }
    }
}