using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Level");
    }
}
