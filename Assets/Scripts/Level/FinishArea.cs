using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishArea : MonoBehaviour
{
    [SerializeField] private string _sceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            SceneManager.LoadScene(_sceneName);
        }
    }
}