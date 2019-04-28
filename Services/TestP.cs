using System;
namespace Services
{
    class TestP : Shap, IPaintCost
    {
        public int GetCost(int area)
        {
            return area * width * heigth;
        }
    }
}