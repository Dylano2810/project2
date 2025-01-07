using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Animator anim;
    private GameObject attackarea = default;

    private bool attacking = false;

    private float timeToAttack = 0.25f;
    private float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        attackarea = transform.GetChild(0).gameObject;
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
            anim.Play("Attack");

        }
        if(attacking)
        {
            timer += Time.deltaTime;
            if (timer >= timeToAttack )
            {
                timer = 0;
                attacking = false;
                attackarea.SetActive(attacking);
                Debug.Log("Attack");
            }
        }
    }
    private void Attack()
    {
        attacking = true;
        attackarea.SetActive(attacking);
       
    }
    
}
