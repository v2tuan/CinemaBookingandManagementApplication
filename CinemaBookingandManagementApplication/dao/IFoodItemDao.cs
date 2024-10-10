using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.dao
{
    internal interface IFoodItemDao
    {
        List<FoodItem> findAll();

        FoodItem findByID(int id);

        FoodItem findByName(string name);

        void insert(FoodItem food);
        void update(FoodItem FoodItem);
        void delete(int id);
    }
}
