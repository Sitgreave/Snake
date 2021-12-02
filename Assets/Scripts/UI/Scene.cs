using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
   public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
