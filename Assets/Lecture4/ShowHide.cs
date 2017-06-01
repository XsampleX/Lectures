using UnityEngine;

namespace Lecture4
{
    public class ShowHide : MonoBehaviour
    {

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //get a single meshrenderer in the scene and change its color
                MeshRenderer mat = FindObjectOfType<MeshRenderer>();
                mat.material.color = Random.ColorHSV();

                //get all MeshRenderers in the scene and change their color
                MeshRenderer[] mats = FindObjectsOfType<MeshRenderer>();
                int r = 0;

                while (r < mats.Length)
                {
                    mats[r].material.color = Random.ColorHSV();
                    r = r + 1;
                }

                //enable/disable meshrenderer
                //GetComponent<MeshRenderer>().enabled = !GetComponent<MeshRenderer>().enabled;
            }



            //Shorter version:
            //GetComponent<MeshRenderer>().enabled = (Input.GetKeyDown(KeyCode.Space) ? !GetComponent<MeshRenderer>().enabled : GetComponent<MeshRenderer>().enabled);
        }
    }
}