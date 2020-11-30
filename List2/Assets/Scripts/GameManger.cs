using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    [SerializeField]
    private List<Sprite> Images;
    [SerializeField]
    Text MatchText; 
    private Slot[] Slots;
    private int Matches = 18;
    static private int indexer;
    // Start is called before the first frame update
    void Start()
    {
        Slots = FindObjectsOfType<Slot>();
        System.Random rnd = new System.Random();
        indexer = Images.Count-1;
        int n = Images.Count;
        while (n > 1) {  
            n--;  
            int r = rnd.Next(n + 1);  
            Sprite tmp = Images[r];
            Images[r] = Images[n];
            Images[n] = tmp;
        }
        foreach (Slot slot in Slots)
        {
            slot.setup(Images[indexer], Images[indexer].name);
            indexer--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0)){
            checkValues();
        }
    }
    void checkValues()
    {
        List<int> compare = new List<int>();
        for(int i=0; i<Slots.Length; i++)
        {
            if(Slots[i].state == 1)
            {
                compare.Add(i);
            }
        }
        if(compare.Count == 2)
        {
            compareSlots(compare);
        }
    }
    void compareSlots(List<int> comp)
    {
        Slot.DoNot = true;
        int newState = 0;
        if(Slots[comp[0]].value==Slots[comp[1]].value)
        {
            newState = 2;
            Matches--;
            MatchText.text = "Matches Left: " + Matches;
            if(Matches == 0)
            {
                Invoke("BackToMenue", 11f);
            }
        }
        Slots[comp[0]].state=newState;
        Slots[comp[0]].falseCheck();
        Slots[comp[1]].state=newState;
        Slots[comp[1]].falseCheck();
    }
    void BackToMenue(){
        SceneManager.LoadScene("Menu");
    }
}
