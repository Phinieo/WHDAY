using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1 : MonoBehaviour, SceneScript
{

    SceneManager m_oSceneManager;

    // Start is called before the first frame update
    void Start()
    {

        m_oSceneManager = GameObject.Find("GameManager").GetComponent<SceneManager>();

        m_oSceneManager.UpdateButton0Text("Find comfort in your friends");
        m_oSceneManager.UpdateButton1Text("Suck it up and go in");
        m_oSceneManager.UpdateButton2Text("Chicken out and leave");
        m_oSceneManager.UpdateButton3Text("I'm not scared! Charge right in");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button0Pressed()
    {

        m_oSceneManager.m_oScore.nGhost++;
        m_oSceneManager.LoadNewScene("Scene4");

    }

    public void Button1Pressed()
    {

        m_oSceneManager.m_oScore.nGhost++;
        m_oSceneManager.LoadNewScene("Scene4");

    }

    public void Button2Pressed()
    {

        m_oSceneManager.m_oScore.nGhost++;
        m_oSceneManager.LoadNewScene("Scene4");

    }

    public void Button3Pressed()
    {

        m_oSceneManager.m_oScore.nGhost++;
        m_oSceneManager.LoadNewScene("Scene4");

    }

}
