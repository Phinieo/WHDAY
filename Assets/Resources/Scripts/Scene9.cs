using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene9 : MonoBehaviour, SceneScript
{

    SceneManager m_oSceneManager;

    // Start is called before the first frame update
    void Start()
    {

        m_oSceneManager = GameObject.Find("GameManager").GetComponent<SceneManager>();

        m_oSceneManager.UpdateButton0Text("SCENE1 WORKED!");
        m_oSceneManager.UpdateButton1Text("BLAH BLAH");
        m_oSceneManager.UpdateButton2Text("LALDLE");
        m_oSceneManager.UpdateButton3Text("PBBBBPLT");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button0Pressed()
    {
        m_oSceneManager.GameOver();
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
