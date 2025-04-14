using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timer = 0;
    public float spawnTime = 2.5f;

    int randomX;
    int randSpawn;

    [SerializeField] GameObject coin;
    [SerializeField] GameObject asteroid;
    [SerializeField] GameObject spawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomX = Random.Range(-6, 7);
        randSpawn = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        spawn.transform.position = new Vector3 (randomX, 6, 0);
        timer += Time.deltaTime;

        if(timer >= spawnTime)
        {
            Debug.Log(randSpawn);

            if (randSpawn % 2 == 0) 
            { 
                Instantiate(coin, spawn.transform.position, spawn.transform.rotation);
            }
            else
            {
                Instantiate(asteroid, spawn.transform.position, spawn.transform.rotation);
            }
            
            randomX = Random.Range(-6, 6);
            randSpawn = Random.Range(1, 3);
            timer = 0;
        }
    }
}
