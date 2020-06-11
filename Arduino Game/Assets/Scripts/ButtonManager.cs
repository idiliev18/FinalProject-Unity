using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ButtonManager : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Canvas;
    public GameObject Coliders;
    public BoxCollider boxCollider;

    public Vector3 targetPosition;
    public Quaternion targetRotation;

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
            boxCollider.enabled = false;
            cameraControllerRTS.enabled = true;
            objectsSelect.enabled = true;
            volume.profile.TryGet(out d);
            d.active = false;
            Coliders.SetActive(true);

            Canvas.SetActive(false);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            Camera.transform.position = targetPosition;
            Camera.transform.rotation = targetRotation;
        }
    }
}
