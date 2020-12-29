using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootable : MonoBehaviour
{



      public int currentHealth = 10;







    public void Damage(int damageAmount)
    {

      currentHealth -= damageAmount;
      if (currentHealth <= 0)
      {
        gameObject.SetActive(false);


      }
    }

}
