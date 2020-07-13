using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerMover))]
public class Player : MonoBehaviour
{
    private PlayerMover _mover;

    public event UnityAction Died;

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
    }

    private void FixedUpdate()
    {
        _mover.Move();
    }

    public void Die()
    {
        Died?.Invoke();
    }
}