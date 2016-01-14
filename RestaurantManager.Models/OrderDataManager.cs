using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {
        private List<MenuItem> _menuItems;
        private List<MenuItem> _currentlySelectedMenuItems;

        internal override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
        }

        public override event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public List<MenuItem> MenuItems
        {
            get
            {
                return _menuItems;
            }
            set
            {
                if (value != _menuItems)
                {
                    this._menuItems = value;
                    this.OnPropertyChanged();
                } 
            }    
        }

        public List<MenuItem> CurrentlySelectedMenuItems
        {
            get
            {
                return _currentlySelectedMenuItems;
            }
            set
            {
                if (value != _currentlySelectedMenuItems)
                {
                    this._currentlySelectedMenuItems = value;
                    this.OnPropertyChanged();
                }
            }
        }
    }
}
