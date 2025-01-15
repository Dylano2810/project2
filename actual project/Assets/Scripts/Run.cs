using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public AudioSource RunAudio;
    // Start is called before the first frame update
    void Audio()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            RunAudio.Play();
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            RunAudio.Stop();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            RunAudio.Play();
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            RunAudio.Stop();
        }

    }

    // Update is called once per frame
    void StopSound()
    {

    }
}
