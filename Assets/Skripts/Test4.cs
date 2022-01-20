using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Test4 : MonoBehaviour
{
    [SerializeField] List <Toggle> toogle; // ��������� toogle
    [SerializeField] List<Button> buttons;// ��������� ������
    [SerializeField] List<string> Name1; // ��������� ������
    [SerializeField] List<string> Name2;
    [SerializeField] List<string> Name3;
    [SerializeField] List<string> Name4;
    [SerializeField] List<string> Name5;

    public void ButtonUrlClick()  // ������� ��� ������� ������ 
    {
        NameUrl(); // ������� �������� ������ � ��������
    }

   void NameUrl ()
    {
        for (int i = 0; i < toogle.Count; i++) /* ���� ��� �������� ��������� toogle
            ������� �������� � ������� ����� �������� ��� ���������������*/
        {
            if (toogle[i].isOn == true) // ���� toogle �������
            {
                 switch (i) // ����� ������� � ����������� �� ���������� toogle
             {  
            case 0 : // ���� ������ ������

               for (int j=0; j<buttons.Count; j++) // ���� ������������ ����� ��� � � toogle
                {
                    if (buttons[j].name== EventSystem.current.currentSelectedGameObject.name) /* ������� ��������� 
                                ����� ������ �� ��������� � �������*/
                    {
                        OpenTestUrl(Name1[j]);/* ������������� ������ � ������ ������ ��� �� 
                                �������� � ��������������� ������ ������, �.�. ������ ������� � ������ 
                                ������ ����� ����������� ��� ������� ������ ������ � ��.*/
                    }
                }
                break;

            case 1 :// 4 ���������� ������� ���������� �������
                        for (int j = 0; j < buttons.Count; j++)
                        {
                            if (buttons[j].name == EventSystem.current.currentSelectedGameObject.name)
                            {
                                OpenTestUrl(Name2[j]);
                            }
                        }
                        break;

                    case 2:
                        for (int j = 0; j < buttons.Count; j++)
                        {
                            if (buttons[j].name == EventSystem.current.currentSelectedGameObject.name)
                            {
                                OpenTestUrl(Name3[j]);
                            }
                        }
                        break;

                    case 3:
                        for (int j = 0; j < buttons.Count; j++)
                        {
                            if (buttons[j].name == EventSystem.current.currentSelectedGameObject.name)
                            {
                                OpenTestUrl(Name4[j]);
                            }
                        }
                        break;

                    case 4:
                        for (int j = 0; j < buttons.Count; j++)
                        {
                            if (buttons[j].name == EventSystem.current.currentSelectedGameObject.name)
                            {
                                OpenTestUrl(Name5[j]);
                            }
                        }
                        break;
                }
            }    
        }
    }

    void OpenTestUrl(string name) // ����� �������� ������ � ����������
    {
        Application.OpenURL(name); // �������� ������ � ��������
    }

}
