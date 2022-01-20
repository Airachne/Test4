using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Test4 : MonoBehaviour
{
    [SerializeField] List <Toggle> toogle; // коллекция toogle
    [SerializeField] List<Button> buttons;// коллекция кнопок
    [SerializeField] List<string> Name1; // коллекция ссылок
    [SerializeField] List<string> Name2;
    [SerializeField] List<string> Name3;
    [SerializeField] List<string> Name4;
    [SerializeField] List<string> Name5;

    public void ButtonUrlClick()  // событие при нажатии кнопки 
    {
        NameUrl(); // функция открытия ссылок в браузере
    }

   void NameUrl ()
    {
        for (int i = 0; i < toogle.Count; i++) /* цикл для проверки активного toogle
            позиция элемента в массиве также явлеется его идентификатором*/
        {
            if (toogle[i].isOn == true) // если toogle активен
            {
                 switch (i) // выбор условия в зависимости от выбранного toogle
             {  
            case 0 : // если выбран первый

               for (int j=0; j<buttons.Count; j++) // цикл используется также как и с toogle
                {
                    if (buttons[j].name== EventSystem.current.currentSelectedGameObject.name) /* условие сравнения 
                                имени кнопки из коллекции с нажатой*/
                    {
                        OpenTestUrl(Name1[j]);/* Идентификатор кнопки в данном случае так же 
                                является и идентификатором списка ссылок, т.к. первая позиция в списке 
                                ссылок будет открываться при нажатии первой кнопки и тд.*/
                    }
                }
                break;

            case 1 :// 4 дальнейших условия аналогичны первому
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

    void OpenTestUrl(string name) // Метод открытие ссылок с параметром
    {
        Application.OpenURL(name); // открытие ссылок в браузере
    }

}
