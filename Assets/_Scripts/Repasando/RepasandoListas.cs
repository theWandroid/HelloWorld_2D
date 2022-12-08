using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasandoListas : MonoBehaviour
{

    List<string> partyMembers = new List<string>() { "Aragorn", "Gimli", "Legolas"};



    // Start is called before the first frame update
    void Start()
    {
        string firstMember = partyMembers[0];

        int partyLength = partyMembers.Count;

        Debug.LogFormat("Nuestra comunidad tiene {0}", partyMembers.Count);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
