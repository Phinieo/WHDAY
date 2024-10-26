using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    DecorationPoints m_oScore;

    // Start is called before the first frame update
    void Start()
    {

        m_oScore = new DecorationPoints();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Option0Clicked()
    {



    }

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

