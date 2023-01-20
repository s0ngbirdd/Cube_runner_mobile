using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Serialize
    [SerializeField] private GameObject _menuUI;
    [SerializeField] private GameObject _joystick;

    private void Awake()
    {
        GameEnder.OnGameOver.AddListener(ShowFailMenuUI);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void ShowFailMenuUI()
    {
        _joystick.SetActive(false);
        _menuUI.SetActive(true);
    }
}
