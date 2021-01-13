using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class creditController : MonoBehaviour
{
    public static int credits = 1000;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
      text = gameObject.GetComponent<Text>();
      InvokeRepeating("incrementCredit",0.0f,1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void incrementCredit()
    {
      credits += 1;
      text.text = credits + " c";
    }


}
