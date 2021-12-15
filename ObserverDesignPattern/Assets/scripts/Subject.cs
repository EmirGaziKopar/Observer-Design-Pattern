using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    //Haberi verecek olan subject'im haberi b�yle yayacak
    //Deyim yerindeyse ��yle ba��racak : Forward !!! , Back !!! , Left !!! , Right !!!

    private List<Observer> observers = null;//Bu subject'imizi dinleyecek olanlar listesi yani g�zlemciler 


    [SerializeField] private SubjectType subjectType; //bir subject type �zelli�im olsun ama di�er scriptlerden sadece �ekebileyim de�i�tiremeyeyim.

    public SubjectType SubjectType => subjectType; 



    //observerlar�n kayd�n� ger�ekle�tirebilmek i�in bir fonksiyon olu�tural�m
    public void registerObserver(Observer observer)
    {
        
        if(observers == null)
        {
            observers = new List<Observer>();
        }
        
        observers.Add(observer); //subjectimize bir g�zlemci atad�k.
    }


    private void Start()
    {
        //subject diyor ki beni subject olarak kaydet ben sana bir�eyleri ba��rmak istiyorum (observerable)
        ObserverManager.Instance.registerSubject(this); //Beni yani Subjects'i observer manager'in i�ine kaydet diyorum. 
    }

    public void Notify(NotificationType notificationType) 
    {
        foreach (var observer in observers)
        {
            observer.OnNotify(notificationType);
        }
    }
}
