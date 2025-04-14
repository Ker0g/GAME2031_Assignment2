using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int Score { get; private set; } = 0;
    public int Health { get; private set; } = 5;
   

    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(int amount)
    {
        Score += amount;
    }

    public void ResetScore()
    {
        Score = 0;
    }

    public void Damage()
    {
        Health--;

        if (Health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

   
}
