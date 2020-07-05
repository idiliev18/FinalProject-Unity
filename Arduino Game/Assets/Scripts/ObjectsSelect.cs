using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSelect : MonoBehaviour
{
    public Camera rayOutCamera;
    public GameObject arduinoOutline;
    public GameObject arduino;
    public GameObject LEDOutline;
    public GameObject LED;

    //public bool isSelecArduino = false; 
    //public bool isSelecLED = false;

    public Quaternion rotation;

    public DragObjects dragObjectsArduino;
    public DragObjects dragObjectsLED;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();

            bool hit = Physics.Raycast(rayOutCamera.ScreenPointToRay(Input.mousePosition), out hitInfo);

            if (hit)
            {
                Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                if (hitInfo.transform.gameObject.tag == "Arduino")
                {
                    arduinoOutline.SetActive(true);
                    dragObjectsArduino.enabled = true;
                    //isSelecArduino = true;
                }
                else
                {
                    dragObjectsArduino.enabled = false;
                    arduinoOutline.SetActive(false);
                    //isSelecArduino = false;
                }

                if (hitInfo.transform.gameObject.tag == "LED")
                {
                    LEDOutline.SetActive(true);
                    dragObjectsLED.enabled = true;
                    //isSelecLED = true;
                }
                else
                {
                    dragObjectsLED.enabled = false;
                    LEDOutline.SetActive(false);
                    //isSelecLED = false;
                }
            }
        }


        /*
        ////////////////////////////////////////////////////
        //////////////////Need Fix Rotation//////////////////
        ////////////////////////////////////////////////////
        if (isSelecArduino)
        {
            rotation.y = arduino.transform.rotation.y;  
            
            if (Input.GetKeyDown("r"))
            {
                if (rotation.y >= 0 && rotation.y < 90)
                {
                    Debug.Log("Rotate1");
                    rotation.y = 90;
                    arduino.transform.rotation = rotation;
                }
                else if (rotation.y >= 90 && rotation.y < 180)
                {
                    Debug.Log("Rotate2");
                    rotation.y = 180;
                    arduino.transform.rotation = rotation;
                }
                else if (rotation.y >= 180 && rotation.y < 270)
                {
                    Debug.Log("Rotate3");
                    rotation.y = 270;
                    arduino.transform.rotation = rotation;
                }
                else if (rotation.y >= 270 && rotation.y <= 360)
                {
                    Debug.Log("Rotate4");
                    rotation.y = 0;
                    arduino.transform.rotation = rotation;
                }
                if (rotation.y == 180)
                {
                    rotation.y = 270;
                    arduino.transform.rotation = rotation;
                }
            }
        }*/
    }
}