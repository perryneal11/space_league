using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionController : MonoBehaviour
{
  public HealthbarController healthBar;

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Asteroid"){
      if(healthBar)
      {
        healthBar.onTakeDamage(5);

      }
    }



  }
}
