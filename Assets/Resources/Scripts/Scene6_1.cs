using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6_1 : MonoBehaviour, SceneScript
{

    SceneManager m_oSceneManager;

    // Start is called before the first frame update
    void Start()
    {

        m_oSceneManager = GameObject.Find("GameManager").GetComponent<SceneManager>();

        m_oSceneManager.UpdateButton0Text("Hide!");
        m_oSceneManager.UpdateButton1Text("Run away!");
        m_oSceneManager.UpdateButton2Text("Eat the rest of the candy before anyone can steal it");
        m_oSceneManager.UpdateButton3Text("Get ready to confront the followers");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button0Pressed()
    {
        m_oSceneManager.m_oScore.nGhost++;
        m_oSceneManager.ToggleContinueButton();
        m_oSceneManager.UpdateContinueButtonText("Yay!");
        m_oSceneManager.LoadNewScene("Congrats1");
    }

    public void Button1Pressed()
    {
        m_oSceneManager.m_oScore.nSkeleton++;
        m_oSceneManager.ToggleContinueButton();
        m_oSceneManager.UpdateContinueButtonText("Yay!");
        m_oSceneManager.LoadNewScene("Congrats1");
    }

    public void Button2Pressed()
    {
        m_oSceneManager.m_oScore.nJackOLantern++;
        m_oSceneManager.ToggleContinueButton();
        m_oSceneManager.UpdateContinueButtonText("Yay!");
        m_oSceneManager.LoadNewScene("Congrats2");
    }

    public void Button3Pressed()
    {
        m_oSceneManager.m_oScore.nScarecrow++;
        m_oSceneManager.ToggleContinueButton();
        m_oSceneManager.UpdateContinueButtonText("Yay!");
        m_oSceneManager.LoadNewScene("Congrats2");
    }

}
