using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private PlayerInput _input;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        
        _input = new PlayerInput();
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    public void Move()
    {
        Vector2 inputDirection = _input.Player.Move.ReadValue<Vector2>();
        float scaledMoveSpeed = _moveSpeed * Time.fixedDeltaTime;

        Vector3 moveDirection = new Vector3(inputDirection.x, 0, inputDirection.y);

        _rigidbody.AddForce(moveDirection * scaledMoveSpeed, ForceMode.VelocityChange);
    }
}
