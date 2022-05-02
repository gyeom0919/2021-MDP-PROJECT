using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Bolt;


public class Item : MonoBehaviour
{
    public Button FoodBtn;
    public Button InvenBtn;

    #region 
    public Sprite[] WeaponSp;
    public Sprite[] ArmorSp; 
    public Sprite[] ShildSp;
    public Sprite[] HeadSp;
    public Sprite[] AcessorySp;
  
    public int testvalue = 1;

    public string[] Itemtype = { "����", "����", "����" , "�Ǽ�����" , "����" , "���"};

    public Image[] Inventorylist;
    public Image[] InventoryItemlist;

    public bool[] CheakInventorylist = new bool[15];

    public Text nameText;
    public Text statusText;
    public Text discriptionText;

    public GameItem nowGameItem;
    public Image nowimage;
    public Image nowimage_2;

    public Image lastClick;
    public Image Weapon;
    public Image head;
    public Image sheld;
    public Image armo;
    public Image acessory;

    public Image Weapon_2;
    public Image head_2;
    public Image sheld_2;
    public Image armo_2;
    public Image acessory_2;

    public List<GameItem> Itemlist = new List<GameItem>();

    public CreatTable creatTable;

    public void Start()
    {
        Debug.Log(Itemtype[4]);
        Debug.Log(Itemtype[5]);


        creatTable = GameObject.Find("MakeTable").GetComponent<CreatTable>();

        Itemlist.Add(new GameItem(WeaponSp[0], 0, "���ƺ��� ������", "���ݷ�: 5", "â���� �־�Դ�.\n�ǰݽ� �Ļ�ǳ�� �ɸ��� �ִ�.", Itemtype[0], 5 , 100 , 5 , 1000 , 10));
        Itemlist.Add(new GameItem(WeaponSp[1], 1, "�ں���", "���ݷ�: 23", "�߻����.", Itemtype[0], 23, 90, 10, 3000,20));
        Itemlist.Add(new GameItem(WeaponSp[2], 2, "û���ǰ�", "���ݷ�: 45", "����� �ɰ� ����\n������ �����´�.", Itemtype[0], 45, 80, 18, 7000,30));
        Itemlist.Add(new GameItem(WeaponSp[3], 3, "���ǰ�", "���ݷ�: 70", "����ձ��� ��簡 ����ϴ����̴�.\n���̺νô� ���۶� ������ �����Ѵ�.", Itemtype[0], 70, 60, 30, 15000,40));
        Itemlist.Add(new GameItem(WeaponSp[4], 4, "�Ŵ��� ���", "���ݷ�: 100", "����� ��� ���� ����ϴ����̴�.\n¥����� �ڷθ��� �����ִ�", Itemtype[0], 100,  35, 50, 999999999,50));

        Itemlist.Add(new GameItem(ArmorSp[0], 5, "���� ����", "����: 5", "�¹��̰� �԰� ���� �Ұ�������\n���� ���� ���� ����� �����", Itemtype[1], 5, 100, 5, 1000,8));
        Itemlist.Add(new GameItem(ArmorSp[1], 6, "�� ����", "����: 8", "������ ���� ����\n�����θ���� �ܴ��ϴ�.", Itemtype[1], 8, 90, 10, 3000,15));
        Itemlist.Add(new GameItem(ArmorSp[2], 7, "ö ���� ", "����: 14", "ö�� ���� ����.\n��¦�Ÿ��� ������ ����� �ܴ��ϴ�.", Itemtype[1], 14 , 80, 14, 5000,25));
        Itemlist.Add(new GameItem(ArmorSp[3], 8, "�� ����", "����: 23", "�����ϸ� ��븦 ��Ȥ�ϴ� ���� ���ϰ� �ִ�.", Itemtype[1], 23,  80, 18, 7000,35));
        Itemlist.Add(new GameItem(ArmorSp[4], 9, "�ش� ����", "����: 32", "������ �ش뿡 �������ִ�.\n�� ������ �������� �� �� ����.", Itemtype[1], 32, 60, 30, 15000,40));
        Itemlist.Add(new GameItem(ArmorSp[5], 10, "ç���� ����", "����: 45", "��2Ŀ�� ����� ����. \n��û�� ������ �������� �� �� ����.", Itemtype[1], 45, 35, 50, 999999999,50));

        Itemlist.Add(new GameItem(HeadSp[0], 11, "�¹����� �Ȱ�", "ü��: 200", "�¹��̰� ���� ���� �Ȱ��̴�.\n �ڹ��谡 �ɷ��ִ�.", Itemtype[2], 200 , 100, 5, 1000,8));
        Itemlist.Add(new GameItem(HeadSp[1], 12, "�� ���", "ü��: 500", "������ ���� ���.\n ������ ����� �ܴ��ϴ�.", Itemtype[2], 500, 90, 10, 3000,20));
        Itemlist.Add(new GameItem(HeadSp[2], 13, "ö ��� ", "ü��: 700", "ö�� ���� ���. ��¦�Ÿ���\n������ ����� �ܴ��غ��δ�.", Itemtype[2], 700, 85, 15, 7000,30));
        Itemlist.Add(new GameItem(HeadSp[3], 14, "�� ���", "ü��: 1200", "������ ���� ���. �����ϸ�\n��븦 ��Ȥ�ϴ� ���� ���ϰ� �ִ�.", Itemtype[2], 1200,  80, 18, 7000,35));
        Itemlist.Add(new GameItem(HeadSp[4], 15, "�ּ����� ���", "ü��: 1800", "���¹��� ��ȯ�� �߻��� �ּ��簡\n���� ����̴�. ������ ����ϴ�", Itemtype[2], 1800, 60, 30, 15000,45));
        Itemlist.Add(new GameItem(HeadSp[5], 16, "ç���� ���", "ü��: 3000", "��2Ŀ�� ����� ��� \n�ѵ��� 3ȸ������� ��ġ�� ü���� ����ִ�.", Itemtype[2], 3000, 35, 50, 999999999,50));

        Itemlist.Add(new GameItem(ShildSp[0], 17, "���� ���� ", "����: 5", "������ ����� �������� \n���ϰ� �ܴ����� ���� ����.", Itemtype[4], 5, 100, 5, 1000,10));
        Itemlist.Add(new GameItem(ShildSp[1], 18, "ö ����", "����: 11", "ö�� ���� ����. ��¦�Ÿ��� \n������ ����� �ܴ��ϴ�.", Itemtype[4], 11, 90, 10, 3000,20));
        Itemlist.Add(new GameItem(ShildSp[2], 19, "�� ���� ", "����: 22", "������ ���� ����.  \n�̲������ ����� ������ �������.", Itemtype[4], 22, 80, 18 , 7000,30));
        Itemlist.Add(new GameItem(ShildSp[3], 20, "�������� ", "����: 31", "�׿����p���� \n�������쿡�������Ƴ���", Itemtype[4], 31, 60, 30, 15000,40));
        Itemlist.Add(new GameItem(ShildSp[4], 21, "ç���� ����", "����: 40", "��2Ŀ�� ����� ���� \n������ ���������ص� �ո��� �ʴ� �������� ����ִ�.", Itemtype[4], 40,  35, 50, 999999999,50));

        Itemlist.Add(new GameItem(AcessorySp[0], 22, "Ǫ�� ��ȣ��", "���°� ü���� �����÷� ����ó�� �ܴ��ϰ� ������ش�.", Itemtype[3], 1));
        Itemlist.Add(new GameItem(AcessorySp[1], 23, "��Ȥ�� ������", "FLEX!, ���� ����ġ ȹ�淮�� �÷��ش�.", Itemtype[3], 2)); 
        Itemlist.Add(new GameItem(AcessorySp[2], 24, "SS�� ���", "ġ�����̰� ������ ���!", Itemtype[3], 3));
        Itemlist.Add(new GameItem(AcessorySp[3], 25, "���� ���", "-����", Itemtype[3],4));

        
        Itemlist.Add(new GameItem(creatTable.CreatFirstItemMeterial[0], 26, "�ʷϹ���", "��������ҿ��� ������ �ʷϹ���\n �޷и��̴�.", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatFirstItemMeterial[1], 27, "��������", "��������ҿ��� ������ ��������\n ������̴�. ", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatFirstItemMeterial[2], 28, "������", "��������ҿ��� ������ ������\n �ǻ��������� ���ִ�.", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatSecondItemMeterial[0], 29, "�̽�������", "�̽�������, ��Ѱ��� �� �� �ִ�.", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatSecondItemMeterial[1], 30, "����Į������", "����Į�� ����, ���⺸�� �����ϴ�", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatSecondItemMeterial[2], 31, "�����", "�Ѷ߰�!", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatThirdItemMeterial[0], 32, "��������", "�ʴ�", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatThirdItemMeterial[1], 33, "Ǫ������", "����", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatThirdItemMeterial[2], 34, "�ǹ��Ǻ���", "�����Ѻ��� �����ִ�. \n ������ ������ �� �����Ű���.", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatForthItemMeterial[0], 35, "����� ��", "������ �����Ѵ�", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatForthItemMeterial[1], 36, "����� �ΰ���", "�����ϴ�", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatForthItemMeterial[2], 37, "����� ��", "������ �ٶ󺸸� ���.", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatFirstItemMeterial[3], 38, "����� ��", "������ ����� �����̳���.", Itemtype[5]));


        for (int i = 0; i < 15; i++)
        {
            CheakInventorylist[i] = false;
        }

        Debug.Log("gkgkgk");
        GetItem(Itemlist[0]);
    }

    public void GetItem(GameItem item)
    {
        for(int i=0; i<15; i++)
        {
           
            if (CheakInventorylist[i] == false)
            {
                InventoryItemlist[i].GetComponent<Click>().nowItem = item;
                CheakInventorylist[i] = true;              
                Inventorylist[i].sprite = item.sprite;
                Inventorylist[i].color = new Color(255, 255, 255, 255);
                
               
                break;
            }

        }
    }

    public void GetWearingItem(Image img, Image img_2)
    {
        //�������� ��������
        img.GetComponent<Click>().nowItem = nowGameItem;
        img.color = new Color(0.3058824f, 0.2901961f, 0.3058824f, 1f);
        img_2.color = new Color(255, 255, 255, 255);
        img_2.sprite = nowGameItem.sprite;
        nowGameItem.isequipting = true;
    }

    public void Setdeiscription(GameItem item)
    {
        nameText.text = item.name + "[" + item.ItemType + "]";
        if(item.isacesoryCnt == 0 || item.ItemType == "���")
        {
            statusText.text = item.status;
        }
        else
        {
            statusText.text = "";
        }
        discriptionText.text = item.discription;
    }

    public void Deletedeiscription()
    {
        nameText.text = "";
        statusText.text = "";
        discriptionText.text = "";
    }

    public void SetItem() 

    {
       
        if (!nowimage.GetComponent<Click>().isequipt)
        {
            
            if(nowGameItem.ItemType == "���")
            {
                return;
            }
            switch (nowGameItem.ItemType)
            {
                case "����":
                    if (Weapon.GetComponent<Click>().isequipting == true)
                        return;
                    GetWearingItem(Weapon, Weapon_2);
                    Weapon.GetComponent<Click>().isequipting = true;
                    GameObject.Find("Taemin").GetComponent<Player>().Str += Weapon.GetComponent<Click>().nowItem.status_int;
                    break;
                case "����":
                    if (head.GetComponent<Click>().isequipting == true)
                        return;
                    GetWearingItem(head, head_2);
                    head.GetComponent<Click>().isequipting = true;
                    GameObject.Find("Taemin").GetComponent<Player>().Hp += head.GetComponent<Click>().nowItem.status_int;
                    break;
                case "����":
                    if (sheld.GetComponent<Click>().isequipting == true)
                        return;
                    GetWearingItem(sheld, sheld_2);
                    sheld.GetComponent<Click>().isequipting = true;
                    GameObject.Find("Taemin").GetComponent<Player>().Dex += sheld.GetComponent<Click>().nowItem.status_int;
                    break;
                case "����":
                    if (armo.GetComponent<Click>().isequipting == true)
                        return;
                    GetWearingItem(armo, armo_2);
                    GameObject.Find("Taemin").GetComponent<Player>().Dex += armo.GetComponent<Click>().nowItem.status_int;
                    armo.GetComponent<Click>().isequipting = true;
                    break;
                case "�Ǽ�����":
                    if (acessory.GetComponent<Click>().isequipting == true)
                        return;
                    switch (nowGameItem.isacesoryCnt)
                    {
                        case 1:
                            nowGameItem.acessory1_StatusSetting();
                            break;
                        case 2:
                            nowGameItem.acessory2_StatusSetting();
                            break;
                        case 3:
                            nowGameItem.acessory3_StatusSetting();
                            break;
                        case 4:
                            nowGameItem.acessory4_StatusSetting();
                            break;
                    }
                    GetWearingItem(acessory, acessory_2);
                    acessory.GetComponent<Click>().isequipting = true;
                    break;
            }
            CheakInventorylist[nowimage.GetComponent<Click>().num] = false;
            nowGameItem = null;
            nowimage.GetComponent<Click>().Delite();
            nowimage_2.sprite = null;
            nowimage_2.color = new Color(0, 0, 0, 0);

        }

        nowimage.GetComponent<Click>().nowItem = null;

    }

    public void OutItem()
    {
        

        if (nowimage.GetComponent<Click>().isequipt)
        {
            bool kanitsem = false;
            //������â�� ��ĭ�����ٸ� ����
            for (int i = 0; i < 15; i++)
            {
                if (!CheakInventorylist[i])
                {
                    kanitsem = true;
                }

            }


            if (!kanitsem)
            {
                return;
            }
            switch (nowGameItem.isacesoryCnt)
            {
                case 1:
                    nowGameItem.acessory1_StatusOut();
                    break;
                case 2:
                    nowGameItem.acessory2_StatusOut();
                    break;
                case 3:
                    nowGameItem.acessory3_StatusOut();
                    break;
                case 4:
                    nowGameItem.acessory4_StatusOut();
                    break;
            }
            GetItem(nowGameItem);
            
        }
        else
        {
            GameObject.Find("Taemin").GetComponent<Player>().GangHwaSu += nowGameItem.dropGanghwasu;
            CheakInventorylist[nowimage.GetComponent<Click>().num] = false;
            InventoryItemlist[nowimage.GetComponent<Click>().num].GetComponent<Click>().nowItem = null;
        }
            
        switch (nowGameItem.ItemType)
        {
            
            case "����":
                Debug.Log("1");
                Weapon.GetComponent<Click>().isequipting = false;
                if(nowimage.GetComponent<Click>().isequipt == true)
                GameObject.Find("Taemin").GetComponent<Player>().Str -= nowGameItem.status_int;
                Debug.Log("2");
                break;
            case "����":
                
                head.GetComponent<Click>().isequipting = false;
                if (nowimage.GetComponent<Click>().isequipt == true)
                    GameObject.Find("Taemin").GetComponent<Player>().Hp -= nowGameItem.status_int;
                break;
            case "����":
                
                sheld.GetComponent<Click>().isequipting = false;
                if (nowimage.GetComponent<Click>().isequipt == true)
                    GameObject.Find("Taemin").GetComponent<Player>().Dex -= nowGameItem.status_int;
                break;
            case "����":
                if (nowimage.GetComponent<Click>().isequipt == true)
                    GameObject.Find("Taemin").GetComponent<Player>().Dex -= nowGameItem.status_int;
                armo.GetComponent<Click>().isequipting = false;
                break;
            case "�Ǽ�����":         
                acessory.GetComponent<Click>().isequipting = false;
                nowGameItem.isequipting = false;
                break;
        }
        nowGameItem.isequipting = false;
        nowGameItem = null;
        nowimage.GetComponent<Click>().Delite();
        nowimage_2.sprite = null;
        nowimage.color = new Color(0, 0, 0, 0);
        nowimage_2.color = new Color(0, 0, 0, 0);
       
    }
    public void test()
    {
        GetItem(Itemlist[testvalue]);
        testvalue += 1;
    }


    #endregion

    #region
    public Animator anmator;
    public Animator inventoryAnim;

    public Image upgradeImage;
    public Text upgradeName;
    public Text upgradeStatus;
    public Text upgradeDeiscription;
    public Text upgradeUseGangHwaSu;
    public Text persent;

    public void UpgradeOpen()
    {
        if (nowGameItem.isacesoryCnt != 0 || nowGameItem.ItemType == "���")
        {
            return;
        }
        if (nowGameItem.howhighGanghwa == 5)
        {
            upgradeUseGangHwaSu.text = "��ȭ��ġ�� �ִ�ġ�� �����Ͽ����ϴ�.";
            persent.text = "�±� �ҿ��� :" + nowGameItem.upGradeGold;
        }
        if (nowGameItem != null)
        {
            SetUpgradeDeiscription();
            anmator.SetTrigger("doShow");
            inventoryAnim.SetTrigger("doHide");
        }
        FoodBtn.interactable = false;
        InvenBtn.interactable = false;


    }
    public void UpgradeClose()
    {
        anmator.SetTrigger("doHide");
        inventoryAnim.SetTrigger("doShow");
        FoodBtn.interactable = true;
        InvenBtn.interactable = true;
    }

    public void SetUpgradeDeiscription()
    {
        upgradeImage.sprite = nowGameItem.sprite;
        upgradeName.text = nowGameItem.name;
        upgradeStatus.text = nowGameItem.status;
        upgradeDeiscription.text = nowGameItem.discription;
        upgradeUseGangHwaSu.text = "�ʿ��� ��ȭ��: " + nowGameItem.useGangHwaSu.ToString();
        persent.text = "��ȭ ������: "+nowGameItem.persent.ToString()+"%";

    }

    public void DoUpgrade()
    {
        if (nowGameItem.howhighGanghwa == 5)
        {
            upgradeUseGangHwaSu.text = "��ȭ��ġ�� �ִ�ġ�� �����Ͽ����ϴ�.";
            persent.text = "�±� �ҿ��� :" + nowGameItem.upGradeGold;
            return;
        }
        Debug.Log(nowGameItem.useGangHwaSu); 
        Debug.Log(GameObject.Find("Taemin").GetComponent<Player>().GangHwaSu);
        if(GameObject.Find("Taemin").GetComponent<Player>().GangHwaSu< nowGameItem.useGangHwaSu)
        {
            return;
        }
        GameObject.Find("Taemin").GetComponent<Player>().GangHwaSu -= nowGameItem.useGangHwaSu;
        
        if (nowGameItem.persent >= Random.Range(1, 101))
        {
            Debug.Log("��ȭ����");
            nowGameItem.howhighGanghwa += 1;
            nowGameItem.name = nowGameItem.inosnetname + "+" + nowGameItem.howhighGanghwa.ToString();
            switch (nowGameItem.ItemType)
            {
                case "����":
                    nowGameItem.status_int += 2;
                    if(nowGameItem.isequipting == true)
                    GameObject.Find("Taemin").GetComponent<Player>().Str += 2;
                    nowGameItem.status = "���ݷ�:" + nowGameItem.status_int;
                    break;
                case "����":
                    nowGameItem.status_int += 30;
                    if (nowGameItem.isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Hp += 30;
                    nowGameItem.status = "ü��:" + nowGameItem.status_int;
                    break;
                case "����":
                case "����":
                    nowGameItem.status_int += 1;
                    if (nowGameItem.isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Dex += 1;
                    nowGameItem.status = "����:" + nowGameItem.status_int;
                    break;
               
            }
             
        }
        else
        {
            Debug.Log("��ȭ����");
        }
        SetUpgradeDeiscription();
        Setdeiscription(nowGameItem);
        if (nowGameItem.howhighGanghwa == 5)
        {
            upgradeUseGangHwaSu.text = "��ȭ��ġ�� �ִ�ġ�� �����Ͽ����ϴ�.";
            persent.text = "�±� �ҿ��� :" + nowGameItem.upGradeGold;
           
        }
    }

    public void DoPromote()
    {
        bool cheak = false;
        if (Variables.Saved.Get<int>("Jelatine") < nowGameItem.upGradeGold || nowGameItem.howhighGanghwa != 5)
        {
            return;
        }
        Variables.Saved.Set("Jelatine", Variables.Saved.Get<int>("Jelatine") - nowGameItem.upGradeGold );
        // ���� ���Ӿ������� 
        //InventoryItemlist[nowGameItem.number].GetComponent<Click>().nowItem = Itemlist[nowGameItem.number+1];
        // nowGameItem = InventoryItemlist[nowGameItem.number].GetComponent<Click>().nowItem;
        Debug.Log(nowGameItem.number);
        Debug.Log(nowGameItem.status_int);
        if (nowGameItem.isequipting == true)
        {
            cheak = true;
            switch (nowGameItem.ItemType)
            {
                case ("����"):
                    if (Weapon.GetComponent<Click>().isequipting == true)
                    GameObject.Find("Taemin").GetComponent<Player>().Str -= nowGameItem.status_int;
                    break;
                case ("����"):
                    if (armo.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Dex -= nowGameItem.status_int;
                    break;
                case ("����"):
                    if (sheld.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Dex -= nowGameItem.status_int;
                    break;
                case ("����"):
                    if (head.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Hp -= nowGameItem.status_int;
                    break;
            }
        }
            
        nowGameItem = Itemlist[nowGameItem.number + 1];
        nowGameItem.isequipting = cheak;
        if (nowGameItem.isequipting == true)
        {
            switch (nowGameItem.ItemType)
            {
                case ("����"):
                    if (Weapon.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Str += nowGameItem.status_int;
                    break;
                case ("����"):
                    if (armo.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Dex += nowGameItem.status_int;
                    break;
                case ("����"):
                    if (sheld.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Dex += nowGameItem.status_int;
                    break;
                case ("����"):
                    if (head.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Hp += nowGameItem.status_int;
                    break;
            }
        }
            
        nowimage.GetComponent<Click>().nowItem = nowGameItem;


        SetUpgradeDeiscription();
        Setdeiscription(nowGameItem);
        nowimage_2.sprite = nowGameItem.sprite;


    }

    public void DoPromoteinEqipting()
    {

    }

    #endregion

    #region
    public Animator StatusAnim; 
    public Text Str;
    public Text Dex;
    public Text Hp;
    public Text CriPer;
    public Text CriDmg;
    public Text StatusPoint;
    public GameObject StrBottn;
    public GameObject DexBottn;
    public GameObject HpBottn;

    public void OpenStatusPannel()
    {
       
        SetStatusdiscription();
        StatusAnim.SetTrigger("doShow");
        inventoryAnim.SetTrigger("doHide");
        FoodBtn.interactable = false;
        InvenBtn.interactable = false;
    }

    public void CloseStatusPannel()
    {
        Debug.Log("���ؿ���������");
        StatusAnim.SetTrigger("doHide");
        inventoryAnim.SetTrigger("doShow");
        FoodBtn.interactable = true;
        InvenBtn.interactable = true;
    }

    public void SetStatusdiscription()
    {
        if (GameObject.Find("Taemin").GetComponent<Player>().StatusPoint != 0)
        {
            StrBottn.SetActive(true);
            DexBottn.SetActive(true);
            HpBottn.SetActive(true);
        }
        else
        {
            StrBottn.SetActive(false);
            DexBottn.SetActive(false);
            HpBottn.SetActive(false);
        }

        Str.text = "���ݷ�: " + GameObject.Find("Taemin").GetComponent<Player>().Str.ToString();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
        Dex.text = "����: " + GameObject.Find("Taemin").GetComponent<Player>().Dex.ToString();
        Hp.text = "ü��: " + GameObject.Find("Taemin").GetComponent<Player>().Hp.ToString();
        CriPer.text = "ġ��ŸȮ��: " + GameObject.Find("Taemin").GetComponent<Player>().CriticalPersent.ToString()+"%";
        CriDmg.text = "ġ��Ÿ������: " + GameObject.Find("Taemin").GetComponent<Player>().CriticalDamage.ToString()+"%";
        StatusPoint.text = "�ܿ� ��������Ʈ: " + GameObject.Find("Taemin").GetComponent<Player>().StatusPoint.ToString();
       
    }

    

    public void UseStatusStr()
    {   
        GameObject.Find("Taemin").GetComponent<Player>().Str += 2;
        GameObject.Find("Taemin").GetComponent<Player>().StatusPoint -= 1;
        SetStatusdiscription();
    }
    public void UseStatusDex()
    {   
        GameObject.Find("Taemin").GetComponent<Player>().Dex += 1;
        GameObject.Find("Taemin").GetComponent<Player>().StatusPoint -= 1;
        SetStatusdiscription();
    }

    public void UseStatusHp()
    {
        
        GameObject.Find("Taemin").GetComponent<Player>().Hp += 25;
        GameObject.Find("Taemin").GetComponent<Player>().StatusPoint -= 1;
        SetStatusdiscription();
    }

    public void LevelMadaGangsin()
    {
        if (acessory.GetComponent<Click>().nowItem == null)
        {
            return;
        }
        switch (acessory.GetComponent<Click>().nowItem.isacesoryCnt) {
            case 1:
                GameObject.Find("Taemin").GetComponent<Player>().Dex -= 5 * ((GameObject.Find("Taemin").GetComponent<LevelSilider>().Level)-1);
                GameObject.Find("Taemin").GetComponent<Player>().Dex += 5 * (GameObject.Find("Taemin").GetComponent<LevelSilider>().Level);
                GameObject.Find("Taemin").GetComponent<Player>().Hp -= 50 * ((GameObject.Find("Taemin").GetComponent<LevelSilider>().Level)-1);
                GameObject.Find("Taemin").GetComponent<Player>().Hp += 50 * (GameObject.Find("Taemin").GetComponent<LevelSilider>().Level);
                break;
            case 3:
                GameObject.Find("Taemin").GetComponent<Player>().Str -= 5 * ((GameObject.Find("Taemin").GetComponent<LevelSilider>().Level)-1);
                GameObject.Find("Taemin").GetComponent<Player>().Str += 5 * (GameObject.Find("Taemin").GetComponent<LevelSilider>().Level);
                break;
            default:
                break;

        }

        
    }
    #endregion


}
