using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("hero"))
        {
            SceneManager.LoadScene("Scene2");
        }
    }
}