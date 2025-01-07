using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    Animator anim;
    public GameObject shield;

    private bool activeShield;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        activeShield = false;
        shield.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(!activeShield)
            {
                shield.SetActive(!activeShield);
                activeShield = true;
            }
            else
            {
                shield.SetActive(false);
                activeShield=false;
            }

            anim.Play("Player_block");
            anim.Play("Stay_Block");
          
        }
    }

    public bool ActiveShield
    {
        get
        {
            return activeShield;
        }
        set
        {
            activeShield = value;
        }
    }
}
