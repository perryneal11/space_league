using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayViewer : MonoBehaviour
{



  public float weaponRange = 50f;
  private Camera mainCam;






    // Start is called before the first frame update
    void Start()
    {
        mainCam = GetComponentInParent<Camera> ();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lineOrigin = mainCam.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
        Debug.DrawRay (lineOrigin, mainCam.transform.forward * weaponRange, Color.green);
    }
}
