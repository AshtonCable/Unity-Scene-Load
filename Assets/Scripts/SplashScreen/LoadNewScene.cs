using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    // Made by Ashton Cable
    // To work with scenes in unity you must import the SceneManagement namespace.

    // Variables
    #region
    public string SceneName = ("Input Scene Name Here");
    public float SecondsToWait = (3.5f);
    #endregion

    // Start is called before the first frame update.
    void Start()
    {
        // Starts the coroutine
        StartCoroutine(LoadScene());
    }


    // This coroutine waits 3 seconds and then loads a scene with the given scene name.
    IEnumerator LoadScene()
    {
        // Waits for the set amount of seconds.
        yield return new WaitForSeconds(SecondsToWait);
        
        // This code loads the scene
        SceneManager.LoadScene(SceneName);

    }

    // Made by Ashton Cable
}
