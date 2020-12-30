using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float forwardSpeed = 200f, strafeSpeed = 7.5f, hoverSpeed = 50f;
    private float activeForwardSpeed, activeStrafeSpeed, activeHoverSpeed;
    private float forwardAccelaration = 2.5f, strafeAccelaration = 2f, hoverAccelaration =2f;
    public float lookRotateSpeed = 90f;
    private Vector2 lookInput, screenCenter, mouseDistance;
    private float rollInput;
    private float rollSpeed = 200f, rollAccelaration = 2.5f;
    public GameObject centerFlame;
    public GameObject leftFlame;
    public GameObject rightFlame;
    public AudioSource thrustersound;

    // Start is called before the first frame update
    void Start()
    {
        screenCenter.x = Screen.width * .5f;
        screenCenter.y = Screen.height * .5f;
        //Cursor.lockState = CursorLockMode.Confined;
    }

    void Update(){
      if(Input.GetKeyDown(KeyCode.W)){
          if(!thrustersound.isPlaying){
              thrustersound.Play();
              Debug.Log("go");
              centerFlame.GetComponent<ParticleSystem>().Play();
              leftFlame.GetComponent<ParticleSystem>().Play();
              rightFlame.GetComponent<ParticleSystem>().Play();
          }
      }
      else if(Input.GetKeyUp(KeyCode.W)){
        if(thrustersound.isPlaying){
          thrustersound.Stop();
          Debug.Log("stop");
          centerFlame.GetComponent<ParticleSystem>().Stop();
          leftFlame.GetComponent<ParticleSystem>().Stop();
          rightFlame.GetComponent<ParticleSystem>().Stop();
        }
      }
    }

    // Update is called once per frame
    void FixedUpdate()
    {




        lookInput.x = Input.mousePosition.x;
        lookInput.y = Input.mousePosition.y;

        mouseDistance.x = (lookInput.x - screenCenter.x) / screenCenter.y;
        mouseDistance.y = (lookInput.y - screenCenter.y) / screenCenter.y;

        mouseDistance = Vector2.ClampMagnitude(mouseDistance, 1f);

        rollInput = Mathf.Lerp(rollInput, Input.GetAxis("Roll"), rollAccelaration * Time.deltaTime);

        transform.Rotate(-mouseDistance.y * lookRotateSpeed * Time.deltaTime, mouseDistance.x * lookRotateSpeed * Time.deltaTime, rollInput * rollSpeed * Time.deltaTime, Space.Self);

        activeForwardSpeed = Mathf.Lerp(activeForwardSpeed, Input.GetAxisRaw("Vertical") * forwardSpeed, forwardAccelaration * Time.deltaTime );
        activeStrafeSpeed = Mathf.Lerp(activeStrafeSpeed, Input.GetAxisRaw("Horizontal") * strafeSpeed, strafeAccelaration * Time.deltaTime) ;
        activeHoverSpeed = Mathf.Lerp(activeHoverSpeed, Input.GetAxis("Hover") * hoverSpeed, hoverAccelaration * Time.deltaTime);

        transform.position += transform.forward * activeForwardSpeed * Time.deltaTime + (transform.up * activeHoverSpeed * Time.deltaTime);

    }
}
