using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour
{
  public string sceneToLoad;

  public void OnButtonClick()
  {
    SceneManager.LoadScene(sceneToLoad);
  }
}