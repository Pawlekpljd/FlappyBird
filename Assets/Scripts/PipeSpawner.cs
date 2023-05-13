using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float repeatRate = 1;
    private float pipeTimer = 0;
    public float height = 5;
    public float xGap = 1;
    public float yGap = 1;
    public GameObject prefabPipe;
    public GameObject prefabCoin;

    // Update is called once per frame
    void Update()
    {
        if (pipeTimer > repeatRate)
        {
            pipeTimer = 0;
            SpawnPipeAndCoin();
        }

        pipeTimer += Time.deltaTime;
    }

    private void SpawnPipeAndCoin()
    {
        GameObject newPipe = Instantiate(prefabPipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, 10f);

        if(Random.Range(1,3) > 1)
        {
            SpawnCoin(newPipe.transform);
        }
    }

    public void SpawnCoin(Transform pipe)
    {
        GameObject newCoin = Instantiate(prefabCoin);
        newCoin.transform.position = transform.position + new Vector3(pipe.position.x + xGap, pipe.position.y + Random.Range(-yGap, yGap), 0);
        Destroy(newCoin, 10f);
    }


}
