using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sound_cat : MonoBehaviour
{
    public GameObject start;
    private AudioSource theAudio;
    [SerializeField] private AudioClip[] clip;
    Image healthBar;
   
    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();
        start = GameObject.Find("Start");
    }

    // Update is called once per frame
    void Play()
    {
        if (start.activeSelf == false)
        {
            theAudio.Play();
            Invoke("InvokeT", 6f);
        }
    }

    public void InvokeT()
    {
        theAudio.Stop();
        Invoke("Play", 2f);
    }
    
}
