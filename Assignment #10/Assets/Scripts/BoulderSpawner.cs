using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderSpawner : MonoBehaviour
{
    BoulderObjectPooler objectPooler;
    public float time;

    private void Start()
    {
        objectPooler = BoulderObjectPooler.instance;
        time = 0.5f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time -= Time.deltaTime;

        if (time <= 0.0f)
        {
            BoulderObjectPooler.instance.SpawnFromPool("Boulder", transform.position, Quaternion.identity);
            time = 0.5f;
        }
    }
}
