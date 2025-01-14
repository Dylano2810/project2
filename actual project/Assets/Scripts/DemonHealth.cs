//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class DemonHealth : MonoBehaviour
//{
//    public float hitpoints;
//    public float maxHitpoints = 5;
//    public HealthbarBehaviour healthbar;


//    // Start is called before the first frame update
//    void Start()
//    {
//        hitpoints = maxHitpoints;
//        healthbar.SetHealth(hitpoints, maxHitpoints);
//    }

//    // Update is called once per frame
//    public void TakeHit(float damage)
//    {
//        hitpoints -= damage;
//        healthbar.SetHealth(hitpoints, maxHitpoints);

//        if (hitpoints <= 0)
//        {
//            Destroy(gameObject);
//        }
//    }
//}
