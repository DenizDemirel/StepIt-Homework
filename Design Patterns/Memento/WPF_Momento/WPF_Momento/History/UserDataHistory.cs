using System.Linq;
using WPF_Momento.Model;
using System.Collections.Generic;
using System;

namespace WPF_Momento.History;

public class UserDataHistory {


    private int userDataIndex;
   

    private IList<UserDataMemento> mementos;
    private UserData userData;

    public UserDataHistory( UserData originator, IList<UserDataMemento> mementos) {
        this.userData = originator;
        this.mementos = mementos;
    }

    public void Save() {

        userDataIndex = mementos.Count;
        mementos.Add(userData.Save());
    }
     
    public void Undo() {
         
        if (mementos.Any() == false || userDataIndex <= 0) 
            return;

        userDataIndex--;
        var UndoSave = mementos[userDataIndex];

        this.userData.Load(UndoSave);
    }
    public void Redo() {
         
        if (mementos.Any() == false || (userDataIndex + 1) > mementos.Count - 1)
            return;

        userDataIndex++;
        var RedoSave = mementos[userDataIndex];

        this.userData.Load(RedoSave);
    }
}