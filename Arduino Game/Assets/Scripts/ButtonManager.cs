using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ButtonManager : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Canvas;
    public GameObject Cable1;
    public GameObject Cable2;

    public Vector3 targetPosition;
    public Quaternion targetRotation1 = Quaternion.Euler(270, 270, 180);

    public MoveCamera moveCameraScript;
    public PlayerMovement PlayerMovementScript;
    public Volume volume;
    public CameraControllerRTS cameraControllerRTS;
    private DepthOfField d;
    public ObjectsSelect objectsSelect;

    public MeshRenderer meshRendererPlayer;
    public MeshRenderer meshRendererGlass;
    public MeshRenderer meshRendererButton;

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            moveCameraScript.enabled = false;
            PlayerMovementScript.enabled = false;
            meshRendererButton.enabled = false;
            meshRendererPlayer.enabled = false;
            cameraControllerRTS.enabled = true;
            objectsSelect.enabled = true;
            volume.profile.TryGet(out d);
            d.active = false;

            Canvas.SetActive(false);
            Cable1.SetActive(true);
            Cable2.SetActive(true);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            Camera.transform.position = targetPosition;
            Camera.transform.rotation = targetRotation1;
        }
    }
}
