using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private SpawnPoint _spawnPoint;
    [SerializeField] private GameOverPanel _gameOverPanel;

    private Player _player;

    private void OnEnable()
    {
        _spawnPoint.PlayerSpawned += OnPlayerSpawned;
    }

    private void OnDisable()
    {
        _spawnPoint.PlayerSpawned -= OnPlayerSpawned;
    }

    private void OnPlayerSpawned(Player player)
    {
        _player = player;
        _player.Died += OnDied;
    }

    private void OnDied()
    {
        _player.Died -= OnDied;
        _gameOverPanel.GameOver();
        Time.timeScale = 0;
    }
}