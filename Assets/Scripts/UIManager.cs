using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text score;
    [SerializeField] TMP_Text health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score.text ="Score:  " + GameManager.Instance.Score;
        health.text ="Health: " + GameManager.Instance.Health;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score:  " + GameManager.Instance.Score;
        health.text = "Health: " + GameManager.Instance.Health;
    }
}
