using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraControllerRTS : MonoBehaviour
{
    public float panSpeed = 2f;
    public float panBorderThickness = 10f;
    private float scroll;
    public float scrollSpeed = 2f;

    public Vector2 panLimit;
    public Vector2 panLimit2;
    public Vector2 panLimit3;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
            {
                pos.x -= panSpeed * Time.deltaTime;
            }
            if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
            {
                pos.x += panSpeed * Time.deltaTime;
            }
            if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
            {
                pos.z -= panSpeed * Time.deltaTime;
            }
            if (Input.GetKey("d") || Input.mousePosition.x >= Screen.height - panBorderThickness)
            {
                pos.z += panSpeed * Time.deltaTime;
            }

            scroll = Input.GetAxis("Mouse ScrollWheel");
            pos.y -= scroll * scrollSpeed * Time.deltaTime;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (Input.GetKey("w") || Input.mousePosition.x >= Screen.height - panBorderThickness)
            {
                pos.x -= panSpeed * Time.deltaTime;
            }
            if (Input.GetKey("s") || Input.mousePosition.x <= panBorderThickness)
            {
                pos.x += panSpeed * Time.deltaTime;
            }
            if (Input.GetKey("a") || Input.mousePosition.y <= panBorderThickness)
            {
                pos.z += panSpeed * Time.deltaTime;
            }
            if (Input.GetKey("d") || Input.mousePosition.y >= Screen.height - panBorderThickness)
            {
                pos.z -= panSpeed * Time.deltaTime;
            }

            scroll = Input.GetAxis("Mouse ScrollWheel");
            pos.y -= scroll * scrollSpeed * Time.deltaTime;
        }


        pos.x = Mathf.Clamp(pos.x, panLimit2.x, panLimit.x);
        pos.z = Mathf.Clamp(pos.z, panLimit2.y, panLimit.y);
        pos.y = Mathf.Clamp(pos.y, panLimit3.x, panLimit3.y);
        
        transform.position = pos;
    }
}
