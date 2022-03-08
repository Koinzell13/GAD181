using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Controller : MonoBehaviour
{
    public float speed;
    public float difficulty;
    public GameObject Slave_1;
    public GameObject Slave_2;
    public GameObject Slave_3;
    public GameObject Slave_4;
    public GameObject Slave_5;
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
    }

    public void Reset()
    {
        Slave_1.SetActive(false);
        hittable = false;
        Second();
    }

    public void Second()
    {
        Slave_2.SetActive(true);
        Turn2();
    }

    void Turn2()
    {
        if (Slave_2.activeSelf)
        {
            Slave_2.transform.Translate(1 * speed, 0, 0);
        }
    }

    public void readyToHit2()
    {
        Debug.Log("don't hit me");
        hittable = true;
    }

    public void Reset2()
    {
        Slave_2.SetActive(false);
        hittable = false;
    }
}