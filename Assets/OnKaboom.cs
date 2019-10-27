using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnKaboom : MonoBehaviour
{
    public GameObject Sphere;
    public TextMeshPro Meshy;

    /* void SphereDestroy()
     {
         Sphere.GetComponent<Script>()}*/
    void Update()
    {

        if (Pathmaker.globalTileCOUNT >= 600)
        {
            Meshy.text = "Congratulations. Press the R key to restart.";
            if (Input.GetKey(KeyCode.R))
            {
                Debug.Log("R Key Pressed");
                Pathmaker.globalTileCOUNT = 0;
                SceneManager.LoadScene("IMadeMySelf");
            }
        }
}

}



