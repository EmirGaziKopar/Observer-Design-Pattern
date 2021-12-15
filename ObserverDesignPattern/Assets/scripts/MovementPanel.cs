using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPanel : Subject
{
    //Ben bu buttonlara bast�m diyecek olan script
    //yap�lanlar� burada bildirece�iz
    //ba��racak olan nesne 
    
    public void ForwardOnClick()
    {
        Notify(NotificationType.Forward);
    }

    public void BackOnClick()
    {
        Notify(NotificationType.Back);
    }

    public void RightOnClick()
    {
        Notify(NotificationType.Right);
    }

    public void LeftOnClick()
    {
        Notify(NotificationType.Left);
    }

}
