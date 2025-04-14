using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("girl you need a shot of b12");
            GameManager.Instance.Damage();
        }
    }
}
