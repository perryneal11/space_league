using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarController : MonoBehaviour
{
  public Image healthBar;
  public float health;
  public float startHealth;
  public AudioSource crashAudio;
  public Transform player;
  public Transform redSpawn;

  public void onTakeDamage(int damage){
    health = health - damage;
    healthBar.fillAmount = health / startHealth;
    crashAudio.Play();

    if(health <= 0){
      player.transform.position = redSpawn.transform.position;
      player.Rotate(0,0,0);
      health = 100;
      healthBar.fillAmount = health;
    }


  }
}
