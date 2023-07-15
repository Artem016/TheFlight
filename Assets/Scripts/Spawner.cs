using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float timeToSpawn, minPosition, maxPosition;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            timer = timeToSpawn;
            GameObject pipe = Instantiate(pipePrefab, transform.position, quaternion.identity);
            float rand = Random.Range(minPosition, maxPosition);
            pipe.transform.position = new Vector3(pipe.transform.position.x, rand, 0);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
