﻿using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private Image black;
    private Animator anim = null;
    private void Awake()
    {
        anim = black.GetComponent<Animator>();
    }
    public void LoadScene(int index)
    {
        StartCoroutine(FadingAndLoad(index));
    }
    public void ExitProgram()
    {
        Application.Quit();
    }
    IEnumerator FadingAndLoad(int index)
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(index);
    }
}
