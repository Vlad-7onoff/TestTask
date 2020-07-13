using UnityEngine;

public class CircularMover : MonoBehaviour
{
    [SerializeField] private float _turnSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.up, _turnSpeed * Time.deltaTime);
    }
}