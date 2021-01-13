using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerupController : MonoBehaviour
{
    public static bool hasBooster = false;
    public AudioSource boostersound;
    public Button boosterButton;
    public GameObject booster;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space) && boosterButton.interactable == true)
      {
        Debug.Log("hey there");
        StartCoroutine(useBooster());
      }
    }

    public void purchaseBooster(){
      if (creditController.credits >= 1000){
        creditController.credits -= 1000;
        Debug.Log("booster purchased");
        hasBooster = true;
        boosterButton.interactable = true;
      }
      else {
        Debug.Log("not enough credits");
      }
    }

    IEnumerator useBooster(){
      Debug.Log("Boost");
      if (hasBooster == true) {
        booster.GetComponent<ParticleSystem>().Play();
        boostersound.Play();
        boosterButton.interactable = false;
        ShipController.forwardSpeed += 1000;
        yield return new WaitForSeconds(3);
        ShipController.forwardSpeed -= 1000;
        boostersound.Stop();
        StartCoroutine(boosterCooldown());
      }
    }


    IEnumerator boosterCooldown(){
      yield return new WaitForSeconds(10);
      boosterButton.interactable = true;
    }

}
