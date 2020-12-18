using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject Asteroid1;
    public GameObject Asteroid2;
    public GameObject Asteroid3;
    public int asteroidType;
    public int xpos;
    public int zpos;
    public int ypos;
    public int pos;
    public int scale;
    public int numberOfAsteroids;

    // Start is called before the first frame update
    void Start()
    {
      while(numberOfAsteroids < 200){
      xpos = Random.Range(-1000, 1000);
      ypos = Random.Range(-1000, 1000);
      zpos = Random.Range(-800, 800);
      scale = Random.Range(1, 80);
      asteroidType = Random.Range(1, 3);

      if (asteroidType == 1) {
        GameObject roid = Instantiate(Asteroid1, new Vector3(xpos, ypos, zpos), Quaternion.identity) as GameObject;
        roid.transform.localScale = new Vector3(scale, scale, scale);
      }
      else if (asteroidType == 2) {
        GameObject roid = Instantiate(Asteroid2, new Vector3(xpos, ypos, zpos), Quaternion.identity) as GameObject;
        roid.transform.localScale = new Vector3(scale, scale, scale);
      }
      else if (asteroidType ==3) {
        GameObject roid = Instantiate(Asteroid3, new Vector3(xpos, ypos, zpos), Quaternion.identity) as GameObject;
        roid.transform.localScale = new Vector3(scale, scale, scale);
      }

      //roid.transform.localScale = new Vector3(scale, scale, scale);
      numberOfAsteroids += 1;

    }
    }


}
