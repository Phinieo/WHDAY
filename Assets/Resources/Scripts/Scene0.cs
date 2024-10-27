using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene0 : MonoBehaviour, SceneScript
{

    SceneManager m_oSceneManager;

    // Start is called before the first frame update
    void Start()
    {
        
        m_oSceneManager = GameObject.Find("GameManager").GetComponent<SceneManager>();

        m_oSceneManager.UpdateButton0Text("The Haunted House");
        m_oSceneManager.UpdateButton1Text("The neighbor’s front porch to get some candy");
        m_oSceneManager.UpdateButton2Text("The Graveyard");
        m_oSceneManager.UpdateButton3Text("Frightful Fits Costume Shop");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button0Pressed()
    {
        Debug.Log("TEST0");
        m_oSceneManager.LoadNewScene("Scene1");
        m_oSceneManager.m_oScore.nSkeleton++;
    }

    public void Button1Pressed()
    {
        Debug.Log("TEST1");
    }

    public void Button2Pressed()
    {
        Debug.Log("TEST2");
    }

    public void Button3Pressed()
    {
        Debug.Log("TEST3");
    }

}
