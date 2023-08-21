using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Momento.Base;
using WPF_Momento.History;

namespace WPF_Momento.Model;

public class UserData : ISaveable<UserDataMemento>
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Description { get; set; }
    public string? Picture { get; set; }

    public UserDataMemento Save() {

        return new UserDataMemento() {

            Name = this.Name,
            Surname = this.Surname,

            Description = this.Description,
            Picture = this.Picture,
        };
    }

    public void Load( UserDataMemento memento ) {

        this.Name = memento.Name;
        this.Surname = memento.Surname;

        this.Description = memento.Description;
        this.Picture = memento.Picture;
    }
}
