using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    private int poinsToWin;
    private int currentPoints;
    public GameObject myIdol;

    // Start is called before the first frame update
    void Start()
    {
        poinsToWin = myIdol.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoints >= poinsToWin)
        {
            // WIN
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
