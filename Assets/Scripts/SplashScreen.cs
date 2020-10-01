using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : SceneLoader
{
    [SerializeField] float timeBeforeNextScene = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoToNextScene());
    }

    private IEnumerator GoToNextScene()
    {
        yield return new WaitForSeconds(timeBeforeNextScene);
        LoadNextScene();
    }
}
