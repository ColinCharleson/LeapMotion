using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource BackgroundMusic;

    private float musicVolume = 1f;


    // Start is called before the first frame update
    void Start()
    {

        BackgroundMusic.Play();

    }

    // Update is called once per frame
    void Update()
    {

        BackgroundMusic.volume = musicVolume;

    }

}