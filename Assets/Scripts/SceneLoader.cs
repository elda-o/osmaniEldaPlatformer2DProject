using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator Fade;
    private int sceneToLoad;
    public void SceneChange()
    {
        //StartCoroutine(TransitionAnimation(SceneName));
        SceneManager.LoadScene(sceneToLoad);
    }

    public void TransitionAnimation(int SceneIndex)
    {
        // transition start here
        Fade.Play("FadeIn");
        sceneToLoad = SceneIndex;
        //yield return new WaitForSeconds(1);
        //SceneManager.LoadScene(SceneName);
        // loadscene

        
    }
}
