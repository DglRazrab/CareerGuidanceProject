using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DesignerLvlManager : MonoBehaviour
{
    public GameObject Science, Shop, SocialNet, Conclusion;
    public SpriteRenderer BGColor, InterfaceColor, DesignType, Goods, Search, Ava, Buttons,
        AvaSN, InterfaceSN, ButtonsSN;
    public SpriteRenderer bg1, bg2, bg3, bg4, bg5, intr1, intr2, intr3, intr4, intr5, dsg1, dsg2, dsg3, dsg4,
        av1, av2, av3, av4, btns1, btns2, btns3, btns4, btns5, gds1, gds2, gds3, gds4, s1, s2, s3, s4,
        av1sn, av2sn, bg1sn, bg2sn, bg3sn, bg4sn, bg5sn, btn1s1, btn1s2, btn1s3, btn1s4, btn2s1, btn2s2,
        btn2s3, btn2s4, btn3s1, btn3s2, btn3s3, btn3s4, btn4s1, btn4s2, btn4s3, btn4s4, btn5s1, btn5s2,
        btn5s3, btn5s4;

    public void Complete()
    {
        SocialNet.SetActive(false);
        Conclusion.SetActive(true);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void ToSecondScene()
    {
        Science.SetActive(false);
        Shop.SetActive(true);
    }

    public void ToThirdScene()
    {
        Shop.SetActive(false);
        SocialNet.SetActive(true);
    }

    public void DropDownBGColors(int value)
    {
        switch (value)
        {
            case 0:
                BGColor.sprite = bg1.sprite;
                break;

            case 1:
                BGColor.sprite = bg2.sprite;
                break;

            case 2:
                BGColor.sprite = bg3.sprite;
                break;

            case 3:
                BGColor.sprite = bg4.sprite;
                break;

            case 4:
                BGColor.sprite = bg5.sprite;
                break;
        }
    }

    public void DropDownInterfaceColors(int value)
    {
        switch (value)
        {
            case 0:
                InterfaceColor.sprite = intr1.sprite;
                break;

            case 1:
                InterfaceColor.sprite = intr2.sprite;
                break;

            case 2:
                InterfaceColor.sprite = intr3.sprite;
                break;

            case 3:
                InterfaceColor.sprite = intr4.sprite;
                break;

            case 4:
                InterfaceColor.sprite = intr5.sprite;
                break;
        }
    }

    public void DropDownDesignTypes(int value)
    {
        switch (value)
        {
            case 0:
                DesignType.sprite = dsg1.sprite;
                break;

            case 1:
                DesignType.sprite = dsg2.sprite;
                break;

            case 2:
                DesignType.sprite = dsg3.sprite;
                break;

            case 3:
                DesignType.sprite = dsg4.sprite;
                break;
        }
    }

    public void DropDownBGShopColors(int value)
    {
        switch (value)
        {
            case 0:
                Goods.sprite = gds1.sprite;
                break;

            case 1:
                Goods.sprite = gds2.sprite;
                break;

            case 2:
                Goods.sprite = gds3.sprite;
                break;

            case 3:
                Goods.sprite = gds4.sprite;
                break;
        }
    }

    public void DropDownAva(int value)
    {
        switch (value)
        {
            case 0:
                Ava.sprite = av1.sprite;
                break;

            case 1:
                Ava.sprite = av2.sprite;
                break;

            case 2:
                Ava.sprite = av3.sprite;
                break;

            case 3:
                Ava.sprite = av4.sprite;
                break;
        }
    }

    public void DropDownBtns(int value)
    {
        switch (value)
        {
            case 0:
                Buttons.sprite = btns1.sprite;
                break;

            case 1:
                Buttons.sprite = btns2.sprite;
                break;

            case 2:
                Buttons.sprite = btns3.sprite;
                break;

            case 3:
                Buttons.sprite = btns4.sprite;
                break;

            case 4:
                Buttons.sprite = btns5.sprite;
                break;
        }
    }

    public void DropDownSearch(int value)
    {
        switch (value)
        {
            case 0:
                Search.sprite = s1.sprite;
                break;

            case 1:
                Search.sprite = s2.sprite;
                break;

            case 2:
                Search.sprite = s3.sprite;
                break;

            case 3:
                Search.sprite = s4.sprite;
                break;
        }
    }

    public void DropDownAvaSN(int value)
    {
        switch (value)
        {
            case 0:
                AvaSN.sprite = av1sn.sprite;
                break;

            case 1:
                AvaSN.sprite = av2sn.sprite;
                break;
        }
    }

    public void DropDownBGSN(int value)
    {
        switch (value)
        {
            case 0:
                InterfaceSN.sprite = bg1sn.sprite;
                break;

            case 1:
                InterfaceSN.sprite = bg2sn.sprite;
                break;

            case 2:
                InterfaceSN.sprite = bg3sn.sprite;
                break;

            case 3:
                InterfaceSN.sprite = bg4sn.sprite;
                break;

            case 4:
                InterfaceSN.sprite = bg5sn.sprite;
                break;
        }
    }

    public void DropDownButtonsSN(int value)
    {
        switch (value)
        {
            case 0:
                ButtonsSN.sprite = btn1s1.sprite;
                break;

            case 1:
                ButtonsSN.sprite = btn1s2.sprite;
                break;

            case 2:
                ButtonsSN.sprite = btn1s3.sprite;
                break;

            case 3:
                ButtonsSN.sprite = btn1s4.sprite;
                break;

            case 4:
                ButtonsSN.sprite = btn2s1.sprite;
                break;

            case 5:
                ButtonsSN.sprite = btn2s2.sprite;
                break;

            case 6:
                ButtonsSN.sprite = btn2s3.sprite;
                break;

            case 7:
                ButtonsSN.sprite = btn2s4.sprite;
                break;

            case 8:
                ButtonsSN.sprite = btn3s1.sprite;
                break;

            case 9:
                ButtonsSN.sprite = btn3s2.sprite;
                break;

            case 10:
                ButtonsSN.sprite = btn3s3.sprite;
                break;

            case 11:
                ButtonsSN.sprite = btn3s4.sprite;
                break;

            case 12:
                ButtonsSN.sprite = btn4s1.sprite;
                break;

            case 13:
                ButtonsSN.sprite = btn4s2.sprite;
                break;

            case 14:
                ButtonsSN.sprite = btn4s3.sprite;
                break;

            case 15:
                ButtonsSN.sprite = btn4s4.sprite;
                break;

            case 16:
                ButtonsSN.sprite = btn5s1.sprite;
                break;

            case 17:
                ButtonsSN.sprite = btn5s2.sprite;
                break;

            case 18:
                ButtonsSN.sprite = btn5s3.sprite;
                break;

            case 19:
                ButtonsSN.sprite = btn5s4.sprite;
                break;
        }
    }
}
