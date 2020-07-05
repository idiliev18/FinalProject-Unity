using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public pinScript pinScript;
   
    public GameObject pauseMenu;

    public PlayerMovement playerMovement;

    public bool isShownCanvas = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isShownCanvas = !isShownCanvas;
            pauseMenu.SetActive(isShownCanvas);

            Cursor.visible = isShownCanvas;

            if (!isShownCanvas)
            {
                Cursor.lockState = CursorLockMode.Locked;
                playerMovement.enabled = true;
            }
            else
            {
                playerMovement.enabled = false;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    public void Resume()
    {
        isShownCanvas = false;
        pauseMenu.SetActive(false);

        Cursor.visible = false;

        Cursor.lockState = CursorLockMode.Locked;
        playerMovement.enabled = true;
    }

    public void Quit()
    {
        SceneManager.LoadScene(1);
    }
}
