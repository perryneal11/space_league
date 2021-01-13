using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootable : MonoBehaviour
{
      public int currentHealth = 10;
      public AudioSource breakAudio;
      public GameObject Asteroid1;
      public GameObject Asteroid2;
      public GameObject Asteroid3;
      public int xpos;
      public int zpos;
      public int ypos;

    public void FixedUpdate(){
      transform.position += transform.forward * Random.Range(0, 50) * Time.deltaTime + (transform.up * Random.Range(0, 50) * Time.deltaTime);

    }


    public void Damage(int damageAmount)
    {

      currentHealth -= damageAmount;

      if (currentHealth <= 0)
      {
        breakAudio.Play();
      //  Destroy (gameObject, breakAudio.clip.length);
        gameObject.SetActive(false);

        GameObject roid1 = Instantiate(Asteroid1, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity) as GameObject;
        GameObject roid2 = Instantiate(Asteroid2, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity) as GameObject;
        GameObject roid3 = Instantiate(Asteroid3, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity) as GameObject;
        roid1.transform.localScale = new Vector3(gameObject.transform.localScale.x / 3, gameObject.transform.localScale.y / 3 , gameObject.transform.localScale.z / 3);
        roid1.transform.position += transform.up * Random.Range(0, 50);
        roid2.transform.localScale = new Vector3(gameObject.transform.localScale.x / 3, gameObject.transform.localScale.y / 3, gameObject.transform.localScale.z / 3);
        roid3.transform.localScale = new Vector3(gameObject.transform.localScale.x / 3, gameObject.transform.localScale.y / 3, gameObject.transform.localScale.z / 3);

      }
    }


    public Vector3 RandomVector(float min, float max) {
    var x = Random.Range(min, max);
    var y = Random.Range(min, max);
    var z = Random.Range(min, max);
    return new Vector3(x, y, z);
}

}
