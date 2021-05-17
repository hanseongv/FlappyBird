using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    public GameObject column;
    public float delay = 6f;
    public float randomDelay = 2f;
    public float spawnX = 4f;
    public float spqwnYmin = -1.8f;
    public float spqwnYmax = 1.5f;

    private IEnumerator Start()
    {
        while (true)
        {
            Vector3 pos;
            pos.z = 0;
            pos.x = spawnX;
            pos.y = Random.Range(spqwnYmin, spqwnYmax);
            Instantiate(column, pos, column.transform.rotation);

            yield return new WaitForSeconds(delay +
                Random.Range(-randomDelay, randomDelay)); // -2~ 2      6-2  4
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}