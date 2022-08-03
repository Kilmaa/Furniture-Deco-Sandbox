using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    public AudioSource soundPlayer;
    public AudioClip clickSound;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayClickSound()
    {
        soundPlayer.PlayOneShot(clickSound);
    }
}
