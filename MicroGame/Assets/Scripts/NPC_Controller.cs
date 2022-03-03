using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Controller : MonoBehaviour
{
    public float speed;
    public float difficulty;
    public GameObject Slave_1;
    public bool hittable = false;

    // Start is called before the first frame update
    void Start()
    {
        Slave_1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Slave_1.activeSelf)
        {
            Slave_1.transform.Translate(-1 * speed, 0, 0);
        }
    }

    public void readyToHit()
    {
        Debug.Log("don't hit me");
        hittable = true;
        Reset();

    }

    public void Reset()
    {
        Slave_1.SetActive(false);
    }
}
