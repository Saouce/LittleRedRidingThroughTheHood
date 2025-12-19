using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapScript : MonoBehaviour
{
    public int sceneToLoad;

    public void loadNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    


}
