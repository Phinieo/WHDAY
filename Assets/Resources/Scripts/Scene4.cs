using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4 : MonoBehaviour, SceneScript
{

    SceneManager m_oSceneManager;

    // Start is called before the first frame update
    void Start()
    {

        m_oSceneManager = GameObject.Find("GameManager").GetComponent<SceneManager>();

        m_oSceneManager.UpdateButton0Text("None - I don't like dressing up");
        m_oSceneManager.UpdateButton1Text("Pirate");
        m_oSceneManager.UpdateButton2Text("Fairy");
        m_oSceneManager.UpdateButton3Text("Traffic Cone");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button0Pressed()
    {
        Debug.Log("TEST0");
        m_oSceneManager.LoadNewScene("Scene5");
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
