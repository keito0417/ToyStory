using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandfatherchatScript : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    public string sendMessege = "";

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("じゃすぱー"))
        {
            flowchart.SendFungusMessage(sendMessege);
        }
    }
}