using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        private List<Order> _orderItems;

        internal override void OnDataLoaded()
        {
            this.OrderItems = base.Repository.Orders;
        }

        public override event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public List<Order> OrderItems
        {
            get
            {
                return _orderItems;
            }
            set
            {
                if (value != _orderItems)
                {
                    this._orderItems = value;
                    this.OnPropertyChanged();
                }
            }

        }

    }
}
