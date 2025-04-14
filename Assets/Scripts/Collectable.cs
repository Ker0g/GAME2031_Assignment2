using UnityEngine;

public class Collectable : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Yea");
            GameManager.Instance.AddScore(1);
        }
        Destroy(gameObject);
    }
}
