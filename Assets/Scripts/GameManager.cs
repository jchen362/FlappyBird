using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject _gameOverCanvas;
    [SerializeField] private GameObject _gameStartCanvas;
    [SerializeField] private GameObject _scoreCanvas;

    //starts when script instance is being loaded
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        Time.timeScale = 0f;
        
    }

    public void StartGame()
    {
        _gameStartCanvas.SetActive(false);
        _scoreCanvas.SetActive(true);
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        //since we only have one scene, we just take the current scene and reload it
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }
}
