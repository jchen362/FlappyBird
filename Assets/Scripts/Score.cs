using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public static Score instance;
    [SerializeField] private TextMeshProUGUI _bestText;
    [SerializeField] private TextMeshProUGUI _currentText;

    private int _score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _currentText.text = _score.ToString();
        _bestText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _bestText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
    }

    public void UpdateScore()
    {
        _score += 1;
        _currentText.text = _score.ToString();
        UpdateHighScore();
    }
}
