using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene5_2 : MonoBehaviour, SceneScript
{

    SceneManager m_oSceneManager;

    // Start is called before the first frame update
    void Start()
    {

        m_oSceneManager = GameObject.Find("GameManager").GetComponent<SceneManager>();

        m_oSceneManager.UpdateButton0Text("Research a way to stop the end of the world");
        m_oSceneManager.UpdateButton1Text("Start a small vegetable garden to feed everyone");
        m_oSceneManager.UpdateButton2Text("Leave everyone behind to survive on your own");
        m_oSceneManager.UpdateButton3Text("Sit and stare at the wall");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button0Pressed()
    {
        m_oSceneManager.ToggleContinueButton();
        m_oSceneManager.LoadNewScene("Woods0");
    }

    public void Button1Pressed()
    {
        m_oSceneManager.m_oScore.nJackOLantern++;
        m_oSceneManager.ToggleContinueButton();
        m_oSceneManager.LoadNewScene("Apocalypse2");
    }

    public void Button2Pressed()
    {
        m_oSceneManager.m_oScore.nScarecrow++;
        m_oSceneManager.ToggleContinueButton();
        m_oSceneManager.LoadNewScene("Apocalypse2");
    }

    public void Button3Pressed()
    {
        m_oSceneManager.m_oScore.nGhost++;
        m_oSceneManager.ToggleContinueButton();
        m_oSceneManager.LoadNewScene("Apocalypse2");
    }

}
