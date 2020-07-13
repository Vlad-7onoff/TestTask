using UnityEngine;
using UnityEngine.Events;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Player _player;

    public event UnityAction<Player> PlayerSpawned;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        Player player = Instantiate(_player, transform.position, Quaternion.identity);
        PlayerSpawned?.Invoke(player);
    }
}