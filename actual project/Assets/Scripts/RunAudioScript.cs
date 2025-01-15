using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAudioScript : MonoBehaviour
{
    public AudioSource Run;
    // Start is called before the first frame update
    void Audio()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Run.Play();
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Run.Stop();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Run.Play();
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Run.Stop();
        }

    }

    // Update is called once per frame
    void StopSound()
    {
        
    }
}
