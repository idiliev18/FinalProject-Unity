using UnityEngine;
using UnityEngine.SceneManagement;

public class pinScript : MonoBehaviour
{
    public GameObject LEDLight;

    public plusAndMinus plusAndMinus;

    public int level = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pin+"))
        {
            plusAndMinus.plus = true;
        }

        if (other.gameObject.CompareTag("Pin-"))
        {
            plusAndMinus.minus = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Pin+"))
        {
            plusAndMinus.plus = false;
        }

        if (other.gameObject.CompareTag("Pin+"))
        {
            plusAndMinus.minus = false;
        }
    }

    public void Test()
    {
        if (plusAndMinus.plus == true && plusAndMinus.minus == true)
        {
            LEDLight.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            level = SceneManager.GetActiveScene().buildIndex + 1;
            SaveSystem.SaveData(this);
        }
    }
}

