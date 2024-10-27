using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene7 : MonoBehaviour, SceneScript
{

    SceneManager m_oSceneManager;

    // Start is called before the first frame update
    void Start()
    {

        m_oSceneManager = GameObject.Find("GameManager").GetComponent<SceneManager>();

        m_oSceneManager.UpdateButton0Text("Go through the front door");
        m_oSceneManager.UpdateButton1Text("Look for a secret entrance");
        m_oSceneManager.UpdateButton2Text("Rest on a nearby stump");
        m_oSceneManager.UpdateButton3Text("Run away!");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button0Pressed()
    {
        Debug.Log("TEST0");
        m_oSceneManager.LoadNewScene("Scene8");
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
