using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int _playerHP = 1;
    private int _playerScore = 0;

    public GameObject player;
    public TextMeshProUGUI points;
    public bool playerIsDead = false;

    public int PlayerHP
    {
        get => _playerHP;
        set => _playerHP = value;
    }

    public int PlayerScore
    {
        get => _playerScore;
        set => _playerScore = value;
    }

    private void Start()
    {
        player = GetComponent<GameObject>();
        points = GameObject.Find("Points").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        points.text = PlayerScore.ToString();
    }

    private void OnGUI()
    {
        if (playerIsDead)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100
               , Screen.height / 2 - 50, 200, 100), "You lose"))
            {
                Utilities.LoadLevel(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
