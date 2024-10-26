using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    DecorationPoints m_oScore;
    SceneScript m_oScript;
    GameObject m_goScene;
    public GameObject m_goMainCanvas;


    // Start is called before the first frame update
    void Start()
    {

        m_oScore = new DecorationPoints();


        if (m_goMainCanvas == null)
        {

            m_goMainCanvas = GameObject.Find("Main Canvas");

        }


        GameObject prefab = Resources.Load<GameObject>("Scene0"); 

        if (prefab != null)
        {
            // Instantiate the prefab in the scene
            m_goScene = Instantiate(prefab, Vector3.zero, Quaternion.identity);
            m_goScene.transform.SetParent(m_goMainCanvas.transform, false);
        }
        else
        {

            Debug.Log("Error finding scene prefab in resoures folder");

        }

        m_oScript = m_goScene.GetComponent<SceneScript>();

        if (m_oScript == null)
        {

            Debug.Log("Error finding scene script on scene prefab");

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Option0Clicked()
    {

        m_oScript.Button0Pressed();

    }


    public void Option1Clicked()
    {

        m_oScript.Button1Pressed();

    }

    public void Option2Clicked()
    {

        m_oScript.Button2Pressed();

    }

    public void Option3Clicked()
    {

        m_oScript.Button3Pressed();

    }

}


public interface SceneScript
{

    public void Button0Pressed();
    public void Button1Pressed();
    public void Button2Pressed();  
    public void Button3Pressed(); 


}

public class DecorationPoints
{

    public int nJackOLantern;
    public int nSkeleton;
    public int nGhost;
    public int nScarecrow;

    public DecorationPoints() {

        nJackOLantern = 0;
        nSkeleton = 0;
        nGhost = 0;
        nScarecrow = 0;

    }


}

