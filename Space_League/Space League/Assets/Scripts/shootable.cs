using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootable : MonoBehaviour
{



      public int currentHealth = 10;
      public AudioSource breakAudio;


    public void Damage(int damageAmount)
    {

      currentHealth -= damageAmount;

      if (currentHealth <= 0)
      {
        breakAudio.Play();
      //  Destroy (gameObject, breakAudio.clip.length);
        gameObject.SetActive(false);


      }
    }

}
