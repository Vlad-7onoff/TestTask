using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class GameOverPanel : MonoBehaviour
{
    [SerializeField] private Button _restart;

    private CanvasGroup _gameOverGroup;

    private void OnEnable()
    {
        _restart.onClick.AddListener(OnRestartClick);
    }

    private void OnDisable()
    {
        _restart.onClick.RemoveListener(OnRestartClick);
    }

    private void Start()
    {
        _gameOverGroup = GetComponent<CanvasGroup>();
        _gameOverGroup.alpha = 0;
        _gameOverGroup.interactable = false;
    }

    public void OnRestartKeyClick(InputAction.CallbackContext context)
    {
        if (_gameOverGroup.interactable == true)
            _restart.onClick?.Invoke();
    }

    private void OnRestartClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        _gameOverGroup.alpha = 1;
        _gameOverGroup.interactable = true;
    }
}