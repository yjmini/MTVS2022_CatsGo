using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject start;
    // Start is called before the first frame update
    void Start()
    {
        start = GameObject.Find("Start");
    }
    public void OnClickstart()
    {
        start.SetActive(false);

    }
}