using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Slot : MonoBehaviour
{
    public static bool DoNot = false;
    [SerializeField]
    private SpriteRenderer m_SpriteRenderer;
    [SerializeField]
    //private GameManger m_GameManager;
    private Color WhiteTransparent = new Color(1f, 1f, 1f, 0f);
    private Color WhiteOpaque = new Color(1f, 1f, 1f, 1f);
    public int state;
    public string value;
    [SerializeField]
    private MemoryBlock m_MemoryBlock;
    public void setup(Sprite Img, string Name)
    {
        value = Name;
        m_SpriteRenderer.sprite = Img;
        m_SpriteRenderer.color = WhiteTransparent;
        state = 0;
    }
    public void ShowHideImage()
    {
        if(state == 0 && !DoNot)
        {
            m_SpriteRenderer.color = WhiteOpaque;
            state = 1;
        }/*else if(state == 1 && !DoNot)
        {
            m_SpriteRenderer.color = WhiteTransparent;
            state = 0;
        }*/
    }
    IEnumerator pause()
    {
        yield return new WaitForSeconds(1);
        if(state == 0)
        {
            m_SpriteRenderer.color = WhiteTransparent;
        }
        else if(state == 1)
        {
            m_SpriteRenderer.color = WhiteOpaque;
        }
        else if(state == 2)
        {
            m_MemoryBlock.StartFalling();
        }
        DoNot = false;
    }
    public void falseCheck()
    {
        StartCoroutine(pause());
    }
}
