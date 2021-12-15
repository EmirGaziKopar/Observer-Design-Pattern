using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverManager : MonoBehaviour
{

    //Hangi register'a neyi at�yaca��m�z� register �zerinden yap�caz ��nk� ben bir subject'e eri�mek istiyorsam bunu tek bir yerden 
    //y�netece�im ki kolay olsun.
    #region Singleton

    private static ObserverManager _instance = null;

    public static ObserverManager Instance => _instance;

    #endregion
    private void Start()
    {
        
    }
    private void Awake()
    {
        _instance = this;
    }

    public List<Subject> subjects = null;

    public void registerSubject(Subject subject)
    {
        if(subjects == null)
        {
            subjects = new List<Subject>();
        }
        subjects.Add(subject);
    }

    //Biraz �nce subject'in i�erisinde observerlar�m� yani g�zlemcilerimi tutmu�tum. 
    //�imdiyse observer manager'�m�n i�ersinde subject'lerimi tutacaa��m.

    public void RegisterObserver(Observer observer , SubjectType subjectType ) //Observerlara , tipi subject olanlara kay�t ol dedik
    {
        foreach (var subject in subjects)
        {
            if(subject.SubjectType == subjectType)
            {
                subject.registerObserver(observer);
            }
        }
    }
  


}

//Buradan sonras� yukardaki class'dan ba��ms�z



//Haberi verecek olan subject bu enum'u kullanacak.
//Forward'� duydu�u zaman o i�levi yapacak , Back duydu�u zaman o i�levi yapacak.
public enum NotificationType
{
    Forward, Back, Left, Right
}

public enum SubjectType
{
    MovemementPanel
}
